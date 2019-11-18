Public Class Login
    Inherits System.Windows.Forms.Form
    Dim LginLog As LoginLogic
    Dim Fname As String
    Dim Lname As String
    Dim address As String
    Dim street As String
    Dim state As String
    Dim zip As String
    Dim Uname As String
    Dim UnameVryfy As String
    Dim CPword As String
    Dim VryPword As String
    Dim Pword As String

    'load form
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create the Logic Class when the form loads
        LginLog = New LoginLogic()
        LoginGB.Visible = True
        SignUpGB.Visible = False
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

        If LginLog.IsCreateUsrFormValid(Fname, Lname, street, state, zip, CPword, VryPword) Then

            If Fname.Length() > 0 AndAlso Lname.Length() > 0 AndAlso street.Length() > 0 AndAlso state.Length() > 0 AndAlso zip.Length() > 0 AndAlso CPword = VryPword Then
                Dim AddEmployee = New AddEmployee(Fname, Lname, street, state, zip)
                AddEmployee.Show()
                Me.Hide()
            End If

            FnameTxt.Clear()
            LnameTxt.Clear()
            StreetTxt.Clear()
            StateTxt.Clear()
            ZipTxt.Clear()
            CreateUnameTxt.Clear()
            CreatePwordTxt.Clear()
            VerifyPwordTxt.Clear()

            Me.Hide()
        Else
            'first name field check
            If Fname.Length() = 0 Then
                Dim MSG, style, title, response, MyString
                MSG = "Please Provide First Name "
                title = "Input Error- First Name"
                style = vbOKOnly + vbDefaultButton1
                response = MsgBox(MSG, style, title)
                If response = vbOKOnly Then
                    MyString = "OK"
                End If
            End If
            'last name field check
            If Lname.Length() = 0 Then
                Dim MSG, style, title, response, MyString
                MSG = "Please Provide Last Name "
                title = "Input Error- Last Name"
                style = vbOKOnly + vbDefaultButton1
                response = MsgBox(MSG, style, title)
                If response = vbOKOnly Then
                    MyString = "OK"
                End If
            End If
            'street field check
            If street.Length() = 0 Then
                Dim MSG, style, title, response, MyString
                MSG = "Please Provide Street Address "
                title = "Input Error- Address Information"
                style = vbOKOnly + vbDefaultButton1
                response = MsgBox(MSG, style, title)
                If response = vbOKOnly Then
                    MyString = "OK"
                End If
            End If
            'state field check
            If state.Length() = 0 Then
                Dim MSG, style, title, response, MyString
                MSG = "Please Provide State "
                title = "Input Error- Address Information"
                style = vbOKOnly + vbDefaultButton1
                response = MsgBox(MSG, style, title)
                If response = vbOKOnly Then
                    MyString = "OK"
                End If
            End If
            'zip field check
            If zip.Length() = 0 Then
                Dim MSG, style, title, response, MyString
                MSG = "Please Provide Zip Code "
                title = "Input Error- Address Information"
                style = vbOKOnly + vbDefaultButton1
                response = MsgBox(MSG, style, title)
                If response = vbOKOnly Then
                    MyString = "OK"
                End If
            End If
            'include  if (Pword.Contains("/") Or (Pword.Contains("\") Or (Pword.Contains("{")) Or (Pword.Contains("}")) Or (Pword.Contains("(")) Or (Pword.Contains(")")))
            'Password Requriment- Between 1-15 Characters
            If CPword.Length = 0 OrElse CPword.Length() > 15 Then
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
            End If
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        'ATTENTION: This button should navigate to EmpDashboard.vb
        'We need to add a sqladapter to check the Username & Password to validate credentials.
        Uname = loginUsrTxt.Text
        Pword = loginPwTxt.Text
        EmpDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        LoginGB.Visible = False
        SignUpGB.Visible = True
    End Sub

    Private Sub backToLoginBtn_Click(sender As Object, e As EventArgs) Handles backToLoginBtn.Click
        LoginGB.Visible = True
        SignUpGB.Visible = False
    End Sub
End Class