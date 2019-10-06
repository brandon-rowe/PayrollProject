Public Class CompanyInfoForm

    'load form
    Private Sub CompanyInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'labels'
    'company name'
    Private Sub CompanyNameLabel_Click(sender As Object, e As EventArgs) Handles CompanyNameLabel.Click

    End Sub

    'number of employees
    Private Sub NumEmployeesLabel_Click(sender As Object, e As EventArgs) Handles NumEmployeesLabel.Click

    End Sub

    'company type
    Private Sub CompanyTypeLabel_Click(sender As Object, e As EventArgs) Handles CompanyTypeLabel.Click

    End Sub
    'end of labels'

    'interactive components'
    'text box'
    Private Sub CnameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles CnameTxtBox.TextChanged

    End Sub

    'check boxes'
    'employee range 1-4
    Private Sub CheckBoxNumEmployee1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxNumEmployee1.CheckedChanged

    End Sub

    'employee range 5-9
    Private Sub CheckBoxNumEmployee2_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxNumEmployee2.CheckedChanged

    End Sub

    'employee range 10+
    Private Sub CheckBoxNumEmployee3_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxNumEmployee3.CheckedChanged

    End Sub
    'end of check boxes'

    'drop down menue to select company type
    Private Sub CompanyTypeComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles companyTypeComboBox1.SelectedIndexChanged

    End Sub

    'buttons'
    'back'
    Private Sub CompanyInformationFormBackButton_Click(sender As Object, e As EventArgs) Handles CompanyInformationFormBackButton.Click

    End Sub

    'next'
    Private Sub CompanyInfoFormNextButton_Click(sender As Object, e As EventArgs) Handles CompanyInfoFormNextButton.Click

    End Sub
    'end of buttons'
    'end of interactive components'
End Class