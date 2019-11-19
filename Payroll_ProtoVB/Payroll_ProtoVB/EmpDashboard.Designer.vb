<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpDashboard))
        Me.menueStrip = New System.Windows.Forms.ToolStrip()
        Me.dashBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.payrollBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.calcPayBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.metricsBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritalstatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DependentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SalariedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursworkedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SsnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Primary = New Payroll_ProtoVB.Primary()
        Me.EmployeeTableAdapter = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeeTableAdapter()
        Me.EmpDetailedView = New System.Windows.Forms.Button()
        Me.menueStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menueStrip
        '
        Me.menueStrip.AutoSize = False
        Me.menueStrip.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.menueStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.menueStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dashBTN, Me.ToolStripSeparator1, Me.payrollBTN, Me.ToolStripSeparator2, Me.calcPayBTN, Me.ToolStripSeparator3, Me.metricsBTN, Me.ToolStripSeparator4, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.ExitBtn})
        Me.menueStrip.Location = New System.Drawing.Point(0, 0)
        Me.menueStrip.Name = "menueStrip"
        Me.menueStrip.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.menueStrip.Size = New System.Drawing.Size(95, 465)
        Me.menueStrip.Stretch = True
        Me.menueStrip.TabIndex = 4
        Me.menueStrip.Text = "ToolStrip1"
        '
        'dashBTN
        '
        Me.dashBTN.BackColor = System.Drawing.Color.AliceBlue
        Me.dashBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dashBTN.Image = CType(resources.GetObject("dashBTN.Image"), System.Drawing.Image)
        Me.dashBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dashBTN.Name = "dashBTN"
        Me.dashBTN.Size = New System.Drawing.Size(74, 19)
        Me.dashBTN.Text = "Dashboard"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(74, 6)
        '
        'payrollBTN
        '
        Me.payrollBTN.BackColor = System.Drawing.Color.AliceBlue
        Me.payrollBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.payrollBTN.Image = CType(resources.GetObject("payrollBTN.Image"), System.Drawing.Image)
        Me.payrollBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.payrollBTN.Name = "payrollBTN"
        Me.payrollBTN.Size = New System.Drawing.Size(74, 19)
        Me.payrollBTN.Text = "Payroll"
        Me.payrollBTN.ToolTipText = "Payroll"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(74, 6)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(74, 6)
        '
        'metricsBTN
        '
        Me.metricsBTN.BackColor = System.Drawing.Color.AliceBlue
        Me.metricsBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.metricsBTN.Image = CType(resources.GetObject("metricsBTN.Image"), System.Drawing.Image)
        Me.metricsBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.metricsBTN.Name = "metricsBTN"
        Me.metricsBTN.Size = New System.Drawing.Size(74, 19)
        Me.metricsBTN.Text = "Metrics"
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.MaritalstatusDataGridViewCheckBoxColumn, Me.DependentsDataGridViewTextBoxColumn, Me.AdminDataGridViewCheckBoxColumn, Me.SalariedDataGridViewCheckBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.HourlyrateDataGridViewTextBoxColumn, Me.HoursworkedDataGridViewTextBoxColumn, Me.SsnDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(133, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(858, 397)
        Me.DataGridView1.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'MaritalstatusDataGridViewCheckBoxColumn
        '
        Me.MaritalstatusDataGridViewCheckBoxColumn.DataPropertyName = "maritalstatus"
        Me.MaritalstatusDataGridViewCheckBoxColumn.HeaderText = "maritalstatus"
        Me.MaritalstatusDataGridViewCheckBoxColumn.Name = "MaritalstatusDataGridViewCheckBoxColumn"
        Me.MaritalstatusDataGridViewCheckBoxColumn.Visible = False
        '
        'DependentsDataGridViewTextBoxColumn
        '
        Me.DependentsDataGridViewTextBoxColumn.DataPropertyName = "dependents"
        Me.DependentsDataGridViewTextBoxColumn.HeaderText = "dependents"
        Me.DependentsDataGridViewTextBoxColumn.Name = "DependentsDataGridViewTextBoxColumn"
        Me.DependentsDataGridViewTextBoxColumn.Visible = False
        '
        'AdminDataGridViewCheckBoxColumn
        '
        Me.AdminDataGridViewCheckBoxColumn.DataPropertyName = "admin"
        Me.AdminDataGridViewCheckBoxColumn.HeaderText = "admin"
        Me.AdminDataGridViewCheckBoxColumn.Name = "AdminDataGridViewCheckBoxColumn"
        Me.AdminDataGridViewCheckBoxColumn.Visible = False
        '
        'SalariedDataGridViewCheckBoxColumn
        '
        Me.SalariedDataGridViewCheckBoxColumn.DataPropertyName = "salaried"
        Me.SalariedDataGridViewCheckBoxColumn.HeaderText = "Salaried"
        Me.SalariedDataGridViewCheckBoxColumn.Name = "SalariedDataGridViewCheckBoxColumn"
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        '
        'HourlyrateDataGridViewTextBoxColumn
        '
        Me.HourlyrateDataGridViewTextBoxColumn.DataPropertyName = "hourlyrate"
        Me.HourlyrateDataGridViewTextBoxColumn.HeaderText = "hourlyrate"
        Me.HourlyrateDataGridViewTextBoxColumn.Name = "HourlyrateDataGridViewTextBoxColumn"
        Me.HourlyrateDataGridViewTextBoxColumn.Visible = False
        '
        'HoursworkedDataGridViewTextBoxColumn
        '
        Me.HoursworkedDataGridViewTextBoxColumn.DataPropertyName = "hoursworked"
        Me.HoursworkedDataGridViewTextBoxColumn.HeaderText = "hoursworked"
        Me.HoursworkedDataGridViewTextBoxColumn.Name = "HoursworkedDataGridViewTextBoxColumn"
        Me.HoursworkedDataGridViewTextBoxColumn.Visible = False
        '
        'SsnDataGridViewTextBoxColumn
        '
        Me.SsnDataGridViewTextBoxColumn.DataPropertyName = "ssn"
        Me.SsnDataGridViewTextBoxColumn.HeaderText = "SSN"
        Me.SsnDataGridViewTextBoxColumn.Name = "SsnDataGridViewTextBoxColumn"
        Me.SsnDataGridViewTextBoxColumn.Visible = False
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
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'EmpDetailedView
        '
        Me.EmpDetailedView.Location = New System.Drawing.Point(887, 425)
        Me.EmpDetailedView.Name = "EmpDetailedView"
        Me.EmpDetailedView.Size = New System.Drawing.Size(104, 36)
        Me.EmpDetailedView.TabIndex = 6
        Me.EmpDetailedView.Text = "Manage Employee Information"
        Me.EmpDetailedView.UseVisualStyleBackColor = True
        '
        'EmpDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 465)
        Me.Controls.Add(Me.EmpDetailedView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.menueStrip)
        Me.Name = "EmpDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Dashboard"
        Me.menueStrip.ResumeLayout(False)
        Me.menueStrip.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents menueStrip As ToolStrip
    Friend WithEvents dashBTN As ToolStripButton
    Friend WithEvents payrollBTN As ToolStripButton
    Friend WithEvents calcPayBTN As ToolStripButton
    Friend WithEvents metricsBTN As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Primary As Primary
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As PrimaryTableAdapters.EmployeeTableAdapter
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents EmpDetailedView As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaritalstatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DependentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SalariedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursworkedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SsnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
