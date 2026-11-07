<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        btnBack = New Button()
        btnClear = New Button()
        btnRegisterPatient = New Button()
        txtQueueNumber = New TextBox()
        cmbGender = New ComboBox()
        txtPhoneNumber = New TextBox()
        txtAge = New TextBox()
        txtPatientName = New TextBox()
        txtPatientID = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblWelcome = New Label()
        Timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnBack)
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(btnRegisterPatient)
        GroupBox1.Controls.Add(txtQueueNumber)
        GroupBox1.Controls.Add(cmbGender)
        GroupBox1.Controls.Add(txtPhoneNumber)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(txtPatientName)
        GroupBox1.Controls.Add(txtPatientID)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBox1.Location = New Point(25, 120)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(549, 481)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "PATIENT REGISTRATION"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.IndianRed
        btnBack.Location = New Point(433, 405)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 56)
        btnBack.TabIndex = 14
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.Highlight
        btnClear.Location = New Point(251, 405)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 55)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnRegisterPatient
        ' 
        btnRegisterPatient.BackColor = SystemColors.ControlLight
        btnRegisterPatient.Location = New Point(24, 405)
        btnRegisterPatient.Name = "btnRegisterPatient"
        btnRegisterPatient.Size = New Size(157, 56)
        btnRegisterPatient.TabIndex = 12
        btnRegisterPatient.Text = "Resgister Pateint "
        btnRegisterPatient.UseVisualStyleBackColor = False
        ' 
        ' txtQueueNumber
        ' 
        txtQueueNumber.Location = New Point(182, 340)
        txtQueueNumber.Multiline = True
        txtQueueNumber.Name = "txtQueueNumber"
        txtQueueNumber.Size = New Size(345, 34)
        txtQueueNumber.TabIndex = 11
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Location = New Point(182, 229)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(345, 28)
        cmbGender.TabIndex = 10
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(182, 284)
        txtPhoneNumber.Multiline = True
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(345, 34)
        txtPhoneNumber.TabIndex = 9
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(182, 173)
        txtAge.Multiline = True
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(345, 34)
        txtAge.TabIndex = 8
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Location = New Point(182, 120)
        txtPatientName.Multiline = True
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(345, 34)
        txtPatientName.TabIndex = 7
        ' 
        ' txtPatientID
        ' 
        txtPatientID.Location = New Point(182, 65)
        txtPatientID.Multiline = True
        txtPatientID.Name = "txtPatientID"
        txtPatientID.Size = New Size(345, 34)
        txtPatientID.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(24, 348)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 20)
        Label6.TabIndex = 5
        Label6.Text = "Queue Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(24, 287)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 20)
        Label5.TabIndex = 4
        Label5.Text = "Phone number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(24, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 20)
        Label4.TabIndex = 3
        Label4.Text = "Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(24, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 2
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(24, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 1
        Label2.Text = "Patient Nane:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(24, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 0
        Label1.Text = "Patient ID:"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.Red
        lblWelcome.Location = New Point(222, 47)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(492, 29)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome to Registratuon Dashborad"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 600
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(990, 625)
        Controls.Add(lblWelcome)
        Controls.Add(GroupBox1)
        Name = "DashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration Dashboard"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRegisterPatient As Button
    Friend WithEvents txtQueueNumber As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Timer1 As Timer
End Class
