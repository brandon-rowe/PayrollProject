﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim PayfrequencyLabel As System.Windows.Forms.Label
        Me.employeeSearchLabel = New System.Windows.Forms.Label()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SearchAddGroupBox = New System.Windows.Forms.GroupBox()
        Me.AddEmpBtn = New System.Windows.Forms.Button()
        Me.addEmployeLinkLabel = New System.Windows.Forms.Label()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.SearchEmpTxt = New System.Windows.Forms.TextBox()
        Me.employeeMgmtFormEmployeeSearch = New System.Windows.Forms.Label()
        Me.LoginGroupBox = New System.Windows.Forms.GroupBox()
        Me.PwordTxt = New System.Windows.Forms.MaskedTextBox()
        Me.CancelLoginBtn = New System.Windows.Forms.Button()
        Me.ConLoginBtn = New System.Windows.Forms.Button()
        Me.UnameTxt = New System.Windows.Forms.TextBox()
        Me.loginformPassLabel = New System.Windows.Forms.Label()
        Me.loginFormUsrLabel = New System.Windows.Forms.Label()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.EmployeeInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.SalariedGroupBox = New System.Windows.Forms.GroupBox()
        Me.SalaryTxtBox = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Primary = New Payroll_ProtoVB.Primary()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HourlyGroupBox = New System.Windows.Forms.GroupBox()
        Me.employeeMGMTPayableHrsLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormWageRateLabel = New System.Windows.Forms.Label()
        Me.PayRateTxt = New System.Windows.Forms.TextBox()
        Me.PayHrsTxt = New System.Windows.Forms.TextBox()
        Me.PayfrequencyTextBox = New System.Windows.Forms.TextBox()
        Me.PayTypeTxtBox = New System.Windows.Forms.TextBox()
        Me.EmpIDTxt = New System.Windows.Forms.TextBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.SSN_Txt = New System.Windows.Forms.MaskedTextBox()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.removeEmpBtn = New System.Windows.Forms.Button()
        Me.editEmpBtn = New System.Windows.Forms.Button()
        Me.DependentsTxt = New System.Windows.Forms.TextBox()
        Me.employeeMGMTDependLabel = New System.Windows.Forms.Label()
        Me.MaritalStatusTxt = New System.Windows.Forms.TextBox()
        Me.employeeMGMTFormMarriedStatLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormPaymentTypeLabel = New System.Windows.Forms.Label()
        Me.PositionTxt = New System.Windows.Forms.TextBox()
        Me.employeeMGMTFormPositionLable = New System.Windows.Forms.Label()
        Me.SSN_Label = New System.Windows.Forms.Label()
        Me.LnameTxt = New System.Windows.Forms.TextBox()
        Me.LnameLabel = New System.Windows.Forms.Label()
        Me.StreetTxt = New System.Windows.Forms.TextBox()
        Me.FnameTxt = New System.Windows.Forms.TextBox()
        Me.employeeMGMTFormAddyLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormFirstNameLabel = New System.Windows.Forms.Label()
        Me.EmployeeTableAdapter = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New Payroll_ProtoVB.PrimaryTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        PayfrequencyLabel = New System.Windows.Forms.Label()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SearchAddGroupBox.SuspendLayout()
        Me.LoginGroupBox.SuspendLayout()
        Me.EmployeeInfoGroupBox.SuspendLayout()
        Me.SalariedGroupBox.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HourlyGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(7, 16)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(111, 20)
        IDLabel.TabIndex = 111
        IDLabel.Text = "Employee ID"
        '
        'PayfrequencyLabel
        '
        PayfrequencyLabel.AutoSize = True
        PayfrequencyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PayfrequencyLabel.Location = New System.Drawing.Point(6, 186)
        PayfrequencyLabel.Name = "PayfrequencyLabel"
        PayfrequencyLabel.Size = New System.Drawing.Size(127, 20)
        PayfrequencyLabel.TabIndex = 113
        PayfrequencyLabel.Text = "Pay Frequency"
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
        Me.splitContainer1.Panel1.Controls.Add(Me.SearchAddGroupBox)
        Me.splitContainer1.Panel1.Controls.Add(Me.LoginGroupBox)
        Me.splitContainer1.Panel1.Controls.Add(Me.employeeSearchLabel)
        Me.splitContainer1.Panel1.Controls.Add(Me.WelcomeLabel)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.AutoScroll = True
        Me.splitContainer1.Panel2.Controls.Add(Me.EmployeeInfoGroupBox)
        Me.splitContainer1.Size = New System.Drawing.Size(1028, 495)
        Me.splitContainer1.SplitterDistance = 377
        Me.splitContainer1.TabIndex = 1
        '
        'SearchAddGroupBox
        '
        Me.SearchAddGroupBox.Controls.Add(Me.AddEmpBtn)
        Me.SearchAddGroupBox.Controls.Add(Me.addEmployeLinkLabel)
        Me.SearchAddGroupBox.Controls.Add(Me.SearchBtn)
        Me.SearchAddGroupBox.Controls.Add(Me.SearchEmpTxt)
        Me.SearchAddGroupBox.Controls.Add(Me.employeeMgmtFormEmployeeSearch)
        Me.SearchAddGroupBox.Location = New System.Drawing.Point(0, 310)
        Me.SearchAddGroupBox.Name = "SearchAddGroupBox"
        Me.SearchAddGroupBox.Size = New System.Drawing.Size(374, 153)
        Me.SearchAddGroupBox.TabIndex = 111
        Me.SearchAddGroupBox.TabStop = False
        Me.SearchAddGroupBox.Visible = False
        '
        'AddEmpBtn
        '
        Me.AddEmpBtn.Location = New System.Drawing.Point(277, 89)
        Me.AddEmpBtn.Name = "AddEmpBtn"
        Me.AddEmpBtn.Size = New System.Drawing.Size(89, 23)
        Me.AddEmpBtn.TabIndex = 18
        Me.AddEmpBtn.Text = "Add Employee"
        Me.AddEmpBtn.UseVisualStyleBackColor = True
        '
        'addEmployeLinkLabel
        '
        Me.addEmployeLinkLabel.AutoSize = True
        Me.addEmployeLinkLabel.Location = New System.Drawing.Point(20, 89)
        Me.addEmployeLinkLabel.Name = "addEmployeLinkLabel"
        Me.addEmployeLinkLabel.Size = New System.Drawing.Size(235, 13)
        Me.addEmployeLinkLabel.TabIndex = 19
        Me.addEmployeLinkLabel.Text = "If Employee Not Found, You may Add them Now"
        '
        'SearchBtn
        '
        Me.SearchBtn.Location = New System.Drawing.Point(291, 51)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(75, 23)
        Me.SearchBtn.TabIndex = 17
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'SearchEmpTxt
        '
        Me.SearchEmpTxt.Location = New System.Drawing.Point(153, 52)
        Me.SearchEmpTxt.Name = "SearchEmpTxt"
        Me.SearchEmpTxt.Size = New System.Drawing.Size(121, 20)
        Me.SearchEmpTxt.TabIndex = 16
        '
        'employeeMgmtFormEmployeeSearch
        '
        Me.employeeMgmtFormEmployeeSearch.AutoSize = True
        Me.employeeMgmtFormEmployeeSearch.Location = New System.Drawing.Point(19, 55)
        Me.employeeMgmtFormEmployeeSearch.Name = "employeeMgmtFormEmployeeSearch"
        Me.employeeMgmtFormEmployeeSearch.Size = New System.Drawing.Size(128, 13)
        Me.employeeMgmtFormEmployeeSearch.TabIndex = 15
        Me.employeeMgmtFormEmployeeSearch.Text = "Search For Employee (ID)"
        '
        'LoginGroupBox
        '
        Me.LoginGroupBox.Controls.Add(Me.PwordTxt)
        Me.LoginGroupBox.Controls.Add(Me.CancelLoginBtn)
        Me.LoginGroupBox.Controls.Add(Me.ConLoginBtn)
        Me.LoginGroupBox.Controls.Add(Me.UnameTxt)
        Me.LoginGroupBox.Controls.Add(Me.loginformPassLabel)
        Me.LoginGroupBox.Controls.Add(Me.loginFormUsrLabel)
        Me.LoginGroupBox.Location = New System.Drawing.Point(16, 103)
        Me.LoginGroupBox.Name = "LoginGroupBox"
        Me.LoginGroupBox.Size = New System.Drawing.Size(314, 168)
        Me.LoginGroupBox.TabIndex = 15
        Me.LoginGroupBox.TabStop = False
        '
        'PwordTxt
        '
        Me.PwordTxt.Location = New System.Drawing.Point(157, 68)
        Me.PwordTxt.Name = "PwordTxt"
        Me.PwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PwordTxt.Size = New System.Drawing.Size(121, 20)
        Me.PwordTxt.TabIndex = 10
        Me.PwordTxt.UseSystemPasswordChar = True
        '
        'CancelLoginBtn
        '
        Me.CancelLoginBtn.Location = New System.Drawing.Point(111, 106)
        Me.CancelLoginBtn.Name = "CancelLoginBtn"
        Me.CancelLoginBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelLoginBtn.TabIndex = 12
        Me.CancelLoginBtn.Text = "Cancel"
        Me.CancelLoginBtn.UseVisualStyleBackColor = True
        '
        'ConLoginBtn
        '
        Me.ConLoginBtn.Location = New System.Drawing.Point(202, 106)
        Me.ConLoginBtn.Name = "ConLoginBtn"
        Me.ConLoginBtn.Size = New System.Drawing.Size(75, 23)
        Me.ConLoginBtn.TabIndex = 11
        Me.ConLoginBtn.Text = "Continue"
        Me.ConLoginBtn.UseVisualStyleBackColor = True
        '
        'UnameTxt
        '
        Me.UnameTxt.Location = New System.Drawing.Point(157, 40)
        Me.UnameTxt.Name = "UnameTxt"
        Me.UnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.UnameTxt.TabIndex = 9
        '
        'loginformPassLabel
        '
        Me.loginformPassLabel.AutoSize = True
        Me.loginformPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginformPassLabel.Location = New System.Drawing.Point(37, 69)
        Me.loginformPassLabel.Name = "loginformPassLabel"
        Me.loginformPassLabel.Size = New System.Drawing.Size(86, 20)
        Me.loginformPassLabel.TabIndex = 14
        Me.loginformPassLabel.Text = "Password"
        '
        'loginFormUsrLabel
        '
        Me.loginFormUsrLabel.AutoSize = True
        Me.loginFormUsrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginFormUsrLabel.Location = New System.Drawing.Point(37, 40)
        Me.loginFormUsrLabel.Name = "loginFormUsrLabel"
        Me.loginFormUsrLabel.Size = New System.Drawing.Size(98, 20)
        Me.loginFormUsrLabel.TabIndex = 13
        Me.loginFormUsrLabel.Text = "User Name"
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(135, 274)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(104, 24)
        Me.WelcomeLabel.TabIndex = 111
        Me.WelcomeLabel.Text = "Welcome!"
        Me.WelcomeLabel.Visible = False
        '
        'EmployeeInfoGroupBox
        '
        Me.EmployeeInfoGroupBox.Controls.Add(Me.SalariedGroupBox)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.HourlyGroupBox)
        Me.EmployeeInfoGroupBox.Controls.Add(PayfrequencyLabel)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.PayfrequencyTextBox)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.PayTypeTxtBox)
        Me.EmployeeInfoGroupBox.Controls.Add(IDLabel)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.EmpIDTxt)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.ClearBtn)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.SSN_Txt)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.cancelBtn)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.removeEmpBtn)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.editEmpBtn)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.DependentsTxt)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.employeeMGMTDependLabel)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.MaritalStatusTxt)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.employeeMGMTFormMarriedStatLabel)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.employeeMGMTFormPaymentTypeLabel)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.PositionTxt)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.employeeMGMTFormPositionLable)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.SSN_Label)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.LnameTxt)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.LnameLabel)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.StreetTxt)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.FnameTxt)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.employeeMGMTFormAddyLabel)
        Me.EmployeeInfoGroupBox.Controls.Add(Me.employeeMGMTFormFirstNameLabel)
        Me.EmployeeInfoGroupBox.Location = New System.Drawing.Point(3, 28)
        Me.EmployeeInfoGroupBox.Name = "EmployeeInfoGroupBox"
        Me.EmployeeInfoGroupBox.Size = New System.Drawing.Size(644, 467)
        Me.EmployeeInfoGroupBox.TabIndex = 84
        Me.EmployeeInfoGroupBox.TabStop = False
        Me.EmployeeInfoGroupBox.Visible = False
        '
        'SalariedGroupBox
        '
        Me.SalariedGroupBox.Controls.Add(Me.SalaryTxtBox)
        Me.SalariedGroupBox.Controls.Add(Me.Label2)
        Me.SalariedGroupBox.Location = New System.Drawing.Point(6, 219)
        Me.SalariedGroupBox.Name = "SalariedGroupBox"
        Me.SalariedGroupBox.Size = New System.Drawing.Size(277, 65)
        Me.SalariedGroupBox.TabIndex = 116
        Me.SalariedGroupBox.TabStop = False
        Me.SalariedGroupBox.Visible = False
        '
        'SalaryTxtBox
        '
        Me.SalaryTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "salary", True))
        Me.SalaryTxtBox.Location = New System.Drawing.Point(142, 29)
        Me.SalaryTxtBox.Name = "SalaryTxtBox"
        Me.SalaryTxtBox.Size = New System.Drawing.Size(117, 20)
        Me.SalaryTxtBox.TabIndex = 111
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Salary"
        '
        'HourlyGroupBox
        '
        Me.HourlyGroupBox.Controls.Add(Me.employeeMGMTPayableHrsLabel)
        Me.HourlyGroupBox.Controls.Add(Me.employeeMGMTFormWageRateLabel)
        Me.HourlyGroupBox.Controls.Add(Me.PayRateTxt)
        Me.HourlyGroupBox.Controls.Add(Me.PayHrsTxt)
        Me.HourlyGroupBox.Location = New System.Drawing.Point(8, 219)
        Me.HourlyGroupBox.Name = "HourlyGroupBox"
        Me.HourlyGroupBox.Size = New System.Drawing.Size(281, 137)
        Me.HourlyGroupBox.TabIndex = 115
        Me.HourlyGroupBox.TabStop = False
        Me.HourlyGroupBox.Visible = False
        '
        'employeeMGMTPayableHrsLabel
        '
        Me.employeeMGMTPayableHrsLabel.AutoSize = True
        Me.employeeMGMTPayableHrsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTPayableHrsLabel.Location = New System.Drawing.Point(6, 29)
        Me.employeeMGMTPayableHrsLabel.Name = "employeeMGMTPayableHrsLabel"
        Me.employeeMGMTPayableHrsLabel.Size = New System.Drawing.Size(123, 20)
        Me.employeeMGMTPayableHrsLabel.TabIndex = 107
        Me.employeeMGMTPayableHrsLabel.Text = "Hours Worked"
        '
        'employeeMGMTFormWageRateLabel
        '
        Me.employeeMGMTFormWageRateLabel.AutoSize = True
        Me.employeeMGMTFormWageRateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormWageRateLabel.Location = New System.Drawing.Point(6, 61)
        Me.employeeMGMTFormWageRateLabel.Name = "employeeMGMTFormWageRateLabel"
        Me.employeeMGMTFormWageRateLabel.Size = New System.Drawing.Size(104, 20)
        Me.employeeMGMTFormWageRateLabel.TabIndex = 106
        Me.employeeMGMTFormWageRateLabel.Text = "Hourly Rate"
        '
        'PayRateTxt
        '
        Me.PayRateTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "hourlyrate", True))
        Me.PayRateTxt.Location = New System.Drawing.Point(138, 63)
        Me.PayRateTxt.Name = "PayRateTxt"
        Me.PayRateTxt.Size = New System.Drawing.Size(121, 20)
        Me.PayRateTxt.TabIndex = 89
        '
        'PayHrsTxt
        '
        Me.PayHrsTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "hoursworked", True))
        Me.PayHrsTxt.Location = New System.Drawing.Point(139, 29)
        Me.PayHrsTxt.Name = "PayHrsTxt"
        Me.PayHrsTxt.Size = New System.Drawing.Size(121, 20)
        Me.PayHrsTxt.TabIndex = 94
        '
        'PayfrequencyTextBox
        '
        Me.PayfrequencyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "payfrequency", True))
        Me.PayfrequencyTextBox.Location = New System.Drawing.Point(148, 183)
        Me.PayfrequencyTextBox.Name = "PayfrequencyTextBox"
        Me.PayfrequencyTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PayfrequencyTextBox.TabIndex = 114
        '
        'PayTypeTxtBox
        '
        Me.PayTypeTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "salaried", True))
        Me.PayTypeTxtBox.Location = New System.Drawing.Point(515, 183)
        Me.PayTypeTxtBox.Name = "PayTypeTxtBox"
        Me.PayTypeTxtBox.Size = New System.Drawing.Size(117, 20)
        Me.PayTypeTxtBox.TabIndex = 113
        '
        'EmpIDTxt
        '
        Me.EmpIDTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ID", True))
        Me.EmpIDTxt.Enabled = False
        Me.EmpIDTxt.Location = New System.Drawing.Point(148, 19)
        Me.EmpIDTxt.Name = "EmpIDTxt"
        Me.EmpIDTxt.Size = New System.Drawing.Size(121, 20)
        Me.EmpIDTxt.TabIndex = 112
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(505, 295)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(118, 23)
        Me.ClearBtn.TabIndex = 111
        Me.ClearBtn.Text = "Clear Selection"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'SSN_Txt
        '
        Me.SSN_Txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ssn", True))
        Me.SSN_Txt.Location = New System.Drawing.Point(148, 153)
        Me.SSN_Txt.Mask = "000-00-0000"
        Me.SSN_Txt.Name = "SSN_Txt"
        Me.SSN_Txt.Size = New System.Drawing.Size(121, 20)
        Me.SSN_Txt.TabIndex = 88
        Me.SSN_Txt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(505, 387)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(118, 23)
        Me.cancelBtn.TabIndex = 97
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'removeEmpBtn
        '
        Me.removeEmpBtn.Location = New System.Drawing.Point(505, 353)
        Me.removeEmpBtn.Name = "removeEmpBtn"
        Me.removeEmpBtn.Size = New System.Drawing.Size(118, 28)
        Me.removeEmpBtn.TabIndex = 96
        Me.removeEmpBtn.Text = "Remove Employee"
        Me.removeEmpBtn.UseVisualStyleBackColor = True
        '
        'editEmpBtn
        '
        Me.editEmpBtn.Location = New System.Drawing.Point(505, 324)
        Me.editEmpBtn.Name = "editEmpBtn"
        Me.editEmpBtn.Size = New System.Drawing.Size(118, 23)
        Me.editEmpBtn.TabIndex = 95
        Me.editEmpBtn.Text = "Update"
        Me.editEmpBtn.UseVisualStyleBackColor = True
        '
        'DependentsTxt
        '
        Me.DependentsTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "dependents", True))
        Me.DependentsTxt.Location = New System.Drawing.Point(515, 96)
        Me.DependentsTxt.Name = "DependentsTxt"
        Me.DependentsTxt.Size = New System.Drawing.Size(121, 20)
        Me.DependentsTxt.TabIndex = 91
        '
        'employeeMGMTDependLabel
        '
        Me.employeeMGMTDependLabel.AutoSize = True
        Me.employeeMGMTDependLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTDependLabel.Location = New System.Drawing.Point(388, 96)
        Me.employeeMGMTDependLabel.Name = "employeeMGMTDependLabel"
        Me.employeeMGMTDependLabel.Size = New System.Drawing.Size(107, 20)
        Me.employeeMGMTDependLabel.TabIndex = 105
        Me.employeeMGMTDependLabel.Text = "Dependents"
        '
        'MaritalStatusTxt
        '
        Me.MaritalStatusTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "maritalstatus", True))
        Me.MaritalStatusTxt.Location = New System.Drawing.Point(515, 52)
        Me.MaritalStatusTxt.Name = "MaritalStatusTxt"
        Me.MaritalStatusTxt.Size = New System.Drawing.Size(121, 20)
        Me.MaritalStatusTxt.TabIndex = 90
        '
        'employeeMGMTFormMarriedStatLabel
        '
        Me.employeeMGMTFormMarriedStatLabel.AutoSize = True
        Me.employeeMGMTFormMarriedStatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormMarriedStatLabel.Location = New System.Drawing.Point(388, 52)
        Me.employeeMGMTFormMarriedStatLabel.Name = "employeeMGMTFormMarriedStatLabel"
        Me.employeeMGMTFormMarriedStatLabel.Size = New System.Drawing.Size(69, 20)
        Me.employeeMGMTFormMarriedStatLabel.TabIndex = 104
        Me.employeeMGMTFormMarriedStatLabel.Text = "Married"
        '
        'employeeMGMTFormPaymentTypeLabel
        '
        Me.employeeMGMTFormPaymentTypeLabel.AutoSize = True
        Me.employeeMGMTFormPaymentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormPaymentTypeLabel.Location = New System.Drawing.Point(388, 181)
        Me.employeeMGMTFormPaymentTypeLabel.Name = "employeeMGMTFormPaymentTypeLabel"
        Me.employeeMGMTFormPaymentTypeLabel.Size = New System.Drawing.Size(75, 20)
        Me.employeeMGMTFormPaymentTypeLabel.TabIndex = 103
        Me.employeeMGMTFormPaymentTypeLabel.Text = "Salaried"
        '
        'PositionTxt
        '
        Me.PositionTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "title", True))
        Me.PositionTxt.Location = New System.Drawing.Point(515, 138)
        Me.PositionTxt.Name = "PositionTxt"
        Me.PositionTxt.Size = New System.Drawing.Size(121, 20)
        Me.PositionTxt.TabIndex = 92
        '
        'employeeMGMTFormPositionLable
        '
        Me.employeeMGMTFormPositionLable.AutoSize = True
        Me.employeeMGMTFormPositionLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormPositionLable.Location = New System.Drawing.Point(390, 136)
        Me.employeeMGMTFormPositionLable.Name = "employeeMGMTFormPositionLable"
        Me.employeeMGMTFormPositionLable.Size = New System.Drawing.Size(73, 20)
        Me.employeeMGMTFormPositionLable.TabIndex = 102
        Me.employeeMGMTFormPositionLable.Text = "Position"
        '
        'SSN_Label
        '
        Me.SSN_Label.AutoSize = True
        Me.SSN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSN_Label.Location = New System.Drawing.Point(7, 151)
        Me.SSN_Label.Name = "SSN_Label"
        Me.SSN_Label.Size = New System.Drawing.Size(45, 20)
        Me.SSN_Label.TabIndex = 101
        Me.SSN_Label.Text = "SSN"
        '
        'LnameTxt
        '
        Me.LnameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "lname", True))
        Me.LnameTxt.Location = New System.Drawing.Point(148, 86)
        Me.LnameTxt.Name = "LnameTxt"
        Me.LnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.LnameTxt.TabIndex = 85
        '
        'LnameLabel
        '
        Me.LnameLabel.AutoSize = True
        Me.LnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameLabel.Location = New System.Drawing.Point(7, 84)
        Me.LnameLabel.Name = "LnameLabel"
        Me.LnameLabel.Size = New System.Drawing.Size(95, 20)
        Me.LnameLabel.TabIndex = 100
        Me.LnameLabel.Text = "Last Name"
        '
        'StreetTxt
        '
        Me.StreetTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "address", True))
        Me.StreetTxt.Location = New System.Drawing.Point(148, 119)
        Me.StreetTxt.Name = "StreetTxt"
        Me.StreetTxt.Size = New System.Drawing.Size(223, 20)
        Me.StreetTxt.TabIndex = 87
        '
        'FnameTxt
        '
        Me.FnameTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "fname", True))
        Me.FnameTxt.Location = New System.Drawing.Point(148, 52)
        Me.FnameTxt.Name = "FnameTxt"
        Me.FnameTxt.Size = New System.Drawing.Size(121, 20)
        Me.FnameTxt.TabIndex = 84
        '
        'employeeMGMTFormAddyLabel
        '
        Me.employeeMGMTFormAddyLabel.AutoSize = True
        Me.employeeMGMTFormAddyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormAddyLabel.Location = New System.Drawing.Point(7, 119)
        Me.employeeMGMTFormAddyLabel.Name = "employeeMGMTFormAddyLabel"
        Me.employeeMGMTFormAddyLabel.Size = New System.Drawing.Size(75, 20)
        Me.employeeMGMTFormAddyLabel.TabIndex = 99
        Me.employeeMGMTFormAddyLabel.Text = "Address"
        '
        'employeeMGMTFormFirstNameLabel
        '
        Me.employeeMGMTFormFirstNameLabel.AutoSize = True
        Me.employeeMGMTFormFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormFirstNameLabel.Location = New System.Drawing.Point(6, 52)
        Me.employeeMGMTFormFirstNameLabel.Name = "employeeMGMTFormFirstNameLabel"
        Me.employeeMGMTFormFirstNameLabel.Size = New System.Drawing.Size(96, 20)
        Me.employeeMGMTFormFirstNameLabel.TabIndex = 98
        Me.employeeMGMTFormFirstNameLabel.Text = "First Name"
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EmployeeFutureTableAdapter = Nothing
        Me.TableAdapterManager.EmployeePastTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackLogsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Payroll_ProtoVB.PrimaryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpManagment
        '
        Me.AcceptButton = Me.ConLoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "EmpManagment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmpManagementForm"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.PerformLayout()
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.SearchAddGroupBox.ResumeLayout(False)
        Me.SearchAddGroupBox.PerformLayout()
        Me.LoginGroupBox.ResumeLayout(False)
        Me.LoginGroupBox.PerformLayout()
        Me.EmployeeInfoGroupBox.ResumeLayout(False)
        Me.EmployeeInfoGroupBox.PerformLayout()
        Me.SalariedGroupBox.ResumeLayout(False)
        Me.SalariedGroupBox.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HourlyGroupBox.ResumeLayout(False)
        Me.HourlyGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents employeeSearchLabel As Label
    Private WithEvents splitContainer1 As SplitContainer
    Friend WithEvents Primary As Primary
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As PrimaryTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As PrimaryTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeInfoGroupBox As GroupBox
    Private WithEvents SSN_Txt As MaskedTextBox
    Private WithEvents cancelBtn As Button
    Private WithEvents employeeMGMTPayableHrsLabel As Label
    Private WithEvents PayHrsTxt As TextBox
    Private WithEvents removeEmpBtn As Button
    Private WithEvents editEmpBtn As Button
    Private WithEvents PayRateTxt As TextBox
    Private WithEvents employeeMGMTFormWageRateLabel As Label
    Private WithEvents DependentsTxt As TextBox
    Private WithEvents employeeMGMTDependLabel As Label
    Private WithEvents MaritalStatusTxt As TextBox
    Private WithEvents employeeMGMTFormMarriedStatLabel As Label
    Private WithEvents employeeMGMTFormPaymentTypeLabel As Label
    Private WithEvents PositionTxt As TextBox
    Private WithEvents employeeMGMTFormPositionLable As Label
    Private WithEvents SSN_Label As Label
    Private WithEvents LnameTxt As TextBox
    Private WithEvents LnameLabel As Label
    Private WithEvents StreetTxt As TextBox
    Private WithEvents FnameTxt As TextBox
    Private WithEvents employeeMGMTFormAddyLabel As Label
    Private WithEvents employeeMGMTFormFirstNameLabel As Label
    Friend WithEvents LoginGroupBox As GroupBox
    Private WithEvents PwordTxt As MaskedTextBox
    Private WithEvents CancelLoginBtn As Button
    Private WithEvents ConLoginBtn As Button
    Private WithEvents UnameTxt As TextBox
    Private WithEvents loginformPassLabel As Label
    Private WithEvents loginFormUsrLabel As Label
    Friend WithEvents SearchAddGroupBox As GroupBox
    Private WithEvents AddEmpBtn As Button
    Private WithEvents addEmployeLinkLabel As Label
    Private WithEvents SearchBtn As Button
    Private WithEvents SearchEmpTxt As TextBox
    Private WithEvents employeeMgmtFormEmployeeSearch As Label
    Friend WithEvents WelcomeLabel As Label
    Private WithEvents ClearBtn As Button
    Friend WithEvents EmpIDTxt As TextBox
    Private WithEvents PayTypeTxtBox As TextBox
    Friend WithEvents PayfrequencyTextBox As TextBox
    Friend WithEvents HourlyGroupBox As GroupBox
    Friend WithEvents SalariedGroupBox As GroupBox
    Private WithEvents SalaryTxtBox As TextBox
    Private WithEvents Label2 As Label
End Class
