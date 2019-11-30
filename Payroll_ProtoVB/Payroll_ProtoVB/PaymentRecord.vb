Public Class PaymentRecord

    Dim ID As String
    Public Sub New(nID As Integer)
        InitializeComponent()
        ID = nID
    End Sub
    Private Sub PaymentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.EmployeePast' table. You can move, or remove it, as needed.
        Me.EmployeePastTableAdapter.FillByID(Me.Primary.EmployeePast, ID)

        endPayPeriodDatePicker.Value = Date.Today
        strtPayPeriodDatePicker.Value = Date.Today.AddYears(-5)
    End Sub
    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        Me.Refresh()
    End Sub
    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles PayTstripBTN.Click
        Payroll.Show()
        Me.Close()
    End Sub

    Private Sub CalcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        PayRateCalc.Show()
        Me.Close()
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

    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles backBTN.Click
        FeedbackLogsTableAdapter1.CountPlusOne("PaymentRecord", "Back Button")

        Payroll.Show()
        Me.Close()
    End Sub

    Private Sub populateTabelBTN_Click(sender As Object, e As EventArgs) Handles populateTabelBTN.Click
        FeedbackLogsTableAdapter1.CountPlusOne("PaymentRecord", "Continue Button")

        Me.EmployeePastTableAdapter.FillByDate(Me.Primary.EmployeePast, strtPayPeriodDatePicker.Value, endPayPeriodDatePicker.Value, ID)
    End Sub

    Private Sub strtPayPeriodDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles strtPayPeriodDatePicker.ValueChanged
        FeedbackLogsTableAdapter1.CountPlusOne("PaymentRecord", "Start Date Selector")
    End Sub

    Private Sub endPayPeriodDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles endPayPeriodDatePicker.ValueChanged
        FeedbackLogsTableAdapter1.CountPlusOne("PaymentRecord", "End Date Selector")
    End Sub
End Class