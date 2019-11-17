Public Class EmpManagment

    'load form
    Private Sub EmpManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EmployeeMGMTFormCancelButton1_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormCancelButton1.Click
        Me.Close()
        EmpDashboard.BringToFront()

    End Sub
End Class