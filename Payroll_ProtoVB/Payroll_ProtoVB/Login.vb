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
    Dim CPword As String
    Dim VryPword As String
    Dim Pword As String
    Dim PwordVAL As Boolean
    Dim empTA As New EmployeeTableAdapter
    Dim feedBackLogs As New FeedbackLogsTableAdapter

    'load form
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create the Logic Class when the form loads
        LginLog = New LoginLogic()
        LoginGB.Visible = True
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        feedBackLogs.CountPlusOne("Login", "Login Button")

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

    Private Sub createAdmin_Click(sender As Object, e As EventArgs) Handles createAdminBtn.Click
        feedBackLogs.CountPlusOne("Login", "Create Admin Button")

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
End Class