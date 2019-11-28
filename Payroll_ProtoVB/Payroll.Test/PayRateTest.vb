Imports NUnit.Framework
Imports Payroll_ProtoVB

<TestFixture>
Public Class PayRateTest
    <TestCase(25, 10, ExpectedResult:=250)>
    <TestCase(0, 10, ExpectedResult:=0)>
    <TestCase(0, 0, ExpectedResult:=0)>
    <TestCase(-1, 0, ExpectedResult:=0)>
    <TestCase(-1, -1, ExpectedResult:=0)>
    <TestCase(0, -1, ExpectedResult:=0)>
    <TestCase(25, 41, ExpectedResult:=1037.5)>
    Function PayTest(pay As Double, hours As Double) As Double
        Dim PayRate As PayRateLogic = New PayRateLogic()
        'Dim result As Double = PayRate.CalculateHourlyPay(pay, hours)

        ' Return result
    End Function

    'Stub for testing when taxes work
    'Function TestTaxes(Pay As Double, marStatus As String, Dependents As Integer)

    'End Function
End Class
