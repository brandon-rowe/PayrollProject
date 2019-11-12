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
    Dim Pword2 As String

    'load form
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'create user button
    Private Sub UsrGenFormCreateUsrButton_Click(sender As Object, e As EventArgs) Handles usrGenFormCreateUsrButton.Click
        Fname = FnameTxt.Text
        Lname = LnameTxt.Text
        street = StreetTxt.Text
        state = StateTxt.Text
        zip = ZipTxt.Text
        Uname = CreateUnameTxt.Text
        Pword = CreatePwordTxt.Text
        Pword2 = VerifyPwordTxt.Text
        address = street + " " + state + " " + zip

        'If (Pword == Pword2) Then

        Dim AddEmployee = New AddEmployee()
            AddEmployee.Show()
            'Me.Close()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Uname = loginUsrTxt.Text
        Pword = loginPwTxt.Text

        Dim Payroll = New Payroll()
        Payroll.Show()
        'Me.Close()
    End Sub
End Class