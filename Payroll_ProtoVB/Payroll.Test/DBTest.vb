Imports NUnit.Framework
Imports Payroll_ProtoVB

Public Class DBTest
    Dim EmpTA As New PrimaryTableAdapters.EmployeeTableAdapter
    <TestCase(0, "first", "last", "boss", "123 address", True, 0, True, True, 1000, 0, 0, "123456789", "user", "pass", ExpectedResult:=True)>
    Public Function AddEmployee(ID As Integer, FName As String, LName As String, Position As String, Address As String, MaritalStatus As Boolean,
                                Dependents As Integer, Admin As Boolean, Salaried As Boolean, Salary As Decimal, HourlyRate As Decimal, HoursWorked As Decimal,
                                SSN As String, UName As String, PWord As String) As Boolean

        Dim EmployeeDT As New Primary.EmployeeDataTable

        Dim Row As Primary.EmployeeRow = EmployeeDT.NewEmployeeRow()
        Row.ID = ID
        Row.fname = FName
        Row.lname = LName
        Row.title = Position
        Row.address = Address
        Row.maritalstatus = MaritalStatus
        Row.dependents = Dependents
        Row.admin = Admin
        Row.salaried = Salaried
        Row.salary = Salary
        Row.hourlyrate = HourlyRate
        Row.hoursworked = HoursWorked
        Row.ssn = SSN
        Row.usern = UName
        Row.pass = PWord

        EmployeeDT.AddEmployeeRow(Row)

        EmpTA.Fill(EmployeeDT)

        Dim FilledDT As Primary.EmployeeDataTable = EmpTA.GetDataByID(ID)

        Dim FilledRow As Primary.EmployeeRow = FilledDT.Rows(0)

        Return FilledRow.fname = Row.fname
    End Function

End Class
