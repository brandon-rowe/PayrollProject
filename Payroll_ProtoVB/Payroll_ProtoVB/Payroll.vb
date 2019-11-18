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

    Private Sub payStubViewBTN_Click(sender As Object, e As EventArgs) Handles payStubViewBTN.Click
        'ATTENTION: This button should navigate to PayStub.vb
        PayStub.Show()
        Me.Close()
    End Sub

    Private Sub metricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        'ATTENTION: This button should navigate to Metrics.vb
        Metrics.Show()
        Me.Close()
    End Sub

    Private Sub PayrollFormSearch_Click(sender As Object, e As EventArgs) Handles MyBaseFormSearch.Click
        'B. Rowe: We need to think through the functionality of this button and how best to implement.
    End Sub

    Private Sub EmpRecord_Click(sender As Object, e As EventArgs) Handles EmpRecord.Click
        'ATTENTION: This button should navigate to PaymentRecord.vb
        PaymentRecord.Show()
        Me.Close()
    End Sub
End Class