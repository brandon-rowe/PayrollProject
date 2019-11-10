Public Class Login
    Inherits System.Windows.Forms.Form

    Dim Fname As String
    Dim Lname As String
    Dim address As String
    Dim state As String
    Dim zip As Long
    Dim phone As Long
    Dim Uname As String
    Dim Pword As String

    'load form
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'create user button
    Private Sub UsrGenFormCreateUsrButton_Click(sender As Object, e As EventArgs) Handles usrGenFormCreateUsrButton.Click
        Fname = usrGenFormFirstNameTxtBox.Text
        Lname = usrGenFormLastNameTxtBox.Text
        address = usrGenFormAddyTxtBox.Text
        state = usrGenFormStateTxtBox.Text
        zip = usrGenFormZipTxtBox.Text
        phone = usrGenFormPhoneTxtBox.Text
        Uname = usrGenFormUsrNameTxtBox.Text
        Pword = usrGenFormPassTxtBox.Text

        Dim AddEmployeeForm As New Form()
        AddEmployeeForm.ShowDialog()

        'Console.WriteLine(Fname)
        'Console.WriteLine(Lname)
        'Console.WriteLine(address)
        'Console.WriteLine(state)
        'Console.WriteLine(zip)
        'Console.WriteLine(phone)
        'Console.WriteLine(Uname)
        'Console.WriteLine(Pword)
    End Sub

End Class