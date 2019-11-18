Public Class PayStub
    Inherits System.Windows.Forms.Form

    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        Me.Refresh()
    End Sub
    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles payTstripBTN.Click
        Payroll.Show()
    End Sub

    Private Sub CalcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        PayRateCalc.Show()
    End Sub

    Private Sub MetricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        Metrics.Show()
    End Sub

End Class