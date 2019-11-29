Imports Payroll_ProtoVB.PrimaryTableAdapters

Public Class EmpDashboard
    Dim employTA As New EmployeeTableAdapter


    Private Sub EmpDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Primary.Employee)
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.EmployeeBindingSource.EndEdit()
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        employTA.Adapter.Update(Me.Primary)
    End Sub

    Private Sub EmpDetailedView_Click(sender As Object, e As EventArgs) Handles EmpDetailedView.Click
        'ATTENTION: This button should navigate to EmpManagement.vb

        'saves edit first CM
        Me.EmployeeBindingSource.EndEdit()
        DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        employTA.Adapter.Update(Me.Primary)

        'shows empmanagement CM
        Dim EmpManagment = New EmpManagment(DataGridView1.CurrentRow.Index + 1)
        EmpManagment.Show()
        Me.Close()
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

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class