Public Class PayRateLogic


    Function CalculateHourlyPay(hourlyPayRate As Double, numHours As Double) As Double

        Dim otpayrate As Double
        Dim otHours As Double
        Dim otpay As Double
        Dim regpay As Double
        Dim totalpay As Double
        Dim regHours As Double

        regHours = 40.0

        If numHours <= regHours Then
            totalpay = hourlyPayRate * numHours
        ElseIf numHours > regHours Then
            otHours = numHours - regHours
            otpayrate = 1.5 * hourlyPayRate
            otpay = otpayrate * otHours
            regpay = regHours * hourlyPayRate
            totalpay = otpay + regpay
        End If

        Return totalpay
    End Function

    'Once we do the above calculations, we then make some percentage
    'guesses of how much tax to withold based on marital status, tax
    'bracket and dependents. (Ex. Non-married, <$36,000/yr, 1 dependent
    'would be around 27-29% tax taken out.)

    'Function ApplyTaxes(Pay As Double, marStatus As String, Dependents As Integer)

    'End Function

End Class
