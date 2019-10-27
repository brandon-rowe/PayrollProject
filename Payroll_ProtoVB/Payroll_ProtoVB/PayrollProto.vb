Public Class PayrollProto

    'load form
    Private Sub PayrollProto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_540GroupProjectDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me._540GroupProjectDataSet.Employee)

    End Sub


End Class
