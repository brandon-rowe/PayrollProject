Public Class PayRateLogic
    Function CalculateHourlyPayTaxed(hourlyPayRate As Double, numHours As Double, dependents As Integer, maritalstatus As Boolean) As Double
        Dim Pay As Double = CalculateHourlyPay(hourlyPayRate, numHours)
        Dim TaxedPay As Double = ApplyTaxes(Pay, dependents, maritalstatus)

        Return Pay
    End Function

    Function CalculateHourlyPay(hourlyPayRate As Double, numHours As Double) As Double

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


        Return grossPay

    End Function

    'Once we do the above calculations, we then make some percentage
    'guesses of how much tax to withold based on marital status, tax
    'bracket and dependents. (Ex. Non-married, <$36,000/yr, 1 dependent
    'would be around 27-29% tax taken out.)

    Function ApplyTaxes(Pay As Double, Dependents As Integer, marStatus As Boolean) As Double
        Return Pay - CalculateTaxAmount(Dependents, marStatus)
    End Function


    Function CalculateTaxAmount(Dependents As Integer, marStatus As Boolean) As Double
        If marStatus Then
            Return (Dependents * 20) - 50
        Else
            Return (Dependents * 20)
        End If

    End Function

End Class
