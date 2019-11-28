Imports NUnit.Framework
Imports Payroll_ProtoVB

<TestFixture>
Public Class PayRateTest
    Dim PayRate As PayRateLogic
    <OneTimeSetUp>
    Sub Setup()
        PayRate = New PayRateLogic()
    End Sub
    <TestCase(25, 10, ExpectedResult:=250)>
    <TestCase(0, 10, ExpectedResult:=0)>
    <TestCase(0, 0, ExpectedResult:=0)>
    <TestCase(-1, 0, ExpectedResult:=0)>
    <TestCase(-1, -1, ExpectedResult:=0)>
    <TestCase(0, -1, ExpectedResult:=0)>
    <TestCase(25, 41, ExpectedResult:=1037.5)>
    Function HourlyUnTaxedTest(Pay As Double, Hours As Double) As Double
        Dim result As Double = PayRate.CalculateHourlyPay(Pay, Hours)

        Return result
    End Function

    <TestCase(25, 10, 1, False, ExpectedResult:=250)>
    <TestCase(0, 10, 1, False, ExpectedResult:=0)>
    <TestCase(0, 0, 1, False, ExpectedResult:=0)>
    <TestCase(-1, 0, 1, False, ExpectedResult:=0)>
    <TestCase(-1, -1, 1, False, ExpectedResult:=0)>
    <TestCase(0, -1, 1, False, ExpectedResult:=0)>
    <TestCase(25, 41, 1, False, ExpectedResult:=1037.5)>
    Function HourlyTaxedTest_UnMarried(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean) As Double
        Dim HourlyUnTaxedPay = PayRate.CalculateHourlyPay(Pay, Hours)
        Dim result = PayRate.ApplyTaxes(HourlyUnTaxedPay, Dependents, MarStatus)

        Return result
    End Function

    <TestCase(25, 10, 1, True, ExpectedResult:=250)>
    <TestCase(0, 10, 1, True, ExpectedResult:=0)>
    <TestCase(0, 0, 1, True, ExpectedResult:=0)>
    <TestCase(-1, 0, 1, True, ExpectedResult:=0)>
    <TestCase(-1, -1, 1, True, ExpectedResult:=0)>
    <TestCase(0, -1, 1, True, ExpectedResult:=0)>
    <TestCase(25, 41, 1, True, ExpectedResult:=1037.5)>
    Function HourlyTaxedTest_Married(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean) As Double
        Dim HourlyUnTaxedPay = PayRate.CalculateHourlyPay(Pay, Hours)
        Dim result = PayRate.ApplyTaxes(HourlyUnTaxedPay, Dependents, MarStatus)

        Return result
    End Function
End Class
