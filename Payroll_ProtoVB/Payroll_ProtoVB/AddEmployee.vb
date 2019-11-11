Public Class AddEmployee
    Inherits System.Windows.Forms.Form
    'load form
    Dim EmpFname As String
    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addEmployeeFormAddButton_Click(sender As Object, e As EventArgs) Handles AddEmpBtn.Click
        EmpFname = addEmpFnameTxt.Text
        Console.WriteLine(EmpFname)

    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        Dim Payroll = New Payroll()
        Payroll.Show()
    End Sub
End Class
