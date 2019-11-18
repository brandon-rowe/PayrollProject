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
        'ATTENTION: This button should remain on AddEmployee.vb 
        'until Next Or Back button is selected

        Fname = FnameTxt.Text
        Lname = LnameTxt.Text
        street = StreetTxt.Text
        state = StateTxt.Text
        zip = ZipTxt.Text
        address = street + " " + state + " " + zip
        status = MaritalStatCB.Text
        dependents = DependentsTxt.Text
        position = PositionTxt.Text
        paymentType = PayTypeCBox.Text

        Console.WriteLine(Fname)
        Console.WriteLine(Lname)
        Console.WriteLine(address)
        Console.WriteLine(status)
        Console.WriteLine(dependents)
        Console.WriteLine(position)
        Console.WriteLine(paymentType)


        FnameTxt.Clear()
        LnameTxt.Clear()
        StreetTxt.Clear()
        StateTxt.Clear()
        ZipTxt.Clear()
        MaritalStatCB.Refresh()
        MaritalStatCB.ResetText()
        DependentsTxt.Clear()
        PositionTxt.Clear()
        PayTypeCBox.Refresh()
        PayTypeCBox.ResetText()
        'not correct usage, will not revert to default blank permissions.
        AccessCTRL.Refresh()
        AccessCTRL.ResetText()
        'B. Rowe: Some table adapter code here to update variables to table.
        'B. Rowe: Should be an insert query table adapter.



    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        'ATTENTION: This button should navigate to Login.vb
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

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        'ATTENTION: This button should navigate to Login.vb
        Me.Close()
        Login.Show()
    End Sub
End Class
