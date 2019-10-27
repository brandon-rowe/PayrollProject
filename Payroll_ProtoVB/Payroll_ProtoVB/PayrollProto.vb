Public Class PayrollProto

    'load form
    Private Sub PayrollProto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_540GroupProjectDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me._540GroupProjectDataSet.Employee)

    End Sub

    'Menue Strip
    Private Sub MenueStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menueStrip.ItemClicked

    End Sub

    'menue buttons'
    'dashboard
    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click

    End Sub

    'payroll
    Private Sub payTstripBTN_Click(sender As Object, e As EventArgs) Handles payTstripBTN.Click

    End Sub

    'metrics
    Private Sub MetricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click

    End Sub
    'end of menue buttons'
    'Menue button separators'
    Private Sub ToolStripSeparator1_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator1.Click

    End Sub

    Private Sub ToolStripSeparator2_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator2.Click

    End Sub

    Private Sub ToolStripSeparator3_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator3.Click

    End Sub

    Private Sub ToolStripSeparator4_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator4.Click

    End Sub

    Private Sub ToolStripSeparator5_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator5.Click

    End Sub

    Private Sub ToolStripSeparator6_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator6.Click

    End Sub
    'end of Menue items'

    'datagrid
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick

    End Sub

    'employee managment button
    Private Sub DashboardEmployeeMGMTButton_Click(sender As Object, e As EventArgs) Handles dashboardEmployeeMGMTButton.Click

    End Sub
End Class
