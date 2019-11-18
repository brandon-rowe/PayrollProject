Imports Payroll_ProtoVB.PrimaryTableAdapters

Public Class EmpManagment

    Inherits System.Windows.Forms.Form
    Dim employTA As New EmployeeTableAdapter
    Dim ID As Integer

    Private Sub EmployeeMGMTFormCancelButton1_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormCancelButton1.Click
        'ATTENTION: This button should navigate to EmpDashboard.vb
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeMGMTFormAddButton_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormAddButton.Click
        'ATTENTION: This button should navigate to AddEmployee.vb
        Dim AddEmployee = New AddEmployee()
        AddEmployee.Show()
    End Sub

    Private Sub EmployeeMGMTFormCancelButton2_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormCancelButton2.Click
        'ATTENTION: This button should navigate to EmpDashboard.vb
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub employeeMGMTFormSearch_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormSearch.Click
        'B. Rowe: We need to think through the functionality of these buttons.

    End Sub

    Private Sub employeeMGMTFormEditButton_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormEditButton.Click
        'How best to implement them and should be link to previous forms to solve
        'some of these tasks.
    End Sub

    Private Sub employeeMGMTFormRmvEmployeeButton_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormRmvEmployeeButton.Click
        'B. Rowe: We need to think through the functionality of these buttons.
        ID = EmpIDTxt.Text
        employTA.DeleteRow(ID)
    End Sub

End Class