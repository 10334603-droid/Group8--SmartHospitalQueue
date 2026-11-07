<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        btnExit = New Button()
        btnLogin = New Button()
        cboRole = New ComboBox()
        txtPassword = New TextBox()
        txtUseranme = New TextBox()
        lblLoginAs = New Label()
        lblPassword = New Label()
        lblUsername = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Controls.Add(cboRole)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUseranme)
        GroupBox1.Controls.Add(lblLoginAs)
        GroupBox1.Controls.Add(lblPassword)
        GroupBox1.Controls.Add(lblUsername)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBox1.Location = New Point(574, 206)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(513, 492)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Hospital Queue System "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(153, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(262, 28)
        Label2.TabIndex = 9
        Label2.Text = "Please Login and Continue"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.Location = New Point(271, 374)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(124, 62)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.HotTrack
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnLogin.Location = New Point(68, 374)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(124, 62)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' cboRole
        ' 
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"Doctor", "Receptionist"})
        cboRole.Location = New Point(166, 324)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(298, 36)
        cboRole.TabIndex = 6
        cboRole.Text = "select role"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(166, 248)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(303, 34)
        txtPassword.TabIndex = 5
        ' 
        ' txtUseranme
        ' 
        txtUseranme.Location = New Point(166, 175)
        txtUseranme.Name = "txtUseranme"
        txtUseranme.Size = New Size(303, 34)
        txtUseranme.TabIndex = 4
        ' 
        ' lblLoginAs
        ' 
        lblLoginAs.AutoSize = True
        lblLoginAs.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        lblLoginAs.Location = New Point(36, 324)
        lblLoginAs.Name = "lblLoginAs"
        lblLoginAs.Size = New Size(90, 25)
        lblLoginAs.TabIndex = 3
        lblLoginAs.Text = "Login As:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        lblPassword.Location = New Point(36, 250)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(97, 25)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        lblUsername.Location = New Point(36, 175)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(110, 25)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Usseranme:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        Label1.Location = New Point(236, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 0
        Label1.Text = "Welcome"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(576, 677)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(598, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(470, 188)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1093, 703)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.ControlText
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Smart Hospital Queue Ssystem"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblLoginAs As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUseranme As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
