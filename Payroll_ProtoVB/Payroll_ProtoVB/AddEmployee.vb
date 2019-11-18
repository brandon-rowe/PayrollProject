Imports Payroll_ProtoVB.PrimaryTableAdapters

Public Class AddEmployee
    Inherits System.Windows.Forms.Form
    'load form

    Dim employTA As New EmployeeTableAdapter
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
    Dim ssn As String
    'Dim ID As Integer



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
        ssn = SSN_Txt.Text
        'ID = employTA.maxIDQuery()
        'ID = ID + 1

        'Console.WriteLine(ID)
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

        employTA.InsertQuery(6, Fname, Lname, position, address, True, 4, False, False, 0, 50, 24, ssn)
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

    Private Sub PayTypeCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PayTypeCBox.SelectedIndexChanged

    End Sub

    Private Sub MaritalStatCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaritalStatCB.SelectedIndexChanged

    End Sub
End Class
