Public Class PayStub
    Inherits System.Windows.Forms.Form

    Dim ID As String
    Dim type As String

    Public Sub New(nID As Integer, nType As String)
        InitializeComponent()
        ID = nID
        type = nType
    End Sub

    Private Sub PrintStubBTN_Click(sender As Object, e As EventArgs) Handles printStubBTN.Click
        PrintDocument1.Print()

        'Dim MSG, style, title, response, MyString
        'MSG = "Would You Like To Print the PayStub? "
        'title = "Payroll- Rollout Payroll"
        'style = vbYesNo + vbDefaultButton1
        'response = MsgBox(MSG, style, title)
        'If response = vbYes Then
        '    MSG = "Printing in Process "
        '    title = "Payroll- Rollout Payroll"
        '    style = vbOK + vbDefaultButton1
        '    response = MsgBox(MSG, style, title)
        '    If (response = vbOKOnly) Then
        '        MyString = "OK"
        '    End If
        'End If
    End Sub

    Private Sub DashTstripBTN_Click(sender As Object, e As EventArgs) Handles dashTstripBTN.Click
        EmpDashboard.Show()
        Me.Close()
    End Sub
    Private Sub PayTstripBTN_Click(sender As Object, e As EventArgs) Handles payTstripBTN.Click
        Payroll.Show()
        Me.Close()
    End Sub

    Private Sub CalcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        PayRateCalc.Show()
        Me.Close()
    End Sub

    Private Sub MetricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        Metrics.Show()
        Me.Close()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Payroll.Show()
        Me.Close()
    End Sub

    Private Sub PayStub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmployeeTableAdapter.FillByID(Me.Primary.Employee, ID)
        If type = "future" Then
            Me.EmployeeFutureTableAdapter.FillByID(Me.Primary.EmployeeFuture, ID)
            Me.empAddyMTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "address", True))
            Me.payNumMTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeFutureBindingSource, "amount", True))
            Me.empNameTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeFutureBindingSource, "fname", True))
            Me.prntDatePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeFutureBindingSource, "date", True))
            Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeFutureBindingSource, "lname", True))
            Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeFutureBindingSource, "lname", True))
            Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeFutureBindingSource, "fname", True))
            Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeFutureBindingSource, "PaymentID", True))
            Me.endPayPeriodDatePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeFutureBindingSource, "date", True))
            Me.EmployeeFutureTableAdapter.FillByID(Me.Primary.EmployeeFuture, ID)
        Else
            Me.empAddyMTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "address", True))
            Me.payNumMTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeePastBindingSource, "amount", True))
            Me.empNameTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeePastBindingSource, "fname", True))
            Me.prntDatePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeePastBindingSource, "date", True))
            Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeePastBindingSource, "lname", True))
            Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeePastBindingSource, "lname", True))
            Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeePastBindingSource, "fname", True))
            Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeePastBindingSource, "PaymentID", True))
            Me.endPayPeriodDatePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeePastBindingSource, "date", True))
            Me.EmployeePastTableAdapter1.FillByID(Me.Primary.EmployeePast, ID)
        End If
        strtPayPeriodDatePicker.Value = endPayPeriodDatePicker.Value.AddDays(-31)

        Dim amount As Double = payNumMTxtBox.Text
        Dim amountText As String = ""
        amount = amount / 1000
        If amount > 1 Then
            If amount.ToString.StartsWith("1") Then
                amountText = amountText + "One thousand"
            ElseIf amount.ToString.StartsWith("2") Then
                amountText = amountText + "Two thousand"
            ElseIf amount.ToString.StartsWith("3") Then
                amountText = amountText + "Three thousand"
            ElseIf amount.ToString.StartsWith("4") Then
                amountText = amountText + "Four thousand"
            ElseIf amount.ToString.StartsWith("5") Then
                amountText = amountText + "Five thousand"
            ElseIf amount.ToString.StartsWith("6") Then
                amountText = amountText + "Six thousand"
            ElseIf amount.ToString.StartsWith("7") Then
                amountText = amountText + "Seven thousand"
            ElseIf amount.ToString.StartsWith("8") Then
                amountText = amountText + "Eight thousand"
            ElseIf amount.ToString.StartsWith("9") Then
                amountText = amountText + "Nine thousand"
            End If
        End If

        If (amount.ToString.Length > 2) Then
            Dim hundredsStr As String = amount.ToString.Substring(amount.ToString.IndexOf(".") + 1, (amount.ToString.Length() - amount.ToString.IndexOf(".") - 1))

            If (hundredsStr.StartsWith("1")) Then
                amountText = amountText + " one hundred"
            ElseIf (hundredsStr.StartsWith("2")) Then
                amountText = amountText + " two hundred"
            ElseIf (hundredsStr.StartsWith("3")) Then
                amountText = amountText + " three hundred"
            ElseIf (hundredsStr.StartsWith("4")) Then
                amountText = amountText + " four hundred"
            ElseIf (hundredsStr.StartsWith("5")) Then
                amountText = amountText + " five hundred"
            ElseIf (hundredsStr.StartsWith("6")) Then
                amountText = amountText + " six hundred"
            ElseIf (hundredsStr.StartsWith("7")) Then
                amountText = amountText + " seven hundred"
            ElseIf (hundredsStr.StartsWith("8")) Then
                amountText = amountText + " eight hundred"
            ElseIf (hundredsStr.StartsWith("9")) Then
                amountText = amountText + " nine hundred"
            ElseIf (hundredsStr.StartsWith("0")) Then
                amount = amount.ToString.Substring(1, (amount.ToString.Length() - 1))
            End If

            If (amount.ToString.Length > 3) Then

                amountText = amountText + " and "

                Dim tensStr As String = amount.ToString.Substring((amount.ToString.IndexOf(".") + 2), (amount.ToString.Length() - amount.ToString.IndexOf(".") - 2))
                'payStrMTxtBox.Text = tensStr

                If (tensStr.StartsWith("1")) Then
                    If (tensStr.Length > 1) Then
                        If (tensStr.Chars(1) = "1") Then
                            amountText = amountText + " eleven"
                        ElseIf (tensStr.Chars(1) = "2") Then
                            amountText = amountText + " twelve"
                        ElseIf (tensStr.Chars(1) = "3") Then
                            amountText = amountText + " thirteen"
                        ElseIf (tensStr.Chars(1) = "4") Then
                            amountText = amountText + " fourteen"
                        ElseIf (tensStr.Chars(1) = "5") Then
                            amountText = amountText + " fifteen"
                        ElseIf (tensStr.Chars(1) = "6") Then
                            amountText = amountText + " sixteen"
                        ElseIf (tensStr.Chars(1) = "7") Then
                            amountText = amountText + " seventeen"
                        ElseIf (tensStr.Chars(1) = "8") Then
                            amountText = amountText + " eight-teen"
                        ElseIf (tensStr.Chars(1) = "9") Then
                            amountText = amountText + " nineteen"
                        End If
                    Else
                        amountText = amountText + " ten"
                    End If
                ElseIf (tensStr.StartsWith("2")) Then
                    amountText = amountText + " twenty"
                ElseIf (tensStr.StartsWith("3")) Then
                    amountText = amountText + " thirty"
                ElseIf (tensStr.StartsWith("4")) Then
                    amountText = amountText + " forty"
                ElseIf (tensStr.StartsWith("5")) Then
                    amountText = amountText + " fifty"
                ElseIf (tensStr.StartsWith("6")) Then
                    amountText = amountText + " sixty"
                ElseIf (tensStr.StartsWith("7")) Then
                    amountText = amountText + " seventy"
                ElseIf (tensStr.StartsWith("8")) Then
                    amountText = amountText + " eighty"
                ElseIf (tensStr.StartsWith("9")) Then
                    amountText = amountText + " ninety"
                End If

                If (tensStr.Length > 1) Then
                    amountText = amountText + "-"
                    If (tensStr.Chars(1) = "1") Then
                        amountText = amountText + "one"
                    ElseIf (tensStr.Chars(1) = "2") Then
                        amountText = amountText + "two"
                    ElseIf (tensStr.Chars(1) = "3") Then
                        amountText = amountText + "three"
                    ElseIf (tensStr.Chars(1) = "4") Then
                        amountText = amountText + "four"
                    ElseIf (tensStr.Chars(1) = "5") Then
                        amountText = amountText + "five"
                    ElseIf (tensStr.Chars(1) = "6") Then
                        amountText = amountText + "six"
                    ElseIf (tensStr.Chars(1) = "7") Then
                        amountText = amountText + "seven"
                    ElseIf (tensStr.Chars(1) = "8") Then
                        amountText = amountText + "eight"
                    ElseIf (tensStr.Chars(1) = "9") Then
                        amountText = amountText + "nine"
                    End If
                End If
            End If
        End If

        payStrMTxtBox.Text = amountText

    End Sub
End Class