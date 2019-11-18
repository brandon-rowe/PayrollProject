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


        FnameTxt.Clear()
        LnameTxt.Clear()
        AddressTxt.Clear()
        StateTxt.Clear()
        ZipTxt.Clear()
        MaritalStatCB.Refresh()
        MaritalStatCB.ResetText()
        DependentsTxt.Clear()
        PositionTxt.Clear()
        PayTypeTxt.Refresh()
        PayTypeTxt.ResetText()
        'not correct usage, will not revert to default blank permissions.
        AccessCTRL.Refresh()
        AccessCTRL.ResetText()
        'B. Rowe: Some table adapter code here to update variables to table.
        'B. Rowe: Should be an insert query table adapter.



    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click

        Me.Close()
        Login.Show()
        Login.FnameTxt.Clear()
        Login.LnameTxt.Clear()
        Login.StreetTxt.Clear()
        Login.StateTxt.Clear()
        Login.ZipTxt.Clear()
        Login.CreateUnameTxt.Clear()
        Login.CreatePwordTxt.Clear()
        Login.VerifyPwordTxt.Clear()
    End Sub

End Class
