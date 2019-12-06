Public Class PayRateLogic
    Function CalculateHourlyPayTaxed(hourlyPayRate As Double, numHours As Double, dependents As Integer, maritalstatus As Boolean, payfrequency As String) As Double
        If numHours <= 0 Then
            Return 0
        End If
        Dim GrossPay As Double = CalculateHourlyPay(hourlyPayRate, numHours, payfrequency)
        Dim TaxedPay As Double = ApplyTaxes(GrossPay)
        Dim MarriageDependentsBonus As Double = ApplyMarriageDependents(GrossPay, dependents, maritalstatus)
        Dim NetPay As Double = TaxedPay + MarriageDependentsBonus
        Return Math.Round(NetPay, 2)
    End Function

    Function CalculateHourlyPay(hourlyPayRate As Double, numHours As Double, payfrequency As String) As Double

        Dim otpayrate As Double
        Dim otHours As Double
        Dim otpay As Double
        Dim regpay As Double
        Dim regHours As Double
        Dim grossPay As Double

        If (payfrequency = "Monthly") Then
            regHours = 160.0
        ElseIf (payfrequency = "Bi-Weekly") Then
            regHours = 80.0
        Else
            regHours = 40.0
        End If


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

    Function ApplyMarriageDependents(GrossPay As Double, Dependents As Integer, marStatus As Boolean) As Double
        If Dependents < 0 Then
            Dependents = 0
        End If
        If marStatus Then
            Return ((GrossPay * 0.02) * Dependents) + (GrossPay * 0.02)
        Else
            Return ((GrossPay * 0.02) * Dependents)
        End If
    End Function

    Function ApplyTaxes(Pay As Double) As Double
        Return Pay - (Pay * 0.27)
    End Function

End Class
