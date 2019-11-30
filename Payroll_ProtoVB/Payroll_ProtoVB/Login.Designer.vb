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
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.loginUsrTxt = New System.Windows.Forms.TextBox()
        Me.loginformPassLabel = New System.Windows.Forms.Label()
        Me.loginFormUsrLabel = New System.Windows.Forms.Label()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LoginGB = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.createAdminBtn = New System.Windows.Forms.Button()
        Me.loginPwTxt = New System.Windows.Forms.MaskedTextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.LoginGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(181, 176)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'loginUsrTxt
        '
        Me.loginUsrTxt.Location = New System.Drawing.Point(159, 115)
        Me.loginUsrTxt.Name = "loginUsrTxt"
        Me.loginUsrTxt.Size = New System.Drawing.Size(121, 20)
        Me.loginUsrTxt.TabIndex = 0
        '
        'loginformPassLabel
        '
        Me.loginformPassLabel.AutoSize = True
        Me.loginformPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginformPassLabel.Location = New System.Drawing.Point(39, 144)
        Me.loginformPassLabel.Name = "loginformPassLabel"
        Me.loginformPassLabel.Size = New System.Drawing.Size(86, 20)
        Me.loginformPassLabel.TabIndex = 2
        Me.loginformPassLabel.Text = "Password"
        '
        'loginFormUsrLabel
        '
        Me.loginFormUsrLabel.AutoSize = True
        Me.loginFormUsrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginFormUsrLabel.Location = New System.Drawing.Point(39, 115)
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
        Me.splitContainer1.Panel2Collapsed = True
        Me.splitContainer1.Size = New System.Drawing.Size(418, 299)
        Me.splitContainer1.SplitterDistance = 412
        Me.splitContainer1.TabIndex = 1
        '
        'LoginGB
        '
        Me.LoginGB.Controls.Add(Me.Label1)
        Me.LoginGB.Controls.Add(Me.createAdminBtn)
        Me.LoginGB.Controls.Add(Me.loginFormUsrLabel)
        Me.LoginGB.Controls.Add(Me.loginPwTxt)
        Me.LoginGB.Controls.Add(Me.loginformPassLabel)
        Me.LoginGB.Controls.Add(Me.loginBtn)
        Me.LoginGB.Controls.Add(Me.loginUsrTxt)
        Me.LoginGB.Location = New System.Drawing.Point(9, 10)
        Me.LoginGB.Name = "LoginGB"
        Me.LoginGB.Size = New System.Drawing.Size(406, 286)
        Me.LoginGB.TabIndex = 21
        Me.LoginGB.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Payroll Login"
        '
        'createAdminBtn
        '
        Me.createAdminBtn.Location = New System.Drawing.Point(312, 257)
        Me.createAdminBtn.Name = "createAdminBtn"
        Me.createAdminBtn.Size = New System.Drawing.Size(88, 23)
        Me.createAdminBtn.TabIndex = 6
        Me.createAdminBtn.Text = "Create Admin"
        Me.createAdminBtn.UseVisualStyleBackColor = True
        '
        'loginPwTxt
        '
        Me.loginPwTxt.Location = New System.Drawing.Point(159, 146)
        Me.loginPwTxt.Name = "loginPwTxt"
        Me.loginPwTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.loginPwTxt.Size = New System.Drawing.Size(121, 20)
        Me.loginPwTxt.TabIndex = 1
        Me.loginPwTxt.UseSystemPasswordChar = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Login
        '
        Me.AcceptButton = Me.loginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 299)
        Me.Controls.Add(Me.splitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login | Sign Up"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.LoginGB.ResumeLayout(False)
        Me.LoginGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents loginBtn As Button
    Private WithEvents loginUsrTxt As TextBox
    Private WithEvents loginformPassLabel As Label
    Private WithEvents loginFormUsrLabel As Label
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents loginPwTxt As MaskedTextBox
    Private WithEvents createAdminBtn As Button
    Friend WithEvents LoginGB As GroupBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label1 As Label
End Class
