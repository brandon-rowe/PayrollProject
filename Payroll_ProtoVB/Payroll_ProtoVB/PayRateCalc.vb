Public Class PayRateCalc
    Private Sub PayRateCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Primary.Employee)
        'TODO: This line of code loads data into the 'Primary.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Primary.Employee)

    End Sub
    'Test Calculation
    'These variables will be set from the DB once we have it setup and the
    'table adapters are working properly.

    'Dim hourlyPayRate As Double
    'Dim numHours As Double
    'Dim regHours As Double
    'Dim otHours As Double
    'Dim otPayRate As Double
    'Dim otPay As Double
    'Dim regPay As Double
    'Dim totalPay As Double

    '    regHours = 40

    '    If numHours <= regHours Then
    '        totalPay = hourlyPay * numHours
    '    ElseIf numHours > regHours Then
    '        otHours = numHours - regHours
    '        otPayRate = 1.5 * hourlyPayRate
    '        otPay = otPayRate * otHours
    '        regPay = regHours * hourlyPayRate
    '        totalPay = otPay + regPay
    '    End If
    '
    'Once we do the above calculations, we then make some percentage
    'guesses of how much tax to withold based on marital status, tax
    'bracket and dependents. (Ex. Non-married, <$36,000/yr, 1 dependent
    'would be around 27-29% tax taken out.)
End Class