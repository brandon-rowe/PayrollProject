Imports Payroll_ProtoVB.PrimaryTableAdapters

Public Class EmpManagment

    Inherits System.Windows.Forms.Form
    Dim employTA As New EmployeeTableAdapter
    Dim ID As Integer
    Dim Row As Integer

    Public Sub New(nRow As Integer)
        InitializeComponent()
        Row = nRow
    End Sub

    Private Sub EmployeeMGMTFormCancelButton1_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormCancelButton1.Click
        'ATTENTION: This button should navigate to EmpDashboard.vb
        EmpDashboard.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeMGMTFormAddButton_Click(sender As Object, e As EventArgs) Handles employeeMGMTFormAddButton.Click
        'ATTENTION: This button should navigate to AddEmployee.vb
        Dim AddEmployee = New AddEmployee()
        AddEmployee.Show()
        Me.Close()
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
        'This button only takes in the ID as a selector to delete the record.
        ID = EmpIDTxt.Text
        employTA.DeleteRow(ID)
    End Sub

    Private Sub EmpManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.employTA.FillBySelectedRow(Me.Primary.Employee, Row)
    End Sub
End Class