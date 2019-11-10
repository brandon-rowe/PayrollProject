<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayRateCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayRateCalc))
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.metricsTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.dashTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.calcPayBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menueStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Employee_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeLName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WageHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employCalcEditBTN = New System.Windows.Forms.Button()
        Me.menueStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(74, 6)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(74, 6)
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
        Me.menueStrip.TabIndex = 3
        Me.menueStrip.Text = "ToolStrip1"
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Employee_ID, Me.employeeFName, Me.employeeLName, Me.WageHours, Me.Amount})
        Me.DataGridView1.Location = New System.Drawing.Point(203, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(541, 361)
        Me.DataGridView1.TabIndex = 4
        '
        'Employee_ID
        '
        Me.Employee_ID.HeaderText = "Employee ID"
        Me.Employee_ID.Name = "Employee_ID"
        '
        'employeeFName
        '
        Me.employeeFName.HeaderText = "First Name"
        Me.employeeFName.Name = "employeeFName"
        '
        'employeeLName
        '
        Me.employeeLName.HeaderText = "Last Name"
        Me.employeeLName.Name = "employeeLName"
        '
        'WageHours
        '
        Me.WageHours.HeaderText = "Hours Worked"
        Me.WageHours.Name = "WageHours"
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'employCalcEditBTN
        '
        Me.employCalcEditBTN.Location = New System.Drawing.Point(768, 409)
        Me.employCalcEditBTN.Name = "employCalcEditBTN"
        Me.employCalcEditBTN.Size = New System.Drawing.Size(75, 23)
        Me.employCalcEditBTN.TabIndex = 5
        Me.employCalcEditBTN.Text = "Edit"
        Me.employCalcEditBTN.UseVisualStyleBackColor = True
        '
        'EmployPayRateCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.employCalcEditBTN)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.menueStrip)
        Me.Name = "EmployPayRateCalculate"
        Me.Text = "EmployPayRateCalculate"
        Me.menueStrip.ResumeLayout(False)
        Me.menueStrip.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents metricsTstripBTN As ToolStripButton
    Friend WithEvents dashTstripBTN As ToolStripButton
    Friend WithEvents calcPayBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Private WithEvents menueStrip As ToolStrip
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Employee_ID As DataGridViewTextBoxColumn
    Friend WithEvents employeeFName As DataGridViewTextBoxColumn
    Friend WithEvents employeeLName As DataGridViewTextBoxColumn
    Friend WithEvents WageHours As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents employCalcEditBTN As Button
End Class
