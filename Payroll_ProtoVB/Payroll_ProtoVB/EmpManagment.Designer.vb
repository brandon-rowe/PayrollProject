<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmpManagment
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
        Me.components = New System.ComponentModel.Container()
        Me.employeeMGMTPayableHrsLabel = New System.Windows.Forms.Label()
        Me.PayHrsTxt = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Primary = New Payroll_ProtoVB.Primary()
        Me.employeeMGMTFormRmvEmployeeButton = New System.Windows.Forms.Button()
        Me.employeeMGMTFormEditButton = New System.Windows.Forms.Button()
        Me.PayRateTxt = New System.Windows.Forms.TextBox()
        Me.employeeMGMTFormWageRateLabel = New System.Windows.Forms.Label()
        Me.DependentsTxt = New System.Windows.Forms.TextBox()
        Me.employeeMGMTDependLabel = New System.Windows.Forms.Label()
        Me.MaritalStatusTxt = New System.Windows.Forms.TextBox()
        Me.employeeMGMTFormMarriedStatLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormPaymentTypeLabel = New System.Windows.Forms.Label()
        Me.paymentTypeCBox = New System.Windows.Forms.ComboBox()
        Me.PositionTxt = New System.Windows.Forms.TextBox()
        Me.employeeMGMTFormPositionLable = New System.Windows.Forms.Label()
        Me.SSN_Label = New System.Windows.Forms.Label()
        Me.LnameTxt = New System.Windows.Forms.TextBox()
        Me.LnameLabel = New System.Windows.Forms.Label()
        Me.StreetTxt = New System.Windows.Forms.TextBox()
        Me.FnameTxt = New System.Windows.Forms.TextBox()
        Me.employeeMGMTFormAddyLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormFirstNameLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormAddButton = New System.Windows.Forms.Button()
        Me.addEmployeLinkLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormSearch = New System.Windows.Forms.Button()
        Me.employeeMgmtFormSearchTxtBox = New System.Windows.Forms.TextBox()
        Me.employeeMgmtFormEmployeeSearch = New System.Windows.Forms.Label()
        Me.loginFormButton = New System.Windows.Forms.Button()
        Me.employeeMgmtFormUsrTxtBox = New System.Windows.Forms.TextBox()
        Me.loginformPassLabel = New System.Windows.Forms.Label()
        Me.loginFormUsrLabel = New System.Windows.Forms.Label()
        Me.employeeSearchLabel = New System.Windows.Forms.Label()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.loginPwTxt = New System.Windows.Forms.MaskedTextBox()
        Me.employeeMGMTFormCancelButton1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SSN_Txt = New System.Windows.Forms.MaskedTextBox()
        Me.EmpIDTxt = New System.Windows.Forms.TextBox()
        Me.EmpIDLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormCancelButton2 = New System.Windows.Forms.Button()
        Me.EmployeeTableAdapter = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeeTableAdapter()
        Me.FillBySelectedRowToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TableAdapterManager = New Payroll_ProtoVB.PrimaryTableAdapters.TableAdapterManager()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'employeeMGMTPayableHrsLabel
        '
        Me.employeeMGMTPayableHrsLabel.AutoSize = True
        Me.employeeMGMTPayableHrsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTPayableHrsLabel.Location = New System.Drawing.Point(398, 207)
        Me.employeeMGMTPayableHrsLabel.Name = "employeeMGMTPayableHrsLabel"
        Me.employeeMGMTPayableHrsLabel.Size = New System.Drawing.Size(125, 20)
        Me.employeeMGMTPayableHrsLabel.TabIndex = 79
        Me.employeeMGMTPayableHrsLabel.Text = "Payable Hours"
        '
        'PayHrsTxt
        '
        Me.PayHrsTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "hoursworked", True))
        Me.PayHrsTxt.Location = New System.Drawing.Point(525, 209)
        Me.PayHrsTxt.Name = "PayHrsTxt"
        Me.PayHrsTxt.Size = New System.Drawing.Size(121, 20)
        Me.PayHrsTxt.TabIndex = 12
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Primary
        '
        'Primary
        '
        Me.Primary.DataSetName = "Primary"
        Me.Primary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'employeeMGMTFormRmvEmployeeButton
        '
        Me.employeeMGMTFormRmvEmployeeButton.Location = New System.Drawing.Point(515, 335)
        Me.employeeMGMTFormRmvEmployeeButton.Name = "employeeMGMTFormRmvEmployeeButton"
        Me.employeeMGMTFormRmvEmployeeButton.Size = New System.Drawing.Size(118, 28)
        Me.employeeMGMTFormRmvEmployeeButton.TabIndex = 14
        Me.employeeMGMTFormRmvEmployeeButton.Text = "Remove Employee"
        Me.employeeMGMTFormRmvEmployeeButton.UseVisualStyleBackColor = True
        '
        'employeeMGMTFormEditButton
        '
        Me.employeeMGMTFormEditButton.Location = New System.Drawing.Point(539, 290)
        Me.employeeMGMTFormEditButton.Name = "employeeMGMTFormEditButton"
        Me.employeeMGMTFormEditButton.Size = New System.Drawing.Size(75, 23)
        Me.employeeMGMTFormEditButton.TabIndex = 13
        Me.employeeMGMTFormEditButton.Text = "Edit Fields"
        Me.employeeMGMTFormEditButton.UseVisualStyleBackColor = True
        '
        'PayRateTxt
        '
        Me.PayRateTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "hourlyrate", True))
        Me.PayRateTxt.Location = New System.Drawing.Point(145, 201)
        Me.PayRateTxt.Name = "PayRateTxt"
        Me.PayRateTxt.Size = New System.Drawing.Size(121, 20)
        Me.PayRateTxt.TabIndex = 7
        '
        'employeeMGMTFormWageRateLabel
        '
        Me.employeeMGMTFormWageRateLabel.AutoSize = True
        Me.employeeMGMTFormWageRateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormWageRateLabel.Location = New System.Drawing.Point(17, 201)
        Me.employeeMGMTFormWageRateLabel.Name = "employeeMGMTFormWageRateLabel"
        Me.employeeMGMTFormWageRateLabel.Size = New System.Drawing.Size(104, 20)
        Me.employeeMGMTFormWageRateLabel.TabIndex = 76
        Me.employeeMGMTFormWageRateLabel.Text = "Hourly Rate"
        '
        'DependentsTxt
        '
        Me.DependentsTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "dependents", True))
        Me.DependentsTxt.Location = New System.Drawing.Point(525, 68)
        Me.DependentsTxt.Name = "DependentsTxt"
        Me.DependentsTxt.Size = New System.Drawing.Size(121, 20)
        Me.DependentsTxt.TabIndex = 9
        '
        'employeeMGMTDependLabel
        '
        Me.employeeMGMTDependLabel.AutoSize = True
        Me.employeeMGMTDependLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTDependLabel.Location = New System.Drawing.Point(398, 68)
        Me.employeeMGMTDependLabel.Name = "employeeMGMTDependLabel"
        Me.employeeMGMTDependLabel.Size = New System.Drawing.Size(107, 20)
        Me.employeeMGMTDependLabel.TabIndex = 74
        Me.employeeMGMTDependLabel.Text = "Dependents"
        '
        'MaritalStatusTxt
        '
        Me.MaritalStatusTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "maritalstatus", True))
        Me.MaritalStatusTxt.Location = New System.Drawing.Point(525, 24)
        Me.MaritalStatusTxt.Name = "MaritalStatusTxt"
        Me.MaritalStatusTxt.Size = New System.Drawing.Size(121, 20)
        Me.MaritalStatusTxt.TabIndex = 8
        '
        'employeeMGMTFormMarriedStatLabel
        '
        Me.employeeMGMTFormMarriedStatLabel.AutoSize = True
        Me.employeeMGMTFormMarriedStatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormMarriedStatLabel.Location = New System.Drawing.Point(398, 24)
        Me.employeeMGMTFormMarriedStatLabel.Name = "employeeMGMTFormMarriedStatLabel"
        Me.employeeMGMTFormMarriedStatLabel.Size = New System.Drawing.Size(121, 20)
        Me.employeeMGMTFormMarriedStatLabel.TabIndex = 72
        Me.employeeMGMTFormMarriedStatLabel.Text = "Marital Status"
        '
        'employeeMGMTFormPaymentTypeLabel
        '
        Me.employeeMGMTFormPaymentTypeLabel.AutoSize = True
        Me.employeeMGMTFormPaymentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormPaymentTypeLabel.Location = New System.Drawing.Point(398, 161)
        Me.employeeMGMTFormPaymentTypeLabel.Name = "employeeMGMTFormPaymentTypeLabel"
        Me.employeeMGMTFormPaymentTypeLabel.Size = New System.Drawing.Size(121, 20)
        Me.employeeMGMTFormPaymentTypeLabel.TabIndex = 71
        Me.employeeMGMTFormPaymentTypeLabel.Text = "Payment Type"
        '
        'paymentTypeCBox
        '
        Me.paymentTypeCBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "salaried", True))
        Me.paymentTypeCBox.FormattingEnabled = True
        Me.paymentTypeCBox.Items.AddRange(New Object() {"Salary", "Hourly"})
        Me.paymentTypeCBox.Location = New System.Drawing.Point(525, 163)
        Me.paymentTypeCBox.Name = "paymentTypeCBox"
        Me.paymentTypeCBox.Size = New System.Drawing.Size(121, 21)
        Me.paymentTypeCBox.TabIndex = 11
        '
        'PositionTxt
        '
        Me.PositionTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "title", True))
        Me.PositionTxt.Location = New System.Drawing.Point(525, 110)
        Me.PositionTxt.Name = "PositionTxt"
        Me.PositionTxt.Size = New System.Drawing.Size(121, 20)
        Me.PositionTxt.TabIndex = 10
        '
        'employeeMGMTFormPositionLable
        '
        Me.employeeMGMTFormPositionLable.AutoSize = True
        Me.employeeMGMTFormPositionLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormPositionLable.Location = New System.Drawing.Point(398, 110)
        Me.employeeMGMTFormPositionLable.Name = "employeeMGMTFormPositionLable"
        Me.employeeMGMTFormPositionLable.Size = New System.Drawing.Size(73, 20)
        Me.employeeMGMTFormPositionLable.TabIndex = 68
        Me.employeeMGMTFormPositionLable.Text = "Position"
        '
        'SSN_Label
        '
        Me.SSN_Label.AutoSize = True
        Me.SSN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSN_Label.Location = New System.Drawing.Point(17, 167)
        Me.SSN_Label.Name = "SSN_Label"
        Me.SSN_Label.Size = New System.Drawing.Size(45, 20)
        Me.SSN_Label.TabIndex = 66
        Me.SSN_Label.Text = "SSN"
        '
        'LnameTxt
        '
        Me.LnameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "lname", True))
        Me.LnameTxt.Location = New System.Drawing.Point(145, 56)
        Me.LnameTxt.Name = "LnameTxt"
        Me.LnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.LnameTxt.TabIndex = 1
        '
        'LnameLabel
        '
        Me.LnameLabel.AutoSize = True
        Me.LnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameLabel.Location = New System.Drawing.Point(17, 56)
        Me.LnameLabel.Name = "LnameLabel"
        Me.LnameLabel.Size = New System.Drawing.Size(95, 20)
        Me.LnameLabel.TabIndex = 64
        Me.LnameLabel.Text = "Last Name"
        '
        'StreetTxt
        '
        Me.StreetTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "address", True))
        Me.StreetTxt.Location = New System.Drawing.Point(145, 135)
        Me.StreetTxt.Name = "StreetTxt"
        Me.StreetTxt.Size = New System.Drawing.Size(240, 20)
        Me.StreetTxt.TabIndex = 3
        '
        'FnameTxt
        '
        Me.FnameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "fname", True))
        Me.FnameTxt.Location = New System.Drawing.Point(145, 24)
        Me.FnameTxt.Name = "FnameTxt"
        Me.FnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.FnameTxt.TabIndex = 0
        '
        'employeeMGMTFormAddyLabel
        '
        Me.employeeMGMTFormAddyLabel.AutoSize = True
        Me.employeeMGMTFormAddyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormAddyLabel.Location = New System.Drawing.Point(17, 135)
        Me.employeeMGMTFormAddyLabel.Name = "employeeMGMTFormAddyLabel"
        Me.employeeMGMTFormAddyLabel.Size = New System.Drawing.Size(75, 20)
        Me.employeeMGMTFormAddyLabel.TabIndex = 57
        Me.employeeMGMTFormAddyLabel.Text = "Address"
        '
        'employeeMGMTFormFirstNameLabel
        '
        Me.employeeMGMTFormFirstNameLabel.AutoSize = True
        Me.employeeMGMTFormFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormFirstNameLabel.Location = New System.Drawing.Point(16, 24)
        Me.employeeMGMTFormFirstNameLabel.Name = "employeeMGMTFormFirstNameLabel"
        Me.employeeMGMTFormFirstNameLabel.Size = New System.Drawing.Size(96, 20)
        Me.employeeMGMTFormFirstNameLabel.TabIndex = 56
        Me.employeeMGMTFormFirstNameLabel.Text = "First Name"
        '
        'employeeMGMTFormAddButton
        '
        Me.employeeMGMTFormAddButton.Location = New System.Drawing.Point(263, 345)
        Me.employeeMGMTFormAddButton.Name = "employeeMGMTFormAddButton"
        Me.employeeMGMTFormAddButton.Size = New System.Drawing.Size(102, 23)
        Me.employeeMGMTFormAddButton.TabIndex = 5
        Me.employeeMGMTFormAddButton.Text = "Add Employee"
        Me.employeeMGMTFormAddButton.UseVisualStyleBackColor = True
        '
        'addEmployeLinkLabel
        '
        Me.addEmployeLinkLabel.AutoSize = True
        Me.addEmployeLinkLabel.Location = New System.Drawing.Point(13, 350)
        Me.addEmployeLinkLabel.Name = "addEmployeLinkLabel"
        Me.addEmployeLinkLabel.Size = New System.Drawing.Size(235, 13)
        Me.addEmployeLinkLabel.TabIndex = 14
        Me.addEmployeLinkLabel.Text = "If Employee Not Found, You may Add them Now"
        '
        'employeeMGMTFormSearch
        '
        Me.employeeMGMTFormSearch.Location = New System.Drawing.Point(279, 306)
        Me.employeeMGMTFormSearch.Name = "employeeMGMTFormSearch"
        Me.employeeMGMTFormSearch.Size = New System.Drawing.Size(75, 23)
        Me.employeeMGMTFormSearch.TabIndex = 4
        Me.employeeMGMTFormSearch.Text = "Search"
        Me.employeeMGMTFormSearch.UseVisualStyleBackColor = True
        '
        'employeeMgmtFormSearchTxtBox
        '
        Me.employeeMgmtFormSearchTxtBox.Location = New System.Drawing.Point(132, 309)
        Me.employeeMgmtFormSearchTxtBox.Name = "employeeMgmtFormSearchTxtBox"
        Me.employeeMgmtFormSearchTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.employeeMgmtFormSearchTxtBox.TabIndex = 3
        '
        'employeeMgmtFormEmployeeSearch
        '
        Me.employeeMgmtFormEmployeeSearch.AutoSize = True
        Me.employeeMgmtFormEmployeeSearch.Location = New System.Drawing.Point(12, 316)
        Me.employeeMgmtFormEmployeeSearch.Name = "employeeMgmtFormEmployeeSearch"
        Me.employeeMgmtFormEmployeeSearch.Size = New System.Drawing.Size(108, 13)
        Me.employeeMgmtFormEmployeeSearch.TabIndex = 0
        Me.employeeMgmtFormEmployeeSearch.Text = "Search For Employee"
        '
        'loginFormButton
        '
        Me.loginFormButton.Location = New System.Drawing.Point(177, 204)
        Me.loginFormButton.Name = "loginFormButton"
        Me.loginFormButton.Size = New System.Drawing.Size(75, 23)
        Me.loginFormButton.TabIndex = 2
        Me.loginFormButton.Text = "Continue"
        Me.loginFormButton.UseVisualStyleBackColor = True
        '
        'employeeMgmtFormUsrTxtBox
        '
        Me.employeeMgmtFormUsrTxtBox.Location = New System.Drawing.Point(132, 138)
        Me.employeeMgmtFormUsrTxtBox.Name = "employeeMgmtFormUsrTxtBox"
        Me.employeeMgmtFormUsrTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.employeeMgmtFormUsrTxtBox.TabIndex = 0
        '
        'loginformPassLabel
        '
        Me.loginformPassLabel.AutoSize = True
        Me.loginformPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginformPassLabel.Location = New System.Drawing.Point(12, 167)
        Me.loginformPassLabel.Name = "loginformPassLabel"
        Me.loginformPassLabel.Size = New System.Drawing.Size(86, 20)
        Me.loginformPassLabel.TabIndex = 8
        Me.loginformPassLabel.Text = "Password"
        '
        'loginFormUsrLabel
        '
        Me.loginFormUsrLabel.AutoSize = True
        Me.loginFormUsrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginFormUsrLabel.Location = New System.Drawing.Point(12, 138)
        Me.loginFormUsrLabel.Name = "loginFormUsrLabel"
        Me.loginFormUsrLabel.Size = New System.Drawing.Size(98, 20)
        Me.loginFormUsrLabel.TabIndex = 7
        Me.loginFormUsrLabel.Text = "User Name"
        '
        'employeeSearchLabel
        '
        Me.employeeSearchLabel.AutoSize = True
        Me.employeeSearchLabel.Location = New System.Drawing.Point(12, 9)
        Me.employeeSearchLabel.Name = "employeeSearchLabel"
        Me.employeeSearchLabel.Size = New System.Drawing.Size(260, 91)
        Me.employeeSearchLabel.TabIndex = 1
        Me.employeeSearchLabel.Text = "Welcome To the Employee Management Page" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Here Administrative Users May Search For" &
    " Employees" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add or Delete Employees" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Or Manage Employee Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please Veri" &
    "fy Your Credentials to Continue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.splitContainer1.Panel1.Controls.Add(Me.employeeMGMTFormCancelButton1)
        Me.splitContainer1.Panel1.Controls.Add(Me.employeeMGMTFormAddButton)
        Me.splitContainer1.Panel1.Controls.Add(Me.addEmployeLinkLabel)
        Me.splitContainer1.Panel1.Controls.Add(Me.employeeMGMTFormSearch)
        Me.splitContainer1.Panel1.Controls.Add(Me.employeeMgmtFormSearchTxtBox)
        Me.splitContainer1.Panel1.Controls.Add(Me.employeeMgmtFormEmployeeSearch)
        Me.splitContainer1.Panel1.Controls.Add(Me.loginFormButton)
        Me.splitContainer1.Panel1.Controls.Add(Me.employeeMgmtFormUsrTxtBox)
        Me.splitContainer1.Panel1.Controls.Add(Me.loginformPassLabel)
        Me.splitContainer1.Panel1.Controls.Add(Me.loginFormUsrLabel)
        Me.splitContainer1.Panel1.Controls.Add(Me.employeeSearchLabel)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.AutoScroll = True
        Me.splitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.splitContainer1.Panel2.Controls.Add(Me.SSN_Txt)
        Me.splitContainer1.Panel2.Controls.Add(Me.EmpIDTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.EmpIDLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTFormCancelButton2)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTPayableHrsLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.PayHrsTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTFormRmvEmployeeButton)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTFormEditButton)
        Me.splitContainer1.Panel2.Controls.Add(Me.PayRateTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTFormWageRateLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.DependentsTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTDependLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.MaritalStatusTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTFormMarriedStatLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTFormPaymentTypeLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.paymentTypeCBox)
        Me.splitContainer1.Panel2.Controls.Add(Me.PositionTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTFormPositionLable)
        Me.splitContainer1.Panel2.Controls.Add(Me.SSN_Label)
        Me.splitContainer1.Panel2.Controls.Add(Me.LnameTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.LnameLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.StreetTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.FnameTxt)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTFormAddyLabel)
        Me.splitContainer1.Panel2.Controls.Add(Me.employeeMGMTFormFirstNameLabel)
        Me.splitContainer1.Size = New System.Drawing.Size(1028, 495)
        Me.splitContainer1.SplitterDistance = 377
        Me.splitContainer1.TabIndex = 1
        '
        'loginPwTxt
        '
        Me.loginPwTxt.Location = New System.Drawing.Point(132, 166)
        Me.loginPwTxt.Name = "loginPwTxt"
        Me.loginPwTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.loginPwTxt.Size = New System.Drawing.Size(121, 20)
        Me.loginPwTxt.TabIndex = 1
        Me.loginPwTxt.UseSystemPasswordChar = True
        '
        'employeeMGMTFormCancelButton1
        '
        Me.employeeMGMTFormCancelButton1.Location = New System.Drawing.Point(86, 204)
        Me.employeeMGMTFormCancelButton1.Name = "employeeMGMTFormCancelButton1"
        Me.employeeMGMTFormCancelButton1.Size = New System.Drawing.Size(75, 23)
        Me.employeeMGMTFormCancelButton1.TabIndex = 6
        Me.employeeMGMTFormCancelButton1.Text = "Cancel"
        Me.employeeMGMTFormCancelButton1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "hourlyrate", True))
        Me.TextBox1.Location = New System.Drawing.Point(145, 231)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Salary"
        '
        'SSN_Txt
        '
        Me.SSN_Txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ssn", True))
        Me.SSN_Txt.Location = New System.Drawing.Point(145, 169)
        Me.SSN_Txt.Mask = "000-00-0000"
        Me.SSN_Txt.Name = "SSN_Txt"
        Me.SSN_Txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SSN_Txt.Size = New System.Drawing.Size(121, 20)
        Me.SSN_Txt.TabIndex = 6
        Me.SSN_Txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.SSN_Txt.UseSystemPasswordChar = True
        '
        'EmpIDTxt
        '
        Me.EmpIDTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.EmpIDTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ID", True))
        Me.EmpIDTxt.Location = New System.Drawing.Point(144, 92)
        Me.EmpIDTxt.Name = "EmpIDTxt"
        Me.EmpIDTxt.Size = New System.Drawing.Size(121, 20)
        Me.EmpIDTxt.TabIndex = 2
        '
        'EmpIDLabel
        '
        Me.EmpIDLabel.AutoSize = True
        Me.EmpIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpIDLabel.Location = New System.Drawing.Point(16, 92)
        Me.EmpIDLabel.Name = "EmpIDLabel"
        Me.EmpIDLabel.Size = New System.Drawing.Size(111, 20)
        Me.EmpIDLabel.TabIndex = 81
        Me.EmpIDLabel.Text = "Employee ID"
        '
        'employeeMGMTFormCancelButton2
        '
        Me.employeeMGMTFormCancelButton2.Location = New System.Drawing.Point(539, 379)
        Me.employeeMGMTFormCancelButton2.Name = "employeeMGMTFormCancelButton2"
        Me.employeeMGMTFormCancelButton2.Size = New System.Drawing.Size(75, 23)
        Me.employeeMGMTFormCancelButton2.TabIndex = 15
        Me.employeeMGMTFormCancelButton2.Text = "Cancel"
        Me.employeeMGMTFormCancelButton2.UseVisualStyleBackColor = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'FillBySelectedRowToolStrip
        '
        Me.FillBySelectedRowToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBySelectedRowToolStrip.Name = "FillBySelectedRowToolStrip"
        Me.FillBySelectedRowToolStrip.Size = New System.Drawing.Size(1028, 25)
        Me.FillBySelectedRowToolStrip.TabIndex = 2
        Me.FillBySelectedRowToolStrip.Text = "FillBySelectedRowToolStrip"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EmployeeFutureTableAdapter = Nothing
        Me.TableAdapterManager.EmployeePastTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Payroll_ProtoVB.PrimaryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.FillBySelectedRowToolStrip)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "EmpManagment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmpManagementForm"
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.PerformLayout()
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents employeeMGMTPayableHrsLabel As Label
    Private WithEvents PayHrsTxt As TextBox
    Private WithEvents employeeMGMTFormRmvEmployeeButton As Button
    Private WithEvents employeeMGMTFormEditButton As Button
    Private WithEvents PayRateTxt As TextBox
    Private WithEvents employeeMGMTFormWageRateLabel As Label
    Private WithEvents DependentsTxt As TextBox
    Private WithEvents employeeMGMTDependLabel As Label
    Private WithEvents MaritalStatusTxt As TextBox
    Private WithEvents employeeMGMTFormMarriedStatLabel As Label
    Private WithEvents employeeMGMTFormPaymentTypeLabel As Label
    Private WithEvents paymentTypeCBox As ComboBox
    Private WithEvents PositionTxt As TextBox
    Private WithEvents employeeMGMTFormPositionLable As Label
    Private WithEvents SSN_Label As Label
    Private WithEvents LnameTxt As TextBox
    Private WithEvents LnameLabel As Label
    Private WithEvents StreetTxt As TextBox
    Private WithEvents FnameTxt As TextBox
    Private WithEvents employeeMGMTFormAddyLabel As Label
    Private WithEvents employeeMGMTFormFirstNameLabel As Label
    Private WithEvents employeeMGMTFormAddButton As Button
    Private WithEvents addEmployeLinkLabel As Label
    Private WithEvents employeeMGMTFormSearch As Button
    Private WithEvents employeeMgmtFormSearchTxtBox As TextBox
    Private WithEvents employeeMgmtFormEmployeeSearch As Label
    Private WithEvents loginFormButton As Button
    Private WithEvents employeeMgmtFormUsrTxtBox As TextBox
    Private WithEvents loginformPassLabel As Label
    Private WithEvents loginFormUsrLabel As Label
    Private WithEvents employeeSearchLabel As Label
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents employeeMGMTFormCancelButton2 As Button
    Private WithEvents employeeMGMTFormCancelButton1 As Button
    Private WithEvents EmpIDTxt As TextBox
    Private WithEvents EmpIDLabel As Label
    Private WithEvents loginPwTxt As MaskedTextBox
    Private WithEvents SSN_Txt As MaskedTextBox
    Friend WithEvents Primary As Primary
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As PrimaryTableAdapters.EmployeeTableAdapter
    Friend WithEvents FillBySelectedRowToolStrip As ToolStrip
    Friend WithEvents TableAdapterManager As PrimaryTableAdapters.TableAdapterManager
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label1 As Label
End Class
