Imports NUnit.Framework
Imports Payroll_ProtoVB
<TestFixture>
Public Class LoginTest

    <TestCase("First", "Last", "123 Street", "SC", "12345", "password", "password", ExpectedResult:=True)>
    <TestCase("First", "Last", "123 Street", "SC", "12345", "password", "password1", ExpectedResult:=False)>
    <TestCase("", "Last", "123 Street", "SC", "12345", "password", "password", ExpectedResult:=False)>
    <TestCase("First", "", "123 Street", "SC", "12345", "password", "password", ExpectedResult:=False)>
    <TestCase("First", "Last", "", "SC", "12345", "password", "password", ExpectedResult:=False)>
    <TestCase("First", "Last", "123 Street", "", "12345", "password", "password", ExpectedResult:=False)>
    <TestCase("First", "Last", "123 Street", "SC", "", "password", "password", ExpectedResult:=False)>
    <TestCase("First", "Last", "123 Street", "SC", "12345", "", "password", ExpectedResult:=False)>
    <TestCase("First", "Last", "123 Street", "SC", "12345", "password", "", ExpectedResult:=False)>
    <TestCase("First", "Last", "123 Street", "SC", "12345", "", "", ExpectedResult:=False)>
    Function ValidationCheck(FName As String, LName As String, Street As String, State As String, Zip As String, PWord As String, VPWord As String) As Boolean
        Dim LgIn As LoginLogic = New LoginLogic()
        Dim result As Boolean

        result = LgIn.IsCreateUsrFormValid(FName, LName, Street, State, Zip, PWord, VPWord)
        Return result
    End Function

End Class
