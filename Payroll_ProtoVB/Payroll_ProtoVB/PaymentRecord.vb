Public Class PaymentRecord
    Private Sub PaymentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Primary.EmployeePast' table. You can move, or remove it, as needed.
        Me.EmployeePastTableAdapter.Fill(Me.Primary.EmployeePast)

    End Sub
End Class