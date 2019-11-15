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
    Dim CPword As String
    Dim VryPword As String
    Dim Pword As String

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
        CPword = CreatePwordTxt.Text
        VryPword = VerifyPwordTxt.Text
        address = street + " " + state + " " + zip

        'include  if (Pword.Contains("/") Or (Pword.Contains("\") Or (Pword.Contains("{")) Or (Pword.Contains("}")) Or (Pword.Contains("(")) Or (Pword.Contains(")")))
        'Password Requriment- Less than 15 Characters
        If CPword.Length() > 15 Then
            Dim MSG, style, title, response, MyString
            MSG = "The Password Input is invalid: Passwords cannot exceed 15 characters "
            title = "Input Error- Password"
            style = vbOKOnly + vbDefaultButton1
            response = MsgBox(MSG, style, title)
            If response = vbOKOnly Then
                MyString = "OK"
            End If
        End If

        'Password Verification
        If (CPword <> VryPword) Then
            Dim MSG, style, title, response, MyString
            MSG = "Passwords do not match"
            title = "Input Error- Password"
            style = vbOKOnly + vbDefaultButton1
            response = MsgBox(MSG, style, title)
            If response = vbOKOnly Then
                MyString = "OK"
            End If

            'if passwords match proceed to next form, must be contained within else if, otherwise dialog box will generate,
            'but Information will still be transferred.

        ElseIf CPword = VryPword Then
            Dim AddEmployee = New AddEmployee()
            AddEmployee.Show()
        End If

        'Me.Close()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Uname = loginUsrTxt.Text
        Pword = loginPwTxt.Text
        If Pword.Length() > 15 Then
            Dim MSG, style, title, response, MyString
            MSG = "The Password Input is invalid: Passwords cannot exceed 15 characters "
            title = "Input Error- Password"
            style = vbOKOnly + vbDefaultButton1
            response = MsgBox(MSG, style, title)
            If response = vbOKOnly Then
                MyString = "OK"
            End If

        ElseIf Pword.Length <= 15 Then
        Dim Payroll = New Payroll()
        Payroll.Show()
        End If

        'Me.Close()
    End Sub


End Class