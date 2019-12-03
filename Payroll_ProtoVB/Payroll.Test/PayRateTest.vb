Imports NUnit.Framework
Imports Payroll_ProtoVB

<TestFixture>
Public Class PayRateTest
    Dim PayRate As PayRateLogic
    Const Monthly = "Monthly"
    Const Biweekly = "Bi-Weekly"
    Const Weekly = "Weekly"

    <OneTimeSetUp>
    Sub Setup()
        PayRate = New PayRateLogic()
    End Sub


    <TestCase(25, 10, Monthly, ExpectedResult:=250)>
    <TestCase(0, 10, Monthly, ExpectedResult:=0)>
    <TestCase(0, 0, Monthly, ExpectedResult:=0)>
    <TestCase(-1, 0, Monthly, ExpectedResult:=0)>
    <TestCase(-1, -1, Monthly, ExpectedResult:=0)>
    <TestCase(0, -1, Monthly, ExpectedResult:=0)>
    <TestCase(25, 161, Monthly, ExpectedResult:=4037.5)>
    Function HourlyUnTaxedMonthlyTest(Pay As Double, Hours As Double, PayFrequency As String) As Double
        Dim result As Double = PayRate.CalculateHourlyPay(Pay, Hours, PayFrequency)

        Return result
    End Function

    <TestCase(25, 10, Biweekly, ExpectedResult:=250)>
    <TestCase(0, 10, Biweekly, ExpectedResult:=0)>
    <TestCase(0, 0, Biweekly, ExpectedResult:=0)>
    <TestCase(-1, 0, Biweekly, ExpectedResult:=0)>
    <TestCase(-1, -1, Biweekly, ExpectedResult:=0)>
    <TestCase(0, -1, Biweekly, ExpectedResult:=0)>
    <TestCase(25, 81, Biweekly, ExpectedResult:=2037.5)>
    Function HourlyUnTaxedBiWeeklyTest(Pay As Double, Hours As Double, PayFrequency As String) As Double
        Dim result As Double = PayRate.CalculateHourlyPay(Pay, Hours, PayFrequency)

        Return result
    End Function

    <TestCase(25, 10, Weekly, ExpectedResult:=250)>
    <TestCase(0, 10, Weekly, ExpectedResult:=0)>
    <TestCase(0, 0, Weekly, ExpectedResult:=0)>
    <TestCase(-1, 0, Weekly, ExpectedResult:=0)>
    <TestCase(-1, -1, Weekly, ExpectedResult:=0)>
    <TestCase(0, -1, Weekly, ExpectedResult:=0)>
    <TestCase(25, 41, Weekly, ExpectedResult:=1037.5)>
    Function HourlyUnTaxedWeeklyTest(Pay As Double, Hours As Double, PayFrequency As String) As Double
        Dim result As Double = PayRate.CalculateHourlyPay(Pay, Hours, PayFrequency)

        Return result
    End Function
    <TestCase(25, 10, 1, False, Monthly, ExpectedResult:=202.5)>
    <TestCase(25, 10, 0, False, Monthly, ExpectedResult:=182.5)>
    <TestCase(25, 10, -1, False, Monthly, ExpectedResult:=182.5)>
    <TestCase(0, 10, 1, False, Monthly, ExpectedResult:=0)>
    <TestCase(0, 0, 1, False, Monthly, ExpectedResult:=0)>
    <TestCase(-1, 0, 1, False, Monthly, ExpectedResult:=0)>
    <TestCase(-1, -1, 1, False, Monthly, ExpectedResult:=0)>
    <TestCase(0, -1, 1, False, Monthly, ExpectedResult:=0)>
    <TestCase(25, 41, 1, False, Monthly, ExpectedResult:=768.25)>
    <TestCase(25, 161, 1, False, Monthly, ExpectedResult:=2937.38)>
    Function HourlyTaxedTestMonthly_UnMarried(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    <TestCase(25, 10, 1, False, Biweekly, ExpectedResult:=202.5)>
    <TestCase(0, 10, 1, False, Biweekly, ExpectedResult:=0)>
    <TestCase(0, 0, 1, False, Biweekly, ExpectedResult:=0)>
    <TestCase(-1, 0, 1, False, Biweekly, ExpectedResult:=0)>
    <TestCase(-1, -1, 1, False, Biweekly, ExpectedResult:=0)>
    <TestCase(0, -1, 1, False, Biweekly, ExpectedResult:=0)>
    <TestCase(25, 41, 1, False, Biweekly, ExpectedResult:=768.25)>
    <TestCase(25, 81, 1, False, Biweekly, ExpectedResult:=1507.38)>
    Function HourlyTaxedTestBiweekly_UnMarried(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    <TestCase(25, 10, 1, False, Weekly, ExpectedResult:=202.5)>
    <TestCase(0, 10, 1, False, Weekly, ExpectedResult:=0)>
    <TestCase(0, 0, 1, False, Weekly, ExpectedResult:=0)>
    <TestCase(-1, 0, 1, False, Weekly, ExpectedResult:=0)>
    <TestCase(-1, -1, 1, False, Weekly, ExpectedResult:=0)>
    <TestCase(0, -1, 1, False, Weekly, ExpectedResult:=0)>
    <TestCase(25, 41, 1, False, Weekly, ExpectedResult:=777.38)>
    Function HourlyTaxedTestWeekly_UnMarried(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    <TestCase(25, 10, 1, True, Monthly, ExpectedResult:=252.5)>
    <TestCase(0, 10, 1, True, Monthly, ExpectedResult:=0)>
    <TestCase(0, 0, 1, True, Monthly, ExpectedResult:=0)>
    <TestCase(-1, 0, 1, True, Monthly, ExpectedResult:=0)>
    <TestCase(-1, -1, 1, True, Monthly, ExpectedResult:=0)>
    <TestCase(0, -1, 1, True, Monthly, ExpectedResult:=0)>
    <TestCase(25, 41, 1, True, Monthly, ExpectedResult:=818.25)>
    <TestCase(25, 161, 1, True, Monthly, ExpectedResult:=3017.38)>
    Function HourlyTaxedTestMonthly_Married(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    <TestCase(25, 10, 1, True, Biweekly, ExpectedResult:=252.5)>
    <TestCase(0, 10, 1, True, Biweekly, ExpectedResult:=0)>
    <TestCase(0, 0, 1, True, Biweekly, ExpectedResult:=0)>
    <TestCase(-1, 0, 1, True, Biweekly, ExpectedResult:=0)>
    <TestCase(-1, -1, 1, True, Biweekly, ExpectedResult:=0)>
    <TestCase(0, -1, 1, True, Biweekly, ExpectedResult:=0)>
    <TestCase(25, 41, 1, True, Biweekly, ExpectedResult:=818.25)>
    <TestCase(25, 81, 1, True, Biweekly, ExpectedResult:=1557.38)>
    Function HourlyTaxedTestBiweekly_Married(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    <TestCase(25, 10, 1, True, Weekly, ExpectedResult:=252.5)>
    <TestCase(0, 10, 1, True, Weekly, ExpectedResult:=0)>
    <TestCase(0, 0, 1, True, Weekly, ExpectedResult:=0)>
    <TestCase(-1, 0, 1, True, Weekly, ExpectedResult:=0)>
    <TestCase(-1, -1, 1, True, Weekly, ExpectedResult:=0)>
    <TestCase(0, -1, 1, True, Weekly, ExpectedResult:=0)>
    <TestCase(25, 41, 1, True, Weekly, ExpectedResult:=827.38)>
    Function HourlyTaxedTestWeekly_Married(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function
End Class
