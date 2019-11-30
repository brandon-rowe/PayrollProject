<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayStub
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayStub))
        Me.PayStubGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.RichTextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.signatureLabel = New System.Windows.Forms.Label()
        Me.accountNumberTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.endPayPeriodDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.dateDashLabel = New System.Windows.Forms.Label()
        Me.memo = New System.Windows.Forms.Label()
        Me.payPeriodLabel = New System.Windows.Forms.Label()
        Me.strtPayPeriodDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.empAddyMTxtBox = New System.Windows.Forms.MaskedTextBox()
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
        Me.printStubBTN = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Primary = New Payroll_ProtoVB.Primary()
        Me.EmployeeFutureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeFutureTableAdapter = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeeFutureTableAdapter()
        Me.EmployeePastTableAdapter1 = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeePastTableAdapter()
        Me.EmployeePastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Payroll_ProtoVB.PrimaryTableAdapters.EmployeeTableAdapter()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.dashTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.payTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.calcPayBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.metricsTstripBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.menueStrip = New System.Windows.Forms.ToolStrip()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.FeedbackLogsTableAdapter1 = New Payroll_ProtoVB.PrimaryTableAdapters.FeedbackLogsTableAdapter()
        Me.PayStubGroupBox.SuspendLayout()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeFutureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeePastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menueStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PayStubGroupBox
        '
        Me.PayStubGroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.PayStubGroupBox.Controls.Add(Me.TextBox5)
        Me.PayStubGroupBox.Controls.Add(Me.TextBox4)
        Me.PayStubGroupBox.Controls.Add(Me.TextBox2)
        Me.PayStubGroupBox.Controls.Add(Me.TextBox3)
        Me.PayStubGroupBox.Controls.Add(Me.TextBox1)
        Me.PayStubGroupBox.Controls.Add(Me.Label1)
        Me.PayStubGroupBox.Controls.Add(Me.signatureLabel)
        Me.PayStubGroupBox.Controls.Add(Me.accountNumberTxtBox)
        Me.PayStubGroupBox.Controls.Add(Me.endPayPeriodDatePicker)
        Me.PayStubGroupBox.Controls.Add(Me.dateDashLabel)
        Me.PayStubGroupBox.Controls.Add(Me.memo)
        Me.PayStubGroupBox.Controls.Add(Me.payPeriodLabel)
        Me.PayStubGroupBox.Controls.Add(Me.strtPayPeriodDatePicker)
        Me.PayStubGroupBox.Controls.Add(Me.empAddyMTxtBox)
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
        Me.PayStubGroupBox.Enabled = False
        Me.PayStubGroupBox.Location = New System.Drawing.Point(224, 94)
        Me.PayStubGroupBox.Name = "PayStubGroupBox"
        Me.PayStubGroupBox.Size = New System.Drawing.Size(631, 307)
        Me.PayStubGroupBox.TabIndex = 4
        Me.PayStubGroupBox.TabStop = False
        Me.PayStubGroupBox.Text = "PayStub"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(445, 190)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TextBox5.Size = New System.Drawing.Size(113, 26)
        Me.TextBox5.TabIndex = 30
        Me.TextBox5.Text = "Bob Burger"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(581, 19)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(20, 20)
        Me.TextBox4.TabIndex = 28
        Me.TextBox4.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(125, 173)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(52, 20)
        Me.TextBox2.TabIndex = 27
        Me.TextBox2.Text = "Last Name"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(67, 173)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(52, 20)
        Me.TextBox3.TabIndex = 26
        Me.TextBox3.Text = "First Name"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(233, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(52, 20)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(374, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Endorse___________________________"
        '
        'signatureLabel
        '
        Me.signatureLabel.AutoSize = True
        Me.signatureLabel.Enabled = False
        Me.signatureLabel.Location = New System.Drawing.Point(374, 206)
        Me.signatureLabel.Name = "signatureLabel"
        Me.signatureLabel.Size = New System.Drawing.Size(210, 13)
        Me.signatureLabel.TabIndex = 23
        Me.signatureLabel.Text = "SIGNED___________________________"
        '
        'accountNumberTxtBox
        '
        Me.accountNumberTxtBox.Enabled = False
        Me.accountNumberTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountNumberTxtBox.Location = New System.Drawing.Point(28, 284)
        Me.accountNumberTxtBox.Name = "accountNumberTxtBox"
        Me.accountNumberTxtBox.Size = New System.Drawing.Size(235, 20)
        Me.accountNumberTxtBox.TabIndex = 22
        Me.accountNumberTxtBox.Text = "Acc Num: 0242528735571L0008993"
        Me.accountNumberTxtBox.Visible = False
        '
        'endPayPeriodDatePicker
        '
        Me.endPayPeriodDatePicker.CustomFormat = "MM/dd/yy"
        Me.endPayPeriodDatePicker.Enabled = False
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
        Me.dateDashLabel.Enabled = False
        Me.dateDashLabel.Location = New System.Drawing.Point(236, 259)
        Me.dateDashLabel.Name = "dateDashLabel"
        Me.dateDashLabel.Size = New System.Drawing.Size(10, 13)
        Me.dateDashLabel.TabIndex = 20
        Me.dateDashLabel.Text = "-"
        '
        'memo
        '
        Me.memo.AutoSize = True
        Me.memo.Enabled = False
        Me.memo.Location = New System.Drawing.Point(9, 253)
        Me.memo.Name = "memo"
        Me.memo.Size = New System.Drawing.Size(40, 13)
        Me.memo.TabIndex = 19
        Me.memo.Text = "MEMO"
        '
        'payPeriodLabel
        '
        Me.payPeriodLabel.AutoSize = True
        Me.payPeriodLabel.Enabled = False
        Me.payPeriodLabel.Location = New System.Drawing.Point(77, 253)
        Me.payPeriodLabel.Name = "payPeriodLabel"
        Me.payPeriodLabel.Size = New System.Drawing.Size(61, 13)
        Me.payPeriodLabel.TabIndex = 18
        Me.payPeriodLabel.Text = "Pay Period:"
        '
        'strtPayPeriodDatePicker
        '
        Me.strtPayPeriodDatePicker.CustomFormat = "MM/dd/yy"
        Me.strtPayPeriodDatePicker.Enabled = False
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
        Me.empAddyMTxtBox.Enabled = False
        Me.empAddyMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empAddyMTxtBox.Location = New System.Drawing.Point(67, 199)
        Me.empAddyMTxtBox.Name = "empAddyMTxtBox"
        Me.empAddyMTxtBox.Size = New System.Drawing.Size(236, 20)
        Me.empAddyMTxtBox.TabIndex = 16
        Me.empAddyMTxtBox.Text = "Employee Address"
        '
        'payNumMTxtBox
        '
        Me.payNumMTxtBox.Enabled = False
        Me.payNumMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payNumMTxtBox.Location = New System.Drawing.Point(513, 103)
        Me.payNumMTxtBox.Name = "payNumMTxtBox"
        Me.payNumMTxtBox.Size = New System.Drawing.Size(82, 20)
        Me.payNumMTxtBox.TabIndex = 14
        Me.payNumMTxtBox.Text = "**100.43"
        '
        'payStrMTxtBox
        '
        Me.payStrMTxtBox.Enabled = False
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
        Me.DOLLARSLabel.Enabled = False
        Me.DOLLARSLabel.Location = New System.Drawing.Point(538, 144)
        Me.DOLLARSLabel.Name = "DOLLARSLabel"
        Me.DOLLARSLabel.Size = New System.Drawing.Size(57, 13)
        Me.DOLLARSLabel.TabIndex = 12
        Me.DOLLARSLabel.Text = "DOLLARS"
        '
        'payStrLabel
        '
        Me.payStrLabel.AutoSize = True
        Me.payStrLabel.Enabled = False
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
        Me.payNumLabel.Enabled = False
        Me.payNumLabel.Location = New System.Drawing.Point(510, 115)
        Me.payNumLabel.Name = "payNumLabel"
        Me.payNumLabel.Size = New System.Drawing.Size(85, 13)
        Me.payNumLabel.TabIndex = 10
        Me.payNumLabel.Text = "_____________"
        '
        'empNameTxtBox
        '
        Me.empNameTxtBox.Enabled = False
        Me.empNameTxtBox.Location = New System.Drawing.Point(175, 103)
        Me.empNameTxtBox.Name = "empNameTxtBox"
        Me.empNameTxtBox.Size = New System.Drawing.Size(52, 20)
        Me.empNameTxtBox.TabIndex = 9
        Me.empNameTxtBox.Text = "First Name"
        '
        'payToOrderEmployeeNameLabel
        '
        Me.payToOrderEmployeeNameLabel.AutoSize = True
        Me.payToOrderEmployeeNameLabel.Enabled = False
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
        Me.payToOrderLabel.Enabled = False
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
        Me.datePrintLabel.Enabled = False
        Me.datePrintLabel.Location = New System.Drawing.Point(447, 63)
        Me.datePrintLabel.Name = "datePrintLabel"
        Me.datePrintLabel.Size = New System.Drawing.Size(66, 13)
        Me.datePrintLabel.TabIndex = 6
        Me.datePrintLabel.Text = "Date Printed"
        '
        'prntDatePicker
        '
        Me.prntDatePicker.CustomFormat = "MM/dd/yy"
        Me.prntDatePicker.Enabled = False
        Me.prntDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.prntDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.prntDatePicker.Location = New System.Drawing.Point(519, 57)
        Me.prntDatePicker.Name = "prntDatePicker"
        Me.prntDatePicker.Size = New System.Drawing.Size(83, 20)
        Me.prntDatePicker.TabIndex = 5
        Me.prntDatePicker.Value = New Date(2019, 11, 20, 0, 0, 0, 0)
        '
        'RefNumMTxtBox
        '
        Me.RefNumMTxtBox.Enabled = False
        Me.RefNumMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefNumMTxtBox.Location = New System.Drawing.Point(513, 19)
        Me.RefNumMTxtBox.Name = "RefNumMTxtBox"
        Me.RefNumMTxtBox.Size = New System.Drawing.Size(62, 20)
        Me.RefNumMTxtBox.TabIndex = 4
        Me.RefNumMTxtBox.Text = "Check #:"
        '
        'bankAddyMTxtBox
        '
        Me.bankAddyMTxtBox.Enabled = False
        Me.bankAddyMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankAddyMTxtBox.Location = New System.Drawing.Point(214, 45)
        Me.bankAddyMTxtBox.Name = "bankAddyMTxtBox"
        Me.bankAddyMTxtBox.Size = New System.Drawing.Size(211, 20)
        Me.bankAddyMTxtBox.TabIndex = 3
        Me.bankAddyMTxtBox.Text = "2344 Lincoln Ave. Spartanburg, SC 29316"
        '
        'bankNameMTxtBox
        '
        Me.bankNameMTxtBox.Enabled = False
        Me.bankNameMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankNameMTxtBox.Location = New System.Drawing.Point(214, 19)
        Me.bankNameMTxtBox.Name = "bankNameMTxtBox"
        Me.bankNameMTxtBox.Size = New System.Drawing.Size(114, 20)
        Me.bankNameMTxtBox.TabIndex = 2
        Me.bankNameMTxtBox.Text = "United Union Bank"
        '
        'companyAddyMTxtBox
        '
        Me.companyAddyMTxtBox.Enabled = False
        Me.companyAddyMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyAddyMTxtBox.Location = New System.Drawing.Point(9, 45)
        Me.companyAddyMTxtBox.Name = "companyAddyMTxtBox"
        Me.companyAddyMTxtBox.Size = New System.Drawing.Size(181, 20)
        Me.companyAddyMTxtBox.TabIndex = 1
        Me.companyAddyMTxtBox.Text = "452 Newt Lane Chesnee, SC 29323"
        '
        'companyNameMTxtBox
        '
        Me.companyNameMTxtBox.Enabled = False
        Me.companyNameMTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyNameMTxtBox.Location = New System.Drawing.Point(9, 19)
        Me.companyNameMTxtBox.Name = "companyNameMTxtBox"
        Me.companyNameMTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.companyNameMTxtBox.TabIndex = 0
        Me.companyNameMTxtBox.Text = "Bob's Company"
        '
        'printStubBTN
        '
        Me.printStubBTN.Location = New System.Drawing.Point(776, 408)
        Me.printStubBTN.Name = "printStubBTN"
        Me.printStubBTN.Size = New System.Drawing.Size(79, 23)
        Me.printStubBTN.TabIndex = 18
        Me.printStubBTN.Text = "Print"
        Me.printStubBTN.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(686, 408)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(79, 23)
        Me.Cancel.TabIndex = 19
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Primary
        '
        Me.Primary.DataSetName = "Primary"
        Me.Primary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeFutureBindingSource
        '
        Me.EmployeeFutureBindingSource.DataMember = "EmployeeFuture"
        Me.EmployeeFutureBindingSource.DataSource = Me.Primary
        '
        'EmployeeFutureTableAdapter
        '
        Me.EmployeeFutureTableAdapter.ClearBeforeFill = True
        '
        'EmployeePastTableAdapter1
        '
        Me.EmployeePastTableAdapter1.ClearBeforeFill = True
        '
        'EmployeePastBindingSource
        '
        Me.EmployeePastBindingSource.DataMember = "EmployeePast"
        Me.EmployeePastBindingSource.DataSource = Me.Primary
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Primary
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(74, 6)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(74, 6)
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(74, 6)
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
        'menueStrip
        '
        Me.menueStrip.AutoSize = False
        Me.menueStrip.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.menueStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.menueStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dashTstripBTN, Me.ToolStripSeparator3, Me.payTstripBTN, Me.ToolStripSeparator4, Me.calcPayBTN, Me.ToolStripSeparator5, Me.metricsTstripBTN, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripSeparator6, Me.ExitBtn})
        Me.menueStrip.Location = New System.Drawing.Point(0, 0)
        Me.menueStrip.Name = "menueStrip"
        Me.menueStrip.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.menueStrip.Size = New System.Drawing.Size(95, 495)
        Me.menueStrip.Stretch = True
        Me.menueStrip.TabIndex = 5
        Me.menueStrip.Text = "ToolStrip1"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FeedbackLogsTableAdapter1
        '
        Me.FeedbackLogsTableAdapter1.ClearBeforeFill = True
        '
        'PayStub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1028, 495)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.printStubBTN)
        Me.Controls.Add(Me.menueStrip)
        Me.Controls.Add(Me.PayStubGroupBox)
        Me.Name = "PayStub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayStubForm"
        Me.PayStubGroupBox.ResumeLayout(False)
        Me.PayStubGroupBox.PerformLayout()
        CType(Me.Primary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeFutureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeePastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menueStrip.ResumeLayout(False)
        Me.menueStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PayStubGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents signatureLabel As Label
    Friend WithEvents accountNumberTxtBox As MaskedTextBox
    Friend WithEvents endPayPeriodDatePicker As DateTimePicker
    Friend WithEvents dateDashLabel As Label
    Friend WithEvents memo As Label
    Friend WithEvents payPeriodLabel As Label
    Friend WithEvents strtPayPeriodDatePicker As DateTimePicker
    Friend WithEvents empAddyMTxtBox As MaskedTextBox
    Friend WithEvents payNumMTxtBox As MaskedTextBox
    Friend WithEvents payStrMTxtBox As MaskedTextBox
    Friend WithEvents DOLLARSLabel As Label
    Friend WithEvents payStrLabel As Label
    Friend WithEvents payNumLabel As Label
    Friend WithEvents empNameTxtBox As TextBox
    Friend WithEvents payToOrderEmployeeNameLabel As Label
    Friend WithEvents payToOrderLabel As Label
    Friend WithEvents datePrintLabel As Label
    Friend WithEvents prntDatePicker As DateTimePicker
    Friend WithEvents RefNumMTxtBox As MaskedTextBox
    Friend WithEvents bankAddyMTxtBox As MaskedTextBox
    Friend WithEvents bankNameMTxtBox As MaskedTextBox
    Friend WithEvents companyAddyMTxtBox As MaskedTextBox
    Friend WithEvents companyNameMTxtBox As MaskedTextBox
    Friend WithEvents printStubBTN As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Primary As Primary
    Friend WithEvents EmployeeFutureBindingSource As BindingSource
    Friend WithEvents EmployeeFutureTableAdapter As PrimaryTableAdapters.EmployeeFutureTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents EmployeePastTableAdapter1 As PrimaryTableAdapters.EmployeePastTableAdapter
    Friend WithEvents EmployeePastBindingSource As BindingSource
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As PrimaryTableAdapters.EmployeeTableAdapter
    Friend WithEvents TextBox4 As TextBox
    ' Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Private WithEvents menueStrip As ToolStrip
    Friend WithEvents dashTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents payTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents calcPayBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents metricsTstripBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents TextBox5 As RichTextBox
    Friend WithEvents FeedbackLogsTableAdapter1 As PrimaryTableAdapters.FeedbackLogsTableAdapter
End Class
