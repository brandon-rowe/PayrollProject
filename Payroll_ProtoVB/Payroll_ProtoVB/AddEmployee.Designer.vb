<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DependentsTxt = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormDepStatLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormMstatLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormPaymentTypeLabel = New System.Windows.Forms.Label()
        Me.PayTypeCBox = New System.Windows.Forms.ComboBox()
        Me.AccessCTRL = New System.Windows.Forms.CheckedListBox()
        Me.addEmployeeFormPermissionsLabel = New System.Windows.Forms.Label()
        Me.AddEmpBtn = New System.Windows.Forms.Button()
        Me.PositionTxt = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormPositionLable = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.LnameTxt = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormLastNameLabel = New System.Windows.Forms.Label()
        Me.ZipTxt = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormZipLabel = New System.Windows.Forms.Label()
        Me.StateTxt = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormStateLabel = New System.Windows.Forms.Label()
        Me.StreetTxt = New System.Windows.Forms.TextBox()
        Me.FnameTxt = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormAddyLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormFirstNameLabel = New System.Windows.Forms.Label()
        Me.MaritalStatCB = New System.Windows.Forms.ComboBox()
        Me.SSN_Label = New System.Windows.Forms.Label()
        Me.SSN_Txt = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'DependentsTxt
        '
        Me.DependentsTxt.Location = New System.Drawing.Point(202, 326)
        Me.DependentsTxt.Name = "DependentsTxt"
        Me.DependentsTxt.Size = New System.Drawing.Size(121, 20)
        Me.DependentsTxt.TabIndex = 8
        '
        'addEmployeeFormDepStatLabel
        '
        Me.addEmployeeFormDepStatLabel.AutoSize = True
        Me.addEmployeeFormDepStatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormDepStatLabel.Location = New System.Drawing.Point(30, 326)
        Me.addEmployeeFormDepStatLabel.Name = "addEmployeeFormDepStatLabel"
        Me.addEmployeeFormDepStatLabel.Size = New System.Drawing.Size(107, 20)
        Me.addEmployeeFormDepStatLabel.TabIndex = 83
        Me.addEmployeeFormDepStatLabel.Text = "Dependents"
        '
        'addEmployeeFormMstatLabel
        '
        Me.addEmployeeFormMstatLabel.AutoSize = True
        Me.addEmployeeFormMstatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormMstatLabel.Location = New System.Drawing.Point(16, 257)
        Me.addEmployeeFormMstatLabel.Name = "addEmployeeFormMstatLabel"
        Me.addEmployeeFormMstatLabel.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormMstatLabel.TabIndex = 81
        Me.addEmployeeFormMstatLabel.Text = "Marital Status"
        '
        'addEmployeeFormPaymentTypeLabel
        '
        Me.addEmployeeFormPaymentTypeLabel.AutoSize = True
        Me.addEmployeeFormPaymentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormPaymentTypeLabel.Location = New System.Drawing.Point(15, 288)
        Me.addEmployeeFormPaymentTypeLabel.Name = "addEmployeeFormPaymentTypeLabel"
        Me.addEmployeeFormPaymentTypeLabel.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormPaymentTypeLabel.TabIndex = 80
        Me.addEmployeeFormPaymentTypeLabel.Text = "Payment Type"
        '
        'PayTypeCBox
        '
        Me.PayTypeCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.PayTypeCBox.FormattingEnabled = True
        Me.PayTypeCBox.ItemHeight = 13
        Me.PayTypeCBox.Items.AddRange(New Object() {"Salary", "Hourly"})
        Me.PayTypeCBox.Location = New System.Drawing.Point(202, 287)
        Me.PayTypeCBox.Name = "PayTypeCBox"
        Me.PayTypeCBox.Size = New System.Drawing.Size(121, 21)
        Me.PayTypeCBox.TabIndex = 7
        '
        'AccessCTRL
        '
        Me.AccessCTRL.FormattingEnabled = True
        Me.AccessCTRL.Items.AddRange(New Object() {"FullAccess(Administrator)", "PartialAccess(Employees)"})
        Me.AccessCTRL.Location = New System.Drawing.Point(202, 401)
        Me.AccessCTRL.Name = "AccessCTRL"
        Me.AccessCTRL.Size = New System.Drawing.Size(149, 34)
        Me.AccessCTRL.TabIndex = 10
        '
        'addEmployeeFormPermissionsLabel
        '
        Me.addEmployeeFormPermissionsLabel.AutoSize = True
        Me.addEmployeeFormPermissionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormPermissionsLabel.Location = New System.Drawing.Point(41, 415)
        Me.addEmployeeFormPermissionsLabel.Name = "addEmployeeFormPermissionsLabel"
        Me.addEmployeeFormPermissionsLabel.Size = New System.Drawing.Size(105, 20)
        Me.addEmployeeFormPermissionsLabel.TabIndex = 77
        Me.addEmployeeFormPermissionsLabel.Text = "Permissions"
        '
        'AddEmpBtn
        '
        Me.AddEmpBtn.Location = New System.Drawing.Point(44, 460)
        Me.AddEmpBtn.Name = "AddEmpBtn"
        Me.AddEmpBtn.Size = New System.Drawing.Size(102, 23)
        Me.AddEmpBtn.TabIndex = 11
        Me.AddEmpBtn.Text = "Add Employee"
        Me.AddEmpBtn.UseVisualStyleBackColor = True
        '
        'PositionTxt
        '
        Me.PositionTxt.Location = New System.Drawing.Point(202, 365)
        Me.PositionTxt.Name = "PositionTxt"
        Me.PositionTxt.Size = New System.Drawing.Size(121, 20)
        Me.PositionTxt.TabIndex = 9
        '
        'addEmployeeFormPositionLable
        '
        Me.addEmployeeFormPositionLable.AutoSize = True
        Me.addEmployeeFormPositionLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormPositionLable.Location = New System.Drawing.Point(64, 365)
        Me.addEmployeeFormPositionLable.Name = "addEmployeeFormPositionLable"
        Me.addEmployeeFormPositionLable.Size = New System.Drawing.Size(73, 20)
        Me.addEmployeeFormPositionLable.TabIndex = 71
        Me.addEmployeeFormPositionLable.Text = "Position"
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(342, 460)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(102, 23)
        Me.BackBtn.TabIndex = 13
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'NextBtn
        '
        Me.NextBtn.Location = New System.Drawing.Point(202, 460)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(102, 23)
        Me.NextBtn.TabIndex = 12
        Me.NextBtn.Text = "Next"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'LnameTxt
        '
        Me.LnameTxt.Location = New System.Drawing.Point(202, 66)
        Me.LnameTxt.Name = "LnameTxt"
        Me.LnameTxt.Size = New System.Drawing.Size(192, 20)
        Me.LnameTxt.TabIndex = 1
        '
        'addEmployeeFormLastNameLabel
        '
        Me.addEmployeeFormLastNameLabel.AutoSize = True
        Me.addEmployeeFormLastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormLastNameLabel.Location = New System.Drawing.Point(41, 68)
        Me.addEmployeeFormLastNameLabel.Name = "addEmployeeFormLastNameLabel"
        Me.addEmployeeFormLastNameLabel.Size = New System.Drawing.Size(95, 20)
        Me.addEmployeeFormLastNameLabel.TabIndex = 65
        Me.addEmployeeFormLastNameLabel.Text = "Last Name"
        '
        'ZipTxt
        '
        Me.ZipTxt.Location = New System.Drawing.Point(202, 171)
        Me.ZipTxt.Name = "ZipTxt"
        Me.ZipTxt.Size = New System.Drawing.Size(192, 20)
        Me.ZipTxt.TabIndex = 4
        '
        'addEmployeeFormZipLabel
        '
        Me.addEmployeeFormZipLabel.AutoSize = True
        Me.addEmployeeFormZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormZipLabel.Location = New System.Drawing.Point(102, 169)
        Me.addEmployeeFormZipLabel.Name = "addEmployeeFormZipLabel"
        Me.addEmployeeFormZipLabel.Size = New System.Drawing.Size(34, 20)
        Me.addEmployeeFormZipLabel.TabIndex = 63
        Me.addEmployeeFormZipLabel.Text = "Zip"
        '
        'StateTxt
        '
        Me.StateTxt.Location = New System.Drawing.Point(202, 137)
        Me.StateTxt.Name = "StateTxt"
        Me.StateTxt.Size = New System.Drawing.Size(192, 20)
        Me.StateTxt.TabIndex = 3
        '
        'addEmployeeFormStateLabel
        '
        Me.addEmployeeFormStateLabel.AutoSize = True
        Me.addEmployeeFormStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormStateLabel.Location = New System.Drawing.Point(83, 137)
        Me.addEmployeeFormStateLabel.Name = "addEmployeeFormStateLabel"
        Me.addEmployeeFormStateLabel.Size = New System.Drawing.Size(53, 20)
        Me.addEmployeeFormStateLabel.TabIndex = 61
        Me.addEmployeeFormStateLabel.Text = "State"
        '
        'StreetTxt
        '
        Me.StreetTxt.Location = New System.Drawing.Point(202, 105)
        Me.StreetTxt.Name = "StreetTxt"
        Me.StreetTxt.Size = New System.Drawing.Size(192, 20)
        Me.StreetTxt.TabIndex = 2
        '
        'FnameTxt
        '
        Me.FnameTxt.Location = New System.Drawing.Point(202, 30)
        Me.FnameTxt.Name = "FnameTxt"
        Me.FnameTxt.Size = New System.Drawing.Size(192, 20)
        Me.FnameTxt.TabIndex = 0
        '
        'addEmployeeFormAddyLabel
        '
        Me.addEmployeeFormAddyLabel.AutoSize = True
        Me.addEmployeeFormAddyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormAddyLabel.Location = New System.Drawing.Point(61, 105)
        Me.addEmployeeFormAddyLabel.Name = "addEmployeeFormAddyLabel"
        Me.addEmployeeFormAddyLabel.Size = New System.Drawing.Size(75, 20)
        Me.addEmployeeFormAddyLabel.TabIndex = 58
        Me.addEmployeeFormAddyLabel.Text = "Address"
        '
        'addEmployeeFormFirstNameLabel
        '
        Me.addEmployeeFormFirstNameLabel.AutoSize = True
        Me.addEmployeeFormFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormFirstNameLabel.Location = New System.Drawing.Point(41, 32)
        Me.addEmployeeFormFirstNameLabel.Name = "addEmployeeFormFirstNameLabel"
        Me.addEmployeeFormFirstNameLabel.Size = New System.Drawing.Size(96, 20)
        Me.addEmployeeFormFirstNameLabel.TabIndex = 57
        Me.addEmployeeFormFirstNameLabel.Text = "First Name"
        '
        'MaritalStatCB
        '
        Me.MaritalStatCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MaritalStatCB.FormattingEnabled = True
        Me.MaritalStatCB.Items.AddRange(New Object() {"Single", "Married"})
        Me.MaritalStatCB.Location = New System.Drawing.Point(202, 253)
        Me.MaritalStatCB.Name = "MaritalStatCB"
        Me.MaritalStatCB.Size = New System.Drawing.Size(121, 21)
        Me.MaritalStatCB.TabIndex = 6
        '
        'SSN_Label
        '
        Me.SSN_Label.AutoSize = True
        Me.SSN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSN_Label.Location = New System.Drawing.Point(91, 206)
        Me.SSN_Label.Name = "SSN_Label"
        Me.SSN_Label.Size = New System.Drawing.Size(45, 20)
        Me.SSN_Label.TabIndex = 86
        Me.SSN_Label.Text = "SSN"
        '
        'SSN_Txt
        '
        Me.SSN_Txt.Location = New System.Drawing.Point(204, 206)
        Me.SSN_Txt.Mask = "000-00-0000"
        Me.SSN_Txt.Name = "SSN_Txt"
        Me.SSN_Txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SSN_Txt.Size = New System.Drawing.Size(121, 20)
        Me.SSN_Txt.TabIndex = 5
        Me.SSN_Txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.SSN_Txt.UseSystemPasswordChar = True
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 539)
        Me.Controls.Add(Me.SSN_Txt)
        Me.Controls.Add(Me.SSN_Label)
        Me.Controls.Add(Me.MaritalStatCB)
        Me.Controls.Add(Me.DependentsTxt)
        Me.Controls.Add(Me.addEmployeeFormDepStatLabel)
        Me.Controls.Add(Me.addEmployeeFormMstatLabel)
        Me.Controls.Add(Me.addEmployeeFormPaymentTypeLabel)
        Me.Controls.Add(Me.PayTypeCBox)
        Me.Controls.Add(Me.AccessCTRL)
        Me.Controls.Add(Me.addEmployeeFormPermissionsLabel)
        Me.Controls.Add(Me.AddEmpBtn)
        Me.Controls.Add(Me.PositionTxt)
        Me.Controls.Add(Me.addEmployeeFormPositionLable)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.LnameTxt)
        Me.Controls.Add(Me.addEmployeeFormLastNameLabel)
        Me.Controls.Add(Me.ZipTxt)
        Me.Controls.Add(Me.addEmployeeFormZipLabel)
        Me.Controls.Add(Me.StateTxt)
        Me.Controls.Add(Me.addEmployeeFormStateLabel)
        Me.Controls.Add(Me.StreetTxt)
        Me.Controls.Add(Me.FnameTxt)
        Me.Controls.Add(Me.addEmployeeFormAddyLabel)
        Me.Controls.Add(Me.addEmployeeFormFirstNameLabel)
        Me.Name = "AddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Employees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents DependentsTxt As TextBox
    Private WithEvents addEmployeeFormDepStatLabel As Label
    Private WithEvents addEmployeeFormMstatLabel As Label
    Private WithEvents addEmployeeFormPaymentTypeLabel As Label
    Private WithEvents PayTypeCBox As ComboBox
    Private WithEvents AccessCTRL As CheckedListBox
    Private WithEvents addEmployeeFormPermissionsLabel As Label
    Private WithEvents AddEmpBtn As Button
    Private WithEvents PositionTxt As TextBox
    Private WithEvents addEmployeeFormPositionLable As Label
    Private WithEvents BackBtn As Button
    Private WithEvents NextBtn As Button
    Private WithEvents LnameTxt As TextBox
    Private WithEvents addEmployeeFormLastNameLabel As Label
    Private WithEvents ZipTxt As TextBox
    Private WithEvents addEmployeeFormZipLabel As Label
    Private WithEvents StateTxt As TextBox
    Private WithEvents addEmployeeFormStateLabel As Label
    Private WithEvents StreetTxt As TextBox
    Private WithEvents FnameTxt As TextBox
    Private WithEvents addEmployeeFormAddyLabel As Label
    Private WithEvents addEmployeeFormFirstNameLabel As Label
    Private WithEvents MaritalStatCB As ComboBox
    Private WithEvents SSN_Label As Label
    Private WithEvents SSN_Txt As MaskedTextBox
End Class
