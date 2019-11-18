Public Class PaymentRecord

    Private Sub PaymentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.EmployeePast' table. You can move, or remove it, as needed.
        Me.EmployeePastTableAdapter.Fill(Me.Primary.EmployeePast)

    End Sub
    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        Me.Refresh()
    End Sub
    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles PayTstripBTN.Click
        Payroll.Show()
    End Sub

    Private Sub CalcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        PayRateCalc.Show()
    End Sub

    Private Sub MetricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        Metrics.Show()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class