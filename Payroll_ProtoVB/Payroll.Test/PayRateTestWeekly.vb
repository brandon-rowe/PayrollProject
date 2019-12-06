Imports NUnit.Framework
Imports Payroll_ProtoVB

<TestFixture>
Public Class PayRateTestWeekly
    Dim PayRate As PayRateLogic
    Const Monthly = "Monthly"
    Const Biweekly = "Bi-Weekly"
    Const Weekly = "Weekly"

    <OneTimeSetUp>
    Sub Setup()
        PayRate = New PayRateLogic()
    End Sub




    '
    ' Tests untaxed calculations for hourly worker paid Weekly
    '
    <TestCase(25, 10, Weekly, ExpectedResult:=250)>     'Standard case: $25 an hour, 10 hours
    <TestCase(0, 10, Weekly, ExpectedResult:=0)>        '$0 an hour, 10 hours
    <TestCase(0, 0, Weekly, ExpectedResult:=0)>         '$0 an hour, 0 hours
    <TestCase(-1, 0, Weekly, ExpectedResult:=0)>        'Aberrant case: -$1 an hour, 0 hours
    <TestCase(-1, -1, Weekly, ExpectedResult:=0)>       'Aberrant case: -$1 an hour, -1 hours
    <TestCase(0, -1, Weekly, ExpectedResult:=0)>        'Aberrant case: $0 an hour, -1 hours
    <TestCase(25, 41, Weekly, ExpectedResult:=1037.5)>  'Weekly Overtime: $25 an hour, 41 hours
    Function HourlyUnTaxedWeeklyTest(Pay As Double, Hours As Double, PayFrequency As String) As Double
        Dim result As Double = PayRate.CalculateHourlyPay(Pay, Hours, PayFrequency)

        Return result
    End Function




    '
    ' Tests taxed calculations for Unmarried hourly worker paid Weekly
    '
    <TestCase(25, 10, 1, False, Weekly, ExpectedResult:=202.5)>     'Standard case: $25 an hour, 10 hours, 1 dependent, Unmarried
    <TestCase(0, 10, 1, False, Weekly, ExpectedResult:=20)>         '$0 an hour, 10 hours, 1 dependent, Unmarried
    <TestCase(0, 0, 1, False, Weekly, ExpectedResult:=0)>           '$0 an hour, 0 hours, 1 dependent, Unmarried
    <TestCase(-1, 0, 1, False, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, 0 hours, 1 dependent, Unmarried
    <TestCase(-1, -1, 1, False, Weekly, ExpectedResult:=0)>         'Aberrant case: -$1 an hour, -1 hours, 1 dependent, Unmarried
    <TestCase(0, -1, 1, False, Weekly, ExpectedResult:=0)>          'Aberrant case: $0 an hour, -1 hours, 1 dependent, Unmarried
    <TestCase(25, 41, 1, False, Weekly, ExpectedResult:=777.38)>    'Weekly Overtime: $25 an hour, 41 hours, 1 dependent, Unmarried
    Function HourlyTaxedTestWeekly_UnMarried(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function




    '
    ' Tests taxed calculations for Married hourly worker paid Weekly
    '
    <TestCase(25, 10, 1, True, Weekly, ExpectedResult:=252.5)>      'Standard case: $25 an hour, 10 hours, 1 dependent, Married
    <TestCase(0, 10, 1, True, Weekly, ExpectedResult:=70)>          '$0 an hour, 10 hours, 1 dependent, Married
    <TestCase(0, 0, 1, True, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 1 dependent, Married
    <TestCase(-1, 0, 1, True, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 1 dependent, Married
    <TestCase(-1, -1, 1, True, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 1 dependent, Married
    <TestCase(0, -1, 1, True, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 1 dependent, Married     
    <TestCase(25, 41, 1, True, Weekly, ExpectedResult:=827.38)>     'Weekly Overtime: $25 an hour, 41 hours, 1 dependent, Married
    Function HourlyTaxedTestWeekly_Married(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Unmarried hourly worker paid Weekly With 2 Dependants
    '
    <TestCase(25, 10, 2, False, Weekly, ExpectedResult:=222.5)>      'Standard case: $25 an hour, 10 hours, 2 dependent, UnMarried
    <TestCase(0, 10, 2, False, Weekly, ExpectedResult:=40)>          '$0 an hour, 10 hours, 2 dependent, UnMarried
    <TestCase(0, 0, 2, False, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 2 dependent, UnMarried
    <TestCase(-1, 0, 2, False, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 2 dependent, UnMarried
    <TestCase(-1, -1, 2, False, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 2 dependent, UnMarried
    <TestCase(0, -1, 2, False, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 2 dependent, UnMarried     
    <TestCase(25, 41, 2, False, Weekly, ExpectedResult:=797.38)>     'Weekly Overtime: $25 an hour, 41 hours, 2 dependent, UnMarried
    Function HourlyTaxedTestWeekly_UnMarried_2Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Married hourly worker paid Weekly With 2 Dependants
    '
    <TestCase(25, 10, 2, True, Weekly, ExpectedResult:=272.5)>      'Standard case: $25 an hour, 10 hours, 2 dependent, UnMarried
    <TestCase(0, 10, 2, True, Weekly, ExpectedResult:=90)>          '$0 an hour, 10 hours, 2 dependent, UnMarried
    <TestCase(0, 0, 2, True, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 2 dependent, UnMarried
    <TestCase(-1, 0, 2, True, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 2 dependent, UnMarried
    <TestCase(-1, -1, 2, True, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 2 dependent, UnMarried
    <TestCase(0, -1, 2, True, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 2 dependent, UnMarried     
    <TestCase(25, 41, 2, True, Weekly, ExpectedResult:=847.38)>     'Weekly Overtime: $25 an hour, 41 hours, 2 dependent, UnMarried
    Function HourlyTaxedTestWeekly_Married_2Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Unmarried hourly worker paid Weekly With 3 Dependants
    '
    <TestCase(25, 10, 3, False, Weekly, ExpectedResult:=242.5)>      'Standard case: $25 an hour, 10 hours, 3 dependent, UnMarried
    <TestCase(0, 10, 3, False, Weekly, ExpectedResult:=60)>          '$0 an hour, 10 hours, 3 dependent, UnMarried
    <TestCase(0, 0, 3, False, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 3 dependent, UnMarried
    <TestCase(-1, 0, 3, False, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 3 dependent, UnMarried
    <TestCase(-1, -1, 3, False, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 3 dependent, UnMarried
    <TestCase(0, -1, 3, False, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 3 dependent, UnMarried     
    <TestCase(25, 41, 3, False, Weekly, ExpectedResult:=817.38)>     'Weekly Overtime: $25 an hour, 41 hours, 3 dependent, UnMarried
    Function HourlyTaxedTestWeekly_UnMarried_3Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Married hourly worker paid Weekly With 3 Dependants
    '
    <TestCase(25, 10, 3, True, Weekly, ExpectedResult:=292.5)>      'Standard case: $25 an hour, 10 hours, 3 dependent, UnMarried
    <TestCase(0, 10, 3, True, Weekly, ExpectedResult:=110)>          '$0 an hour, 10 hours, 3 dependent, UnMarried
    <TestCase(0, 0, 3, True, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 3 dependent, UnMarried
    <TestCase(-1, 0, 3, True, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 3 dependent, UnMarried
    <TestCase(-1, -1, 3, True, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 3 dependent, UnMarried
    <TestCase(0, -1, 3, True, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 3 dependent, UnMarried     
    <TestCase(25, 41, 3, True, Weekly, ExpectedResult:=867.38)>     'Weekly Overtime: $25 an hour, 41 hours, 3 dependent, UnMarried
    Function HourlyTaxedTestWeekly_Married_3Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Unmarried hourly worker paid Weekly With 4 Dependants
    '
    <TestCase(25, 10, 4, False, Weekly, ExpectedResult:=262.5)>      'Standard case: $25 an hour, 10 hours, 4 dependent, UnMarried
    <TestCase(0, 10, 4, False, Weekly, ExpectedResult:=80)>          '$0 an hour, 10 hours, 4 dependent, UnMarried
    <TestCase(0, 0, 4, False, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 4 dependent, UnMarried
    <TestCase(-1, 0, 4, False, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 4 dependent, UnMarried
    <TestCase(-1, -1, 4, False, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 4 dependent, UnMarried
    <TestCase(0, -1, 4, False, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 4 dependent, UnMarried     
    <TestCase(25, 41, 4, False, Weekly, ExpectedResult:=837.38)>     'Weekly Overtime: $25 an hour, 41 hours, 4 dependent, UnMarried
    Function HourlyTaxedTestWeekly_UnMarried_4Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Married hourly worker paid Weekly With 4 Dependants
    '
    <TestCase(25, 10, 4, True, Weekly, ExpectedResult:=312.5)>      'Standard case: $25 an hour, 10 hours, 4 dependent, UnMarried
    <TestCase(0, 10, 4, True, Weekly, ExpectedResult:=130)>          '$0 an hour, 10 hours, 4 dependent, UnMarried
    <TestCase(0, 0, 4, True, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 4 dependent, UnMarried
    <TestCase(-1, 0, 4, True, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 4 dependent, UnMarried
    <TestCase(-1, -1, 4, True, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 4 dependent, UnMarried
    <TestCase(0, -1, 4, True, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 4 dependent, UnMarried     
    <TestCase(25, 41, 4, True, Weekly, ExpectedResult:=887.38)>     'Weekly Overtime: $25 an hour, 41 hours, 4 dependent, UnMarried
    Function HourlyTaxedTestWeekly_Married_4Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Unmarried hourly worker paid Weekly With 5 Dependants
    '
    <TestCase(25, 10, 5, False, Weekly, ExpectedResult:=282.5)>      'Standard case: $25 an hour, 10 hours, 5 dependent, UnMarried
    <TestCase(0, 10, 5, False, Weekly, ExpectedResult:=100)>          '$0 an hour, 10 hours, 5 dependent, UnMarried
    <TestCase(0, 0, 5, False, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 5 dependent, UnMarried
    <TestCase(-1, 0, 5, False, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 5 dependent, UnMarried
    <TestCase(-1, -1, 5, False, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 5 dependent, UnMarried
    <TestCase(0, -1, 5, False, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 5 dependent, UnMarried     
    <TestCase(25, 41, 5, False, Weekly, ExpectedResult:=857.38)>     'Weekly Overtime: $25 an hour, 41 hours, 5 dependent, UnMarried
    Function HourlyTaxedTestWeekly_UnMarried_5Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Married hourly worker paid Weekly With 5 Dependants
    '
    <TestCase(25, 10, 5, True, Weekly, ExpectedResult:=332.5)>      'Standard case: $25 an hour, 10 hours, 5 dependent, UnMarried
    <TestCase(0, 10, 5, True, Weekly, ExpectedResult:=150)>          '$0 an hour, 10 hours, 5 dependent, UnMarried
    <TestCase(0, 0, 5, True, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 5 dependent, UnMarried
    <TestCase(-1, 0, 5, True, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 5 dependent, UnMarried
    <TestCase(-1, -1, 5, True, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 5 dependent, UnMarried
    <TestCase(0, -1, 5, True, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 5 dependent, UnMarried     
    <TestCase(25, 41, 5, True, Weekly, ExpectedResult:=907.38)>     'Weekly Overtime: $25 an hour, 41 hours, 5 dependent, UnMarried
    Function HourlyTaxedTestWeekly_Married_5Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Unmarried hourly worker paid Weekly With 6 Dependants
    '
    <TestCase(25, 10, 6, False, Weekly, ExpectedResult:=302.5)>      'Standard case: $25 an hour, 10 hours, 6 dependent, UnMarried
    <TestCase(0, 10, 6, False, Weekly, ExpectedResult:=120)>          '$0 an hour, 10 hours, 6 dependent, UnMarried
    <TestCase(0, 0, 6, False, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 6 dependent, UnMarried
    <TestCase(-1, 0, 6, False, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 6 dependent, UnMarried
    <TestCase(-1, -1, 6, False, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 6 dependent, UnMarried
    <TestCase(0, -1, 6, False, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 6 dependent, UnMarried     
    <TestCase(25, 41, 6, False, Weekly, ExpectedResult:=877.38)>     'Weekly Overtime: $25 an hour, 41 hours, 6 dependent, UnMarried
    Function HourlyTaxedTestWeekly_UnMarried_6Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Married hourly worker paid Weekly With 6 Dependants
    '
    <TestCase(25, 10, 6, True, Weekly, ExpectedResult:=352.5)>      'Standard case: $25 an hour, 10 hours, 6 dependent, UnMarried
    <TestCase(0, 10, 6, True, Weekly, ExpectedResult:=170)>          '$0 an hour, 10 hours, 6 dependent, UnMarried
    <TestCase(0, 0, 6, True, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 6 dependent, UnMarried
    <TestCase(-1, 0, 6, True, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 6 dependent, UnMarried
    <TestCase(-1, -1, 6, True, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 6 dependent, UnMarried
    <TestCase(0, -1, 6, True, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 6 dependent, UnMarried     
    <TestCase(25, 41, 6, True, Weekly, ExpectedResult:=927.38)>     'Weekly Overtime: $25 an hour, 41 hours, 6 dependent, UnMarried
    Function HourlyTaxedTestWeekly_Married_6Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Unmarried hourly worker paid Weekly With 7 Dependants
    '
    <TestCase(25, 10, 7, False, Weekly, ExpectedResult:=322.5)>      'Standard case: $25 an hour, 10 hours, 7 dependent, UnMarried
    <TestCase(0, 10, 7, False, Weekly, ExpectedResult:=140)>          '$0 an hour, 10 hours, 7 dependent, UnMarried
    <TestCase(0, 0, 7, False, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 7 dependent, UnMarried
    <TestCase(-1, 0, 7, False, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 7 dependent, UnMarried
    <TestCase(-1, -1, 7, False, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 7 dependent, UnMarried
    <TestCase(0, -1, 7, False, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 7 dependent, UnMarried     
    <TestCase(25, 41, 7, False, Weekly, ExpectedResult:=897.38)>     'Weekly Overtime: $25 an hour, 41 hours, 7 dependent, UnMarried
    Function HourlyTaxedTestWeekly_UnMarried_7Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Married hourly worker paid Weekly With 7 Dependants
    '
    <TestCase(25, 10, 7, True, Weekly, ExpectedResult:=372.5)>      'Standard case: $25 an hour, 10 hours, 7 dependent, UnMarried
    <TestCase(0, 10, 7, True, Weekly, ExpectedResult:=190)>          '$0 an hour, 10 hours, 7 dependent, UnMarried
    <TestCase(0, 0, 7, True, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 7 dependent, UnMarried
    <TestCase(-1, 0, 7, True, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 7 dependent, UnMarried
    <TestCase(-1, -1, 7, True, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 7 dependent, UnMarried
    <TestCase(0, -1, 7, True, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 7 dependent, UnMarried     
    <TestCase(25, 41, 7, True, Weekly, ExpectedResult:=947.38)>     'Weekly Overtime: $25 an hour, 41 hours, 7 dependent, UnMarried
    Function HourlyTaxedTestWeekly_Married_7Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Unmarried hourly worker paid Weekly With 8 Dependants
    '
    <TestCase(25, 10, 8, False, Weekly, ExpectedResult:=342.5)>      'Standard case: $25 an hour, 10 hours, 8 dependent, UnMarried
    <TestCase(0, 10, 8, False, Weekly, ExpectedResult:=160)>          '$0 an hour, 10 hours, 8 dependent, UnMarried
    <TestCase(0, 0, 8, False, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 8 dependent, UnMarried
    <TestCase(-1, 0, 8, False, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 8 dependent, UnMarried
    <TestCase(-1, -1, 8, False, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 8 dependent, UnMarried
    <TestCase(0, -1, 8, False, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 8 dependent, UnMarried     
    <TestCase(25, 41, 8, False, Weekly, ExpectedResult:=917.38)>     'Weekly Overtime: $25 an hour, 41 hours, 8 dependent, UnMarried
    Function HourlyTaxedTestWeekly_UnMarried_8Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Married hourly worker paid Weekly With 8 Dependants
    '
    <TestCase(25, 10, 8, True, Weekly, ExpectedResult:=392.5)>      'Standard case: $25 an hour, 10 hours, 8 dependent, UnMarried
    <TestCase(0, 10, 8, True, Weekly, ExpectedResult:=210)>          '$0 an hour, 10 hours, 8 dependent, UnMarried
    <TestCase(0, 0, 8, True, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 8 dependent, UnMarried
    <TestCase(-1, 0, 8, True, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 8 dependent, UnMarried
    <TestCase(-1, -1, 8, True, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 8 dependent, UnMarried
    <TestCase(0, -1, 8, True, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 8 dependent, UnMarried     
    <TestCase(25, 41, 8, True, Weekly, ExpectedResult:=967.38)>     'Weekly Overtime: $25 an hour, 41 hours, 8 dependent, UnMarried
    Function HourlyTaxedTestWeekly_Married_8Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Unmarried hourly worker paid Weekly With 9 Dependants
    '
    <TestCase(25, 10, 9, False, Weekly, ExpectedResult:=362.5)>      'Standard case: $25 an hour, 10 hours, 9 dependent, UnMarried
    <TestCase(0, 10, 9, False, Weekly, ExpectedResult:=180)>          '$0 an hour, 10 hours, 9 dependent, UnMarried
    <TestCase(0, 0, 9, False, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 9 dependent, UnMarried
    <TestCase(-1, 0, 9, False, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 9 dependent, UnMarried
    <TestCase(-1, -1, 9, False, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 9 dependent, UnMarried
    <TestCase(0, -1, 9, False, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 9 dependent, UnMarried     
    <TestCase(25, 41, 9, False, Weekly, ExpectedResult:=937.38)>     'Weekly Overtime: $25 an hour, 41 hours, 9 dependent, UnMarried
    Function HourlyTaxedTestWeekly_UnMarried_9Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

    '
    ' Tests taxed calculations for Married hourly worker paid Weekly With 8 Dependants
    '
    <TestCase(25, 10, 9, True, Weekly, ExpectedResult:=412.5)>      'Standard case: $25 an hour, 10 hours, 9 dependent, UnMarried
    <TestCase(0, 10, 9, True, Weekly, ExpectedResult:=230)>          '$0 an hour, 10 hours, 9 dependent, UnMarried
    <TestCase(0, 0, 9, True, Weekly, ExpectedResult:=0)>            '$0 an hour, 0 hours, 9 dependent, UnMarried
    <TestCase(-1, 0, 9, True, Weekly, ExpectedResult:=0)>           'Aberrant case: -$1 an hour, 0 hours, 9 dependent, UnMarried
    <TestCase(-1, -1, 9, True, Weekly, ExpectedResult:=0)>          'Aberrant case: -$1 an hour, -1 hours, 9 dependent, UnMarried
    <TestCase(0, -1, 9, True, Weekly, ExpectedResult:=0)>           'Aberrant case: $0 an hour, -1 hours, 9 dependent, UnMarried     
    <TestCase(25, 41, 9, True, Weekly, ExpectedResult:=987.38)>     'Weekly Overtime: $25 an hour, 41 hours, 9 dependent, UnMarried
    Function HourlyTaxedTestWeekly_Married_9Dependents(Pay As Double, Hours As Double, Dependents As Integer, MarStatus As Boolean, PayFrequency As String) As Double
        Return PayRate.CalculateHourlyPayTaxed(Pay, Hours, Dependents, MarStatus, PayFrequency)
    End Function

End Class
