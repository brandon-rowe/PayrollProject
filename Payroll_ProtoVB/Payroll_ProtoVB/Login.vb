Imports Payroll_ProtoVB.PrimaryTableAdapters
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
    Dim PwordVAL As Boolean
    Dim empTA As New EmployeeTableAdapter

    'load form
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create the Logic Class when the form loads
        LginLog = New LoginLogic()
        LoginGB.Visible = True
    End Sub

    'create user button
    Private Sub UsrGenFormCreateUsrButton_Click(sender As Object, e As EventArgs)
        address = street + " " + state + " " + zip

        'this is checking to make sure nothing is blank and that the passwords match
        'it has been extracted out of this class so that it can be unit tested
        If LginLog.IsCreateUsrFormValid(Fname, Lname, street, state, zip, CPword, VryPword) Then

            Dim AddEmployee = New AddEmployee(Fname, Lname, street, state, zip, Uname, CPword)
            AddEmployee.Show()

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
            'Or (Pword.Contains("{")) Or (Pword.Contains("}")) Or (Pword.Contains("(")) Or (Pword.Contains(")"))
            If (CPword.Contains("/") OrElse (CPword.Contains("\")) OrElse (CPword.Contains("{")) OrElse (CPword.Contains("}")) OrElse (CPword.Contains("(")) OrElse (CPword.Contains(")"))) Then
                PwordVAL = False
                Dim MSG, style, title, response, MyString
                MSG = "The Password Input is invalid: Passwords cannot Contain characters '/', '\', '{', '}', '(', or ')' "
                title = "Input Error- Password"
                style = vbOKOnly + vbDefaultButton1
                response = MsgBox(MSG, style, title)
                If response = vbOKOnly Then
                    MyString = "OK"
                End If
            End If
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
        CPword = loginPwTxt.Text

        VryPword = empTA.CheckPassword(Uname)
        ' We should add the following condition, otherwise we can just login without typing in anything
        ' because an empty String is equivalent to Nothing returned by empTA
        ' 

        '
        ' HOWEVER, I'm leaving it out atm cause it makes testing easier lol
        If (Not (String.IsNullOrEmpty(CPword)) And Not (String.IsNullOrEmpty(Uname))) Then
            If (VryPword = CPword) Then
                EmpDashboard.Show()
                Me.Close()
            Else
                Dim MSG, style, title, response, MyString
                MSG = "The password didn't work."
                title = "Input Error- Login"
                style = vbOKOnly + vbDefaultButton1
                response = MsgBox(MSG, style, title)
                If response = vbOKOnly Then
                    MyString = "OK"
                End If
            End If
        Else
            Dim MSG, style, title, response, MyString
            MSG = "Username or password is empty."
            title = "Input Error- Login"
            style = vbOKOnly + vbDefaultButton1
            response = MsgBox(MSG, style, title)
            If response = vbOKOnly Then
                MyString = "OK"
            End If
        End If



        'want to create a counter that denies functionality if login attempts exceed a certain amount.
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        If (empTA.CountRows < 1) Then
            AddEmployee.Show()
        Else
            Dim MSG, style, title, response, MyString
            MSG = "Sorry, atleast one admin already exists."
            title = "Admin Exists"
            style = vbOKOnly + vbDefaultButton1
            response = MsgBox(MSG, style, title)
            If response = vbOKOnly Then
                MyString = "OK"
            End If
        End If
    End Sub

    Private Sub backToLoginBtn_Click(sender As Object, e As EventArgs)
        LoginGB.Visible = True
    End Sub
End Class