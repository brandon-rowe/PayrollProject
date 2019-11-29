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
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payfrequency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePastBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Primary = New Payroll_ProtoVB.Primary()
        Me.FuturePayTab = New System.Windows.Forms.TabPage()
        Me.PayrollDataGridViewFuture = New System.Windows.Forms.DataGridView()
        Me.PaymentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payfrequency1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeFutureBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDocumentPaystub = New System.Drawing.Printing.PrintDocument()
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
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.EmployeePastBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeFutureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeePastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.menueStrip.Size = New System.Drawing.Size(95, 509)
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
        Me.TabControl.Location = New System.Drawing.Point(95, 17)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(801, 366)
        Me.TabControl.TabIndex = 16
        '
        'PastPayTab
        '
        Me.PastPayTab.Controls.Add(Me.PayrollDataGridViewPast)
        Me.PastPayTab.Location = New System.Drawing.Point(4, 22)
        Me.PastPayTab.Name = "PastPayTab"
        Me.PastPayTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PastPayTab.Size = New System.Drawing.Size(793, 340)
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
        Me.PayrollDataGridViewPast.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.payfrequency, Me.DataGridViewTextBoxColumn7})
        Me.PayrollDataGridViewPast.DataSource = Me.EmployeePastBindingSource2
        Me.PayrollDataGridViewPast.Location = New System.Drawing.Point(-3, -3)
        Me.PayrollDataGridViewPast.Name = "PayrollDataGridViewPast"
        Me.PayrollDataGridViewPast.Size = New System.Drawing.Size(800, 347)
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'payfrequency
        '
        Me.payfrequency.DataPropertyName = "payfrequency"
        Me.payfrequency.HeaderText = "Pay Frequency"
        Me.payfrequency.Name = "payfrequency"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
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
        Me.FuturePayTab.Size = New System.Drawing.Size(793, 340)
        Me.FuturePayTab.TabIndex = 1
        Me.FuturePayTab.Text = "Future Pay and Stub Layout"
        Me.FuturePayTab.UseVisualStyleBackColor = True
        '
        'PayrollDataGridViewFuture
        '
        Me.PayrollDataGridViewFuture.AllowUserToOrderColumns = True
        Me.PayrollDataGridViewFuture.AutoGenerateColumns = False
        Me.PayrollDataGridViewFuture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PayrollDataGridViewFuture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrollDataGridViewFuture.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentIDDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.payfrequency1, Me.DataGridViewTextBoxColumn9})
        Me.PayrollDataGridViewFuture.DataSource = Me.EmployeeFutureBindingSource1
        Me.PayrollDataGridViewFuture.Location = New System.Drawing.Point(0, 0)
        Me.PayrollDataGridViewFuture.Name = "PayrollDataGridViewFuture"
        Me.PayrollDataGridViewFuture.Size = New System.Drawing.Size(793, 340)
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fname"
        Me.DataGridViewTextBoxColumn5.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "lname"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'payfrequency1
        '
        Me.payfrequency1.DataPropertyName = "payfrequency"
        Me.payfrequency1.HeaderText = "Pay Frequency"
        Me.payfrequency1.Name = "payfrequency1"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'EmployeeFutureBindingSource1
        '
        Me.EmployeeFutureBindingSource1.DataMember = "EmployeeFuture"
        Me.EmployeeFutureBindingSource1.DataSource = Me.Primary
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
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(696, 400)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(89, 35)
        Me.clearBtn.TabIndex = 26
        Me.clearBtn.Text = "Clear Selection"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'EmployeePastBindingSource1
        '
        Me.EmployeePastBindingSource1.DataMember = "EmployeePast"
        '
        'EmployeeFutureBindingSource
        '
        Me.EmployeeFutureBindingSource.DataMember = "EmployeeFuture"
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 509)
        Me.Controls.Add(Me.clearBtn)
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
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents clearBtn As Button
    Friend WithEvents PaymentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents payfrequency As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents payfrequency1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
