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
        Me.usrGenFormAddyLabel = New System.Windows.Forms.Label()
        Me.usrGenFormFirstNameLabel = New System.Windows.Forms.Label()
        Me.VerifyPwordTxt = New System.Windows.Forms.MaskedTextBox()
        Me.userGenFormPassVrfyLabel = New System.Windows.Forms.Label()
        Me.CreateUnameTxt = New System.Windows.Forms.TextBox()
        Me.userGenFormPassLabel = New System.Windows.Forms.Label()
        Me.usrGenFormUsrNameLabel = New System.Windows.Forms.Label()
        Me.userGenFormLabel = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loginUsrTxt = New System.Windows.Forms.TextBox()
        Me.loginformPassLabel = New System.Windows.Forms.Label()
        Me.loginFormUsrLabel = New System.Windows.Forms.Label()
        Me.loginFormLable = New System.Windows.Forms.Label()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.loginPwTxt = New System.Windows.Forms.MaskedTextBox()
        Me.CreatePwordTxt = New System.Windows.Forms.MaskedTextBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'usrGenFormCreateUsrButton
        '
        Me.usrGenFormCreateUsrButton.Location = New System.Drawing.Point(381, 460)
        Me.usrGenFormCreateUsrButton.Name = "usrGenFormCreateUsrButton"
        Me.usrGenFormCreateUsrButton.Size = New System.Drawing.Size(75, 23)
        Me.usrGenFormCreateUsrButton.TabIndex = 8
        Me.usrGenFormCreateUsrButton.Text = "Create User"
        Me.usrGenFormCreateUsrButton.UseVisualStyleBackColor = True
        '
        'LnameTxt
        '
        Me.LnameTxt.Location = New System.Drawing.Point(199, 125)
        Me.LnameTxt.Name = "LnameTxt"
        Me.LnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.LnameTxt.TabIndex = 1
        '
        'usrGenFormLastNameLabel
        '
        Me.usrGenFormLastNameLabel.AutoSize = True
        Me.usrGenFormLastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormLastNameLabel.Location = New System.Drawing.Point(38, 125)
        Me.usrGenFormLastNameLabel.Name = "usrGenFormLastNameLabel"
        Me.usrGenFormLastNameLabel.Size = New System.Drawing.Size(95, 20)
        Me.usrGenFormLastNameLabel.TabIndex = 19
        Me.usrGenFormLastNameLabel.Text = "Last Name"
        '
        'ZipTxt
        '
        Me.ZipTxt.Location = New System.Drawing.Point(199, 228)
        Me.ZipTxt.Name = "ZipTxt"
        Me.ZipTxt.Size = New System.Drawing.Size(121, 20)
        Me.ZipTxt.TabIndex = 4
        '
        'usrGenFormZipLabel
        '
        Me.usrGenFormZipLabel.AutoSize = True
        Me.usrGenFormZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormZipLabel.Location = New System.Drawing.Point(40, 226)
        Me.usrGenFormZipLabel.Name = "usrGenFormZipLabel"
        Me.usrGenFormZipLabel.Size = New System.Drawing.Size(34, 20)
        Me.usrGenFormZipLabel.TabIndex = 17
        Me.usrGenFormZipLabel.Text = "Zip"
        '
        'StateTxt
        '
        Me.StateTxt.Location = New System.Drawing.Point(199, 196)
        Me.StateTxt.Name = "StateTxt"
        Me.StateTxt.Size = New System.Drawing.Size(148, 20)
        Me.StateTxt.TabIndex = 3
        '
        'usrGenFormStateLabel
        '
        Me.usrGenFormStateLabel.AutoSize = True
        Me.usrGenFormStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormStateLabel.Location = New System.Drawing.Point(38, 194)
        Me.usrGenFormStateLabel.Name = "usrGenFormStateLabel"
        Me.usrGenFormStateLabel.Size = New System.Drawing.Size(53, 20)
        Me.usrGenFormStateLabel.TabIndex = 15
        Me.usrGenFormStateLabel.Text = "State"
        '
        'StreetTxt
        '
        Me.StreetTxt.Location = New System.Drawing.Point(199, 162)
        Me.StreetTxt.Name = "StreetTxt"
        Me.StreetTxt.Size = New System.Drawing.Size(240, 20)
        Me.StreetTxt.TabIndex = 2
        '
        'FnameTxt
        '
        Me.FnameTxt.Location = New System.Drawing.Point(199, 89)
        Me.FnameTxt.Name = "FnameTxt"
        Me.FnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.FnameTxt.TabIndex = 0
        '
        'usrGenFormAddyLabel
        '
        Me.usrGenFormAddyLabel.AutoSize = True
        Me.usrGenFormAddyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormAddyLabel.Location = New System.Drawing.Point(38, 162)
        Me.usrGenFormAddyLabel.Name = "usrGenFormAddyLabel"
        Me.usrGenFormAddyLabel.Size = New System.Drawing.Size(75, 20)
        Me.usrGenFormAddyLabel.TabIndex = 12
        Me.usrGenFormAddyLabel.Text = "Address"
        '
        'usrGenFormFirstNameLabel
        '
        Me.usrGenFormFirstNameLabel.AutoSize = True
        Me.usrGenFormFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormFirstNameLabel.Location = New System.Drawing.Point(38, 89)
        Me.usrGenFormFirstNameLabel.Name = "usrGenFormFirstNameLabel"
        Me.usrGenFormFirstNameLabel.Size = New System.Drawing.Size(96, 20)
        Me.usrGenFormFirstNameLabel.TabIndex = 11
        Me.usrGenFormFirstNameLabel.Text = "First Name"
        '
        'VerifyPwordTxt
        '
        Me.VerifyPwordTxt.Location = New System.Drawing.Point(335, 427)
        Me.VerifyPwordTxt.Name = "VerifyPwordTxt"
        Me.VerifyPwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.VerifyPwordTxt.Size = New System.Drawing.Size(121, 20)
        Me.VerifyPwordTxt.TabIndex = 7
        '
        'userGenFormPassVrfyLabel
        '
        Me.userGenFormPassVrfyLabel.AutoSize = True
        Me.userGenFormPassVrfyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userGenFormPassVrfyLabel.Location = New System.Drawing.Point(174, 425)
        Me.userGenFormPassVrfyLabel.Name = "userGenFormPassVrfyLabel"
        Me.userGenFormPassVrfyLabel.Size = New System.Drawing.Size(137, 20)
        Me.userGenFormPassVrfyLabel.TabIndex = 9
        Me.userGenFormPassVrfyLabel.Text = "Verify Password"
        '
        'CreateUnameTxt
        '
        Me.CreateUnameTxt.Location = New System.Drawing.Point(335, 365)
        Me.CreateUnameTxt.Name = "CreateUnameTxt"
        Me.CreateUnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.CreateUnameTxt.TabIndex = 5
        '
        'userGenFormPassLabel
        '
        Me.userGenFormPassLabel.AutoSize = True
        Me.userGenFormPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userGenFormPassLabel.Location = New System.Drawing.Point(174, 393)
        Me.userGenFormPassLabel.Name = "userGenFormPassLabel"
        Me.userGenFormPassLabel.Size = New System.Drawing.Size(86, 20)
        Me.userGenFormPassLabel.TabIndex = 6
        Me.userGenFormPassLabel.Text = "Password"
        '
        'usrGenFormUsrNameLabel
        '
        Me.usrGenFormUsrNameLabel.AutoSize = True
        Me.usrGenFormUsrNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrGenFormUsrNameLabel.Location = New System.Drawing.Point(174, 365)
        Me.usrGenFormUsrNameLabel.Name = "usrGenFormUsrNameLabel"
        Me.usrGenFormUsrNameLabel.Size = New System.Drawing.Size(98, 20)
        Me.usrGenFormUsrNameLabel.TabIndex = 5
        Me.usrGenFormUsrNameLabel.Text = "User Name"
        '
        'userGenFormLabel
        '
        Me.userGenFormLabel.AutoSize = True
        Me.userGenFormLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userGenFormLabel.Location = New System.Drawing.Point(37, 21)
        Me.userGenFormLabel.Name = "userGenFormLabel"
        Me.userGenFormLabel.Size = New System.Drawing.Size(190, 25)
        Me.userGenFormLabel.TabIndex = 1
        Me.userGenFormLabel.Text = "Create New User"
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(226, 277)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(167, 68)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(154, 114)
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'loginUsrTxt
        '
        Me.loginUsrTxt.Location = New System.Drawing.Point(181, 211)
        Me.loginUsrTxt.Name = "loginUsrTxt"
        Me.loginUsrTxt.Size = New System.Drawing.Size(121, 20)
        Me.loginUsrTxt.TabIndex = 0
        '
        'loginformPassLabel
        '
        Me.loginformPassLabel.AutoSize = True
        Me.loginformPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginformPassLabel.Location = New System.Drawing.Point(61, 240)
        Me.loginformPassLabel.Name = "loginformPassLabel"
        Me.loginformPassLabel.Size = New System.Drawing.Size(86, 20)
        Me.loginformPassLabel.TabIndex = 2
        Me.loginformPassLabel.Text = "Password"
        '
        'loginFormUsrLabel
        '
        Me.loginFormUsrLabel.AutoSize = True
        Me.loginFormUsrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginFormUsrLabel.Location = New System.Drawing.Point(61, 211)
        Me.loginFormUsrLabel.Name = "loginFormUsrLabel"
        Me.loginFormUsrLabel.Size = New System.Drawing.Size(98, 20)
        Me.loginFormUsrLabel.TabIndex = 1
        Me.loginFormUsrLabel.Text = "User Name"
        '
        'loginFormLable
        '
        Me.loginFormLable.AutoSize = True
        Me.loginFormLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginFormLable.Location = New System.Drawing.Point(211, 21)
        Me.loginFormLable.Name = "loginFormLable"
        Me.loginFormLable.Size = New System.Drawing.Size(70, 25)
        Me.loginFormLable.TabIndex = 0
        Me.loginFormLable.Text = "Login"
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.loginPwTxt)
        Me.splitContainer1.Panel1.Controls.Add(Me.loginBtn)
        Me.splitContainer1.Panel1.Controls.Add(Me.pictureBox1)
        Me.splitContainer1.Panel1.Controls.Add(Me.loginUsrTxt)
        Me.splitContainer1.Panel1.Controls.Add(Me.loginformPassLabel)
        Me.splitContainer1.Panel1.Controls.Add(Me.loginFormUsrLabel)
        Me.splitContainer1.Panel1.Controls.Add(Me.loginFormLable)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.usrGenFormCreateUsrButton)
        Me.splitContainer1.Panel2.Controls.Add(Me.LnameTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.usrGenFormLastNameLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.ZipTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.usrGenFormZipLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.StateTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.usrGenFormStateLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.StreetTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.FnameTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.usrGenFormAddyLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.usrGenFormFirstNameLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.VerifyPwordTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.userGenFormPassVrfyLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.CreatePwordTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.CreateUnameTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.userGenFormPassLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.usrGenFormUsrNameLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.userGenFormLabel)
        Me.splitContainer1.Size = New System.Drawing.Size(1028, 495)
        Me.splitContainer1.SplitterDistance = 511
        Me.splitContainer1.TabIndex = 1
        '
        'loginPwTxt
        '
        Me.loginPwTxt.Location = New System.Drawing.Point(181, 242)
        Me.loginPwTxt.Name = "loginPwTxt"
        Me.loginPwTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.loginPwTxt.Size = New System.Drawing.Size(121, 20)
        Me.loginPwTxt.TabIndex = 1
        '
        'CreatePwordTxt
        '
        Me.CreatePwordTxt.Location = New System.Drawing.Point(335, 393)
        Me.CreatePwordTxt.Name = "CreatePwordTxt"
        Me.CreatePwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CreatePwordTxt.Size = New System.Drawing.Size(121, 20)
        Me.CreatePwordTxt.TabIndex = 6
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "Login"
        Me.Text = "LoginAndCreateUserForm"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.PerformLayout()
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents usrGenFormCreateUsrButton As Button
    Private WithEvents LnameTxt As TextBox
    Private WithEvents usrGenFormLastNameLabel As Label
    Private WithEvents ZipTxt As TextBox
    Private WithEvents usrGenFormZipLabel As Label
    Private WithEvents StateTxt As TextBox
    Private WithEvents usrGenFormStateLabel As Label
    Private WithEvents StreetTxt As TextBox
    Private WithEvents FnameTxt As TextBox
    Private WithEvents usrGenFormAddyLabel As Label
    Private WithEvents usrGenFormFirstNameLabel As Label
    Private WithEvents VerifyPwordTxt As MaskedTextBox
    Private WithEvents userGenFormPassVrfyLabel As Label
    Private WithEvents CreateUnameTxt As TextBox
    Private WithEvents userGenFormPassLabel As Label
    Private WithEvents usrGenFormUsrNameLabel As Label
    Private WithEvents userGenFormLabel As Label
    Private WithEvents loginBtn As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents loginUsrTxt As TextBox
    Private WithEvents loginformPassLabel As Label
    Private WithEvents loginFormUsrLabel As Label
    Private WithEvents loginFormLable As Label
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents CreatePwordTxt As MaskedTextBox
    Private WithEvents loginPwTxt As MaskedTextBox
End Class
