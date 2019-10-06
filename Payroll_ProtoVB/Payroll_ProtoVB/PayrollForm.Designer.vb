<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollForm))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.metricsTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.payTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dashTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.menueStrip = New System.Windows.Forms.ToolStrip()
        Me.payrollFormEmployeeSearchLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PayrollFormSearch = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PastPayTab = New System.Windows.Forms.TabPage()
        Me.PayrollDataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PastPayDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursWorked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WagesGarnerd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayStubs = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FuturePayTab = New System.Windows.Forms.TabPage()
        Me.PayStubGroupBox = New System.Windows.Forms.GroupBox()
        Me.signatureLabel = New System.Windows.Forms.Label()
        Me.accountNumberTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.endPayPeriodDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.dateDashLabel = New System.Windows.Forms.Label()
        Me.memo = New System.Windows.Forms.Label()
        Me.payPeriodLabel = New System.Windows.Forms.Label()
        Me.strtPayPeriodDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.empAddyMTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.empNameMTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.payNumMTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.payStrMTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.DOLLARSLabel = New System.Windows.Forms.Label()
        Me.payStrLabel = New System.Windows.Forms.Label()
        Me.payNumLabel = New System.Windows.Forms.Label()
        Me.empNameTxtBox = New System.Windows.Forms.TextBox()
        Me.payToOrderEmployeeNameLabel = New System.Windows.Forms.Label()
        Me.payToOrderLabel = New System.Windows.Forms.Label()
        Me.datePrintLabel = New System.Windows.Forms.Label()
        Me.prntDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.RefNumMTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.bankAddyMTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.bankNameMTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.companyAddyMTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.companyNameMTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FuturePay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocumentPaystub = New System.Drawing.Printing.PrintDocument()
        Me.printButton = New System.Windows.Forms.Button()
        Me.menueStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.PastPayTab.SuspendLayout()
        CType(Me.PayrollDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FuturePayTab.SuspendLayout()
        Me.PayStubGroupBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'metricsTstripBTN
        '
        Me.metricsTstripBTN.BackColor = System.Drawing.Color.Honeydew
        Me.metricsTstripBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.metricsTstripBTN.Image = CType(resources.GetObject("metricsTstripBTN.Image"), System.Drawing.Image)
        Me.metricsTstripBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.metricsTstripBTN.Name = "metricsTstripBTN"
        Me.metricsTstripBTN.Size = New System.Drawing.Size(74, 19)
        Me.metricsTstripBTN.Text = "Metrics"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(74, 6)
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
        Me.payTstripBTN.BackColor = System.Drawing.Color.Honeydew
        Me.payTstripBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.payTstripBTN.Image = CType(resources.GetObject("payTstripBTN.Image"), System.Drawing.Image)
        Me.payTstripBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.payTstripBTN.Name = "payTstripBTN"
        Me.payTstripBTN.Size = New System.Drawing.Size(74, 19)
        Me.payTstripBTN.Text = "Payroll"
        Me.payTstripBTN.ToolTipText = "Payroll"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(74, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(74, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(74, 6)
        '
        'dashTstripBTN
        '
        Me.dashTstripBTN.BackColor = System.Drawing.Color.Honeydew
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
        Me.menueStrip.BackColor = System.Drawing.Color.Teal
        Me.menueStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.menueStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dashTstripBTN, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.payTstripBTN, Me.ToolStripSeparator4, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.metricsTstripBTN})
        Me.menueStrip.Location = New System.Drawing.Point(0, 0)
        Me.menueStrip.Name = "menueStrip"
        Me.menueStrip.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.menueStrip.Size = New System.Drawing.Size(95, 495)
        Me.menueStrip.Stretch = True
        Me.menueStrip.TabIndex = 3
        Me.menueStrip.Text = "ToolStrip1"
        '
        'payrollFormEmployeeSearchLabel
        '
        Me.payrollFormEmployeeSearchLabel.AutoSize = True
        Me.payrollFormEmployeeSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payrollFormEmployeeSearchLabel.Location = New System.Drawing.Point(160, 20)
        Me.payrollFormEmployeeSearchLabel.Name = "payrollFormEmployeeSearchLabel"
        Me.payrollFormEmployeeSearchLabel.Size = New System.Drawing.Size(140, 15)
        Me.payrollFormEmployeeSearchLabel.TabIndex = 4
        Me.payrollFormEmployeeSearchLabel.Text = "Search for Employee"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(337, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 5
        '
        'PayrollFormSearch
        '
        Me.PayrollFormSearch.Location = New System.Drawing.Point(526, 19)
        Me.PayrollFormSearch.Name = "PayrollFormSearch"
        Me.PayrollFormSearch.Size = New System.Drawing.Size(75, 23)
        Me.PayrollFormSearch.TabIndex = 14
        Me.PayrollFormSearch.Text = "Search"
        Me.PayrollFormSearch.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.PastPayTab)
        Me.TabControl.Controls.Add(Me.FuturePayTab)
        Me.TabControl.Location = New System.Drawing.Point(163, 71)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(787, 336)
        Me.TabControl.TabIndex = 16
        '
        'PastPayTab
        '
        Me.PastPayTab.Controls.Add(Me.PayrollDataGridView2)
        Me.PastPayTab.Location = New System.Drawing.Point(4, 22)
        Me.PastPayTab.Name = "PastPayTab"
        Me.PastPayTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PastPayTab.Size = New System.Drawing.Size(779, 310)
        Me.PastPayTab.TabIndex = 0
        Me.PastPayTab.Text = "Past Payroll"
        Me.PastPayTab.UseVisualStyleBackColor = True
        '
        'PayrollDataGridView2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PayrollDataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PayrollDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrollDataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PastPayDate, Me.HoursWorked, Me.WagesGarnerd, Me.PayStubs})
        Me.PayrollDataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.PayrollDataGridView2.Name = "PayrollDataGridView2"
        Me.PayrollDataGridView2.Size = New System.Drawing.Size(779, 307)
        Me.PayrollDataGridView2.TabIndex = 1
        '
        'PastPayDate
        '
        Me.PastPayDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PastPayDate.HeaderText = "Pay Date Rollout"
        Me.PastPayDate.Name = "PastPayDate"
        '
        'HoursWorked
        '
        Me.HoursWorked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HoursWorked.HeaderText = "Hours"
        Me.HoursWorked.Name = "HoursWorked"
        '
        'WagesGarnerd
        '
        Me.WagesGarnerd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WagesGarnerd.HeaderText = "Wages"
        Me.WagesGarnerd.Name = "WagesGarnerd"
        '
        'PayStubs
        '
        Me.PayStubs.HeaderText = "PayStubs"
        Me.PayStubs.Name = "PayStubs"
        Me.PayStubs.Width = 85
        '
        'FuturePayTab
        '
        Me.FuturePayTab.Controls.Add(Me.PayStubGroupBox)
        Me.FuturePayTab.Controls.Add(Me.DataGridView1)
        Me.FuturePayTab.Location = New System.Drawing.Point(4, 22)
        Me.FuturePayTab.Name = "FuturePayTab"
        Me.FuturePayTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FuturePayTab.Size = New System.Drawing.Size(779, 310)
        Me.FuturePayTab.TabIndex = 1
        Me.FuturePayTab.Text = "Present and Expected Payroll"
        Me.FuturePayTab.UseVisualStyleBackColor = True
        '
        'PayStubGroupBox
        '
        Me.PayStubGroupBox.Controls.Add(Me.signatureLabel)
        Me.PayStubGroupBox.Controls.Add(Me.accountNumberTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.endPayPeriodDatePicker)
        Me.PayStubGroupBox.Controls.Add(Me.dateDashLabel)
        Me.PayStubGroupBox.Controls.Add(Me.memo)
        Me.PayStubGroupBox.Controls.Add(Me.payPeriodLabel)
        Me.PayStubGroupBox.Controls.Add(Me.strtPayPeriodDatePicker)
        Me.PayStubGroupBox.Controls.Add(Me.empAddyMTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.empNameMTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.payNumMTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.payStrMTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.DOLLARSLabel)
        Me.PayStubGroupBox.Controls.Add(Me.payStrLabel)
        Me.PayStubGroupBox.Controls.Add(Me.payNumLabel)
        Me.PayStubGroupBox.Controls.Add(Me.empNameTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.payToOrderEmployeeNameLabel)
        Me.PayStubGroupBox.Controls.Add(Me.payToOrderLabel)
        Me.PayStubGroupBox.Controls.Add(Me.datePrintLabel)
        Me.PayStubGroupBox.Controls.Add(Me.prntDatePicker)
        Me.PayStubGroupBox.Controls.Add(Me.RefNumMTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.bankAddyMTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.bankNameMTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.companyAddyMTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.companyNameMTxtBox)
        Me.PayStubGroupBox.Location = New System.Drawing.Point(142, 0)
        Me.PayStubGroupBox.Name = "PayStubGroupBox"
        Me.PayStubGroupBox.Size = New System.Drawing.Size(631, 307)
        Me.PayStubGroupBox.TabIndex = 1
        Me.PayStubGroupBox.TabStop = False
        Me.PayStubGroupBox.Text = "PayStub"
        '
        'signatureLabel
        '
        Me.signatureLabel.AutoSize = True
        Me.signatureLabel.Location = New System.Drawing.Point(374, 206)
        Me.signatureLabel.Name = "signatureLabel"
        Me.signatureLabel.Size = New System.Drawing.Size(210, 13)
        Me.signatureLabel.TabIndex = 23
        Me.signatureLabel.Text = "SIGNED___________________________"
        '
        'accountNumberTxtBox
        '
        Me.accountNumberTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountNumberTxtBox.Location = New System.Drawing.Point(28, 284)
        Me.accountNumberTxtBox.Name = "accountNumberTxtBox"
        Me.accountNumberTxtBox.Size = New System.Drawing.Size(235, 20)
        Me.accountNumberTxtBox.TabIndex = 22
        Me.accountNumberTxtBox.Text = "Acc Num: 0242528735571L0008993"
        '
        'endPayPeriodDatePicker
        '
        Me.endPayPeriodDatePicker.CustomFormat = "MM/dd/yy"
        Me.endPayPeriodDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endPayPeriodDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.endPayPeriodDatePicker.Location = New System.Drawing.Point(252, 253)
        Me.endPayPeriodDatePicker.Name = "endPayPeriodDatePicker"
        Me.endPayPeriodDatePicker.Size = New System.Drawing.Size(83, 20)
        Me.endPayPeriodDatePicker.TabIndex = 21
        Me.endPayPeriodDatePicker.Value = New Date(2019, 10, 6, 0, 0, 0, 0)
        '
        'dateDashLabel
        '
        Me.dateDashLabel.AutoSize = True
        Me.dateDashLabel.Location = New System.Drawing.Point(236, 259)
        Me.dateDashLabel.Name = "dateDashLabel"
        Me.dateDashLabel.Size = New System.Drawing.Size(10, 13)
        Me.dateDashLabel.TabIndex = 20
        Me.dateDashLabel.Text = "-"
        '
        'memo
        '
        Me.memo.AutoSize = True
        Me.memo.Location = New System.Drawing.Point(9, 253)
        Me.memo.Name = "memo"
        Me.memo.Size = New System.Drawing.Size(40, 13)
        Me.memo.TabIndex = 19
        Me.memo.Text = "MEMO"
        '
        'payPeriodLabel
        '
        Me.payPeriodLabel.AutoSize = True
        Me.payPeriodLabel.Location = New System.Drawing.Point(77, 253)
        Me.payPeriodLabel.Name = "payPeriodLabel"
        Me.payPeriodLabel.Size = New System.Drawing.Size(61, 13)
        Me.payPeriodLabel.TabIndex = 18
        Me.payPeriodLabel.Text = "Pay Period:"
        '
        'strtPayPeriodDatePicker
        '
        Me.strtPayPeriodDatePicker.CustomFormat = "MM/dd/yy"
        Me.strtPayPeriodDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.strtPayPeriodDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.strtPayPeriodDatePicker.Location = New System.Drawing.Point(144, 253)
        Me.strtPayPeriodDatePicker.Name = "strtPayPeriodDatePicker"
        Me.strtPayPeriodDatePicker.Size = New System.Drawing.Size(83, 20)
        Me.strtPayPeriodDatePicker.TabIndex = 17
        Me.strtPayPeriodDatePicker.Value = New Date(2019, 10, 6, 0, 0, 0, 0)
        '
        'empAddyMTxtBox
        '
        Me.empAddyMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empAddyMTxtBox.Location = New System.Drawing.Point(67, 199)
        Me.empAddyMTxtBox.Name = "empAddyMTxtBox"
        Me.empAddyMTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.empAddyMTxtBox.TabIndex = 16
        Me.empAddyMTxtBox.Text = "Employee Address"
        '
        'empNameMTxtBox
        '
        Me.empNameMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empNameMTxtBox.Location = New System.Drawing.Point(67, 173)
        Me.empNameMTxtBox.Name = "empNameMTxtBox"
        Me.empNameMTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.empNameMTxtBox.TabIndex = 15
        Me.empNameMTxtBox.Text = "Employee Name"
        '
        'payNumMTxtBox
        '
        Me.payNumMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payNumMTxtBox.Location = New System.Drawing.Point(513, 103)
        Me.payNumMTxtBox.Name = "payNumMTxtBox"
        Me.payNumMTxtBox.Size = New System.Drawing.Size(82, 20)
        Me.payNumMTxtBox.TabIndex = 14
        Me.payNumMTxtBox.Text = "**100.43"
        '
        'payStrMTxtBox
        '
        Me.payStrMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payStrMTxtBox.Location = New System.Drawing.Point(28, 134)
        Me.payStrMTxtBox.Name = "payStrMTxtBox"
        Me.payStrMTxtBox.Size = New System.Drawing.Size(504, 20)
        Me.payStrMTxtBox.TabIndex = 13
        Me.payStrMTxtBox.Text = "String of Payment: One Hundred and 43/100****************************************" &
    "*****************************"
        '
        'DOLLARSLabel
        '
        Me.DOLLARSLabel.AutoSize = True
        Me.DOLLARSLabel.Location = New System.Drawing.Point(538, 144)
        Me.DOLLARSLabel.Name = "DOLLARSLabel"
        Me.DOLLARSLabel.Size = New System.Drawing.Size(57, 13)
        Me.DOLLARSLabel.TabIndex = 12
        Me.DOLLARSLabel.Text = "DOLLARS"
        '
        'payStrLabel
        '
        Me.payStrLabel.AutoSize = True
        Me.payStrLabel.Location = New System.Drawing.Point(25, 144)
        Me.payStrLabel.Name = "payStrLabel"
        Me.payStrLabel.Size = New System.Drawing.Size(511, 13)
        Me.payStrLabel.TabIndex = 11
        Me.payStrLabel.Text = "_________________________________________________________________________________" &
    "___"
        '
        'payNumLabel
        '
        Me.payNumLabel.AutoSize = True
        Me.payNumLabel.Location = New System.Drawing.Point(510, 115)
        Me.payNumLabel.Name = "payNumLabel"
        Me.payNumLabel.Size = New System.Drawing.Size(85, 13)
        Me.payNumLabel.TabIndex = 10
        Me.payNumLabel.Text = "_____________"
        '
        'empNameTxtBox
        '
        Me.empNameTxtBox.Location = New System.Drawing.Point(175, 103)
        Me.empNameTxtBox.Name = "empNameTxtBox"
        Me.empNameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.empNameTxtBox.TabIndex = 9
        Me.empNameTxtBox.Text = "Employee Name"
        '
        'payToOrderEmployeeNameLabel
        '
        Me.payToOrderEmployeeNameLabel.AutoSize = True
        Me.payToOrderEmployeeNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payToOrderEmployeeNameLabel.Location = New System.Drawing.Point(161, 113)
        Me.payToOrderEmployeeNameLabel.Name = "payToOrderEmployeeNameLabel"
        Me.payToOrderEmployeeNameLabel.Size = New System.Drawing.Size(343, 15)
        Me.payToOrderEmployeeNameLabel.TabIndex = 8
        Me.payToOrderEmployeeNameLabel.Text = "_______________________________________________$"
        Me.payToOrderEmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'payToOrderLabel
        '
        Me.payToOrderLabel.AutoSize = True
        Me.payToOrderLabel.Location = New System.Drawing.Point(25, 103)
        Me.payToOrderLabel.Name = "payToOrderLabel"
        Me.payToOrderLabel.Size = New System.Drawing.Size(130, 13)
        Me.payToOrderLabel.TabIndex = 7
        Me.payToOrderLabel.Text = "PAY TO THE ORDER OF"
        Me.payToOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'datePrintLabel
        '
        Me.datePrintLabel.AutoSize = True
        Me.datePrintLabel.Location = New System.Drawing.Point(447, 63)
        Me.datePrintLabel.Name = "datePrintLabel"
        Me.datePrintLabel.Size = New System.Drawing.Size(66, 13)
        Me.datePrintLabel.TabIndex = 6
        Me.datePrintLabel.Text = "Date Printed"
        '
        'prntDatePicker
        '
        Me.prntDatePicker.CustomFormat = "MM/dd/yy"
        Me.prntDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.prntDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.prntDatePicker.Location = New System.Drawing.Point(519, 57)
        Me.prntDatePicker.Name = "prntDatePicker"
        Me.prntDatePicker.Size = New System.Drawing.Size(83, 20)
        Me.prntDatePicker.TabIndex = 5
        Me.prntDatePicker.Value = New Date(2019, 10, 6, 0, 0, 0, 0)
        '
        'RefNumMTxtBox
        '
        Me.RefNumMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefNumMTxtBox.Location = New System.Drawing.Point(462, 31)
        Me.RefNumMTxtBox.Name = "RefNumMTxtBox"
        Me.RefNumMTxtBox.Size = New System.Drawing.Size(111, 20)
        Me.RefNumMTxtBox.TabIndex = 4
        Me.RefNumMTxtBox.Text = "Ref Num: 024252"
        '
        'bankAddyMTxtBox
        '
        Me.bankAddyMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankAddyMTxtBox.Location = New System.Drawing.Point(245, 45)
        Me.bankAddyMTxtBox.Name = "bankAddyMTxtBox"
        Me.bankAddyMTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.bankAddyMTxtBox.TabIndex = 3
        Me.bankAddyMTxtBox.Text = "Bank Address"
        '
        'bankNameMTxtBox
        '
        Me.bankNameMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankNameMTxtBox.Location = New System.Drawing.Point(245, 19)
        Me.bankNameMTxtBox.Name = "bankNameMTxtBox"
        Me.bankNameMTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.bankNameMTxtBox.TabIndex = 2
        Me.bankNameMTxtBox.Text = "Bank Name"
        '
        'companyAddyMTxtBox
        '
        Me.companyAddyMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyAddyMTxtBox.Location = New System.Drawing.Point(9, 45)
        Me.companyAddyMTxtBox.Name = "companyAddyMTxtBox"
        Me.companyAddyMTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.companyAddyMTxtBox.TabIndex = 1
        Me.companyAddyMTxtBox.Text = "Company Address"
        '
        'companyNameMTxtBox
        '
        Me.companyNameMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyNameMTxtBox.Location = New System.Drawing.Point(9, 19)
        Me.companyNameMTxtBox.Name = "companyNameMTxtBox"
        Me.companyNameMTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.companyNameMTxtBox.TabIndex = 0
        Me.companyNameMTxtBox.Text = "Company Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FuturePay})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(142, 307)
        Me.DataGridView1.TabIndex = 0
        '
        'FuturePay
        '
        Me.FuturePay.HeaderText = "Expected Payroll Rollouts"
        Me.FuturePay.Name = "FuturePay"
        '
        'PrintDocumentPaystub
        '
        Me.PrintDocumentPaystub.DocumentName = "paystub"
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(922, 413)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 17
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'PayrollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 495)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.PayrollFormSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.payrollFormEmployeeSearchLabel)
        Me.Controls.Add(Me.menueStrip)
        Me.Name = "PayrollForm"
        Me.Text = "PayrollForm"
        Me.menueStrip.ResumeLayout(False)
        Me.menueStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.PastPayTab.ResumeLayout(False)
        CType(Me.PayrollDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FuturePayTab.ResumeLayout(False)
        Me.PayStubGroupBox.ResumeLayout(False)
        Me.PayStubGroupBox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents metricsTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents payTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents dashTstripBTN As ToolStripButton
    Private WithEvents menueStrip As ToolStrip
    Friend WithEvents payrollFormEmployeeSearchLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents PayrollFormSearch As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents PastPayTab As TabPage
    Friend WithEvents PayrollDataGridView2 As DataGridView
    Friend WithEvents FuturePayTab As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PastPayDate As DataGridViewTextBoxColumn
    Friend WithEvents HoursWorked As DataGridViewTextBoxColumn
    Friend WithEvents WagesGarnerd As DataGridViewTextBoxColumn
    Friend WithEvents PayStubs As DataGridViewButtonColumn
    Friend WithEvents PayStubGroupBox As GroupBox
    Friend WithEvents bankAddyMTxtBox As MaskedTextBox
    Friend WithEvents bankNameMTxtBox As MaskedTextBox
    Friend WithEvents companyAddyMTxtBox As MaskedTextBox
    Friend WithEvents companyNameMTxtBox As MaskedTextBox
    Friend WithEvents FuturePay As DataGridViewTextBoxColumn
    Friend WithEvents datePrintLabel As Label
    Friend WithEvents prntDatePicker As DateTimePicker
    Friend WithEvents RefNumMTxtBox As MaskedTextBox
    Friend WithEvents payToOrderEmployeeNameLabel As Label
    Friend WithEvents payToOrderLabel As Label
    Friend WithEvents payNumLabel As Label
    Friend WithEvents empNameTxtBox As TextBox
    Friend WithEvents payStrLabel As Label
    Friend WithEvents payStrMTxtBox As MaskedTextBox
    Friend WithEvents DOLLARSLabel As Label
    Friend WithEvents payNumMTxtBox As MaskedTextBox
    Friend WithEvents dateDashLabel As Label
    Friend WithEvents memo As Label
    Friend WithEvents payPeriodLabel As Label
    Friend WithEvents strtPayPeriodDatePicker As DateTimePicker
    Friend WithEvents empAddyMTxtBox As MaskedTextBox
    Friend WithEvents empNameMTxtBox As MaskedTextBox
    Friend WithEvents endPayPeriodDatePicker As DateTimePicker
    Friend WithEvents signatureLabel As Label
    Friend WithEvents accountNumberTxtBox As MaskedTextBox
    Friend WithEvents PrintDocumentPaystub As Printing.PrintDocument
    Friend WithEvents printButton As Button
End Class
