Imports Payroll_ProtoVB.PrimaryTableAdapters
Imports System
Imports System.Globalization

Public Class AddEmployee
    Inherits System.Windows.Forms.Form
    'load form

    Dim employTA As New EmployeeTableAdapter
    Dim futureTA As New EmployeeFutureTableAdapter
    Dim Fname As String
    Dim Lname As String
    Dim address As String
    Dim street As String
    Dim state As String
    Dim zip As String
    Dim status As String
    Dim dependents As String
    Dim position As String
    Dim paymentType As Boolean
    Dim ssn As String
    Dim ID As Integer
    Dim Uname As String
    Dim Pass As String
    Dim admin As Boolean
    Dim PayRate As String
    Dim HoursWorked As String
    Dim PaymentID As Integer
    Dim PayDate As DateTime

    'empty constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    'constructor to pass admin user generation info.
    Public Sub New(ByVal nFname As String, ByVal nLname As String, ByVal nstreet As String, ByVal nstate As String, ByVal nzip As String, nUname As String, nPass As String)
        InitializeComponent()
        Fname = nFname
        Lname = nLname
        street = nstreet
        state = nstate
        zip = nzip
        Uname = nUname
        Pass = nPass
        FnameTxt.Text = Fname.ToString()
        LnameTxt.Text = Lname.ToString()
        StreetTxt.Text = street.ToString()
        StateTxt.Text = state.ToString()
        ZipTxt.Text = zip.ToString()
    End Sub




    Private Sub AddEmpBtn_Click(sender As Object, e As EventArgs) Handles AddEmpBtn.Click
        'ATTENTION: This button should remain on AddEmployee.vb 
        'until Next Or Back button is selected

        Dim nPayRate As Double = CDbl(PayRateTxtBox.Text)
        Dim nHoursWorked As Double = CDbl(HoursWorkedTxtBox.Text)

        Fname = FnameTxt.Text
        Lname = LnameTxt.Text
        street = StreetTxt.Text
        state = StateTxt.Text
        zip = ZipTxt.Text
        address = street + " " + state + " " + zip
        status = MaritalStatCB.Text
        dependents = DependentsTxt.Text
        position = PositionTxt.Text
        ssn = SSN_Txt.Text
        PayRate = PayRateTxtBox.Text
        HoursWorked = HoursWorkedTxtBox.Text

        If (MaritalStatCB.SelectedIndex = 0) Then
            status = False
        ElseIf (MaritalStatCB.SelectedIndex = 1) Then
            status = True
        End If

        If (PayTypeCBox.SelectedIndex = 0) Then
            paymentType = True
        ElseIf (MaritalStatCB.SelectedIndex = 1) Then
            paymentType = False
        End If

        If (AdminRadioBtn.Checked = True) Then
            admin = True
        ElseIf (EmployeeRadioBtn.Checked = True) Then
            admin = False
        End If

        FnameTxt.Clear()
        LnameTxt.Clear()
        StreetTxt.Clear()
        StateTxt.Clear()
        ZipTxt.Clear()
        PayRateTxtBox.Clear()
        HoursWorkedTxtBox.Clear()
        MaritalStatCB.Refresh()
        MaritalStatCB.ResetText()
        DependentsTxt.Clear()
        PositionTxt.Clear()
        PayTypeCBox.Refresh()
        PayTypeCBox.ResetText()
        SSN_Txt.Clear()
        AccessRadioBtnGroup.Refresh()
        'AccessCTRL.ClearSelected()
        'AccessCTRL.Refresh()
        'AccessCTRL.ResetText()

        If (Date.Today.Day > 15) Then
            PayDate = DateTime.ParseExact("12152019", "MMddyyyy", Nothing)
        End If

        'Update and automate ID assignment by incrementing the number of rows
        ID = employTA.CountRows() + 1
        PaymentID = futureTA.CountRows() + 1

        If (paymentType = True) Then
            employTA.InsertQuery(ID, Fname, Lname, position, address, status, dependents, admin, paymentType, PayRate, 0, HoursWorked, ssn, Uname, Pass)
            futureTA.InsertQuery(PaymentID, ID, PayDate, nPayRate / 12, Fname, Lname)
        Else
            employTA.InsertQuery(ID, Fname, Lname, position, address, status, dependents, admin, paymentType, 0, PayRate, HoursWorked, ssn, Uname, Pass)
            futureTA.InsertQuery(PaymentID, ID, PayDate, nPayRate * nHoursWorked, Fname, Lname)
        End If

    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        'ATTENTION: This button should navigate to Login.vb
        Me.Close()
        Login.LoginGB.Visible = True
        Login.SignUpGB.Visible = False
        Login.Show()
        Login.FnameTxt.Clear()
        Login.LnameTxt.Clear()
        Login.StreetTxt.Clear()
        Login.StateTxt.Clear()
        Login.ZipTxt.Clear()
        Login.CreateUnameTxt.Clear()
        Login.CreatePwordTxt.Clear()
        Login.VerifyPwordTxt.Clear()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        'ATTENTION: This button should navigate to Login.vb
        Me.Close()
        Login.Show()
    End Sub

    Private Sub PayTypeCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PayTypeCBox.SelectedIndexChanged
        If (PayTypeCBox.SelectedIndex = 0) Then
            HourlySalaryLabel.Text = "Salary"
        Else
            HourlySalaryLabel.Text = "Hourly Rate"
        End If
        PaymentGroupBox.Visible = True
    End Sub

    Private Sub MaritalStatCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaritalStatCB.SelectedIndexChanged
        status = MaritalStatCB.Text
    End Sub

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MaritalStatCB.SelectedIndex = 0
        'PayTypeCBox.SelectedIndex = 0
        AdminRadioBtn.Checked = True
    End Sub
End Class
