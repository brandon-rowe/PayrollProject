Public Class PayStub
    Inherits System.Windows.Forms.Form

    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        Me.Refresh()
    End Sub
    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles payTstripBTN.Click
        Payroll.Show()
    End Sub

    Private Sub CalcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        PayRateCalc.Show()
    End Sub

    Private Sub MetricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        Metrics.Show()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub PrintStubBTN_Click(sender As Object, e As EventArgs) Handles printStubBTN.Click
        Dim MSG, style, title, response, MyString
        MSG = "Would You Like To Print the PayStub? "
        title = "Payroll- Rollout Payroll"
        style = vbYesNo + vbDefaultButton1
        response = MsgBox(MSG, style, title)
        If response = vbYes Then
            MSG = "Printing in Process "
            title = "Payroll- Rollout Payroll"
            style = vbOK + vbDefaultButton1
            response = MsgBox(MSG, style, title)
            If (response = vbOKOnly) Then
                MyString = "OK"
            End If
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Payroll.Show()
        Me.Close()
    End Sub
End Class