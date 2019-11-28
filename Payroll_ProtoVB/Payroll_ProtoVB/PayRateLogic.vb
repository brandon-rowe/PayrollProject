Public Class PayRateLogic


    Function CalculateHourlyPay(hourlyPayRate As Double, numHours As Double, dependents As Integer, maritalstatus As Boolean) As Double

        Dim otpayrate As Double
        Dim otHours As Double
        Dim otpay As Double
        Dim regpay As Double
        Dim netPay As Double = 0.0
        Dim regHours As Double
        Dim grossPay As Double

        regHours = 160.0

        If numHours <= regHours AndAlso numHours >= 0 AndAlso hourlyPayRate >= 0 Then
            grossPay = hourlyPayRate * numHours
        ElseIf numHours > regHours Then
            otHours = numHours - regHours
            otpayrate = 1.5 * hourlyPayRate
            otpay = otpayrate * otHours
            regpay = regHours * hourlyPayRate
            grossPay = otpay + regpay
        End If
        If maritalstatus = True Then
            netPay = grossPay - (dependents * 20) - 50
        Else
            netPay = grossPay - (dependents * 20)
        End If

        Return netPay
    End Function

    'Once we do the above calculations, we then make some percentage
    'guesses of how much tax to withold based on marital status, tax
    'bracket and dependents. (Ex. Non-married, <$36,000/yr, 1 dependent
    'would be around 27-29% tax taken out.)

    'Function ApplyTaxes(Pay As Double, marStatus As String, Dependents As Integer)

    'End Function

End Class
