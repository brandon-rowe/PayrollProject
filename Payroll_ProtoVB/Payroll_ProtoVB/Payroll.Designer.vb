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
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.payTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dashTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.menueStrip = New System.Windows.Forms.ToolStrip()
        Me.calcPayBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.payrollFormEmployeeSearchLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PayrollFormSearch = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PastPayTab = New System.Windows.Forms.TabPage()
        Me.PayrollDataGridViewPast = New System.Windows.Forms.DataGridView()
        Me.PaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.payStubViewBTN = New System.Windows.Forms.Button()
        Me.EmployeePastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpRecordView = New System.Windows.Forms.Button()
        Me.EmployeePastTableAdapter = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeePastTableAdapter()
        Me.EmployeeFutureTableAdapter = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeeFutureTableAdapter()
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
        Me.menueStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dashTstripBTN, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.payTstripBTN, Me.ToolStripSeparator4, Me.calcPayBTN, Me.ToolStripSeparator7, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.metricsTstripBTN})
        Me.menueStrip.Location = New System.Drawing.Point(0, 0)
        Me.menueStrip.Name = "menueStrip"
        Me.menueStrip.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.menueStrip.Size = New System.Drawing.Size(95, 495)
        Me.menueStrip.Stretch = True
        Me.menueStrip.TabIndex = 3
        Me.menueStrip.Text = "ToolStrip1"
        '
        'calcPayBTN
        '
        Me.calcPayBTN.BackColor = System.Drawing.Color.Honeydew
        Me.calcPayBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.calcPayBTN.Image = CType(resources.GetObject("calcPayBTN.Image"), System.Drawing.Image)
        Me.calcPayBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.calcPayBTN.Name = "calcPayBTN"
        Me.calcPayBTN.Size = New System.Drawing.Size(74, 19)
        Me.calcPayBTN.Text = "Calculate"
        Me.calcPayBTN.ToolTipText = "Payroll"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(74, 6)
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
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(124, 60)
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
        Me.PayrollDataGridViewPast.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
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
        'payStubViewBTN
        '
        Me.payStubViewBTN.Location = New System.Drawing.Point(939, 410)
        Me.payStubViewBTN.Name = "payStubViewBTN"
        Me.payStubViewBTN.Size = New System.Drawing.Size(79, 23)
        Me.payStubViewBTN.TabIndex = 17
        Me.payStubViewBTN.Text = "View Paystub "
        Me.payStubViewBTN.UseVisualStyleBackColor = True
        '
        'EmpRecordView
        '
        Me.EmpRecordView.Location = New System.Drawing.Point(939, 356)
        Me.EmpRecordView.Name = "EmpRecordView"
        Me.EmpRecordView.Size = New System.Drawing.Size(79, 36)
        Me.EmpRecordView.TabIndex = 18
        Me.EmpRecordView.Text = "Employee Detail View"
        Me.EmpRecordView.UseVisualStyleBackColor = True
        '
        'EmployeePastTableAdapter
        '
        Me.EmployeePastTableAdapter.ClearBeforeFill = True
        '
        'EmployeeFutureTableAdapter
        '
        Me.EmployeeFutureTableAdapter.ClearBeforeFill = True
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.EmpRecordView)
        Me.Controls.Add(Me.payStubViewBTN)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.PayrollFormSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.payrollFormEmployeeSearchLabel)
        Me.Controls.Add(Me.menueStrip)
        Me.Name = "Payroll"
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
    Friend WithEvents PayrollDataGridViewPast As DataGridView
    Friend WithEvents FuturePayTab As TabPage
    Friend WithEvents PayrollDataGridViewFuture As DataGridView
    Friend WithEvents PrintDocumentPaystub As Printing.PrintDocument
    Friend WithEvents payStubViewBTN As Button
    Friend WithEvents EmployeePastBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePastBindingSource1 As BindingSource
    Friend WithEvents EmployeeFutureBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents calcPayBTN As ToolStripButton
    Friend WithEvents EmpRecordView As Button
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
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
End Class
