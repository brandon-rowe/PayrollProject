<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.usrGenFormCreateUsrButton = New System.Windows.Forms.Button()
        Me.LnameTxt = New System.Windows.Forms.TextBox()
        Me.usrGenFormLastNameLabel = New System.Windows.Forms.Label()
        Me.ZipTxt = New System.Windows.Forms.TextBox()
        Me.usrGenFormZipLabel = New System.Windows.Forms.Label()
        Me.StateTxt = New System.Windows.Forms.TextBox()
        Me.usrGenFormStateLabel = New System.Windows.Forms.Label()
        Me.StreetTxt = New System.Windows.Forms.TextBox()
        Me.FnameTxt = New System.Windows.Forms.TextBox()
        Me.StreetLbl = New System.Windows.Forms.Label()
        Me.usrGenFormFirstNameLabel = New System.Windows.Forms.Label()
        Me.VerifyPwordTxt = New System.Windows.Forms.MaskedTextBox()
        Me.userGenFormPassVrfyLabel = New System.Windows.Forms.Label()
        Me.CreateUnameTxt = New System.Windows.Forms.TextBox()
        Me.userGenFormPassLabel = New System.Windows.Forms.Label()
        Me.usrGenFormUsrNameLabel = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loginUsrTxt = New System.Windows.Forms.TextBox()
        Me.loginformPassLabel = New System.Windows.Forms.Label()
        Me.loginFormUsrLabel = New System.Windows.Forms.Label()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LoginGB = New System.Windows.Forms.GroupBox()
        Me.SignUp = New System.Windows.Forms.Button()
        Me.loginPwTxt = New System.Windows.Forms.MaskedTextBox()
        Me.SignUpGB = New System.Windows.Forms.GroupBox()
        Me.CreatePwordTxt = New System.Windows.Forms.MaskedTextBox()
        Me.backToLoginBtn = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.LoginGB.SuspendLayout()
        Me.SignUpGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'usrGenFormCreateUsrButton
        '
        Me.usrGenFormCreateUsrButton.Location = New System.Drawing.Point(178, 370)
        Me.usrGenFormCreateUsrButton.Name = "usrGenFormCreateUsrButton"
        Me.usrGenFormCreateUsrButton.Size = New System.Drawing.Size(75, 23)
        Me.usrGenFormCreateUsrButton.TabIndex = 8
        Me.usrGenFormCreateUsrButton.Text = "Create User"
        Me.usrGenFormCreateUsrButton.UseVisualStyleBackColor = True
        '
        'LnameTxt
        '
        Me.LnameTxt.Location = New System.Drawing.Point(178, 113)
        Me.LnameTxt.Name = "LnameTxt"
        Me.LnameTxt.Size = New System.Drawing.Size(206, 20)
        Me.LnameTxt.TabIndex = 1
        '
        'usrGenFormLastNameLabel
        '
        Me.usrGenFormLastNameLabel.AutoSize = True
        Me.usrGenFormLastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormLastNameLabel.Location = New System.Drawing.Point(50, 113)
        Me.usrGenFormLastNameLabel.Name = "usrGenFormLastNameLabel"
        Me.usrGenFormLastNameLabel.Size = New System.Drawing.Size(95, 20)
        Me.usrGenFormLastNameLabel.TabIndex = 19
        Me.usrGenFormLastNameLabel.Text = "Last Name"
        '
        'ZipTxt
        '
        Me.ZipTxt.Location = New System.Drawing.Point(178, 214)
        Me.ZipTxt.Name = "ZipTxt"
        Me.ZipTxt.Size = New System.Drawing.Size(206, 20)
        Me.ZipTxt.TabIndex = 4
        '
        'usrGenFormZipLabel
        '
        Me.usrGenFormZipLabel.AutoSize = True
        Me.usrGenFormZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormZipLabel.Location = New System.Drawing.Point(111, 214)
        Me.usrGenFormZipLabel.Name = "usrGenFormZipLabel"
        Me.usrGenFormZipLabel.Size = New System.Drawing.Size(34, 20)
        Me.usrGenFormZipLabel.TabIndex = 17
        Me.usrGenFormZipLabel.Text = "Zip"
        '
        'StateTxt
        '
        Me.StateTxt.Location = New System.Drawing.Point(178, 184)
        Me.StateTxt.Name = "StateTxt"
        Me.StateTxt.Size = New System.Drawing.Size(206, 20)
        Me.StateTxt.TabIndex = 3
        '
        'usrGenFormStateLabel
        '
        Me.usrGenFormStateLabel.AutoSize = True
        Me.usrGenFormStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormStateLabel.Location = New System.Drawing.Point(92, 184)
        Me.usrGenFormStateLabel.Name = "usrGenFormStateLabel"
        Me.usrGenFormStateLabel.Size = New System.Drawing.Size(53, 20)
        Me.usrGenFormStateLabel.TabIndex = 15
        Me.usrGenFormStateLabel.Text = "State"
        '
        'StreetTxt
        '
        Me.StreetTxt.Location = New System.Drawing.Point(178, 150)
        Me.StreetTxt.Name = "StreetTxt"
        Me.StreetTxt.Size = New System.Drawing.Size(206, 20)
        Me.StreetTxt.TabIndex = 2
        '
        'FnameTxt
        '
        Me.FnameTxt.Location = New System.Drawing.Point(178, 77)
        Me.FnameTxt.Name = "FnameTxt"
        Me.FnameTxt.Size = New System.Drawing.Size(206, 20)
        Me.FnameTxt.TabIndex = 0
        '
        'StreetLbl
        '
        Me.StreetLbl.AutoSize = True
        Me.StreetLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StreetLbl.Location = New System.Drawing.Point(85, 150)
        Me.StreetLbl.Name = "StreetLbl"
        Me.StreetLbl.Size = New System.Drawing.Size(59, 20)
        Me.StreetLbl.TabIndex = 12
        Me.StreetLbl.Text = "Street"
        '
        'usrGenFormFirstNameLabel
        '
        Me.usrGenFormFirstNameLabel.AutoSize = True
        Me.usrGenFormFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormFirstNameLabel.Location = New System.Drawing.Point(48, 77)
        Me.usrGenFormFirstNameLabel.Name = "usrGenFormFirstNameLabel"
        Me.usrGenFormFirstNameLabel.Size = New System.Drawing.Size(96, 20)
        Me.usrGenFormFirstNameLabel.TabIndex = 11
        Me.usrGenFormFirstNameLabel.Text = "First Name"
        '
        'VerifyPwordTxt
        '
        Me.VerifyPwordTxt.Location = New System.Drawing.Point(178, 311)
        Me.VerifyPwordTxt.Name = "VerifyPwordTxt"
        Me.VerifyPwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.VerifyPwordTxt.Size = New System.Drawing.Size(206, 20)
        Me.VerifyPwordTxt.TabIndex = 7
        Me.VerifyPwordTxt.UseSystemPasswordChar = True
        '
        'userGenFormPassVrfyLabel
        '
        Me.userGenFormPassVrfyLabel.AutoSize = True
        Me.userGenFormPassVrfyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userGenFormPassVrfyLabel.Location = New System.Drawing.Point(7, 311)
        Me.userGenFormPassVrfyLabel.Name = "userGenFormPassVrfyLabel"
        Me.userGenFormPassVrfyLabel.Size = New System.Drawing.Size(137, 20)
        Me.userGenFormPassVrfyLabel.TabIndex = 9
        Me.userGenFormPassVrfyLabel.Text = "Verify Password"
        '
        'CreateUnameTxt
        '
        Me.CreateUnameTxt.Location = New System.Drawing.Point(178, 251)
        Me.CreateUnameTxt.Name = "CreateUnameTxt"
        Me.CreateUnameTxt.Size = New System.Drawing.Size(206, 20)
        Me.CreateUnameTxt.TabIndex = 5
        '
        'userGenFormPassLabel
        '
        Me.userGenFormPassLabel.AutoSize = True
        Me.userGenFormPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userGenFormPassLabel.Location = New System.Drawing.Point(59, 279)
        Me.userGenFormPassLabel.Name = "userGenFormPassLabel"
        Me.userGenFormPassLabel.Size = New System.Drawing.Size(86, 20)
        Me.userGenFormPassLabel.TabIndex = 6
        Me.userGenFormPassLabel.Text = "Password"
        '
        'usrGenFormUsrNameLabel
        '
        Me.usrGenFormUsrNameLabel.AutoSize = True
        Me.usrGenFormUsrNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormUsrNameLabel.Location = New System.Drawing.Point(46, 251)
        Me.usrGenFormUsrNameLabel.Name = "usrGenFormUsrNameLabel"
        Me.usrGenFormUsrNameLabel.Size = New System.Drawing.Size(98, 20)
        Me.usrGenFormUsrNameLabel.TabIndex = 5
        Me.usrGenFormUsrNameLabel.Text = "User Name"
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(132, 314)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(149, 77)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(154, 114)
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'loginUsrTxt
        '
        Me.loginUsrTxt.Location = New System.Drawing.Point(229, 216)
        Me.loginUsrTxt.Name = "loginUsrTxt"
        Me.loginUsrTxt.Size = New System.Drawing.Size(121, 20)
        Me.loginUsrTxt.TabIndex = 0
        '
        'loginformPassLabel
        '
        Me.loginformPassLabel.AutoSize = True
        Me.loginformPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginformPassLabel.Location = New System.Drawing.Point(109, 245)
        Me.loginformPassLabel.Name = "loginformPassLabel"
        Me.loginformPassLabel.Size = New System.Drawing.Size(86, 20)
        Me.loginformPassLabel.TabIndex = 2
        Me.loginformPassLabel.Text = "Password"
        '
        'loginFormUsrLabel
        '
        Me.loginFormUsrLabel.AutoSize = True
        Me.loginFormUsrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginFormUsrLabel.Location = New System.Drawing.Point(109, 216)
        Me.loginFormUsrLabel.Name = "loginFormUsrLabel"
        Me.loginFormUsrLabel.Size = New System.Drawing.Size(98, 20)
        Me.loginFormUsrLabel.TabIndex = 1
        Me.loginFormUsrLabel.Text = "User Name"
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.LoginGB)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.SignUpGB)
        Me.splitContainer1.Size = New System.Drawing.Size(1028, 495)
        Me.splitContainer1.SplitterDistance = 511
        Me.splitContainer1.TabIndex = 1
        '
        'LoginGB
        '
        Me.LoginGB.Controls.Add(Me.pictureBox1)
        Me.LoginGB.Controls.Add(Me.SignUp)
        Me.LoginGB.Controls.Add(Me.loginFormUsrLabel)
        Me.LoginGB.Controls.Add(Me.loginPwTxt)
        Me.LoginGB.Controls.Add(Me.loginformPassLabel)
        Me.LoginGB.Controls.Add(Me.loginBtn)
        Me.LoginGB.Controls.Add(Me.loginUsrTxt)
        Me.LoginGB.Location = New System.Drawing.Point(12, 21)
        Me.LoginGB.Name = "LoginGB"
        Me.LoginGB.Size = New System.Drawing.Size(483, 462)
        Me.LoginGB.TabIndex = 21
        Me.LoginGB.TabStop = False
        Me.LoginGB.Text = "Login"
        '
        'SignUp
        '
        Me.SignUp.Location = New System.Drawing.Point(228, 314)
        Me.SignUp.Name = "SignUp"
        Me.SignUp.Size = New System.Drawing.Size(75, 23)
        Me.SignUp.TabIndex = 6
        Me.SignUp.Text = "Sign Up"
        Me.SignUp.UseVisualStyleBackColor = True
        '
        'loginPwTxt
        '
        Me.loginPwTxt.Location = New System.Drawing.Point(229, 247)
        Me.loginPwTxt.Name = "loginPwTxt"
        Me.loginPwTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.loginPwTxt.Size = New System.Drawing.Size(121, 20)
        Me.loginPwTxt.TabIndex = 1
        Me.loginPwTxt.UseSystemPasswordChar = True
        '
        'SignUpGB
        '
        Me.SignUpGB.Controls.Add(Me.backToLoginBtn)
        Me.SignUpGB.Controls.Add(Me.usrGenFormCreateUsrButton)
        Me.SignUpGB.Controls.Add(Me.usrGenFormFirstNameLabel)
        Me.SignUpGB.Controls.Add(Me.LnameTxt)
        Me.SignUpGB.Controls.Add(Me.usrGenFormUsrNameLabel)
        Me.SignUpGB.Controls.Add(Me.usrGenFormLastNameLabel)
        Me.SignUpGB.Controls.Add(Me.userGenFormPassLabel)
        Me.SignUpGB.Controls.Add(Me.ZipTxt)
        Me.SignUpGB.Controls.Add(Me.CreateUnameTxt)
        Me.SignUpGB.Controls.Add(Me.usrGenFormZipLabel)
        Me.SignUpGB.Controls.Add(Me.CreatePwordTxt)
        Me.SignUpGB.Controls.Add(Me.StateTxt)
        Me.SignUpGB.Controls.Add(Me.userGenFormPassVrfyLabel)
        Me.SignUpGB.Controls.Add(Me.usrGenFormStateLabel)
        Me.SignUpGB.Controls.Add(Me.VerifyPwordTxt)
        Me.SignUpGB.Controls.Add(Me.StreetTxt)
        Me.SignUpGB.Controls.Add(Me.StreetLbl)
        Me.SignUpGB.Controls.Add(Me.FnameTxt)
        Me.SignUpGB.Location = New System.Drawing.Point(17, 21)
        Me.SignUpGB.Name = "SignUpGB"
        Me.SignUpGB.Size = New System.Drawing.Size(484, 462)
        Me.SignUpGB.TabIndex = 7
        Me.SignUpGB.TabStop = False
        Me.SignUpGB.Text = "Sign Up"
        '
        'CreatePwordTxt
        '
        Me.CreatePwordTxt.Location = New System.Drawing.Point(178, 279)
        Me.CreatePwordTxt.Name = "CreatePwordTxt"
        Me.CreatePwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CreatePwordTxt.Size = New System.Drawing.Size(206, 20)
        Me.CreatePwordTxt.TabIndex = 6
        Me.CreatePwordTxt.UseSystemPasswordChar = True
        '
        'backToLoginBtn
        '
        Me.backToLoginBtn.Location = New System.Drawing.Point(273, 370)
        Me.backToLoginBtn.Name = "backToLoginBtn"
        Me.backToLoginBtn.Size = New System.Drawing.Size(93, 23)
        Me.backToLoginBtn.TabIndex = 20
        Me.backToLoginBtn.Text = "Have Account?"
        Me.backToLoginBtn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "Login"
        Me.Text = "Login | Sign Up"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.LoginGB.ResumeLayout(False)
        Me.LoginGB.PerformLayout()
        Me.SignUpGB.ResumeLayout(False)
        Me.SignUpGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents usrGenFormCreateUsrButton As Button
    Private WithEvents usrGenFormLastNameLabel As Label
    Private WithEvents usrGenFormZipLabel As Label
    Private WithEvents usrGenFormStateLabel As Label
    Private WithEvents StreetLbl As Label
    Private WithEvents usrGenFormFirstNameLabel As Label
    Private WithEvents userGenFormPassVrfyLabel As Label
    Private WithEvents usrGenFormUsrNameLabel As Label
    Private WithEvents loginBtn As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents loginUsrTxt As TextBox
    Private WithEvents loginformPassLabel As Label
    Private WithEvents loginFormUsrLabel As Label
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents loginPwTxt As MaskedTextBox
    Protected Friend WithEvents LnameTxt As TextBox
    Protected Friend WithEvents ZipTxt As TextBox
    Protected Friend WithEvents StateTxt As TextBox
    Protected Friend WithEvents StreetTxt As TextBox
    Protected Friend WithEvents FnameTxt As TextBox
    Protected Friend WithEvents VerifyPwordTxt As MaskedTextBox
    Protected Friend WithEvents CreateUnameTxt As TextBox
    Protected Friend WithEvents userGenFormPassLabel As Label
    Protected Friend WithEvents CreatePwordTxt As MaskedTextBox
    Private WithEvents SignUp As Button
    Friend WithEvents LoginGB As GroupBox
    Friend WithEvents SignUpGB As GroupBox
    Private WithEvents backToLoginBtn As Button
End Class
