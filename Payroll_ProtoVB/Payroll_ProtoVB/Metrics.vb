Public Class Metrics
    Private Sub Metrics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.FeedbackLogs' table. You can move, or remove it, as needed.
        Me.FeedbackLogsTableAdapter.Fill(Me.Primary.FeedbackLogs)
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Primary.Employee)
        'Chart1.DataBindTable(FeedbackLogsBindingSource, "count")
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Chart1.Series(0).Points.DataBind(EmployeeBindingSource, "hoursworked", "salary", "")

        'Chart1.Series["Series 1"].XValueMember = "Name"
        'Chart1.Series["Series 1"].YValueMembers = "Sales"
        'Chart1.Series.Add()
        'Chart1.DataBind()


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

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class