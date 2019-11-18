Public Class Metrics
    Private Sub Metrics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        EmpDashboard.Show()
        Me.Close()
    End Sub
    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles payTstripBTN.Click
        Payroll.Show()
        Me.Close()
    End Sub

    Private Sub CalcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        PayRateCalc.Show()
        Me.Close()
    End Sub

    Private Sub MetricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        Me.Refresh()
    End Sub
End Class