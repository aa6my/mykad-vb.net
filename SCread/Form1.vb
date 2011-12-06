Imports System.IO
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim retval As Int32
        Dim readers(-1)() As Char
        Dim i As Int32

        retval = GetReaders(readers)
        If retval = SCARD_E_NO_SERVICE Then
            Status1.Text = "Smart Card service not started"
            Return
        ElseIf retval = SCARD_E_NO_READERS_AVAILABLE Then
            Status1.Text = "No readers available"
            Return
        ElseIf retval <> 0 Then
            Status1.Text = "Error listing reader"
            Return
        End If

        For i = 0 To readers.GetUpperBound(0)
            lsbReader.Items.Add(CStr(readers(i)))
        Next
        lsbReader.SelectedIndex = 0
        Status1.Text = "Ready"
    End Sub

    Private Sub Form1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        ReleaseContext()
    End Sub

    Private Sub btnRead_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRead.Click
        Dim t As New Thread(AddressOf ThreadProc)
        Form.CheckForIllegalCrossThreadCalls = False
        btnRead.Enabled = False
        t.Start()
        Thread.Sleep(0)
    End Sub

    Sub ThreadProc()
        Status1.Text = "Connecting to card..."
        If SelectReader(lsbReader.SelectedItem) = False Then
            Status1.Text = "Can't connect to smart card"
            btnRead.Enabled = True
            Return
        End If
        Status1.Text = "Reading"
        CacheJPN1()
        txtName.Text = ReadInfo("Name")
        txtIC.Text = ReadInfo("IC")
        txtOldIC.Text = ReadInfo("OldIC")
        txtDOB.Text = ReadInfo("DOB")
        txtPOB.Text = ReadInfo("POB")
        txtGender.Text = ReadInfo("Gender")
        txtCitizen.Text = ReadInfo("Citizen")
        txtIssueDate.Text = ReadInfo("IssueDate")
        txtRace.Text = ReadInfo("Race")
        txtReligion.Text = ReadInfo("Religion")
        txtAddress.Text = ReadInfo("Address")
        cachedJPN1 = False

        Dim memstream As New MemoryStream
        Status1.Text = "Reading photo, takes about 7s"
        ReadPhoto(memstream)
        PictureBox1.Image = System.Drawing.Image.FromStream(memstream)
        btnRead.Enabled = True
        Status1.Text = "Ready"
    End Sub

End Class
