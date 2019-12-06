Imports NUnit.Framework
Imports Payroll_ProtoVB

<TestFixture>
Public Class PayRateTestMonthly
    Dim PayRate As PayRateLogic
    Const Monthly = "Monthly"
    Const Biweekly = "Bi-Weekly"
    Const Weekly = "Weekly"

    <OneTimeSetUp>
    Sub Setup()
        PayRate = New PayRateLogic()
    End Sub




    '
    ' Tests untaxed calculations for hourly worker paid Monthly
    '
    <TestCase(25, 10, Monthly, ExpectedResult:=250)>     'Standard case: $25 an hour, 10 hours
    <TestCase(0, 10, Monthly, ExpectedResult:=0)>        '$0 an hour, 10 hours
    <TestCase(0, 0, Monthly, ExpectedResult:=0)>         '$0 an hour, 0 hours
    <TestCase(-1, 0, Monthly, ExpectedResult:=0)>        'Aberrant case: -$1 an hour, 0 hours
    <TestCase(-1, -1, Monthly, ExpectedResult:=0)>       'Aberrant case: -$1 an hour, -1 hours
    <TestCase(0, -1, Monthly, ExpectedResult:=0)>        'Aberrant case: $0 an hour, -1 hours
    <TestCase(25, 161, Monthly, ExpectedResult:=4037.5)> 'Montlhy Overtime: $25 an hour, 161 hours
    Function HourlyUnTaxedMonthlyTest(Pay As Double, Hours As Double, PayFrequency As String) As Double
        Dim result As Double = PayRate.CalculateHourlyPay(Pay, Hours, PayFrequency)

        Return result
    End Function




    '
    ' Tests taxed calculations for Unmarried hourly worker paid Monthly
    '
    <TestCase(25, 10, 1, False, Monthly, ExpectedResult:=202.5)>    'Standard case: $25 an hour, 10 hours, 1 dependent, Unmarried
    <TestCase(0, 10, 1, False, Monthly, ExpectedResult:=20)>        '$0 an hour, 10 hours, 1 dependent, Unmarried
    <TestCase(0, 0, 1, False, Monthly, ExpectedResult:=0)>          '$0 an hour, 0 hours, 1 dependent, Unmarried
    <TestCase(-1, 0, 1, False, Monthly, ExpectedResult:=0)>         'Aberrant case: -$1 an hour, 0 hours, 1 dependent, Unmarried
    <TestCase(-1, -1, 1, False, Monthly, ExpectedResult:=0)>        'Aberrant case: -$1 an hour, -1 hours, 1 dependent, Unmarried
    <TestCase(0, -1, 1, False, Monthly, ExpectedResult:=0)>         'Aberrant case: $0 an hour, -1 hours, 1 dependent, Unmarried
    <TestCase(25, 161, 1, False, Monthly, ExpectedResult:=2967.38)> 'Montlhy Overtime: $25 an hour, 161 hours, 1 dependent, Unmarried
    Function HourlyTaxedTestMonthly_UnMarried(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function




    '
    ' Tests taxed calculations for Married hourly worker paid Monthly
    '
    <TestCase(25, 10, 1, True, Monthly, ExpectedResult:=252.5)>     'Standard case: $25 an hour, 10 hours, 1 dependent, Married
    <TestCase(0, 10, 1, True, Monthly, ExpectedResult:=70)>         '$0 an hour, 10 hours, 1 dependent, Married
    <TestCase(0, 0, 1, True, Monthly, ExpectedResult:=0)>           '$0 an hour, 0 hours, 1 dependent, Married
    <TestCase(-1, 0, 1, True, Monthly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, 0 hours, 1 dependent, Married
    <TestCase(-1, -1, 1, True, Monthly, ExpectedResult:=0)>         'Aberrant case: -$1 an hour, -1 hours, 1 dependent, Married
    <TestCase(0, -1, 1, True, Monthly, ExpectedResult:=0)>          'Aberrant case: $0 an hour, -1 hours, 1 dependent, Married
    <TestCase(25, 161, 1, True, Monthly, ExpectedResult:=3017.38)>  'Monthly Overtime: $25 an hour, 161 hours, 1 dependent, Married
    Function HourlyTaxedTestMonthly_Married(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

End Class
