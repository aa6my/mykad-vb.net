'For waykeong
'Not for commercial use
'-xenon 21 April 2007

Imports System.Runtime.InteropServices
Imports System.IO

Module MyKad
    Public Const SCARD_E_NO_SMARTCARD As Int32 = &H8010000C
    Public Const SCARD_E_NO_SERVICE As Int32 = &H8010001D
    Public Const SCARD_E_NO_READERS_AVAILABLE As Int32 = &H8010002E
    Public Const SCARD_W_REMOVED_CARD As Int32 = &H80100069
    Public Const SCARD_SCOPE_USER As Int32 = 0
    Public Const SCARD_SHARE_SHARED As Int32 = 2
    Public Const SCARD_PROTOCOL_T0 As Int32 = 1

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure SCARD_IO_REQUEST
        Public dwProtocol As Int32
        Public cbPciLength As Int32
    End Structure

    Declare Function SCardEstablishContext Lib "winscard.dll" _
       (ByVal dwScope As Int32, ByVal pvReserved1 As Int32, _
       ByVal pvReserved2 As Int32, ByRef phContext As Int32) As Int32

    Declare Function SCardReleaseContext Lib "winscard.dll" _
       (ByVal hContext As Int32) As Int32

    Declare Function SCardListReadersA Lib "winscard.dll" _
       (ByVal hContext As Int32, ByVal mszGroups As Int32, _
       ByVal mszReaders As Byte(), ByRef pcchReaders As Int32) As Int32

    Declare Function SCardConnectA Lib "winscard.dll" _
       (ByVal hContext As Int32, ByVal szReader As Byte(), _
       ByVal dwShareMode As Int32, ByVal dwPreferredProtocols As Int32, _
       ByRef phCard As Int32, ByRef pdwActiveProtocol As Int32) As Int32

    Declare Function SCardTransmit Lib "winscard.dll" _
       (ByVal hCard As Int32, ByRef pioSendPci As SCARD_IO_REQUEST, _
       ByVal pbSendBuffer As Byte(), ByVal cbSendLength As Int32, _
       ByRef pioRecvPci As SCARD_IO_REQUEST, ByVal pbRecvBuffer As Byte(), _
       ByRef pcbRecvLength As Int32) As Int32

    Declare Function SCardDisconnect Lib "winscard.dll" _
       (ByVal hCard As Int32, ByVal dwDisposition As Int32) As Int32

    Dim hContext As Int32 = &HFFFFFFFF
    Dim hCard As Int32
    Dim connected As Boolean
    Public cachedJPN1 As Boolean
    Dim currentApp As String
    Dim Buffer(511) As Byte
    Dim BufferC(511) As Byte
    Dim dLength As Int32
    Dim pciT0 As SCARD_IO_REQUEST

    Dim Cmd1() As Byte = {&H0, &HA4, &H4, &H0, &HA, &HA0, &H0, &H0, &H0, &H74, &H4A, &H50, &H4E, &H0, &H10}
    Dim Cmd2() As Byte = {&H0, &HC0, &H0, &H0, &H5}
    Dim Cmd3() As Byte = {&HC8, &H32, &H0, &H0, &H5, &H8, &H0, &H0, 0, 0}
    Dim Cmd4() As Byte = {&HCC, &H0, &H0, &H0, &H8, 0, 0, 1, 1, 2, 2, 3, 3}
    Dim Cmd5() As Byte = {&HCC, &H6, &H0, &H0, 0}


    Public Function GetReaders(ByRef readers()() As Char) As Int32
        Dim retval As Int32
        Dim i, j, k As Int32
        If hContext = &HFFFFFFFF Then
            pciT0.dwProtocol = 1
            pciT0.cbPciLength = 8
            retval = SCardEstablishContext(SCARD_SCOPE_USER, 0, 0, hContext)
            If retval <> 0 Then Return retval
        End If
        dLength = 512
        retval = SCardListReadersA(hContext, 0, Buffer, dLength)
        ReDim readers(3)

        j = 0
        For k = 0 To 3
            If Buffer(j) = 0 Then Exit For
            ReDim readers(k)(127)
            For i = 0 To 127
                readers(k)(i) = Chr(Buffer(j))
                If Buffer(j) = 0 Then Exit For
                j += 1
            Next
            j += 1
        Next
        ReDim Preserve readers(k - 1)
        Return retval
    End Function

    Public Function SelectReader(ByVal reader As String) As Boolean
        Dim retval, dProtocol, i As Int32
        Dim reader1(128) As Byte
        If connected Then
            cachedJPN1 = False
            currentApp = ""
            SCardDisconnect(hCard, 0)
        End If
        For i = 0 To reader.Length - 1
            reader1(i) = Asc(reader(i))
        Next
        reader1(i) = 0

        retval = SCardConnectA(hContext, reader1, SCARD_SHARE_SHARED, SCARD_PROTOCOL_T0, hCard, dProtocol)
        If retval = 0 Then
            connected = True
            Return True
        Else
            connected = False
            Return False
        End If
    End Function

    Public Function SelectApp(ByVal App As String) As Boolean
        Dim retval As Int32
        If App = "JPN" Then
            dLength = 256
            retval = SCardTransmit(hCard, pciT0, Cmd1, 15, pciT0, Buffer, dLength)
            If retval <> 0 Or Buffer(0) <> &H61 Or Buffer(1) <> &H5 Then    'Maybe not MyKad
                currentApp = ""
                Return False
            End If
            dLength = 256
            retval = SCardTransmit(hCard, pciT0, Cmd2, 5, pciT0, Buffer, dLength)
            currentApp = "JPN"
            Return True
        End If
        Return False
    End Function

    Public Function ReadInfo(ByVal field As Char()) As String
        Dim Buffer2(127) As Byte
        Dim output As String
        Select Case field
            Case "Name"
                ReadRaw("JPN", 1, 1, &HE9, 40, Buffer2)
                output = BytesToString(Buffer2, 0, 20)
                output &= vbNewLine & BytesToString(Buffer2, 20, 20)
                Return output
            Case "IC"
                ReadRaw("JPN", 1, 1, &H111, 13, Buffer2)
                Return BytesToString(Buffer2, 0, 13)
            Case "OldIC"
                ReadRaw("JPN", 1, 1, &H11F, 8, Buffer2)
                Return BytesToString(Buffer2, 0, 8)
            Case "DOB"
                ReadRaw("JPN", 1, 1, &H127, 4, Buffer2)
                Return BytesToDateString(Buffer2)
            Case "POB"
                ReadRaw("JPN", 1, 1, &H12B, 25, Buffer2)
                Return BytesToString(Buffer2, 0, 25)
            Case "Gender"
                ReadRaw("JPN", 1, 1, &H11E, 1, Buffer2)
                If Buffer2(0) = Asc("L") Then
                    Return "Male"
                ElseIf Buffer2(0) = Asc("P") Then
                    Return "Female"
                End If
            Case "Citizen"
                ReadRaw("JPN", 1, 1, &H148, 18, Buffer2)
                Return BytesToString(Buffer2, 0, 18)
            Case "IssueDate"
                ReadRaw("JPN", 1, 1, &H144, 4, Buffer2)
                Return BytesToDateString(Buffer2)
            Case "Race"
                ReadRaw("JPN", 1, 1, &H15A, 25, Buffer2)
                Return BytesToString(Buffer2, 0, 25)
            Case "Religion"
                ReadRaw("JPN", 1, 1, &H173, 11, Buffer2)
                Return BytesToString(Buffer2, 0, 11)
            Case "Address"
                ReDim Buffer2(511)
                ReadRaw("JPN", 1, 4, 0, 151, Buffer2)
                output = BytesToString(Buffer2, &H3, 30)
                output &= vbNewLine & BytesToString(Buffer2, &H21, 30)
                output &= vbNewLine & BytesToString(Buffer2, &H3F, 30)
                output &= vbNewLine & BytesToPostcodeString(Buffer2, &H5D)
                output &= " " & BytesToString(Buffer2, &H60, 25)
                output &= vbNewLine & BytesToString(Buffer2, &H79, 30)
                Return output
        End Select
        Return ""
    End Function

    Public Function BytesToPostcodeString(ByVal input As Byte(), ByVal offset As Int32) As String
        Dim output(4) As Char
        output(0) = Chr((input(offset+0) >> 4) + &H30)
        output(1) = Chr((input(offset+0) And &HF) + &H30)
        output(2) = Chr((input(offset+1) >> 4) + &H30)
        output(3) = Chr((input(offset+1) And &HF) + &H30)
        output(4) = Chr((input(offset+2) >> 4) + &H30)
        Return output
    End Function

    Public Function BytesToDateString(ByVal input As Byte()) As String
        Dim output(9) As Char
        output(0) = Chr((input(0) >> 4) + &H30)
        output(1) = Chr((input(0) And &HF) + &H30)
        output(2) = Chr((input(1) >> 4) + &H30)
        output(3) = Chr((input(1) And &HF) + &H30)
        output(4) = "-"
        output(5) = Chr((input(2) >> 4) + &H30)
        output(6) = Chr((input(2) And &HF) + &H30)
        output(7) = "-"
        output(8) = Chr((input(3) >> 4) + &H30)
        output(9) = Chr((input(3) And &HF) + &H30)
        Return output
    End Function

    Public Function BytesToString(ByVal input As Byte(), ByVal offset As Int32, ByVal len As Int32) As String
        Dim i, j As Int32
        Dim output(127) As Char
        j = -1
        For i = 0 To len - 1
            output(i) = Chr(input(offset + i))
            If input(offset + i) <> &H20 Then j = i
        Next
        ReDim Preserve output(j)
        Return output
    End Function

    Public Function ReadPhoto(ByRef memstream As MemoryStream) As Boolean
        Dim Buffer2(4095) As Byte
        ReadRaw("JPN", 1, 2, 3, 4000, Buffer2)
        memstream.Write(Buffer2, 0, 4000)
    End Function

    Public Function CacheJPN1() As Boolean
        ReadRaw("JPN", 1, 1, 0, 424, BufferC)
        cachedJPN1 = True
    End Function

    Public Function ReadRaw(ByVal App As String, ByVal FileMajor As Int32, _
       ByVal FileMinor As Int32, ByVal Offset As Int32, ByVal Length As Int32, _
       ByVal Dest As Byte()) As Boolean
        Dim retval As Int32
        If App = "JPN" Then
            If currentApp <> "JPN" Then
                If SelectApp("JPN") = False Then Return False
            End If

            If cachedJPN1 = True And FileMajor = 1 And FileMinor = 1 Then
                Dim k As Int32
                For k = 0 To Length - 1
                    Dest(k) = BufferC(Offset + k)
                Next
                Return True
            End If

            Cmd3(8) = Length And &HFF
            Cmd3(9) = (Length >> 8) And &HFF
            dLength = 256
            retval = SCardTransmit(hCard, pciT0, Cmd3, 10, pciT0, Buffer, dLength)

            Cmd4(5) = FileMinor And &HFF
            Cmd4(6) = (FileMinor >> 8) And &HFF
            Cmd4(7) = FileMajor And &HFF
            Cmd4(8) = (FileMajor >> 8) And &HFF
            Cmd4(9) = Offset And &HFF
            Cmd4(10) = (Offset >> 8) And &HFF
            Cmd4(11) = Length And &HFF
            Cmd4(12) = (Length >> 8) And &HFF
            dLength = 256
            retval = SCardTransmit(hCard, pciT0, Cmd4, 13, pciT0, Buffer, dLength)

            Dim i, j As Int32
            i = 0
            Do
                If Length > 254 Then
                    Cmd5(4) = 252
                    Length -= 252
                Else
                    Cmd5(4) = Length
                    Length = 0
                End If
                dLength = 256
                retval = SCardTransmit(hCard, pciT0, Cmd5, 5, pciT0, Buffer, dLength)

                For j = 0 To dLength - 3
                    Dest(i) = Buffer(j)
                    i += 1
                Next
            Loop While Length > 0
            Return True
        End If
    End Function

    Public Sub ReleaseContext()
        If hContext <> &HFFFFFFFF Then
            SCardReleaseContext(hContext)
        End If
        cachedJPN1 = False
        currentApp = ""
        connected = False
        hContext = &HFFFFFFFF
    End Sub

End Module
