Imports Payroll_ProtoVB.PrimaryTableAdapters

Public Class EmpManagment

    Inherits System.Windows.Forms.Form
    Dim employTA As New EmployeeTableAdapter
    Dim ID As Integer
    Dim Row As Integer
    Dim Uname As String
    Dim PWord As String
    Dim VryPword As String

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
        ' Needs to handle non Integer text
        Me.employTA.FillByID(Me.Primary.Employee, SearchEmpTxt.Text)
    End Sub

    Private Sub ConLoginBtn_Click(sender As Object, e As EventArgs) Handles ConLoginBtn.Click
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

    End Sub

    Private Sub removeEmpBtn_Click(sender As Object, e As EventArgs) Handles removeEmpBtn.Click
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
            ID = EmpIDTxt.Text
            employTA.DeleteRow(ID)
            FnameTxt.Text = ""
            LnameTxt.Text = ""
            EmpIDTxt.Text = ""
            StreetTxt.Text = ""
            SSN_Txt.Text = ""
            StreetTxt.Text = ""
            PayRateTxt.Text = ""
            SalaryTxt.Text = ""
            MaritalStatusTxt.Text = ""
            DependentsTxt.Text = ""
            PositionTxt.Text = ""
            paymentTypeCBox.Text = ""
            PayHrsTxt.Text = ""
            ID = 0
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        'ATTENTION: This button should navigate to EmpDashboard.vb
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub CancelLoginBtn_Click(sender As Object, e As EventArgs) Handles CancelLoginBtn.Click
        'ATTENTION: This button should navigate to EmpDashboard.vb
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub AddEmpBtn_Click(sender As Object, e As EventArgs) Handles AddEmpBtn.Click
        'ATTENTION: This button should navigate to AddEmployee.vb
        Dim AddEmployee = New AddEmployee("Management")
        AddEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub editEmpBtn_Click(sender As Object, e As EventArgs) Handles editEmpBtn.Click
        Me.EmployeeBindingSource.EndEdit()
        'Me.TableAdapterManager1.UpdateAll(Me.Primary)
        employTA.Adapter.Update(Me.Primary)
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        FnameTxt.Text = ""
        LnameTxt.Text = ""
        EmpIDTxt.Text = ""
        StreetTxt.Text = ""
        SSN_Txt.Text = ""
        StreetTxt.Text = ""
        PayRateTxt.Text = ""
        SalaryTxt.Text = ""
        MaritalStatusTxt.Text = ""
        DependentsTxt.Text = ""
        PositionTxt.Text = ""
        paymentTypeCBox.Text = ""
        PayHrsTxt.Text = ""
        ID = 0
    End Sub
End Class