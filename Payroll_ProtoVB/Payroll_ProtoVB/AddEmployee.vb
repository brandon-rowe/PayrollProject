Public Class AddEmployee
    Inherits System.Windows.Forms.Form
    'load form
    Dim Fname As String
    Dim Lname As String
    Dim address As String
    Dim street As String
    Dim state As String
    Dim zip As String
    Dim status As String
    Dim dependents As String
    Dim position As String
    Dim paymentType As String

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddEmpBtn_Click(sender As Object, e As EventArgs) Handles AddEmpBtn.Click
        Fname = FnameTxt.Text
        Lname = LnameTxt.Text
        street = AddressTxt.Text
        state = StateTxt.Text
        zip = ZipTxt.Text
        address = street + " " + state + " " + zip
        status = MaritalStatCB.Text
        dependents = DependentsTxt.Text
        position = PositionTxt.Text
        paymentType = PayTypeTxt.Text

        Console.WriteLine(Fname)
        Console.WriteLine(Lname)
        Console.WriteLine(address)
        Console.WriteLine(status)
        Console.WriteLine(dependents)
        Console.WriteLine(position)
        Console.WriteLine(paymentType)
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Dim Payroll = New Payroll()
        Payroll.Show()
    End Sub
End Class
