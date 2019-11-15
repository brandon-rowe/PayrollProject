Public Class Payroll
    Inherits System.Windows.Forms.Form
    'load form
    Private Sub Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.EmployeeFuture' table. You can move, or remove it, as needed.
        Me.EmployeeFutureTableAdapter.Fill(Me.Primary.EmployeeFuture)
        'TODO: This line of code loads data into the 'Primary.EmployeePast' table. You can move, or remove it, as needed.
        Me.EmployeePastTableAdapter.Fill(Me.Primary.EmployeePast)
    End Sub

    Private Sub metricsTstripBTN_Click(sender As Object, e As EventArgs) Handles metricsTstripBTN.Click
        Dim Metrics = New Metrics()
        Metrics.Show()
    End Sub

    Private Sub calcPayBTN_Click(sender As Object, e As EventArgs) Handles calcPayBTN.Click
        Dim PayCalc = New PayRateCalc()
        PayCalc.Show()
    End Sub

    Private Sub payStubViewBTN_Click(sender As Object, e As EventArgs) Handles payStubViewBTN.Click
        Dim Paystub = New PayStub()
        Paystub.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PaymentRecord.Show()
    End Sub
End Class