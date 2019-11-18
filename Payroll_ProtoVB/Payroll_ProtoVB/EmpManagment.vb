Public Class EmpManagment

    Inherits System.Windows.Forms.Form

    Private Sub EmployeeMGMTFormCancelButton1_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormCancelButton1.Click
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeMGMTFormAddButton_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormAddButton.Click
        AddEmployee.ShowDialog()
    End Sub

    Private Sub EmployeeMGMTFormCancelButton2_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormCancelButton2.Click
        EmpDashboard.Show()
        Me.Close()
    End Sub
End Class