<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Me.DependentsTxt = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormDepStatLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormMstatLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormPaymentTypeLabel = New System.Windows.Forms.Label()
        Me.PayTypeTxt = New System.Windows.Forms.ComboBox()
        Me.addEmployeeFormPermissionsCheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.addEmployeeFormPermissionsLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormAddUsrDescLabel3 = New System.Windows.Forms.Label()
        Me.addEmployeeFormAddUsrDescLabel2 = New System.Windows.Forms.Label()
        Me.addEmployeeFormAddUsrDescLabel1 = New System.Windows.Forms.Label()
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
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.FnameTxt = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormAddyLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormFirstNameLabel = New System.Windows.Forms.Label()
        Me.AddEmployeeFormLabel = New System.Windows.Forms.Label()
        Me.MaritalStatCB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DependentsTxt
        '
        Me.DependentsTxt.Location = New System.Drawing.Point(658, 146)
        Me.DependentsTxt.Name = "DependentsTxt"
        Me.DependentsTxt.Size = New System.Drawing.Size(121, 20)
        Me.DependentsTxt.TabIndex = 7
        '
        'addEmployeeFormDepStatLabel
        '
        Me.addEmployeeFormDepStatLabel.AutoSize = True
        Me.addEmployeeFormDepStatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormDepStatLabel.Location = New System.Drawing.Point(499, 144)
        Me.addEmployeeFormDepStatLabel.Name = "addEmployeeFormDepStatLabel"
        Me.addEmployeeFormDepStatLabel.Size = New System.Drawing.Size(107, 20)
        Me.addEmployeeFormDepStatLabel.TabIndex = 83
        Me.addEmployeeFormDepStatLabel.Text = "Dependents"
        '
        'addEmployeeFormMstatLabel
        '
        Me.addEmployeeFormMstatLabel.AutoSize = True
        Me.addEmployeeFormMstatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormMstatLabel.Location = New System.Drawing.Point(499, 108)
        Me.addEmployeeFormMstatLabel.Name = "addEmployeeFormMstatLabel"
        Me.addEmployeeFormMstatLabel.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormMstatLabel.TabIndex = 81
        Me.addEmployeeFormMstatLabel.Text = "Marital Status"
        '
        'addEmployeeFormPaymentTypeLabel
        '
        Me.addEmployeeFormPaymentTypeLabel.AutoSize = True
        Me.addEmployeeFormPaymentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormPaymentTypeLabel.Location = New System.Drawing.Point(499, 230)
        Me.addEmployeeFormPaymentTypeLabel.Name = "addEmployeeFormPaymentTypeLabel"
        Me.addEmployeeFormPaymentTypeLabel.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormPaymentTypeLabel.TabIndex = 80
        Me.addEmployeeFormPaymentTypeLabel.Text = "Payment Type"
        '
        'PayTypeTxt
        '
        Me.PayTypeTxt.FormattingEnabled = True
        Me.PayTypeTxt.Items.AddRange(New Object() {"Salary", "Hourly"})
        Me.PayTypeTxt.Location = New System.Drawing.Point(658, 229)
        Me.PayTypeTxt.Name = "PayTypeTxt"
        Me.PayTypeTxt.Size = New System.Drawing.Size(121, 21)
        Me.PayTypeTxt.TabIndex = 9
        '
        'addEmployeeFormPermissionsCheckedListBox1
        '
        Me.addEmployeeFormPermissionsCheckedListBox1.FormattingEnabled = True
        Me.addEmployeeFormPermissionsCheckedListBox1.Items.AddRange(New Object() {"FullAccess(Can View and Edit Employe Records, Wages, Edit Payroll Rollout)", "PartialAccess(Can View Employee information and Metrics)"})
        Me.addEmployeeFormPermissionsCheckedListBox1.Location = New System.Drawing.Point(622, 270)
        Me.addEmployeeFormPermissionsCheckedListBox1.Name = "addEmployeeFormPermissionsCheckedListBox1"
        Me.addEmployeeFormPermissionsCheckedListBox1.Size = New System.Drawing.Size(386, 34)
        Me.addEmployeeFormPermissionsCheckedListBox1.TabIndex = 10
        '
        'addEmployeeFormPermissionsLabel
        '
        Me.addEmployeeFormPermissionsLabel.AutoSize = True
        Me.addEmployeeFormPermissionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormPermissionsLabel.Location = New System.Drawing.Point(499, 270)
        Me.addEmployeeFormPermissionsLabel.Name = "addEmployeeFormPermissionsLabel"
        Me.addEmployeeFormPermissionsLabel.Size = New System.Drawing.Size(105, 20)
        Me.addEmployeeFormPermissionsLabel.TabIndex = 77
        Me.addEmployeeFormPermissionsLabel.Text = "Permissions"
        '
        'addEmployeeFormAddUsrDescLabel3
        '
        Me.addEmployeeFormAddUsrDescLabel3.AutoSize = True
        Me.addEmployeeFormAddUsrDescLabel3.Location = New System.Drawing.Point(769, 384)
        Me.addEmployeeFormAddUsrDescLabel3.Name = "addEmployeeFormAddUsrDescLabel3"
        Me.addEmployeeFormAddUsrDescLabel3.Size = New System.Drawing.Size(221, 13)
        Me.addEmployeeFormAddUsrDescLabel3.TabIndex = 76
        Me.addEmployeeFormAddUsrDescLabel3.Text = "Must have at least one Employee to Continue"
        '
        'addEmployeeFormAddUsrDescLabel2
        '
        Me.addEmployeeFormAddUsrDescLabel2.AutoSize = True
        Me.addEmployeeFormAddUsrDescLabel2.Location = New System.Drawing.Point(769, 371)
        Me.addEmployeeFormAddUsrDescLabel2.Name = "addEmployeeFormAddUsrDescLabel2"
        Me.addEmployeeFormAddUsrDescLabel2.Size = New System.Drawing.Size(227, 13)
        Me.addEmployeeFormAddUsrDescLabel2.TabIndex = 75
        Me.addEmployeeFormAddUsrDescLabel2.Text = "You may Also Add Employees Later as needed"
        '
        'addEmployeeFormAddUsrDescLabel1
        '
        Me.addEmployeeFormAddUsrDescLabel1.AutoSize = True
        Me.addEmployeeFormAddUsrDescLabel1.Location = New System.Drawing.Point(769, 358)
        Me.addEmployeeFormAddUsrDescLabel1.Name = "addEmployeeFormAddUsrDescLabel1"
        Me.addEmployeeFormAddUsrDescLabel1.Size = New System.Drawing.Size(239, 13)
        Me.addEmployeeFormAddUsrDescLabel1.TabIndex = 74
        Me.addEmployeeFormAddUsrDescLabel1.Text = "Add Employee, hit next to continue when finished"
        '
        'AddEmpBtn
        '
        Me.AddEmpBtn.Location = New System.Drawing.Point(772, 332)
        Me.AddEmpBtn.Name = "AddEmpBtn"
        Me.AddEmpBtn.Size = New System.Drawing.Size(102, 23)
        Me.AddEmpBtn.TabIndex = 11
        Me.AddEmpBtn.Text = "Add Employee"
        Me.AddEmpBtn.UseVisualStyleBackColor = True
        '
        'PositionTxt
        '
        Me.PositionTxt.Location = New System.Drawing.Point(658, 185)
        Me.PositionTxt.Name = "PositionTxt"
        Me.PositionTxt.Size = New System.Drawing.Size(121, 20)
        Me.PositionTxt.TabIndex = 8
        '
        'addEmployeeFormPositionLable
        '
        Me.addEmployeeFormPositionLable.AutoSize = True
        Me.addEmployeeFormPositionLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormPositionLable.Location = New System.Drawing.Point(499, 183)
        Me.addEmployeeFormPositionLable.Name = "addEmployeeFormPositionLable"
        Me.addEmployeeFormPositionLable.Size = New System.Drawing.Size(73, 20)
        Me.addEmployeeFormPositionLable.TabIndex = 71
        Me.addEmployeeFormPositionLable.Text = "Position"
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(704, 430)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(75, 23)
        Me.BackBtn.TabIndex = 70
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'NextBtn
        '
        Me.NextBtn.Location = New System.Drawing.Point(812, 430)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(75, 23)
        Me.NextBtn.TabIndex = 69
        Me.NextBtn.Text = "Next"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'LnameTxt
        '
        Me.LnameTxt.Location = New System.Drawing.Point(232, 146)
        Me.LnameTxt.Name = "LnameTxt"
        Me.LnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.LnameTxt.TabIndex = 1
        '
        'addEmployeeFormLastNameLabel
        '
        Me.addEmployeeFormLastNameLabel.AutoSize = True
        Me.addEmployeeFormLastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormLastNameLabel.Location = New System.Drawing.Point(71, 146)
        Me.addEmployeeFormLastNameLabel.Name = "addEmployeeFormLastNameLabel"
        Me.addEmployeeFormLastNameLabel.Size = New System.Drawing.Size(95, 20)
        Me.addEmployeeFormLastNameLabel.TabIndex = 65
        Me.addEmployeeFormLastNameLabel.Text = "Last Name"
        '
        'ZipTxt
        '
        Me.ZipTxt.Location = New System.Drawing.Point(232, 249)
        Me.ZipTxt.Name = "ZipTxt"
        Me.ZipTxt.Size = New System.Drawing.Size(121, 20)
        Me.ZipTxt.TabIndex = 4
        '
        'addEmployeeFormZipLabel
        '
        Me.addEmployeeFormZipLabel.AutoSize = True
        Me.addEmployeeFormZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormZipLabel.Location = New System.Drawing.Point(73, 247)
        Me.addEmployeeFormZipLabel.Name = "addEmployeeFormZipLabel"
        Me.addEmployeeFormZipLabel.Size = New System.Drawing.Size(34, 20)
        Me.addEmployeeFormZipLabel.TabIndex = 63
        Me.addEmployeeFormZipLabel.Text = "Zip"
        '
        'StateTxt
        '
        Me.StateTxt.Location = New System.Drawing.Point(232, 217)
        Me.StateTxt.Name = "StateTxt"
        Me.StateTxt.Size = New System.Drawing.Size(148, 20)
        Me.StateTxt.TabIndex = 3
        '
        'addEmployeeFormStateLabel
        '
        Me.addEmployeeFormStateLabel.AutoSize = True
        Me.addEmployeeFormStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormStateLabel.Location = New System.Drawing.Point(71, 215)
        Me.addEmployeeFormStateLabel.Name = "addEmployeeFormStateLabel"
        Me.addEmployeeFormStateLabel.Size = New System.Drawing.Size(53, 20)
        Me.addEmployeeFormStateLabel.TabIndex = 61
        Me.addEmployeeFormStateLabel.Text = "State"
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(232, 183)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(240, 20)
        Me.AddressTxt.TabIndex = 2
        '
        'FnameTxt
        '
        Me.FnameTxt.Location = New System.Drawing.Point(232, 110)
        Me.FnameTxt.Name = "FnameTxt"
        Me.FnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.FnameTxt.TabIndex = 0
        '
        'addEmployeeFormAddyLabel
        '
        Me.addEmployeeFormAddyLabel.AutoSize = True
        Me.addEmployeeFormAddyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormAddyLabel.Location = New System.Drawing.Point(71, 183)
        Me.addEmployeeFormAddyLabel.Name = "addEmployeeFormAddyLabel"
        Me.addEmployeeFormAddyLabel.Size = New System.Drawing.Size(75, 20)
        Me.addEmployeeFormAddyLabel.TabIndex = 58
        Me.addEmployeeFormAddyLabel.Text = "Address"
        '
        'addEmployeeFormFirstNameLabel
        '
        Me.addEmployeeFormFirstNameLabel.AutoSize = True
        Me.addEmployeeFormFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormFirstNameLabel.Location = New System.Drawing.Point(71, 110)
        Me.addEmployeeFormFirstNameLabel.Name = "addEmployeeFormFirstNameLabel"
        Me.addEmployeeFormFirstNameLabel.Size = New System.Drawing.Size(96, 20)
        Me.addEmployeeFormFirstNameLabel.TabIndex = 57
        Me.addEmployeeFormFirstNameLabel.Text = "First Name"
        '
        'AddEmployeeFormLabel
        '
        Me.AddEmployeeFormLabel.AutoSize = True
        Me.AddEmployeeFormLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEmployeeFormLabel.Location = New System.Drawing.Point(70, 42)
        Me.AddEmployeeFormLabel.Name = "AddEmployeeFormLabel"
        Me.AddEmployeeFormLabel.Size = New System.Drawing.Size(215, 25)
        Me.AddEmployeeFormLabel.TabIndex = 56
        Me.AddEmployeeFormLabel.Text = "Add New Employee"
        '
        'MaritalStatCB
        '
        Me.MaritalStatCB.FormattingEnabled = True
        Me.MaritalStatCB.Items.AddRange(New Object() {"Single", "Married"})
        Me.MaritalStatCB.Location = New System.Drawing.Point(658, 107)
        Me.MaritalStatCB.Name = "MaritalStatCB"
        Me.MaritalStatCB.Size = New System.Drawing.Size(121, 21)
        Me.MaritalStatCB.TabIndex = 84
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.MaritalStatCB)
        Me.Controls.Add(Me.DependentsTxt)
        Me.Controls.Add(Me.addEmployeeFormDepStatLabel)
        Me.Controls.Add(Me.addEmployeeFormMstatLabel)
        Me.Controls.Add(Me.addEmployeeFormPaymentTypeLabel)
        Me.Controls.Add(Me.PayTypeTxt)
        Me.Controls.Add(Me.addEmployeeFormPermissionsCheckedListBox1)
        Me.Controls.Add(Me.addEmployeeFormPermissionsLabel)
        Me.Controls.Add(Me.addEmployeeFormAddUsrDescLabel3)
        Me.Controls.Add(Me.addEmployeeFormAddUsrDescLabel2)
        Me.Controls.Add(Me.addEmployeeFormAddUsrDescLabel1)
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
        Me.Controls.Add(Me.AddressTxt)
        Me.Controls.Add(Me.FnameTxt)
        Me.Controls.Add(Me.addEmployeeFormAddyLabel)
        Me.Controls.Add(Me.addEmployeeFormFirstNameLabel)
        Me.Controls.Add(Me.AddEmployeeFormLabel)
        Me.Name = "AddEmployee"
        Me.Text = "AddEmployeeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents DependentsTxt As TextBox
    Private WithEvents addEmployeeFormDepStatLabel As Label
    Private WithEvents addEmployeeFormMstatLabel As Label
    Private WithEvents addEmployeeFormPaymentTypeLabel As Label
    Private WithEvents PayTypeTxt As ComboBox
    Private WithEvents addEmployeeFormPermissionsCheckedListBox1 As CheckedListBox
    Private WithEvents addEmployeeFormPermissionsLabel As Label
    Private WithEvents addEmployeeFormAddUsrDescLabel3 As Label
    Private WithEvents addEmployeeFormAddUsrDescLabel2 As Label
    Private WithEvents addEmployeeFormAddUsrDescLabel1 As Label
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
    Private WithEvents AddressTxt As TextBox
    Private WithEvents FnameTxt As TextBox
    Private WithEvents addEmployeeFormAddyLabel As Label
    Private WithEvents addEmployeeFormFirstNameLabel As Label
    Private WithEvents AddEmployeeFormLabel As Label
    Private WithEvents MaritalStatCB As ComboBox
End Class
