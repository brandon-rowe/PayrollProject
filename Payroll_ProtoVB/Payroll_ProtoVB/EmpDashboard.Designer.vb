﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.dashTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.payTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.calcPayBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.metricsTstripBTN = New System.Windows.Forms.ToolStripButton()
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
        Me.btnDetailedView = New System.Windows.Forms.Button()
        Me.menueStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.menueStrip.TabIndex = 4
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
        Me.SalaryDataGridViewTextBoxColumn.Visible = False
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
        'btnDetailedView
        '
        Me.btnDetailedView.Location = New System.Drawing.Point(892, 442)
        Me.btnDetailedView.Name = "btnDetailedView"
        Me.btnDetailedView.Size = New System.Drawing.Size(99, 41)
        Me.btnDetailedView.TabIndex = 6
        Me.btnDetailedView.Text = "Detailed Employee View"
        Me.btnDetailedView.UseVisualStyleBackColor = True
        '
        'EmpDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.btnDetailedView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.menueStrip)
        Me.Name = "EmpDashboard"
        Me.Text = "EmpDashboard"
        Me.menueStrip.ResumeLayout(False)
        Me.menueStrip.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents menueStrip As ToolStrip
    Friend WithEvents dashTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents payTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents calcPayBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents metricsTstripBTN As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Primary As Primary
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As PrimaryTableAdapters.EmployeeTableAdapter
    Friend WithEvents btnDetailedView As Button
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
