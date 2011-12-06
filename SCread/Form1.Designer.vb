<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lsbReader = New System.Windows.Forms.ComboBox
        Me.btnRead = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPageJPN = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblReligion = New System.Windows.Forms.Label
        Me.lblRace = New System.Windows.Forms.Label
        Me.txtReligion = New System.Windows.Forms.TextBox
        Me.txtRace = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblCitizen = New System.Windows.Forms.Label
        Me.lblIssue = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtCitizen = New System.Windows.Forms.TextBox
        Me.txtIssueDate = New System.Windows.Forms.TextBox
        Me.lblPOB = New System.Windows.Forms.Label
        Me.lblDOB = New System.Windows.Forms.Label
        Me.lblGender = New System.Windows.Forms.Label
        Me.lblOldIC = New System.Windows.Forms.Label
        Me.lblIC = New System.Windows.Forms.Label
        Me.txtPOB = New System.Windows.Forms.TextBox
        Me.txtDOB = New System.Windows.Forms.TextBox
        Me.txtOldIC = New System.Windows.Forms.TextBox
        Me.txtGender = New System.Windows.Forms.TextBox
        Me.txtIC = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.Status = New System.Windows.Forms.StatusStrip
        Me.Status1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.TabControl1.SuspendLayout()
        Me.TabPageJPN.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsbReader
        '
        Me.lsbReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lsbReader.Location = New System.Drawing.Point(12, 12)
        Me.lsbReader.Name = "lsbReader"
        Me.lsbReader.Size = New System.Drawing.Size(324, 21)
        Me.lsbReader.TabIndex = 0
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(359, 11)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(62, 20)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageJPN)
        Me.TabControl1.Location = New System.Drawing.Point(14, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 369)
        Me.TabControl1.TabIndex = 2
        '
        'TabPageJPN
        '
        Me.TabPageJPN.Controls.Add(Me.PictureBox1)
        Me.TabPageJPN.Controls.Add(Me.lblReligion)
        Me.TabPageJPN.Controls.Add(Me.lblRace)
        Me.TabPageJPN.Controls.Add(Me.txtReligion)
        Me.TabPageJPN.Controls.Add(Me.txtRace)
        Me.TabPageJPN.Controls.Add(Me.lblAddress)
        Me.TabPageJPN.Controls.Add(Me.lblCitizen)
        Me.TabPageJPN.Controls.Add(Me.lblIssue)
        Me.TabPageJPN.Controls.Add(Me.txtAddress)
        Me.TabPageJPN.Controls.Add(Me.txtCitizen)
        Me.TabPageJPN.Controls.Add(Me.txtIssueDate)
        Me.TabPageJPN.Controls.Add(Me.lblPOB)
        Me.TabPageJPN.Controls.Add(Me.lblDOB)
        Me.TabPageJPN.Controls.Add(Me.lblGender)
        Me.TabPageJPN.Controls.Add(Me.lblOldIC)
        Me.TabPageJPN.Controls.Add(Me.lblIC)
        Me.TabPageJPN.Controls.Add(Me.txtPOB)
        Me.TabPageJPN.Controls.Add(Me.txtDOB)
        Me.TabPageJPN.Controls.Add(Me.txtOldIC)
        Me.TabPageJPN.Controls.Add(Me.txtGender)
        Me.TabPageJPN.Controls.Add(Me.txtIC)
        Me.TabPageJPN.Controls.Add(Me.txtName)
        Me.TabPageJPN.Controls.Add(Me.lblName)
        Me.TabPageJPN.Location = New System.Drawing.Point(4, 22)
        Me.TabPageJPN.Name = "TabPageJPN"
        Me.TabPageJPN.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageJPN.Size = New System.Drawing.Size(464, 343)
        Me.TabPageJPN.TabIndex = 0
        Me.TabPageJPN.Text = "JPN"
        Me.TabPageJPN.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(308, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lblReligion
        '
        Me.lblReligion.AutoSize = True
        Me.lblReligion.Location = New System.Drawing.Point(161, 220)
        Me.lblReligion.Name = "lblReligion"
        Me.lblReligion.Size = New System.Drawing.Size(45, 13)
        Me.lblReligion.TabIndex = 21
        Me.lblReligion.Text = "Religion"
        '
        'lblRace
        '
        Me.lblRace.AutoSize = True
        Me.lblRace.Location = New System.Drawing.Point(180, 183)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(33, 13)
        Me.lblRace.TabIndex = 20
        Me.lblRace.Text = "Race"
        '
        'txtReligion
        '
        Me.txtReligion.Location = New System.Drawing.Point(212, 217)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Size = New System.Drawing.Size(75, 20)
        Me.txtReligion.TabIndex = 19
        '
        'txtRace
        '
        Me.txtRace.Location = New System.Drawing.Point(219, 180)
        Me.txtRace.Name = "txtRace"
        Me.txtRace.Size = New System.Drawing.Size(68, 20)
        Me.txtRace.TabIndex = 18
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 253)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 17
        Me.lblAddress.Text = "Address"
        '
        'lblCitizen
        '
        Me.lblCitizen.AutoSize = True
        Me.lblCitizen.Location = New System.Drawing.Point(7, 183)
        Me.lblCitizen.Name = "lblCitizen"
        Me.lblCitizen.Size = New System.Drawing.Size(57, 13)
        Me.lblCitizen.TabIndex = 16
        Me.lblCitizen.Text = "Citizenship"
        '
        'lblIssue
        '
        Me.lblIssue.AutoSize = True
        Me.lblIssue.Location = New System.Drawing.Point(6, 220)
        Me.lblIssue.Name = "lblIssue"
        Me.lblIssue.Size = New System.Drawing.Size(58, 13)
        Me.lblIssue.TabIndex = 15
        Me.lblIssue.Text = "Issue Date"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(69, 250)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(218, 79)
        Me.txtAddress.TabIndex = 14
        '
        'txtCitizen
        '
        Me.txtCitizen.Location = New System.Drawing.Point(70, 180)
        Me.txtCitizen.Name = "txtCitizen"
        Me.txtCitizen.Size = New System.Drawing.Size(104, 20)
        Me.txtCitizen.TabIndex = 13
        '
        'txtIssueDate
        '
        Me.txtIssueDate.Location = New System.Drawing.Point(70, 217)
        Me.txtIssueDate.Name = "txtIssueDate"
        Me.txtIssueDate.Size = New System.Drawing.Size(80, 20)
        Me.txtIssueDate.TabIndex = 12
        '
        'lblPOB
        '
        Me.lblPOB.AutoSize = True
        Me.lblPOB.Location = New System.Drawing.Point(6, 150)
        Me.lblPOB.Name = "lblPOB"
        Me.lblPOB.Size = New System.Drawing.Size(70, 13)
        Me.lblPOB.TabIndex = 11
        Me.lblPOB.Text = "Place of Birth"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(6, 112)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(66, 13)
        Me.lblDOB.TabIndex = 10
        Me.lblDOB.Text = "Date of Birth"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(181, 112)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender"
        '
        'lblOldIC
        '
        Me.lblOldIC.AutoSize = True
        Me.lblOldIC.Location = New System.Drawing.Point(177, 75)
        Me.lblOldIC.Name = "lblOldIC"
        Me.lblOldIC.Size = New System.Drawing.Size(36, 13)
        Me.lblOldIC.TabIndex = 8
        Me.lblOldIC.Text = "Old IC"
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Location = New System.Drawing.Point(6, 75)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(35, 13)
        Me.lblIC.TabIndex = 7
        Me.lblIC.Text = "IC no."
        '
        'txtPOB
        '
        Me.txtPOB.Location = New System.Drawing.Point(82, 147)
        Me.txtPOB.Name = "txtPOB"
        Me.txtPOB.Size = New System.Drawing.Size(206, 20)
        Me.txtPOB.TabIndex = 6
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(82, 109)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(72, 20)
        Me.txtDOB.TabIndex = 5
        '
        'txtOldIC
        '
        Me.txtOldIC.Location = New System.Drawing.Point(219, 72)
        Me.txtOldIC.Name = "txtOldIC"
        Me.txtOldIC.Size = New System.Drawing.Size(69, 20)
        Me.txtOldIC.TabIndex = 4
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(229, 109)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(59, 20)
        Me.txtGender.TabIndex = 3
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(52, 72)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(98, 20)
        Me.txtIC.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(52, 16)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(236, 40)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status1, Me.ToolStripProgressBar1})
        Me.Status.Location = New System.Drawing.Point(0, 417)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(498, 22)
        Me.Status.TabIndex = 3
        Me.Status.Text = "StatusStrip1"
        '
        'Status1
        '
        Me.Status1.AutoSize = False
        Me.Status1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(381, 17)
        Me.Status1.Spring = True
        Me.Status1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.AutoSize = False
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 439)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.lsbReader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageJPN.ResumeLayout(False)
        Me.TabPageJPN.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsbReader As System.Windows.Forms.ComboBox
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageJPN As System.Windows.Forms.TabPage
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPOB As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblOldIC As System.Windows.Forms.Label
    Friend WithEvents lblIC As System.Windows.Forms.Label
    Friend WithEvents txtPOB As System.Windows.Forms.TextBox
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtOldIC As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtIC As System.Windows.Forms.TextBox
    Friend WithEvents lblIssue As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCitizen As System.Windows.Forms.TextBox
    Friend WithEvents txtIssueDate As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCitizen As System.Windows.Forms.Label
    Friend WithEvents lblRace As System.Windows.Forms.Label
    Friend WithEvents txtReligion As System.Windows.Forms.TextBox
    Friend WithEvents txtRace As System.Windows.Forms.TextBox
    Friend WithEvents lblReligion As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents Status1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
