Public Class Login
    Inherits System.Windows.Forms.Form

    Dim Fname As String
    Dim Lname As String
    Dim address As String
    Dim street As String
    Dim state As String
    Dim zip As String
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
        street = usrGenFormAddyTxtBox.Text
        state = usrGenFormStateTxtBox.Text
        zip = usrGenFormZipTxtBox.Text
        phone = usrGenFormPhoneTxtBox.Text
        Uname = usrGenFormUsrNameTxtBox.Text
        Pword = usrGenFormPassTxtBox.Text

        address = street + state + zip

        Console.WriteLine(Fname)
        Console.WriteLine(Lname)
        Console.WriteLine(address)
        Console.WriteLine(street)
        Console.WriteLine(state)
        Console.WriteLine(zip)
        Console.WriteLine(phone)
        Console.WriteLine(Uname)
        Console.WriteLine(Pword)
    End Sub

    Private Sub loginFormButton_Click(sender As Object, e As EventArgs) Handles loginFormButton.Click
        Uname = loginUsrTxt.Text
        Pword = loginPwTxt.Text

        Console.WriteLine(Uname)
        Console.WriteLine(Pword)
    End Sub
End Class