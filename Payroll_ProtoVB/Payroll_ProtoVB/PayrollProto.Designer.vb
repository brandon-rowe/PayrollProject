<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayrollProto
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollProto))
        Me.dashboardEmployeeMGMTButton = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wages = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverTimePay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalWagesAcrrude = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menueStrip = New System.Windows.Forms.ToolStrip()
        Me.dashTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.payTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.metricsTstripBTN = New System.Windows.Forms.ToolStripButton()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menueStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'dashboardEmployeeMGMTButton
        '
        Me.dashboardEmployeeMGMTButton.Location = New System.Drawing.Point(955, 391)
        Me.dashboardEmployeeMGMTButton.Name = "dashboardEmployeeMGMTButton"
        Me.dashboardEmployeeMGMTButton.Size = New System.Drawing.Size(93, 37)
        Me.dashboardEmployeeMGMTButton.TabIndex = 5
        Me.dashboardEmployeeMGMTButton.Text = "Manage Employee Data"
        Me.dashboardEmployeeMGMTButton.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Employee, Me.Salary, Me.Wages, Me.OverTimePay, Me.totalWagesAcrrude})
        Me.dataGridView1.GridColor = System.Drawing.Color.Teal
        Me.dataGridView1.Location = New System.Drawing.Point(157, 49)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(783, 379)
        Me.dataGridView1.TabIndex = 4
        '
        'Employee
        '
        Me.Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Employee.HeaderText = "Employee"
        Me.Employee.Name = "Employee"
        '
        'Salary
        '
        Me.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Salary.HeaderText = "Salary"
        Me.Salary.Name = "Salary"
        '
        'Wages
        '
        Me.Wages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Wages.HeaderText = "Payable Hours"
        Me.Wages.Name = "Wages"
        '
        'OverTimePay
        '
        Me.OverTimePay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OverTimePay.HeaderText = "OverTime "
        Me.OverTimePay.Name = "OverTimePay"
        '
        'totalWagesAcrrude
        '
        Me.totalWagesAcrrude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.totalWagesAcrrude.HeaderText = "Total Wages Accrude"
        Me.totalWagesAcrrude.Name = "totalWagesAcrrude"
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
        Me.menueStrip.TabIndex = 2
        Me.menueStrip.Text = "ToolStrip1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(74, 6)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(74, 6)
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
        'PayrollProto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1079, 495)
        Me.Controls.Add(Me.menueStrip)
        Me.Controls.Add(Me.dashboardEmployeeMGMTButton)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "PayrollProto"
        Me.Text = "PayrollProto-Dash"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menueStrip.ResumeLayout(False)
        Me.menueStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dashboardEmployeeMGMTButton As Button
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents Employee As DataGridViewTextBoxColumn
    Private WithEvents Salary As DataGridViewTextBoxColumn
    Private WithEvents Wages As DataGridViewTextBoxColumn
    Private WithEvents OverTimePay As DataGridViewTextBoxColumn
    Private WithEvents totalWagesAcrrude As DataGridViewTextBoxColumn
    Friend WithEvents dashTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents payTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents metricsTstripBTN As ToolStripButton
    Private WithEvents menueStrip As ToolStrip
End Class
