Public Class AddEmployee
    'load form
    Dim EmpFname As String
    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addEmployeeFormAddButton_Click(sender As Object, e As EventArgs) Handles addEmployeeFormAddButton.Click
        EmpFname = addEmpFnameTxt.Text
        Console.WriteLine(EmpFname)

    End Sub
End Class
