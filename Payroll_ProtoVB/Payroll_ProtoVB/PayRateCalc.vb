Public Class PayRateCalc
    Private Sub PayRateCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Primary.Employee)

    End Sub
    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        EmpDashboard.Show()
        Me.Close()
    End Sub
    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles PayTstripBTN.Click
        Payroll.Show()
        Me.Close()
    End Sub

    Private Sub CalcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        Me.Refresh()
    End Sub

    Private Sub MetricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        Metrics.Show()
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

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        EmployeeTableAdapter.Adapter.Update(Me.Primary)
    End Sub

    Private Sub menueStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menueStrip.ItemClicked

    End Sub


    ' Moved Test Calculation to PayRateLogic.vb for testing purposes
    ' Also we should decouple as much logic away from UI as possible (see MVC architecture)
    ' We'll call PayRateLogic.CalculateHourlyPay(hourlyPayRate, numHours, regHours) which returns the amount of money before taxes
    ' Then we'll call PayRateLogic.ApplyTaxes(pay, marStatus, dependents, ...) 
    ' I'm not sure what esle we'll need to apply taxes which is why there are ellipsis
End Class