Public Class AddEmployeeForm
    Inherits System.Windows.Forms.Form

    Dim adminFname As String
    Dim adminLname As String
    Dim adminAddress As String
    Dim adminState As String
    Dim adminZip As Long
    Dim adminPhone As Long
    Dim adminUname As String
    Dim adminPword As String

    'Separate admin info from employee info

    Dim Fname As String
    Dim Lname As String
    Dim address As String
    Dim state As String
    Dim zip As Long
    Dim phone As Long
    Dim Uname As String
    Dim Pword As String



    'load form
    Private Sub AddEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'labels'
    'title'
    Private Sub AddEmployeeFormLabel_Click(sender As Object, e As EventArgs) Handles AddEmployeeFormLabel.Click

    End Sub

    'first name
    Private Sub AddEmployeeFormFirstNameLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormFirstNameLabel.Click

    End Sub

    'last name
    Private Sub AddEmployeeFormLastNameLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormLastNameLabel.Click

    End Sub

    'address
    Private Sub AddEmployeeFormAddyLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormAddyLabel.Click

    End Sub

    'state
    Private Sub AddEmployeeFormStateLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormStateLabel.Click

    End Sub

    'zip
    Private Sub AddEmployeeFormZipLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormZipLabel.Click

    End Sub

    'phone
    Private Sub AddEmployeeFormPhoneLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormPhoneLabel.Click

    End Sub

    'marital status
    Private Sub AddEmployeeFormMstatLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormMstatLabel.Click

    End Sub

    'dependency status
    Private Sub AddEmployeeFormDepStatLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormDepStatLabel.Click

    End Sub

    'position
    Private Sub AddEmployeeFormPositionLable_Click(sender As Object, e As EventArgs) Handles addEmployeeFormPositionLable.Click

    End Sub

    'payment type
    Private Sub AddEmployeeFormPaymentTypeLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormPaymentTypeLabel.Click

    End Sub

    'permissions
    Private Sub AddEmployeeFormPermissionsLabel_Click(sender As Object, e As EventArgs) Handles addEmployeeFormPermissionsLabel.Click

    End Sub

    'descriptive labels'
    Private Sub AddEmployeeFormAddUsrDescLabel1_Click(sender As Object, e As EventArgs) Handles addEmployeeFormAddUsrDescLabel1.Click

    End Sub

    Private Sub AddEmployeeFormAddUsrDescLabel2_Click(sender As Object, e As EventArgs) Handles addEmployeeFormAddUsrDescLabel2.Click

    End Sub

    Private Sub AddEmployeeFormAddUsrDescLabel3_Click(sender As Object, e As EventArgs) Handles addEmployeeFormAddUsrDescLabel3.Click

    End Sub
    'end of descriptive labels'
    'end of labels'

    'interactive components'
    'text boxes'
    Private Sub AddEmployeeFormFirstNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles addEmployeeFormFirstNameTxtBox.TextChanged

    End Sub

    Private Sub AddEmployeeFormLastNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles addEmployeeFormLastNameTxtBox.TextChanged

    End Sub

    Private Sub AddEmployeeFormAddyTxtBox_TextChanged(sender As Object, e As EventArgs) Handles addEmployeeFormAddyTxtBox.TextChanged

    End Sub

    Private Sub AddEmployeeFormStateTxtBox_TextChanged(sender As Object, e As EventArgs) Handles addEmployeeFormStateTxtBox.TextChanged

    End Sub

    Private Sub AddEmployeeFormZipTxtBox_TextChanged(sender As Object, e As EventArgs) Handles addEmployeeFormZipTxtBox.TextChanged

    End Sub

    Private Sub AddEmployeeFormPhoneTxtBox_TextChanged(sender As Object, e As EventArgs) Handles addEmployeeFormPhoneTxtBox.TextChanged

    End Sub

    Private Sub AddEmployeeFormMaritalStatTxtBox_TextChanged(sender As Object, e As EventArgs) Handles addEmployeeFormMaritalStatTxtBox.TextChanged

    End Sub

    Private Sub AddEmployeeFormDepStatTxtBox_TextChanged(sender As Object, e As EventArgs) Handles addEmployeeFormDepStatTxtBox.TextChanged

    End Sub

    Private Sub AddEmployeePositionTxtBox_TextChanged(sender As Object, e As EventArgs) Handles addEmployeePositionTxtBox.TextChanged

    End Sub
    'end of textboxes'
    'combo box'
    Private Sub AddEmployeeFormpaymentTypeComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles addEmployeeFormpaymentTypeComboBox1.SelectedIndexChanged

    End Sub

    'checklist box'
    Private Sub AddEmployeeFormPermissionsCheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles addEmployeeFormPermissionsCheckedListBox1.SelectedIndexChanged

    End Sub

    'buttons'
    'add employee
    Public Sub AddEmployeeFormAddButton_Click(sender As Object, e As EventArgs) Handles addEmployeeFormAddButton.Click

    End Sub

    'back
    Private Sub AddEmployeeFormBackButton_Click(sender As Object, e As EventArgs) Handles addEmployeeFormBackButton.Click

    End Sub

    'next
    Private Sub AddEmployeeFormNextButton_Click(sender As Object, e As EventArgs) Handles addEmployeeFormNextButton.Click

    End Sub
    'end of buttons'
    'end of interactive components'
End Class