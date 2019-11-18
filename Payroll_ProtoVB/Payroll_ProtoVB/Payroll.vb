Public Class Payroll
    Inherits System.Windows.Forms.Form
    'load form
    Private Sub Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.EmployeeFuture' table. You can move, or remove it, as needed.
        Me.EmployeeFutureTableAdapter.Fill(Me.Primary.EmployeeFuture)
        'TODO: This line of code loads data into the 'Primary.EmployeePast' table. You can move, or remove it, as needed.
        Me.EmployeePastTableAdapter.Fill(Me.Primary.EmployeePast)
    End Sub

    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles payTstripBTN.Click
        Me.Refresh()
    End Sub



    Private Sub calcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        PayRateCalc.Show()
        Me.Close()
    End Sub

    Private Sub payStubViewBTN_Click(sender As Object, e As EventArgs) Handles payStubViewBTN.Click
        Dim Paystub = New PayStub()
        Paystub.Show()
        Me.Close()
    End Sub

    Private Sub metricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        Metrics.Show()
        Me.Close()
    End Sub

    Private Sub EmpRecord_Click(sender As Object, e As EventArgs) Handles EmpRecordView.Click
        PaymentRecord.Show()
        Me.Close()
    End Sub

End Class