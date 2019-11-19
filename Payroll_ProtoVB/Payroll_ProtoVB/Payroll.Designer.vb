<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payroll))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.metricsTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.payTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dashTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.menueStrip = New System.Windows.Forms.ToolStrip()
        Me.calcPayBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.payrollFormEmployeeSearchLabel = New System.Windows.Forms.Label()
        Me.EmpIDSeartTxt = New System.Windows.Forms.TextBox()
        Me.EmpIDSearch = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PastPayTab = New System.Windows.Forms.TabPage()
        Me.PayrollDataGridViewPast = New System.Windows.Forms.DataGridView()
        Me.PaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePastBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Primary = New Payroll_ProtoVB.Primary()
        Me.FuturePayTab = New System.Windows.Forms.TabPage()
        Me.PayrollDataGridViewFuture = New System.Windows.Forms.DataGridView()
        Me.PaymentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeFutureBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeePastBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeFutureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDocumentPaystub = New System.Drawing.Printing.PrintDocument()
        Me.EmployeePastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeePastTableAdapter = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeePastTableAdapter()
        Me.EmployeeFutureTableAdapter = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeeFutureTableAdapter()
        Me.FnameSearch = New System.Windows.Forms.Button()
        Me.FnameSearchTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LnameSearch = New System.Windows.Forms.Button()
        Me.LnameSearchTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PaymentRecordBTN = New System.Windows.Forms.Button()
        Me.PayStubBTN = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.menueStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.PastPayTab.SuspendLayout()
        CType(Me.PayrollDataGridViewPast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeePastBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FuturePayTab.SuspendLayout()
        CType(Me.PayrollDataGridViewFuture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeFutureBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeePastBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeFutureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeePastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'metricsTstripBTN
        '
        Me.metricsTstripBTN.BackColor = System.Drawing.Color.AliceBlue
        Me.metricsTstripBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.metricsTstripBTN.Image = CType(resources.GetObject("metricsTstripBTN.Image"), System.Drawing.Image)
        Me.metricsTstripBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.metricsTstripBTN.Name = "metricsTstripBTN"
        Me.metricsTstripBTN.Size = New System.Drawing.Size(74, 19)
        Me.metricsTstripBTN.Text = "Metrics"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(74, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(74, 6)
        '
        'payTstripBTN
        '
        Me.payTstripBTN.BackColor = System.Drawing.Color.AliceBlue
        Me.payTstripBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.payTstripBTN.Image = CType(resources.GetObject("payTstripBTN.Image"), System.Drawing.Image)
        Me.payTstripBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.payTstripBTN.Name = "payTstripBTN"
        Me.payTstripBTN.Size = New System.Drawing.Size(74, 19)
        Me.payTstripBTN.Text = "Payroll"
        Me.payTstripBTN.ToolTipText = "Payroll"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(74, 6)
        '
        'dashTstripBTN
        '
        Me.dashTstripBTN.BackColor = System.Drawing.Color.AliceBlue
        Me.dashTstripBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dashTstripBTN.Image = CType(resources.GetObject("dashTstripBTN.Image"), System.Drawing.Image)
        Me.dashTstripBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dashTstripBTN.Name = "dashTstripBTN"
        Me.dashTstripBTN.Size = New System.Drawing.Size(74, 19)
        Me.dashTstripBTN.Text = "Dashboard"
        '
        'menueStrip
        '
        Me.menueStrip.AutoSize = False
        Me.menueStrip.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.menueStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.menueStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dashTstripBTN, Me.ToolStripSeparator1, Me.payTstripBTN, Me.ToolStripSeparator4, Me.calcPayBTN, Me.ToolStripSeparator6, Me.metricsTstripBTN, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripSeparator5, Me.ExitBtn})
        Me.menueStrip.Location = New System.Drawing.Point(0, 0)
        Me.menueStrip.Name = "menueStrip"
        Me.menueStrip.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.menueStrip.Size = New System.Drawing.Size(95, 513)
        Me.menueStrip.Stretch = True
        Me.menueStrip.TabIndex = 3
        Me.menueStrip.Text = "ToolStrip1"
        '
        'calcPayBTN
        '
        Me.calcPayBTN.BackColor = System.Drawing.Color.AliceBlue
        Me.calcPayBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.calcPayBTN.Image = CType(resources.GetObject("calcPayBTN.Image"), System.Drawing.Image)
        Me.calcPayBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.calcPayBTN.Name = "calcPayBTN"
        Me.calcPayBTN.Size = New System.Drawing.Size(74, 19)
        Me.calcPayBTN.Text = "Calculate"
        Me.calcPayBTN.ToolTipText = "Payroll"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(74, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(74, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(74, 6)
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.ExitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(74, 19)
        Me.ExitBtn.Text = "Exit"
        '
        'payrollFormEmployeeSearchLabel
        '
        Me.payrollFormEmployeeSearchLabel.AutoSize = True
        Me.payrollFormEmployeeSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payrollFormEmployeeSearchLabel.Location = New System.Drawing.Point(110, 408)
        Me.payrollFormEmployeeSearchLabel.Name = "payrollFormEmployeeSearchLabel"
        Me.payrollFormEmployeeSearchLabel.Size = New System.Drawing.Size(155, 15)
        Me.payrollFormEmployeeSearchLabel.TabIndex = 4
        Me.payrollFormEmployeeSearchLabel.Text = "Search Employee by ID"
        '
        'EmpIDSeartTxt
        '
        Me.EmpIDSeartTxt.Location = New System.Drawing.Point(353, 403)
        Me.EmpIDSeartTxt.Name = "EmpIDSeartTxt"
        Me.EmpIDSeartTxt.Size = New System.Drawing.Size(151, 20)
        Me.EmpIDSeartTxt.TabIndex = 5
        '
        'EmpIDSearch
        '
        Me.EmpIDSearch.Location = New System.Drawing.Point(538, 400)
        Me.EmpIDSearch.Name = "EmpIDSearch"
        Me.EmpIDSearch.Size = New System.Drawing.Size(75, 23)
        Me.EmpIDSearch.TabIndex = 14
        Me.EmpIDSearch.Text = "Search"
        Me.EmpIDSearch.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.PastPayTab)
        Me.TabControl.Controls.Add(Me.FuturePayTab)
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(95, 28)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(801, 336)
        Me.TabControl.TabIndex = 16
        '
        'PastPayTab
        '
        Me.PastPayTab.Controls.Add(Me.PayrollDataGridViewPast)
        Me.PastPayTab.Location = New System.Drawing.Point(4, 22)
        Me.PastPayTab.Name = "PastPayTab"
        Me.PastPayTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PastPayTab.Size = New System.Drawing.Size(793, 310)
        Me.PastPayTab.TabIndex = 0
        Me.PastPayTab.Text = "Past Payroll"
        Me.PastPayTab.UseVisualStyleBackColor = True
        '
        'PayrollDataGridViewPast
        '
        Me.PayrollDataGridViewPast.AutoGenerateColumns = False
        Me.PayrollDataGridViewPast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PayrollDataGridViewPast.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PayrollDataGridViewPast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrollDataGridViewPast.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.fname, Me.lname})
        Me.PayrollDataGridViewPast.DataSource = Me.EmployeePastBindingSource2
        Me.PayrollDataGridViewPast.Location = New System.Drawing.Point(-3, -3)
        Me.PayrollDataGridViewPast.Name = "PayrollDataGridViewPast"
        Me.PayrollDataGridViewPast.Size = New System.Drawing.Size(796, 307)
        Me.PayrollDataGridViewPast.TabIndex = 1
        '
        'PaymentIDDataGridViewTextBoxColumn
        '
        Me.PaymentIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentID"
        Me.PaymentIDDataGridViewTextBoxColumn.HeaderText = "Payment ID"
        Me.PaymentIDDataGridViewTextBoxColumn.Name = "PaymentIDDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'fname
        '
        Me.fname.DataPropertyName = "fname"
        Me.fname.HeaderText = "fname"
        Me.fname.Name = "fname"
        '
        'lname
        '
        Me.lname.DataPropertyName = "lname"
        Me.lname.HeaderText = "lname"
        Me.lname.Name = "lname"
        '
        'EmployeePastBindingSource2
        '
        Me.EmployeePastBindingSource2.DataMember = "EmployeePast"
        Me.EmployeePastBindingSource2.DataSource = Me.Primary
        '
        'Primary
        '
        Me.Primary.DataSetName = "Primary"
        Me.Primary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FuturePayTab
        '
        Me.FuturePayTab.Controls.Add(Me.PayrollDataGridViewFuture)
        Me.FuturePayTab.Location = New System.Drawing.Point(4, 22)
        Me.FuturePayTab.Name = "FuturePayTab"
        Me.FuturePayTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FuturePayTab.Size = New System.Drawing.Size(793, 310)
        Me.FuturePayTab.TabIndex = 1
        Me.FuturePayTab.Text = "Future Pay and Stub Layout"
        Me.FuturePayTab.UseVisualStyleBackColor = True
        '
        'PayrollDataGridViewFuture
        '
        Me.PayrollDataGridViewFuture.AutoGenerateColumns = False
        Me.PayrollDataGridViewFuture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PayrollDataGridViewFuture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrollDataGridViewFuture.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentIDDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PayrollDataGridViewFuture.DataSource = Me.EmployeeFutureBindingSource1
        Me.PayrollDataGridViewFuture.Location = New System.Drawing.Point(0, 0)
        Me.PayrollDataGridViewFuture.Name = "PayrollDataGridViewFuture"
        Me.PayrollDataGridViewFuture.Size = New System.Drawing.Size(787, 307)
        Me.PayrollDataGridViewFuture.TabIndex = 0
        '
        'PaymentIDDataGridViewTextBoxColumn1
        '
        Me.PaymentIDDataGridViewTextBoxColumn1.DataPropertyName = "PaymentID"
        Me.PaymentIDDataGridViewTextBoxColumn1.HeaderText = "Payment ID"
        Me.PaymentIDDataGridViewTextBoxColumn1.Name = "PaymentIDDataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'EmployeeFutureBindingSource1
        '
        Me.EmployeeFutureBindingSource1.DataMember = "EmployeeFuture"
        Me.EmployeeFutureBindingSource1.DataSource = Me.Primary
        '
        'EmployeePastBindingSource1
        '
        Me.EmployeePastBindingSource1.DataMember = "EmployeePast"
        '
        'EmployeeFutureBindingSource
        '
        Me.EmployeeFutureBindingSource.DataMember = "EmployeeFuture"
        '
        'PrintDocumentPaystub
        '
        Me.PrintDocumentPaystub.DocumentName = "paystub"
        '
        'EmployeePastTableAdapter
        '
        Me.EmployeePastTableAdapter.ClearBeforeFill = True
        '
        'EmployeeFutureTableAdapter
        '
        Me.EmployeeFutureTableAdapter.ClearBeforeFill = True
        '
        'FnameSearch
        '
        Me.FnameSearch.Location = New System.Drawing.Point(538, 436)
        Me.FnameSearch.Name = "FnameSearch"
        Me.FnameSearch.Size = New System.Drawing.Size(75, 23)
        Me.FnameSearch.TabIndex = 19
        Me.FnameSearch.Text = "Search"
        Me.FnameSearch.UseVisualStyleBackColor = True
        '
        'FnameSearchTxt
        '
        Me.FnameSearchTxt.Location = New System.Drawing.Point(353, 439)
        Me.FnameSearchTxt.Name = "FnameSearchTxt"
        Me.FnameSearchTxt.Size = New System.Drawing.Size(151, 20)
        Me.FnameSearchTxt.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 444)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Search Employee by First Name"
        '
        'LnameSearch
        '
        Me.LnameSearch.Location = New System.Drawing.Point(538, 470)
        Me.LnameSearch.Name = "LnameSearch"
        Me.LnameSearch.Size = New System.Drawing.Size(75, 23)
        Me.LnameSearch.TabIndex = 22
        Me.LnameSearch.Text = "Search"
        Me.LnameSearch.UseVisualStyleBackColor = True
        '
        'LnameSearchTxt
        '
        Me.LnameSearchTxt.Location = New System.Drawing.Point(353, 473)
        Me.LnameSearchTxt.Name = "LnameSearchTxt"
        Me.LnameSearchTxt.Size = New System.Drawing.Size(151, 20)
        Me.LnameSearchTxt.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 478)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Search Employee by Last Name"
        '
        'PaymentRecordBTN
        '
        Me.PaymentRecordBTN.Location = New System.Drawing.Point(696, 458)
        Me.PaymentRecordBTN.Name = "PaymentRecordBTN"
        Me.PaymentRecordBTN.Size = New System.Drawing.Size(89, 35)
        Me.PaymentRecordBTN.TabIndex = 23
        Me.PaymentRecordBTN.Text = "View Detailed Record"
        Me.PaymentRecordBTN.UseVisualStyleBackColor = True
        '
        'PayStubBTN
        '
        Me.PayStubBTN.Location = New System.Drawing.Point(807, 458)
        Me.PayStubBTN.Name = "PayStubBTN"
        Me.PayStubBTN.Size = New System.Drawing.Size(89, 35)
        Me.PayStubBTN.TabIndex = 24
        Me.PayStubBTN.Text = "View Employee PayStub"
        Me.PayStubBTN.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.EmployeePastBindingSource2
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(95, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(808, 25)
        Me.BindingNavigator1.TabIndex = 25
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(696, 400)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(89, 35)
        Me.clearBtn.TabIndex = 26
        Me.clearBtn.Text = "Clear Selection"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 513)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.PayStubBTN)
        Me.Controls.Add(Me.PaymentRecordBTN)
        Me.Controls.Add(Me.LnameSearch)
        Me.Controls.Add(Me.LnameSearchTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FnameSearch)
        Me.Controls.Add(Me.FnameSearchTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.EmpIDSearch)
        Me.Controls.Add(Me.EmpIDSeartTxt)
        Me.Controls.Add(Me.payrollFormEmployeeSearchLabel)
        Me.Controls.Add(Me.menueStrip)
        Me.Name = "Payroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayrollForm"
        Me.menueStrip.ResumeLayout(False)
        Me.menueStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.PastPayTab.ResumeLayout(False)
        CType(Me.PayrollDataGridViewPast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeePastBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FuturePayTab.ResumeLayout(False)
        CType(Me.PayrollDataGridViewFuture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeFutureBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeePastBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeFutureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeePastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents metricsTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents payTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents dashTstripBTN As ToolStripButton
    Private WithEvents menueStrip As ToolStrip
    Friend WithEvents payrollFormEmployeeSearchLabel As Label
    Friend WithEvents EmpIDSeartTxt As TextBox
    Private WithEvents EmpIDSearch As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents PastPayTab As TabPage
    Friend WithEvents PayrollDataGridViewPast As DataGridView
    Friend WithEvents FuturePayTab As TabPage
    Friend WithEvents PayrollDataGridViewFuture As DataGridView
    Friend WithEvents PrintDocumentPaystub As Printing.PrintDocument
    Friend WithEvents EmployeePastBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePastBindingSource1 As BindingSource
    Friend WithEvents EmployeeFutureBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Primary As Primary
    Friend WithEvents EmployeePastBindingSource2 As BindingSource
    Friend WithEvents EmployeePastTableAdapter As PrimaryTableAdapters.EmployeePastTableAdapter
    Friend WithEvents EmployeeFutureBindingSource1 As BindingSource
    Friend WithEvents EmployeeFutureTableAdapter As PrimaryTableAdapters.EmployeeFutureTableAdapter
    Friend WithEvents PaymentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ExitBtn As ToolStripButton
    Private WithEvents FnameSearch As Button
    Friend WithEvents FnameSearchTxt As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents LnameSearch As Button
    Friend WithEvents LnameSearchTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PaymentRecordBTN As Button
    Friend WithEvents PayStubBTN As Button
    Friend WithEvents calcPayBTN As ToolStripButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents clearBtn As Button
End Class
