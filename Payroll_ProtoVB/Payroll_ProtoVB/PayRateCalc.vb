Imports System.Math
Public Class PayRateCalc
    Private Sub PayRateCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.FillBySalaried(Me.Primary.Employee)

        Dim payRateLogic As New PayRateLogic
        Dim grossPay, netPay As Double

        Try
            GrossPayTxtBox.Text = "$" + CStr((DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value * DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value))
            grossPay = GrossPayTxtBox.Text.Substring(1)
        Catch
            GrossPayTxtBox.Text = "$0.0"
            grossPay = 0.0
        End Try

        Try
            NetPayTxtBox.Text = "$" + CStr(payRateLogic.CalculateHourlyPay(DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value))
            netPay = NetPayTxtBox.Text.Substring(1)
        Catch
            NetPayTxtBox.Text = "$0.0"
            netPay = 0.0
        End Try

        TaxesTxtBox.Text = "$" + CStr(Abs(netPay - grossPay))

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
        Me.EmployeeBindingSource.EndEdit()
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        EmployeeTableAdapter.Adapter.Update(Me.Primary)
    End Sub

    Private Sub menueStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menueStrip.ItemClicked

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Me.EmployeeBindingSource.EndEdit()
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        EmployeeTableAdapter.Adapter.Update(Me.Primary)
        EmployeeFutureTableAdapter1.CopyQuery()
        EmployeeFutureTableAdapter1.DeleteHourlyQuery()

        Dim PayDate As DateTime
        Dim newMonth As String = CStr(Date.Today.Month)
        Dim newYear As String = CStr(Date.Today.Year)

        If (Date.Today.Day > 15 And Date.Today.Month = 12) Then
            newMonth = 1
            newYear = Date.Today.Year + 1
        ElseIf (Date.Today.Day > 15) Then
            newMonth = Date.Today.Month + 1
        End If

        If (newMonth.Length = 1) Then
            newMonth = "0" + newMonth
        End If

        PayDate = DateTime.ParseExact(newMonth + "15" + newYear, "MMddyyyy", Nothing)

        Dim datesalaried As DateTime = PayDate

        Try
            datesalaried = EmployeeFutureTableAdapter1.SalariedDateQuery()
        Catch
        End Try

        If (datesalaried < PayDate) Then
            EmployeeFutureTableAdapter1.CopySalariedQuery()
            EmployeeFutureTableAdapter1.SalariedUpdateQuery(datesalaried.AddMonths(1))
            Try
                EmployeeFutureTableAdapter1.SalariedDeleteQuery(datesalaried)
            Catch
            End Try
        End If


        Dim i = 0
        Dim amount As Double
        Dim ID As Integer
        Dim firstname, lastname As String
        Dim salaried As Boolean
        Dim payRateLogic As New PayRateLogic

        While (i < (DataGridView1.Rows.Count() - 1))
            amount = payRateLogic.CalculateHourlyPay(DataGridView1.Item(10, i).Value, DataGridView1.Item(11, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(5, i).Value)
            ID = DataGridView1.Item(0, i).Value
            firstname = DataGridView1.Item(1, i).Value
            lastname = DataGridView1.Item(2, i).Value
            salaried = DataGridView1.Item(8, i).Value
            EmployeeFutureTableAdapter1.InsertHourlyQuery(ID, PayDate, amount, firstname, lastname, salaried)
            i = i + 1
        End While

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim payRateLogic As New PayRateLogic
        Dim grossPay, netPay As Double

        Try
            GrossPayTxtBox.Text = "$" + CStr((DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value * DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value))
            grossPay = GrossPayTxtBox.Text.Substring(1)
        Catch
            GrossPayTxtBox.Text = "$0.0"
            grossPay = 0.0
        End Try

        Try
            NetPayTxtBox.Text = "$" + CStr(payRateLogic.CalculateHourlyPay(DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value))
            netPay = NetPayTxtBox.Text.Substring(1)
        Catch
            NetPayTxtBox.Text = "$0.0"
            netPay = 0.0
        End Try

        TaxesTxtBox.Text = "$" + CStr(Abs(netPay - grossPay))
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        Dim payRateLogic As New PayRateLogic
        Dim grossPay, netPay As Double

        Try
            GrossPayTxtBox.Text = "$" + CStr((DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value * DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value))
            grossPay = GrossPayTxtBox.Text.Substring(1)
        Catch
            GrossPayTxtBox.Text = "$0.0"
            grossPay = 0.0
        End Try

        Try
            NetPayTxtBox.Text = "$" + CStr(payRateLogic.CalculateHourlyPay(DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value, DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value))
            netPay = NetPayTxtBox.Text.Substring(1)
        Catch
            NetPayTxtBox.Text = "$0.0"
            netPay = 0.0
        End Try

        TaxesTxtBox.Text = "$" + CStr(Abs(netPay - grossPay))
    End Sub


    ' Moved Test Calculation to PayRateLogic.vb for testing purposes
    ' Also we should decouple as much logic away from UI as possible (see MVC architecture)
    ' We'll call PayRateLogic.CalculateHourlyPay(hourlyPayRate, numHours, regHours) which returns the amount of money before taxes
    ' Then we'll call PayRateLogic.ApplyTaxes(pay, marStatus, dependents, ...) 
    ' I'm not sure what esle we'll need to apply taxes which is why there are ellipsis
End Class