<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailedPaymentRecordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailedPaymentRecordForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menueStrip = New System.Windows.Forms.ToolStrip()
        Me.dashTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.calcPayBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.metricsTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.EmployeeIDTxtBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormLastNameTxtBox = New System.Windows.Forms.TextBox()
        Me.employeeMGMTFormLastNameLabel = New System.Windows.Forms.Label()
        Me.employeeMGMTFormFirstNameTxtBox = New System.Windows.Forms.TextBox()
        Me.employeeMGMTFormFirstNameLabel = New System.Windows.Forms.Label()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.endPayPeriodDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.dateDashLabel = New System.Windows.Forms.Label()
        Me.strtPayPeriodDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateRangeLabel = New System.Windows.Forms.Label()
        Me.startDateLabel = New System.Windows.Forms.Label()
        Me.endDateLabel = New System.Windows.Forms.Label()
        Me.populateTabelBTN = New System.Windows.Forms.Button()
        Me.backBTN = New System.Windows.Forms.Button()
        Me.menueStrip.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menueStrip
        '
        Me.menueStrip.AutoSize = False
        Me.menueStrip.BackColor = System.Drawing.Color.Teal
        Me.menueStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.menueStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dashTstripBTN, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.calcPayBTN, Me.ToolStripSeparator5, Me.ToolStripSeparator7, Me.ToolStripSeparator6, Me.metricsTstripBTN})
        Me.menueStrip.Location = New System.Drawing.Point(0, 0)
        Me.menueStrip.Name = "menueStrip"
        Me.menueStrip.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.menueStrip.Size = New System.Drawing.Size(95, 495)
        Me.menueStrip.Stretch = True
        Me.menueStrip.TabIndex = 6
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Honeydew
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(74, 19)
        Me.ToolStripButton1.Text = "Payroll"
        Me.ToolStripButton1.ToolTipText = "Payroll"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(74, 6)
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(74, 6)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(74, 6)
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
        'EmployeeIDTxtBox
        '
        Me.EmployeeIDTxtBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.EmployeeIDTxtBox.Enabled = False
        Me.EmployeeIDTxtBox.Location = New System.Drawing.Point(251, 31)
        Me.EmployeeIDTxtBox.Name = "EmployeeIDTxtBox"
        Me.EmployeeIDTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.EmployeeIDTxtBox.TabIndex = 84
        Me.EmployeeIDTxtBox.Visible = False
        '
        'EmployeeIDLabel
        '
        Me.EmployeeIDLabel.AutoSize = True
        Me.EmployeeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDLabel.Location = New System.Drawing.Point(123, 31)
        Me.EmployeeIDLabel.Name = "EmployeeIDLabel"
        Me.EmployeeIDLabel.Size = New System.Drawing.Size(111, 20)
        Me.EmployeeIDLabel.TabIndex = 83
        Me.EmployeeIDLabel.Text = "Employee ID"
        Me.EmployeeIDLabel.Visible = False
        '
        'employeeMGMTFormLastNameTxtBox
        '
        Me.employeeMGMTFormLastNameTxtBox.Enabled = False
        Me.employeeMGMTFormLastNameTxtBox.Location = New System.Drawing.Point(252, 97)
        Me.employeeMGMTFormLastNameTxtBox.Name = "employeeMGMTFormLastNameTxtBox"
        Me.employeeMGMTFormLastNameTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.employeeMGMTFormLastNameTxtBox.TabIndex = 88
        Me.employeeMGMTFormLastNameTxtBox.Visible = False
        '
        'employeeMGMTFormLastNameLabel
        '
        Me.employeeMGMTFormLastNameLabel.AutoSize = True
        Me.employeeMGMTFormLastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormLastNameLabel.Location = New System.Drawing.Point(124, 97)
        Me.employeeMGMTFormLastNameLabel.Name = "employeeMGMTFormLastNameLabel"
        Me.employeeMGMTFormLastNameLabel.Size = New System.Drawing.Size(95, 20)
        Me.employeeMGMTFormLastNameLabel.TabIndex = 87
        Me.employeeMGMTFormLastNameLabel.Text = "Last Name"
        Me.employeeMGMTFormLastNameLabel.Visible = False
        '
        'employeeMGMTFormFirstNameTxtBox
        '
        Me.employeeMGMTFormFirstNameTxtBox.Enabled = False
        Me.employeeMGMTFormFirstNameTxtBox.Location = New System.Drawing.Point(252, 65)
        Me.employeeMGMTFormFirstNameTxtBox.Name = "employeeMGMTFormFirstNameTxtBox"
        Me.employeeMGMTFormFirstNameTxtBox.Size = New System.Drawing.Size(121, 20)
        Me.employeeMGMTFormFirstNameTxtBox.TabIndex = 86
        Me.employeeMGMTFormFirstNameTxtBox.Visible = False
        '
        'employeeMGMTFormFirstNameLabel
        '
        Me.employeeMGMTFormFirstNameLabel.AutoSize = True
        Me.employeeMGMTFormFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeMGMTFormFirstNameLabel.Location = New System.Drawing.Point(123, 65)
        Me.employeeMGMTFormFirstNameLabel.Name = "employeeMGMTFormFirstNameLabel"
        Me.employeeMGMTFormFirstNameLabel.Size = New System.Drawing.Size(96, 20)
        Me.employeeMGMTFormFirstNameLabel.TabIndex = 85
        Me.employeeMGMTFormFirstNameLabel.Text = "First Name"
        Me.employeeMGMTFormFirstNameLabel.Visible = False
        '
        'dataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.GridColor = System.Drawing.Color.Teal
        Me.dataGridView1.Location = New System.Drawing.Point(398, 31)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(546, 391)
        Me.dataGridView1.TabIndex = 89
        '
        'endPayPeriodDatePicker
        '
        Me.endPayPeriodDatePicker.CustomFormat = "MM/dd/yy"
        Me.endPayPeriodDatePicker.Enabled = False
        Me.endPayPeriodDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endPayPeriodDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.endPayPeriodDatePicker.Location = New System.Drawing.Point(289, 186)
        Me.endPayPeriodDatePicker.Name = "endPayPeriodDatePicker"
        Me.endPayPeriodDatePicker.Size = New System.Drawing.Size(83, 20)
        Me.endPayPeriodDatePicker.TabIndex = 92
        Me.endPayPeriodDatePicker.Value = New Date(2019, 10, 6, 0, 0, 0, 0)
        '
        'dateDashLabel
        '
        Me.dateDashLabel.AutoSize = True
        Me.dateDashLabel.Enabled = False
        Me.dateDashLabel.Location = New System.Drawing.Point(273, 192)
        Me.dateDashLabel.Name = "dateDashLabel"
        Me.dateDashLabel.Size = New System.Drawing.Size(10, 13)
        Me.dateDashLabel.TabIndex = 91
        Me.dateDashLabel.Text = "-"
        '
        'strtPayPeriodDatePicker
        '
        Me.strtPayPeriodDatePicker.CustomFormat = "MM/dd/yy"
        Me.strtPayPeriodDatePicker.Enabled = False
        Me.strtPayPeriodDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.strtPayPeriodDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.strtPayPeriodDatePicker.Location = New System.Drawing.Point(181, 186)
        Me.strtPayPeriodDatePicker.Name = "strtPayPeriodDatePicker"
        Me.strtPayPeriodDatePicker.Size = New System.Drawing.Size(83, 20)
        Me.strtPayPeriodDatePicker.TabIndex = 90
        Me.strtPayPeriodDatePicker.Value = New Date(2019, 10, 6, 0, 0, 0, 0)
        '
        'DateRangeLabel
        '
        Me.DateRangeLabel.AutoSize = True
        Me.DateRangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRangeLabel.Location = New System.Drawing.Point(124, 133)
        Me.DateRangeLabel.Name = "DateRangeLabel"
        Me.DateRangeLabel.Size = New System.Drawing.Size(106, 20)
        Me.DateRangeLabel.TabIndex = 93
        Me.DateRangeLabel.Text = "Date Range"
        Me.DateRangeLabel.Visible = False
        '
        'startDateLabel
        '
        Me.startDateLabel.AutoSize = True
        Me.startDateLabel.Enabled = False
        Me.startDateLabel.Location = New System.Drawing.Point(178, 170)
        Me.startDateLabel.Name = "startDateLabel"
        Me.startDateLabel.Size = New System.Drawing.Size(32, 13)
        Me.startDateLabel.TabIndex = 94
        Me.startDateLabel.Text = "Start:"
        '
        'endDateLabel
        '
        Me.endDateLabel.AutoSize = True
        Me.endDateLabel.Enabled = False
        Me.endDateLabel.Location = New System.Drawing.Point(286, 170)
        Me.endDateLabel.Name = "endDateLabel"
        Me.endDateLabel.Size = New System.Drawing.Size(26, 13)
        Me.endDateLabel.TabIndex = 95
        Me.endDateLabel.Text = "End"
        '
        'populateTabelBTN
        '
        Me.populateTabelBTN.Location = New System.Drawing.Point(293, 222)
        Me.populateTabelBTN.Name = "populateTabelBTN"
        Me.populateTabelBTN.Size = New System.Drawing.Size(79, 23)
        Me.populateTabelBTN.TabIndex = 96
        Me.populateTabelBTN.Text = "Continue"
        Me.populateTabelBTN.UseVisualStyleBackColor = True
        '
        'backBTN
        '
        Me.backBTN.Location = New System.Drawing.Point(110, 399)
        Me.backBTN.Name = "backBTN"
        Me.backBTN.Size = New System.Drawing.Size(79, 23)
        Me.backBTN.TabIndex = 97
        Me.backBTN.Text = "Back"
        Me.backBTN.UseVisualStyleBackColor = True
        '
        'DetailedPaymentRecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.backBTN)
        Me.Controls.Add(Me.populateTabelBTN)
        Me.Controls.Add(Me.endDateLabel)
        Me.Controls.Add(Me.startDateLabel)
        Me.Controls.Add(Me.DateRangeLabel)
        Me.Controls.Add(Me.endPayPeriodDatePicker)
        Me.Controls.Add(Me.dateDashLabel)
        Me.Controls.Add(Me.strtPayPeriodDatePicker)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.employeeMGMTFormLastNameTxtBox)
        Me.Controls.Add(Me.employeeMGMTFormLastNameLabel)
        Me.Controls.Add(Me.employeeMGMTFormFirstNameTxtBox)
        Me.Controls.Add(Me.employeeMGMTFormFirstNameLabel)
        Me.Controls.Add(Me.EmployeeIDTxtBox)
        Me.Controls.Add(Me.EmployeeIDLabel)
        Me.Controls.Add(Me.menueStrip)
        Me.Name = "DetailedPaymentRecordForm"
        Me.Text = "DetailedPaymentRecordForm"
        Me.menueStrip.ResumeLayout(False)
        Me.menueStrip.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menueStrip As ToolStrip
    Friend WithEvents dashTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents calcPayBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents metricsTstripBTN As ToolStripButton
    Private WithEvents EmployeeIDTxtBox As TextBox
    Private WithEvents EmployeeIDLabel As Label
    Private WithEvents employeeMGMTFormLastNameTxtBox As TextBox
    Private WithEvents employeeMGMTFormLastNameLabel As Label
    Private WithEvents employeeMGMTFormFirstNameTxtBox As TextBox
    Private WithEvents employeeMGMTFormFirstNameLabel As Label
    Private WithEvents dataGridView1 As DataGridView
    Friend WithEvents endPayPeriodDatePicker As DateTimePicker
    Friend WithEvents dateDashLabel As Label
    Friend WithEvents strtPayPeriodDatePicker As DateTimePicker
    Private WithEvents DateRangeLabel As Label
    Friend WithEvents startDateLabel As Label
    Friend WithEvents endDateLabel As Label
    Friend WithEvents populateTabelBTN As Button
    Friend WithEvents backBTN As Button
End Class
