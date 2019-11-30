Imports System.Math
Public Class PayRateCalc
    Const HourlyPayColIndex = 10
    Const HoursColIndex = 11
    Private Sub PayRateCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.FillBySalaried(Me.Primary.Employee)

        UpdatePayTextBoxes()

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

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs)
        Me.EmployeeBindingSource.EndEdit()
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        EmployeeTableAdapter.Adapter.Update(Me.Primary)
    End Sub

    Private Sub menueStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menueStrip.ItemClicked

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        FeedbackLogsTableAdapter1.CountPlusOne("Calculate", "Submit Payroll Button")

        Dim j = 0
        Dim amount As Double
        Dim ID As Integer
        Dim firstname, lastname As String
        Dim salaried As Boolean
        Dim hourlyRate, hoursWorked As Double
        Dim dependents As Integer
        Dim maritalstatus As Boolean
        Dim payFrequency As String
        Dim payRateLogic As New PayRateLogic
        Dim PayDate, PayDateMinusTwoDays As DateTime

        'Saves edits to the datagrid CM
        Me.EmployeeBindingSource.EndEdit()
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        EmployeeTableAdapter.Adapter.Update(Me.Primary)


        'Handles hourly employee CM
        While (j < (DataGridView1.Rows.Count() - 1))
            PayDateMinusTwoDays = EmployeeFutureTableAdapter1.GetFutureDate(DataGridView1.Item(0, j).Value)
            If (Date.Today >= PayDateMinusTwoDays.AddDays(-2)) Then
                payFrequency = DataGridView1.Item(13, j).Value
                PayDate = EmployeeFutureTableAdapter1.GetFutureDate(DataGridView1.Item(0, j).Value)
                ID = DataGridView1.Item(0, j).Value
                firstname = DataGridView1.Item(1, j).Value
                lastname = DataGridView1.Item(2, j).Value
                salaried = DataGridView1.Item(8, j).Value
                hourlyRate = DataGridView1.Item(HourlyPayColIndex, j).Value
                hoursWorked = DataGridView1.Item(HoursColIndex, j).Value
                dependents = DataGridView1.Item(6, j).Value
                maritalstatus = DataGridView1.Item(5, j).Value
                EmployeeFutureTableAdapter1.CopyQuery(ID)
                EmployeeFutureTableAdapter1.DeleteHourlyQuery(ID)
                amount = payRateLogic.CalculateHourlyPayTaxed(hourlyRate, hoursWorked, dependents, maritalstatus, payFrequency)
                If (payFrequency = "Monthly") Then
                    PayDate = PayDate.AddMonths(1)
                ElseIf (payFrequency = "Bi-Weekly") Then
                    PayDate = PayDate.AddDays(14)
                Else
                    PayDate = PayDate.AddDays(7)
                End If
                EmployeeFutureTableAdapter1.InsertHourlyQuery(ID, PayDate, amount, firstname, lastname, salaried, payFrequency)
            End If
            j = j + 1
        End While


        'Handles salaried employee CM
        Dim salariedDate As DateTime = EmployeeFutureTableAdapter1.SalariedDateQuery()

        If (Date.Today >= salariedDate.AddDays(-2)) Then
            EmployeeFutureTableAdapter1.CopySalariedQuery()
            EmployeeFutureTableAdapter1.SalariedUpdateQuery(salariedDate.AddMonths(1))
            EmployeeFutureTableAdapter1.SalariedDeleteQuery(salariedDate.AddMonths(1))
        End If


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        UpdatePayTextBoxes()
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        UpdatePayTextBoxes()
    End Sub


    ' Updates GrossPayTxtBox, NetPayTxtBox, and TaxesTxtBox
    Private Sub UpdatePayTextBoxes()
        Dim payRateLogic As New PayRateLogic
        Dim grossPay, netPay As Double


        ' Trys to get values from DataGridView, if it cannot then the Text defaults to 0.0
        Try
            GrossPayTxtBox.Text = "$" + CStr(payRateLogic.CalculateHourlyPay(DataGridView1.Item(HourlyPayColIndex, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(HoursColIndex, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value))
            grossPay = GrossPayTxtBox.Text.Substring(1)
        Catch
            GrossPayTxtBox.Text = "$0.0"
            grossPay = 0.0
        End Try

        Try
            NetPayTxtBox.Text = "$" + CStr(payRateLogic.CalculateHourlyPayTaxed(DataGridView1.Item(HourlyPayColIndex, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(HoursColIndex, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value))
            netPay = NetPayTxtBox.Text.Substring(1)
        Catch
            NetPayTxtBox.Text = "$0.0"
            netPay = 0.0
        End Try

        TaxesTxtBox.Text = "$" + CStr(Abs(netPay - grossPay))
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    ' Moved Test Calculation to PayRateLogic.vb for testing purposes
    ' Also we should decouple as much logic away from UI as possible (see MVC architecture)
    ' We'll call PayRateLogic.CalculateHourlyPay(hourlyPayRate, numHours, regHours) which returns the amount of money before taxes
    ' Then we'll call PayRateLogic.ApplyTaxes(pay, marStatus, dependents, ...) 
    ' I'm not sure what esle we'll need to apply taxes which is why there are ellipsis
End Class