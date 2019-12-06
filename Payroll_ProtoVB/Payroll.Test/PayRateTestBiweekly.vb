Imports NUnit.Framework
Imports Payroll_ProtoVB

<TestFixture>
Public Class PayRateTestBiweekly
    Dim PayRate As PayRateLogic
    Const Monthly = "Monthly"
    Const Biweekly = "Bi-Weekly"
    Const Weekly = "Weekly"

    <OneTimeSetUp>
    Sub Setup()
        PayRate = New PayRateLogic()
    End Sub




    '
    ' Tests untaxed calculations for hourly worker paid Biweekly
    '
    <TestCase(25, 10, Biweekly, ExpectedResult:=250)>       'Standard case: $25 an hour, 10 hours
    <TestCase(0, 10, Biweekly, ExpectedResult:=0)>          '$0 an hour, 10 hours
    <TestCase(0, 0, Biweekly, ExpectedResult:=0)>           '$0 an hour, 0 hours
    <TestCase(-1, 0, Biweekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, 0 hours
    <TestCase(-1, -1, Biweekly, ExpectedResult:=0)>         'Aberrant case: -$1 an hour, -1 hours
    <TestCase(0, -1, Biweekly, ExpectedResult:=0)>          'Aberrant case: $0 an hour, -1 hours
    <TestCase(25, 81, Biweekly, ExpectedResult:=2037.5)>    'Biweekly Overtime: $25 an hour, 81 hours
    Function HourlyUnTaxedBiWeeklyTest(Pay As Double, Hours As Double, PayFrequency As String) As Double
        Dim result As Double = PayRate.CalculateHourlyPay(Pay, Hours, PayFrequency)

        Return result
    End Function




    '
    ' Tests taxed calculations for Unmarried hourly worker paid Biweekly
    '
    <TestCase(25, 10, 1, False, Biweekly, ExpectedResult:=202.5)>       'Standard case: $25 an hour, 10 hours, 1 dependent, Unmarried
    <TestCase(0, 10, 1, False, Biweekly, ExpectedResult:=20)>           '$0 an hour, 10 hours, 1 dependent, Unmarried
    <TestCase(0, 0, 1, False, Biweekly, ExpectedResult:=0)>             '$0 an hour, 0 hours, 1 dependent, Unmarried
    <TestCase(-1, 0, 1, False, Biweekly, ExpectedResult:=0)>            'Aberrant case: -$1 an hour, 0 hours, 1 dependent, Unmarried
    <TestCase(-1, -1, 1, False, Biweekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, -1 hours, 1 dependent, Unmarried
    <TestCase(0, -1, 1, False, Biweekly, ExpectedResult:=0)>            'Aberrant case: $0 an hour, -1 hours, 1 dependent, Unmarried
    <TestCase(25, 81, 1, False, Biweekly, ExpectedResult:=1507.38)>     'Biweekly Overtime: $25 an hour, 81 hours, 1 dependent, Unmarried
    Function HourlyTaxedTestBiweekly_UnMarried(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function




    '
    ' Tests taxed calculations for Married hourly worker paid Biweekly
    '
    <TestCase(25, 10, 1, True, Biweekly, ExpectedResult:=252.5)>        'Standard case: $25 an hour, 10 hours, 1 dependent, Married
    <TestCase(0, 10, 1, True, Biweekly, ExpectedResult:=70)>            '$0 an hour, 10 hours, 1 dependent, Married
    <TestCase(0, 0, 1, True, Biweekly, ExpectedResult:=0)>              '$0 an hour, 0 hours, 1 dependent, Married
    <TestCase(-1, 0, 1, True, Biweekly, ExpectedResult:=0)>             'Aberrant case: -$1 an hour, 0 hours, 1 dependent, Married
    <TestCase(-1, -1, 1, True, Biweekly, ExpectedResult:=0)>            'Aberrant case: -$1 an hour, -1 hours, 1 dependent, Married
    <TestCase(0, -1, 1, True, Biweekly, ExpectedResult:=0)>             'Aberrant case: $0 an hour, -1 hours, 1 dependent, Married     
    <TestCase(25, 81, 1, True, Biweekly, ExpectedResult:=1557.38)>      'Biweekly Overtime: $25 an hour, 81 hours, 1 dependent, Married
    Function HourlyTaxedTestBiweekly_Married(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

End Class
