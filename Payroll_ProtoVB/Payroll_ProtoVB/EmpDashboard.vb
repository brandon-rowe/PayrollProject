Public Class EmpDashboard
    Private Sub EmpDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Primary.Employee)

    End Sub
End Class