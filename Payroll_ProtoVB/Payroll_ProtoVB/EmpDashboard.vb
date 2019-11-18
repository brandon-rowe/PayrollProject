Public Class EmpDashboard
    Private Sub EmpDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Primary.Employee)
    End Sub

    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        'ATTENTION: This button should stay on EmpDashboard.vb
        Me.Refresh()
    End Sub

    Private Sub BtnDetailedView_Click(sender As Object, e As EventArgs) Handles btnDetailedView.Click
        'ATTENTION: This button should navigate to EmpManagement.vb
        EmpManagment.Show()
        Me.Close()
    End Sub
    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles payTstripBTN.Click
        'ATTENTION: This button should navigate to Payroll.vb
        Payroll.Show()
        Me.Close()
    End Sub

    Private Sub CalcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        'ATTENTION: This button should navigate to PayRateCalc.vb
        PayRateCalc.Show()
        Me.Close()
    End Sub

    Private Sub MetricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        'ATTENTION: This button should navigate to Metrics.vb
        Metrics.Show()
        Me.Close()
    End Sub
End Class