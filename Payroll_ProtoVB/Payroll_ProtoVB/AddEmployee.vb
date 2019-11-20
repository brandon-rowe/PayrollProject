Imports Payroll_ProtoVB.PrimaryTableAdapters

Public Class AddEmployee
    Inherits System.Windows.Forms.Form
    'load form

    Dim employTA As New EmployeeTableAdapter
    Dim Fname As String
    Dim Lname As String
    Dim address As String
    Dim street As String
    Dim state As String
    Dim zip As String
    Dim status As String
    Dim dependents As String
    Dim position As String
    Dim paymentType As String
    Dim salaryVry As Boolean
    Dim ssn As String
    Dim ID As Integer
    Dim Uname As String
    Dim Pass As String

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

        Fname = FnameTxt.Text
        Lname = LnameTxt.Text
        street = StreetTxt.Text
        state = StateTxt.Text
        zip = ZipTxt.Text
        address = street + " " + state + " " + zip
        status = MaritalStatCB.Text
        dependents = DependentsTxt.Text
        position = PositionTxt.Text
        paymentType = PayTypeCBox.Text
        ssn = SSN_Txt.Text

        FnameTxt.Clear()
        LnameTxt.Clear()
        StreetTxt.Clear()
        StateTxt.Clear()
        ZipTxt.Clear()
        MaritalStatCB.Refresh()
        MaritalStatCB.ResetText()
        DependentsTxt.Clear()
        PositionTxt.Clear()
        PayTypeCBox.Refresh()
        PayTypeCBox.ResetText()
        SSN_Txt.Clear()
        AccessCTRL.ClearSelected()
        AccessCTRL.Refresh()
        AccessCTRL.ResetText()


        'Update and automate ID assignment by incrementing the number of rows
        ID = employTA.CountRows() + 1

        employTA.InsertQuery(ID, Fname, Lname, position, address, True, 4, False, salaryVry, 0, 50, 24, ssn, Uname, Pass)

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
        paymentType = PayTypeCBox.Text
        If paymentType = "Salary" Then
            salaryVry = True
        ElseIf paymentType = "Hourly" Then
            salaryVry = False
        End If
    End Sub

    Private Sub MaritalStatCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaritalStatCB.SelectedIndexChanged
        status = MaritalStatCB.Text
    End Sub

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
