Public Class EmpDashboard
    Private Sub EmpDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Primary.Employee)
    End Sub

    Private Sub DashBTN_Click(sender As Object, e As EventArgs) Handles dashBTN.Click
        'ATTENTION: This button should stay on EmpDashboard.vb
        Me.Refresh()
    End Sub

    Private Sub PayrollBTN_Click(sender As Object, e As EventArgs) Handles payrollBTN.Click
        'ATTENTION: This button should navigate to Payroll.vb
        Payroll.Show()
        Me.Close()
    End Sub

    Private Sub CalcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        'ATTENTION: This button should navigate to PayRateCalc.vb
        PayRateCalc.Show()
        Me.Close()
    End Sub

    Private Sub MetricsBTN_Click(sender As Object, e As EventArgs) Handles metricsBTN.Click
        'ATTENTION: This button should navigate to Metrics.vb
        Metrics.Show()
        Me.Close()
    End Sub

    Private Sub DetailViewBTN_Click(sender As Object, e As EventArgs) Handles DetailViewBTN.Click
        'ATTENTION: This button should navigate to EmpManagement.vb
        EmpManagment.Show()
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
End Class