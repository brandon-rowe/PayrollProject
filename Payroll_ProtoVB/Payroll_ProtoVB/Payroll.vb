Imports Payroll_ProtoVB.PrimaryTableAdapters

Public Class Payroll
    Inherits System.Windows.Forms.Form
    'load form
    Public Sub Payroll()
        InitializeComponent()
    End Sub

    Dim employPast As New EmployeePastTableAdapter
    Dim ID, fname, lname As String
    Private Sub Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.EmployeeFuture' table. You can move, or remove it, as needed.
        Me.EmployeeFutureTableAdapter.Fill(Me.Primary.EmployeeFuture)
        'TODO: This line of code loads data into the 'Primary.EmployeePast' table. You can move, or remove it, as needed.
        Me.EmployeePastTableAdapter.Fill(Me.Primary.EmployeePast)
    End Sub
    'B.Rowe: I restructured this page so that the completed code for buttons are all at the bottom of the page.
    'This way the most pressing code is at the top. I will do this for all pages.

    Private Sub EmpIDSearch_Click(sender As Object, e As EventArgs) Handles EmpIDSearch.Click
        'B. Rowe: We need to think through the functionality of this button and how best to implement.
        ID = EmpIDSeartTxt.Text
        Me.EmployeePastTableAdapter.FillByID(Me.Primary.EmployeePast, ID)
        Me.EmployeeFutureTableAdapter.FillByID(Me.Primary.EmployeeFuture, ID)
    End Sub

    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        'ATTENTION: This button should navigate to EmpDashboard.vb
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles payTstripBTN.Click
        'ATTENTION: This button should stay on Payroll.vb
        Me.Refresh()
    End Sub

    Private Sub calcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        'ATTENTION: This button should navigate to PayRateCalc.vb
        PayRateCalc.Show()
        Me.Close()
    End Sub

    Private Sub metricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        'ATTENTION: This button should navigate to Metrics.vb
        Metrics.Show()
        Me.Close()
    End Sub

    Private Sub DetailViewBTN_Click(sender As Object, e As EventArgs)
        'ATTENTION: This button should navigate to PaymentRecord.vb
        PaymentRecordBTN.Show()
        Me.Close()
    End Sub
    Private Sub PaymentRecordBTN_Click(sender As Object, e As EventArgs) Handles PaymentRecordBTN.Click
        PaymentRecord.Show()
        Me.Close()
    End Sub

    Private Sub PayStubBTN_Click(sender As Object, e As EventArgs) Handles PayStubBTN.Click
        'ATTENTION: This button should navigate to PayStub.vb
        PayStub.Show()
        Me.Close()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub LnameSearch_Click(sender As Object, e As EventArgs) Handles LnameSearch.Click
        lname = LnameSearchTxt.Text
        Me.EmployeePastTableAdapter.FillByLastName(Me.Primary.EmployeePast, lname)
        Me.EmployeeFutureTableAdapter.FillByLastName(Me.Primary.EmployeeFuture, lname)
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click

    End Sub

    Private Sub FnameSearch_Click(sender As Object, e As EventArgs) Handles FnameSearch.Click
        fname = FnameSearchTxt.Text
        Me.EmployeePastTableAdapter.FillByFirstName(Me.Primary.EmployeePast, fname)
        Me.EmployeeFutureTableAdapter.FillByFirstName(Me.Primary.EmployeeFuture, fname)
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Me.EmployeePastTableAdapter.Fill(Me.Primary.EmployeePast)
        ID = ""
        EmpIDSeartTxt.Clear()
        FnameSearchTxt.Clear()
        LnameSearchTxt.Clear()
    End Sub
End Class