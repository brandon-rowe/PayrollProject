Imports Payroll_ProtoVB.PrimaryTableAdapters

Public Class EmpManagment

    Inherits System.Windows.Forms.Form
    Dim employTA As New EmployeeTableAdapter
    Dim ID As Integer
    Dim Row As Integer
    Dim Uname As String
    Dim PWord As String
    Dim VryPword As String
    Dim feedBackLogs As New FeedbackLogsTableAdapter
    Dim futureTA As New EmployeeFutureTableAdapter

    Public Sub New(nRow As Integer)
        InitializeComponent()
        Row = nRow
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub EmpManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.employTA.FillBySelectedRow(Me.Primary.Employee, Row)
        If (PayTypeTxtBox.Text = "True") Then
            SalariedGroupBox.Visible = True
            HourlyGroupBox.Visible = False
        Else
            SalariedGroupBox.Visible = False
            HourlyGroupBox.Visible = True
        End If

        ' If MaritalStatusTxt.Text = "True" Then
        'MaritalStatusTxt.Text = "Married"
        ' Else
        'MaritalStatusTxt.Text = "Single"
        'End If

        'If paymentTypeCBox.Text = "False" Then
        'paymentTypeCBox.SelectedIndex = 1
        'Else
        'paymentTypeCBox.SelectedIndex = 0
        ' End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        feedBackLogs.CountPlusOne("EmpManagement", "Search Button")

        Try
            Me.employTA.FillByID(Me.Primary.Employee, SearchEmpTxt.Text)
            If (PayTypeTxtBox.Text = "True") Then
                SalariedGroupBox.Visible = True
                HourlyGroupBox.Visible = False
            Else
                SalariedGroupBox.Visible = False
                HourlyGroupBox.Visible = True
            End If
        Catch
            Dim MSG, style, title, response, MyString
            MSG = "Not a valid employee ID, please try again."
            title = "Input Error"
            style = vbOKOnly + vbDefaultButton1
            response = MsgBox(MSG, style, title)
            If response = vbOKOnly Then
                MyString = "OK"
            End If
        End Try

    End Sub

    Private Sub ConLoginBtn_Click(sender As Object, e As EventArgs) Handles ConLoginBtn.Click
        feedBackLogs.CountPlusOne("EmpManagement", "Continue Button")

        Uname = UnameTxt.Text
        PWord = PwordTxt.Text

        VryPword = employTA.CheckPassword(Uname)

        If (Not (String.IsNullOrEmpty(PWord)) And Not (String.IsNullOrEmpty(Uname))) Then
            If (VryPword = PWord AndAlso Not (String.IsNullOrEmpty(VryPword))) Then
                EmployeeInfoGroupBox.Visible = True
                LoginGroupBox.Visible = False
                SearchAddGroupBox.Visible = True
                WelcomeLabel.Visible = True
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

        If (PayTypeTxtBox.Text = "True") Then
            SalariedGroupBox.Visible = True
            HourlyGroupBox.Visible = False
        Else
            SalariedGroupBox.Visible = False
            HourlyGroupBox.Visible = True
        End If

    End Sub

    Private Sub removeEmpBtn_Click(sender As Object, e As EventArgs) Handles removeEmpBtn.Click
        feedBackLogs.CountPlusOne("EmpManagement", "Remove Employee Button")

        'This button only takes in the ID as a selector to delete the record.

        If EmpIDTxt.Text = "" Then
            Dim MSG, style, title, response, MyString
            MSG = "Invalid Employee ID"
            title = "Input Error- ID"
            style = vbOKOnly + vbDefaultButton1
            response = MsgBox(MSG, style, title)
            If response = vbOKOnly Then
                MyString = "OK"
            End If
        Else
            Dim Response As Integer
            Response = MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Response = vbYes Then
                ID = EmpIDTxt.Text
                employTA.DeleteRow(ID)
                Try
                    futureTA.DeleteByID(ID)
                Catch
                End Try
                FnameTxt.Text = ""
                LnameTxt.Text = ""
                EmpIDTxt.Text = ""
                StreetTxt.Text = ""
                SSN_Txt.Text = ""
                StreetTxt.Text = ""
                PayRateTxt.Text = ""
                SalaryTxtBox.Text = ""
                MaritalStatusTxt.Text = ""
                DependentsTxt.Text = ""
                PositionTxt.Text = ""
                PayTypeTxtBox.Text = ""
                PayHrsTxt.Text = ""
                PayfrequencyTextBox.Text = ""
                ID = 0
            End If
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        feedBackLogs.CountPlusOne("EmpManagement", "Cancel Button (Right)")

        'ATTENTION: This button should navigate to EmpDashboard.vb
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub CancelLoginBtn_Click(sender As Object, e As EventArgs) Handles CancelLoginBtn.Click
        feedBackLogs.CountPlusOne("EmpManagement", "Cancel Button (Left)")

        'ATTENTION: This button should navigate to EmpDashboard.vb
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub AddEmpBtn_Click(sender As Object, e As EventArgs) Handles AddEmpBtn.Click
        feedBackLogs.CountPlusOne("EmpManagement", "Add Employee Button")

        'ATTENTION: This button should navigate to AddEmployee.vb
        Dim AddEmployee = New AddEmployee("Management")
        AddEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub editEmpBtn_Click(sender As Object, e As EventArgs) Handles editEmpBtn.Click
        feedBackLogs.CountPlusOne("EmpManagement", "Update Button")

        Me.EmployeeBindingSource.EndEdit()
        'Me.TableAdapterManager1.UpdateAll(Me.Primary)
        employTA.Adapter.Update(Me.Primary)
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        feedBackLogs.CountPlusOne("EmpManagement", "Clear Selection Button")

        FnameTxt.Text = ""
        LnameTxt.Text = ""
        EmpIDTxt.Text = ""
        StreetTxt.Text = ""
        SSN_Txt.Text = ""
        StreetTxt.Text = ""
        PayRateTxt.Text = ""
        SalaryTxtBox.Text = ""
        MaritalStatusTxt.Text = ""
        DependentsTxt.Text = ""
        PositionTxt.Text = ""
        PayTypeTxtBox.Text = ""
        PayfrequencyTextBox.Text = ""
        PayHrsTxt.Text = ""
        ID = 0
    End Sub
End Class