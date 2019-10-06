<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyInfoForm
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
        Me.CompanyInformationFormBackButton = New System.Windows.Forms.Button()
        Me.CompanyInfoFormNextButton = New System.Windows.Forms.Button()
        Me.CompanyTypeLabel = New System.Windows.Forms.Label()
        Me.companyTypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.checkBoxNumEmployee3 = New System.Windows.Forms.CheckBox()
        Me.checkBoxNumEmployee2 = New System.Windows.Forms.CheckBox()
        Me.checkBoxNumEmployee1 = New System.Windows.Forms.CheckBox()
        Me.NumEmployeesLabel = New System.Windows.Forms.Label()
        Me.CnameTxtBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CompanyInformationFormBackButton
        '
        Me.CompanyInformationFormBackButton.Location = New System.Drawing.Point(819, 426)
        Me.CompanyInformationFormBackButton.Name = "CompanyInformationFormBackButton"
        Me.CompanyInformationFormBackButton.Size = New System.Drawing.Size(75, 23)
        Me.CompanyInformationFormBackButton.TabIndex = 20
        Me.CompanyInformationFormBackButton.Text = "Back"
        Me.CompanyInformationFormBackButton.UseVisualStyleBackColor = True
        '
        'CompanyInfoFormNextButton
        '
        Me.CompanyInfoFormNextButton.Location = New System.Drawing.Point(921, 426)
        Me.CompanyInfoFormNextButton.Name = "CompanyInfoFormNextButton"
        Me.CompanyInfoFormNextButton.Size = New System.Drawing.Size(75, 23)
        Me.CompanyInfoFormNextButton.TabIndex = 19
        Me.CompanyInfoFormNextButton.Text = "Next"
        Me.CompanyInfoFormNextButton.UseVisualStyleBackColor = True
        '
        'CompanyTypeLabel
        '
        Me.CompanyTypeLabel.AutoSize = True
        Me.CompanyTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyTypeLabel.Location = New System.Drawing.Point(123, 235)
        Me.CompanyTypeLabel.Name = "CompanyTypeLabel"
        Me.CompanyTypeLabel.Size = New System.Drawing.Size(357, 24)
        Me.CompanyTypeLabel.TabIndex = 18
        Me.CompanyTypeLabel.Text = "What Type of Company do you Own?"
        '
        'companyTypeComboBox1
        '
        Me.companyTypeComboBox1.FormattingEnabled = True
        Me.companyTypeComboBox1.Items.AddRange(New Object() {"Limited Liability Company", "Sole-Proprietorship", "Coorperation", "Non-Profit", "Other"})
        Me.companyTypeComboBox1.Location = New System.Drawing.Point(511, 240)
        Me.companyTypeComboBox1.Name = "companyTypeComboBox1"
        Me.companyTypeComboBox1.Size = New System.Drawing.Size(261, 21)
        Me.companyTypeComboBox1.TabIndex = 17
        '
        'checkBoxNumEmployee3
        '
        Me.checkBoxNumEmployee3.AutoSize = True
        Me.checkBoxNumEmployee3.Location = New System.Drawing.Point(692, 160)
        Me.checkBoxNumEmployee3.Name = "checkBoxNumEmployee3"
        Me.checkBoxNumEmployee3.Size = New System.Drawing.Size(44, 17)
        Me.checkBoxNumEmployee3.TabIndex = 16
        Me.checkBoxNumEmployee3.Text = "10+"
        Me.checkBoxNumEmployee3.UseVisualStyleBackColor = True
        '
        'checkBoxNumEmployee2
        '
        Me.checkBoxNumEmployee2.AutoSize = True
        Me.checkBoxNumEmployee2.Location = New System.Drawing.Point(558, 160)
        Me.checkBoxNumEmployee2.Name = "checkBoxNumEmployee2"
        Me.checkBoxNumEmployee2.Size = New System.Drawing.Size(41, 17)
        Me.checkBoxNumEmployee2.TabIndex = 15
        Me.checkBoxNumEmployee2.Text = "5-9"
        Me.checkBoxNumEmployee2.UseVisualStyleBackColor = True
        '
        'checkBoxNumEmployee1
        '
        Me.checkBoxNumEmployee1.AutoSize = True
        Me.checkBoxNumEmployee1.Location = New System.Drawing.Point(426, 160)
        Me.checkBoxNumEmployee1.Name = "checkBoxNumEmployee1"
        Me.checkBoxNumEmployee1.Size = New System.Drawing.Size(41, 17)
        Me.checkBoxNumEmployee1.TabIndex = 14
        Me.checkBoxNumEmployee1.Text = "1-4"
        Me.checkBoxNumEmployee1.UseVisualStyleBackColor = True
        '
        'NumEmployeesLabel
        '
        Me.NumEmployeesLabel.AutoSize = True
        Me.NumEmployeesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumEmployeesLabel.Location = New System.Drawing.Point(142, 153)
        Me.NumEmployeesLabel.Name = "NumEmployeesLabel"
        Me.NumEmployeesLabel.Size = New System.Drawing.Size(218, 24)
        Me.NumEmployeesLabel.TabIndex = 13
        Me.NumEmployeesLabel.Text = "Number of Employees"
        '
        'CnameTxtBox
        '
        Me.CnameTxtBox.Location = New System.Drawing.Point(355, 55)
        Me.CnameTxtBox.Name = "CnameTxtBox"
        Me.CnameTxtBox.Size = New System.Drawing.Size(261, 20)
        Me.CnameTxtBox.TabIndex = 12
        '
        'CompanyNameLabel
        '
        Me.CompanyNameLabel.AutoSize = True
        Me.CompanyNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyNameLabel.Location = New System.Drawing.Point(83, 45)
        Me.CompanyNameLabel.Name = "CompanyNameLabel"
        Me.CompanyNameLabel.Size = New System.Drawing.Size(221, 31)
        Me.CompanyNameLabel.TabIndex = 11
        Me.CompanyNameLabel.Text = "Company Name"
        '
        'CompanyInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 495)
        Me.Controls.Add(Me.CompanyInformationFormBackButton)
        Me.Controls.Add(Me.CompanyInfoFormNextButton)
        Me.Controls.Add(Me.CompanyTypeLabel)
        Me.Controls.Add(Me.companyTypeComboBox1)
        Me.Controls.Add(Me.checkBoxNumEmployee3)
        Me.Controls.Add(Me.checkBoxNumEmployee2)
        Me.Controls.Add(Me.checkBoxNumEmployee1)
        Me.Controls.Add(Me.NumEmployeesLabel)
        Me.Controls.Add(Me.CnameTxtBox)
        Me.Controls.Add(Me.CompanyNameLabel)
        Me.Name = "CompanyInfoForm"
        Me.Text = "CompanyInfoForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents CompanyInformationFormBackButton As Button
    Private WithEvents CompanyInfoFormNextButton As Button
    Private WithEvents CompanyTypeLabel As Label
    Private WithEvents companyTypeComboBox1 As ComboBox
    Private WithEvents checkBoxNumEmployee3 As CheckBox
    Private WithEvents checkBoxNumEmployee2 As CheckBox
    Private WithEvents checkBoxNumEmployee1 As CheckBox
    Private WithEvents NumEmployeesLabel As Label
    Private WithEvents CnameTxtBox As TextBox
    Private WithEvents CompanyNameLabel As Label
End Class
