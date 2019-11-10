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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePastBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuturePayTab = New System.Windows.Forms.TabPage()
        Me.PayrollDataGridViewFuture = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeFutureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDocumentPaystub = New System.Drawing.Printing.PrintDocument()
        Me.payStubViewBTN = New System.Windows.Forms.Button()
        Me.EmployeePastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.menueStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.PastPayTab.SuspendLayout()
        CType(Me.PayrollDataGridViewPast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeePastBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FuturePayTab.SuspendLayout()
        CType(Me.PayrollDataGridViewFuture, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PayrollDataGridViewPast.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PayrollDataGridViewPast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrollDataGridViewPast.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.PayrollDataGridViewPast.DataSource = Me.EmployeePastBindingSource1
        Me.PayrollDataGridViewPast.Location = New System.Drawing.Point(-3, -3)
        Me.PayrollDataGridViewPast.Name = "PayrollDataGridViewPast"
        Me.PayrollDataGridViewPast.Size = New System.Drawing.Size(796, 307)
        Me.PayrollDataGridViewPast.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'EmployeePastBindingSource1
        '
        Me.EmployeePastBindingSource1.DataMember = "EmployeePast"

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
        Me.PayrollDataGridViewFuture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrollDataGridViewFuture.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.DateDataGridViewTextBoxColumn1, Me.AmountDataGridViewTextBoxColumn1})
        Me.PayrollDataGridViewFuture.DataSource = Me.EmployeeFutureBindingSource
        Me.PayrollDataGridViewFuture.Location = New System.Drawing.Point(3, 0)
        Me.PayrollDataGridViewFuture.Name = "PayrollDataGridViewFuture"
        Me.PayrollDataGridViewFuture.Size = New System.Drawing.Size(787, 307)
        Me.PayrollDataGridViewFuture.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'DateDataGridViewTextBoxColumn1
        '
        Me.DateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateDataGridViewTextBoxColumn1.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn1.Name = "DateDataGridViewTextBoxColumn1"
        '
        'AmountDataGridViewTextBoxColumn1
        '
        Me.AmountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountDataGridViewTextBoxColumn1.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn1.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn1.Name = "AmountDataGridViewTextBoxColumn1"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(939, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 36)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Employee Detail View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PayrollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.payStubViewBTN)
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
        CType(Me.PayrollDataGridViewPast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeePastBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FuturePayTab.ResumeLayout(False)
        CType(Me.PayrollDataGridViewFuture, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
End Class
