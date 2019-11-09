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
        Me.addEmployeeFormDepStatTxtBox = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormDepStatLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormMaritalStatTxtBox = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormMstatLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormPaymentTypeLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormpaymentTypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.addEmployeeFormPermissionsCheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.addEmployeeFormPermissionsLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormAddUsrDescLabel3 = New System.Windows.Forms.Label()
        Me.addEmployeeFormAddUsrDescLabel2 = New System.Windows.Forms.Label()
        Me.addEmployeeFormAddUsrDescLabel1 = New System.Windows.Forms.Label()
        Me.addEmployeeFormAddButton = New System.Windows.Forms.Button()
        Me.addEmployeePositionTxtBox = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormPositionLable = New System.Windows.Forms.Label()
        Me.addEmployeeFormBackButton = New System.Windows.Forms.Button()
        Me.addEmployeeFormNextButton = New System.Windows.Forms.Button()
        Me.addEmployeeFormPhoneTxtBox = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormPhoneLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormLastNameTxtBox = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormLastNameLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormZipTxtBox = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormZipLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormStateTxtBox = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormStateLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormAddyTxtBox = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormFirstNameTxtBox = New System.Windows.Forms.TextBox()
        Me.addEmployeeFormAddyLabel = New System.Windows.Forms.Label()
        Me.addEmployeeFormFirstNameLabel = New System.Windows.Forms.Label()
        Me.AddEmployeeFormLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'addEmployeeFormDepStatTxtBox
        '
        Me.addEmployeeFormDepStatTxtBox.Location = New System.Drawing.Point(658, 146)
        Me.addEmployeeFormDepStatTxtBox.Name = "addEmployeeFormDepStatTxtBox"
        Me.addEmployeeFormDepStatTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormDepStatTxtBox.TabIndex = 84
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
        'addEmployeeFormMaritalStatTxtBox
        '
        Me.addEmployeeFormMaritalStatTxtBox.Location = New System.Drawing.Point(658, 110)
        Me.addEmployeeFormMaritalStatTxtBox.Name = "addEmployeeFormMaritalStatTxtBox"
        Me.addEmployeeFormMaritalStatTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormMaritalStatTxtBox.TabIndex = 82
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
        'addEmployeeFormpaymentTypeComboBox1
        '
        Me.addEmployeeFormpaymentTypeComboBox1.FormattingEnabled = True
        Me.addEmployeeFormpaymentTypeComboBox1.Items.AddRange(New Object() {"Salary", "Hourly"})
        Me.addEmployeeFormpaymentTypeComboBox1.Location = New System.Drawing.Point(658, 229)
        Me.addEmployeeFormpaymentTypeComboBox1.Name = "addEmployeeFormpaymentTypeComboBox1"
        Me.addEmployeeFormpaymentTypeComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.addEmployeeFormpaymentTypeComboBox1.TabIndex = 79
        '
        'addEmployeeFormPermissionsCheckedListBox1
        '
        Me.addEmployeeFormPermissionsCheckedListBox1.FormattingEnabled = True
        Me.addEmployeeFormPermissionsCheckedListBox1.Items.AddRange(New Object() {"FullAccess(Can View and Edit Employe Records, Wages, Edit Payroll Rollout)", "PartialAccess(Can View Employee information and Metrics)"})
        Me.addEmployeeFormPermissionsCheckedListBox1.Location = New System.Drawing.Point(622, 270)
        Me.addEmployeeFormPermissionsCheckedListBox1.Name = "addEmployeeFormPermissionsCheckedListBox1"
        Me.addEmployeeFormPermissionsCheckedListBox1.Size = New System.Drawing.Size(386, 34)
        Me.addEmployeeFormPermissionsCheckedListBox1.TabIndex = 78
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
        'addEmployeeFormAddButton
        '
        Me.addEmployeeFormAddButton.Location = New System.Drawing.Point(772, 332)
        Me.addEmployeeFormAddButton.Name = "addEmployeeFormAddButton"
        Me.addEmployeeFormAddButton.Size = New System.Drawing.Size(102, 23)
        Me.addEmployeeFormAddButton.TabIndex = 73
        Me.addEmployeeFormAddButton.Text = "Add Employee"
        Me.addEmployeeFormAddButton.UseVisualStyleBackColor = True
        '
        'addEmployeePositionTxtBox
        '
        Me.addEmployeePositionTxtBox.Location = New System.Drawing.Point(658, 185)
        Me.addEmployeePositionTxtBox.Name = "addEmployeePositionTxtBox"
        Me.addEmployeePositionTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeePositionTxtBox.TabIndex = 72
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
        'addEmployeeFormBackButton
        '
        Me.addEmployeeFormBackButton.Location = New System.Drawing.Point(704, 430)
        Me.addEmployeeFormBackButton.Name = "addEmployeeFormBackButton"
        Me.addEmployeeFormBackButton.Size = New System.Drawing.Size(75, 23)
        Me.addEmployeeFormBackButton.TabIndex = 70
        Me.addEmployeeFormBackButton.Text = "Back"
        Me.addEmployeeFormBackButton.UseVisualStyleBackColor = True
        '
        'addEmployeeFormNextButton
        '
        Me.addEmployeeFormNextButton.Location = New System.Drawing.Point(812, 430)
        Me.addEmployeeFormNextButton.Name = "addEmployeeFormNextButton"
        Me.addEmployeeFormNextButton.Size = New System.Drawing.Size(75, 23)
        Me.addEmployeeFormNextButton.TabIndex = 69
        Me.addEmployeeFormNextButton.Text = "Next"
        Me.addEmployeeFormNextButton.UseVisualStyleBackColor = True
        '
        'addEmployeeFormPhoneTxtBox
        '
        Me.addEmployeeFormPhoneTxtBox.Location = New System.Drawing.Point(232, 284)
        Me.addEmployeeFormPhoneTxtBox.Name = "addEmployeeFormPhoneTxtBox"
        Me.addEmployeeFormPhoneTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormPhoneTxtBox.TabIndex = 68
        '
        'addEmployeeFormPhoneLabel
        '
        Me.addEmployeeFormPhoneLabel.AutoSize = True
        Me.addEmployeeFormPhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeFormPhoneLabel.Location = New System.Drawing.Point(73, 282)
        Me.addEmployeeFormPhoneLabel.Name = "addEmployeeFormPhoneLabel"
        Me.addEmployeeFormPhoneLabel.Size = New System.Drawing.Size(60, 20)
        Me.addEmployeeFormPhoneLabel.TabIndex = 67
        Me.addEmployeeFormPhoneLabel.Text = "Phone"
        '
        'addEmployeeFormLastNameTxtBox
        '
        Me.addEmployeeFormLastNameTxtBox.Location = New System.Drawing.Point(232, 146)
        Me.addEmployeeFormLastNameTxtBox.Name = "addEmployeeFormLastNameTxtBox"
        Me.addEmployeeFormLastNameTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormLastNameTxtBox.TabIndex = 66
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
        'addEmployeeFormZipTxtBox
        '
        Me.addEmployeeFormZipTxtBox.Location = New System.Drawing.Point(232, 249)
        Me.addEmployeeFormZipTxtBox.Name = "addEmployeeFormZipTxtBox"
        Me.addEmployeeFormZipTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormZipTxtBox.TabIndex = 64
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
        'addEmployeeFormStateTxtBox
        '
        Me.addEmployeeFormStateTxtBox.Location = New System.Drawing.Point(232, 217)
        Me.addEmployeeFormStateTxtBox.Name = "addEmployeeFormStateTxtBox"
        Me.addEmployeeFormStateTxtBox.Size = New System.Drawing.Size(148, 20)
        Me.addEmployeeFormStateTxtBox.TabIndex = 62
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
        'addEmployeeFormAddyTxtBox
        '
        Me.addEmployeeFormAddyTxtBox.Location = New System.Drawing.Point(232, 183)
        Me.addEmployeeFormAddyTxtBox.Name = "addEmployeeFormAddyTxtBox"
        Me.addEmployeeFormAddyTxtBox.Size = New System.Drawing.Size(240, 20)
        Me.addEmployeeFormAddyTxtBox.TabIndex = 60
        '
        'addEmployeeFormFirstNameTxtBox
        '
        Me.addEmployeeFormFirstNameTxtBox.Location = New System.Drawing.Point(232, 110)
        Me.addEmployeeFormFirstNameTxtBox.Name = "addEmployeeFormFirstNameTxtBox"
        Me.addEmployeeFormFirstNameTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.addEmployeeFormFirstNameTxtBox.TabIndex = 59
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
        'AddEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.addEmployeeFormDepStatTxtBox)
        Me.Controls.Add(Me.addEmployeeFormDepStatLabel)
        Me.Controls.Add(Me.addEmployeeFormMaritalStatTxtBox)
        Me.Controls.Add(Me.addEmployeeFormMstatLabel)
        Me.Controls.Add(Me.addEmployeeFormPaymentTypeLabel)
        Me.Controls.Add(Me.addEmployeeFormpaymentTypeComboBox1)
        Me.Controls.Add(Me.addEmployeeFormPermissionsCheckedListBox1)
        Me.Controls.Add(Me.addEmployeeFormPermissionsLabel)
        Me.Controls.Add(Me.addEmployeeFormAddUsrDescLabel3)
        Me.Controls.Add(Me.addEmployeeFormAddUsrDescLabel2)
        Me.Controls.Add(Me.addEmployeeFormAddUsrDescLabel1)
        Me.Controls.Add(Me.addEmployeeFormAddButton)
        Me.Controls.Add(Me.addEmployeePositionTxtBox)
        Me.Controls.Add(Me.addEmployeeFormPositionLable)
        Me.Controls.Add(Me.addEmployeeFormBackButton)
        Me.Controls.Add(Me.addEmployeeFormNextButton)
        Me.Controls.Add(Me.addEmployeeFormPhoneTxtBox)
        Me.Controls.Add(Me.addEmployeeFormPhoneLabel)
        Me.Controls.Add(Me.addEmployeeFormLastNameTxtBox)
        Me.Controls.Add(Me.addEmployeeFormLastNameLabel)
        Me.Controls.Add(Me.addEmployeeFormZipTxtBox)
        Me.Controls.Add(Me.addEmployeeFormZipLabel)
        Me.Controls.Add(Me.addEmployeeFormStateTxtBox)
        Me.Controls.Add(Me.addEmployeeFormStateLabel)
        Me.Controls.Add(Me.addEmployeeFormAddyTxtBox)
        Me.Controls.Add(Me.addEmployeeFormFirstNameTxtBox)
        Me.Controls.Add(Me.addEmployeeFormAddyLabel)
        Me.Controls.Add(Me.addEmployeeFormFirstNameLabel)
        Me.Controls.Add(Me.AddEmployeeFormLabel)
        Me.Name = "AddEmployeeForm"
        Me.Text = "AddEmployeeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents addEmployeeFormDepStatTxtBox As TextBox
    Private WithEvents addEmployeeFormDepStatLabel As Label
    Private WithEvents addEmployeeFormMaritalStatTxtBox As TextBox
    Private WithEvents addEmployeeFormMstatLabel As Label
    Private WithEvents addEmployeeFormPaymentTypeLabel As Label
    Private WithEvents addEmployeeFormpaymentTypeComboBox1 As ComboBox
    Private WithEvents addEmployeeFormPermissionsCheckedListBox1 As CheckedListBox
    Private WithEvents addEmployeeFormPermissionsLabel As Label
    Private WithEvents addEmployeeFormAddUsrDescLabel3 As Label
    Private WithEvents addEmployeeFormAddUsrDescLabel2 As Label
    Private WithEvents addEmployeeFormAddUsrDescLabel1 As Label
    Private WithEvents addEmployeeFormAddButton As Button
    Private WithEvents addEmployeePositionTxtBox As TextBox
    Private WithEvents addEmployeeFormPositionLable As Label
    Private WithEvents addEmployeeFormBackButton As Button
    Private WithEvents addEmployeeFormNextButton As Button
    Private WithEvents addEmployeeFormPhoneTxtBox As TextBox
    Private WithEvents addEmployeeFormPhoneLabel As Label
    Private WithEvents addEmployeeFormLastNameTxtBox As TextBox
    Private WithEvents addEmployeeFormLastNameLabel As Label
    Private WithEvents addEmployeeFormZipTxtBox As TextBox
    Private WithEvents addEmployeeFormZipLabel As Label
    Private WithEvents addEmployeeFormStateTxtBox As TextBox
    Private WithEvents addEmployeeFormStateLabel As Label
    Private WithEvents addEmployeeFormAddyTxtBox As TextBox
    Private WithEvents addEmployeeFormFirstNameTxtBox As TextBox
    Private WithEvents addEmployeeFormAddyLabel As Label
    Private WithEvents addEmployeeFormFirstNameLabel As Label
    Private WithEvents AddEmployeeFormLabel As Label
End Class
