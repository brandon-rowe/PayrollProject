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
    Dim VerifyPass As String
    Dim admin As Boolean
    Dim PayRate As String
    Dim HoursWorked As String
    Dim PaymentID As Integer
    Dim PayFrequency As String
    Dim PayDate As DateTime
    Dim returnForm As String
    Dim statusInt As Integer = 0
    Dim feedBackLogs As New FeedbackLogsTableAdapter

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

    'Return to empmanagement CM
    Public Sub New(nReturnForm As String)
        InitializeComponent()
        returnForm = nReturnForm
    End Sub




    Private Sub AddEmpBtn_Click(sender As Object, e As EventArgs) Handles AddEmpBtn.Click
        feedBackLogs.CountPlusOne("AddEmployee", "Add Employee Button")
        'ATTENTION: This button should remain on AddEmployee.vb 
        'until Next Or Back button is selected

        Try
            Dim nPayRate As Double = CDbl(PayRateTxtBox.Text)
            Dim nHoursWorked As Double = 0

            If (PayTypeCBox.Text = "Hourly") Then
                nHoursWorked = CDbl(HoursWorkedTxtBox.Text)
                PayFrequency = PayFreqCmbBox.Text
            Else
                PayFrequency = "Monthly"
            End If

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
            Uname = CreateUnameTxt.Text
            Pass = CreatePwordTxt.Text
            VerifyPass = VerifyPwordTxt.Text

            If (Not (String.IsNullOrEmpty(Pass)) And Not (String.IsNullOrEmpty(Uname))) Then
                If (VerifyPass = Pass) Then
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

                    If (PayFreqCmbBox.Text = "Monthly") Then
                        Dim newMonth As String = CStr(Date.Today.Month)
                        Dim newYear As String = CStr(Date.Today.Year)

                        If (Date.Today.Day > 15 And Date.Today.Month = 12) Then
                            newMonth = 1
                            newYear = Date.Today.Year + 1
                        ElseIf (Date.Today.Day > 15) Then
                            newMonth = Date.Today.Month + 1
                        End If

                        If (newMonth.Length = 1) Then
                            newMonth = "0" + newMonth
                        End If

                        PayDate = DateTime.ParseExact(newMonth + "15" + newYear, "MMddyyyy", Nothing)

                    ElseIf (PayFreqCmbBox.Text = "Bi-Weekly") Then
                        PayDate = futureTA.PayFrequencyDate("Bi-Weekly")
                    ElseIf (PayFreqCmbBox.Text = "Weekly") Then
                        PayDate = futureTA.PayFrequencyDate("Weekly")
                    End If

                    'Update and automate ID assignment by incrementing the number of rows
                    ID = employTA.CountRows() + 1
                    PaymentID = futureTA.CountRows() + 1


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
                    PaymentGroupBox.Visible = False
                    PayFreqCmbBox.SelectedIndex = 0
                    CreateUnameTxt.Text = ""
                    CreatePwordTxt.Text = ""
                    VerifyPwordTxt.Text = ""

                    'AccessCTRL.ClearSelected()
                    'AccessCTRL.Refresh()
                    'AccessCTRL.ResetText()


                    Dim payRateLogic As New PayRateLogic

                    If (paymentType = True) Then
                        employTA.InsertQuery(ID, Fname, Lname, position, address, status, dependents, admin, paymentType, PayRate, 0, 0, ssn, Uname, Pass, PayFrequency)
                        If (status = True) Then
                            statusInt = 1
                        End If
                        futureTA.InsertQuery(ID, PayDate, (nPayRate - (nPayRate * 0.27) + (statusInt * 50 + CInt(dependents) * 20)) / 12, Fname, Lname, 1, PayFrequency)
                    Else
                        employTA.InsertQuery(ID, Fname, Lname, position, address, status, dependents, admin, paymentType, 0, PayRate, HoursWorked, ssn, Uname, Pass, PayFrequency)
                        futureTA.InsertQuery(ID, PayDate, payRateLogic.CalculateHourlyPayTaxed(nPayRate, nHoursWorked, dependents, status, PayFrequency), Fname, Lname, 0, PayFrequency)
                    End If

                    Dim MSG, style, title, response, MyString
                    MSG = "Employee " + Fname + " " + Lname + " added succesfully."
                    title = "Employee Added"
                    style = vbOKOnly + vbDefaultButton1
                    response = MsgBox(MSG, style, title)
                    If response = vbOKOnly Then
                        MyString = "OK"
                    End If

                    Fname = ""
                    Lname = ""
                    street = ""
                    state = ""
                    zip = ""
                    address = ""
                    status = ""
                    dependents = ""
                    position = ""
                    ssn = ""
                    PayRate = 0
                    HoursWorked = 0
                    PayFrequency = ""
                    Uname = ""
                    Pass = ""
                    VerifyPass = ""
                    admin = False
                Else
                    Dim MSG2, style2, title2, response2, MyString2
                    MSG2 = "The password didn't work."
                    title2 = "Input Error- Login"
                    style2 = vbOKOnly + vbDefaultButton1
                    response2 = MsgBox(MSG2, style2, title2)
                    If response2 = vbOKOnly Then
                        MyString2 = "OK"
                    End If
                End If

            Else
                Dim MSG1, style1, title1, response1, MyString1
                MSG1 = "Username or password is empty."
                title1 = "Input Error- Login"
                style1 = vbOKOnly + vbDefaultButton1
                response1 = MsgBox(MSG1, style1, title1)
                If response1 = vbOKOnly Then
                    MyString1 = "OK"
                End If
            End If


        Catch

            Dim MSG, style, title, response, MyString
            MSG = "Please make sure all fields were completed."
            title = "Fields missing"
            style = vbOKOnly + vbDefaultButton1
            response = MsgBox(MSG, style, title)
            If response = vbOKOnly Then
                MyString = "OK"
            End If

        End Try
    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        feedBackLogs.CountPlusOne("AddEmployee", "Back Button")

        'will navigate to the form that it opened from
        Dim EmpManagement As New EmpManagment
        Me.Close()
        If (returnForm = "Management") Then
            EmpManagment.Show()
        Else
            Login.Show()
        End If
    End Sub

    Private Sub PayTypeCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PayTypeCBox.SelectedIndexChanged
        If (PayTypeCBox.SelectedIndex = 0) Then
            HourlySalaryLabel.Text = "Salary"
            PaymentGroupBox.Visible = True
            PayFreqCmbBox.SelectedIndex = 0
            PayFreqLabel.Visible = 0
            HoursWorkedLabel.Visible = 0
            PayFreqCmbBox.Visible = 0
            HoursWorkedTxtBox.Visible = 0
        Else
            HourlySalaryLabel.Text = "Hourly Rate"
            PaymentGroupBox.Visible = True
            PayFreqCmbBox.Visible = True
            HoursWorkedTxtBox.Visible = True
            PayFreqLabel.Visible = True
            HoursWorkedLabel.Visible = True
            PayFreqCmbBox.Refresh()
        End If
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
