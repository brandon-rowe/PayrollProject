Public Class LoginAndCreateUserForm
    Inherits System.Windows.Forms.Form

    Dim Fname As String
    Dim Lname As String
    Dim address As String
    Dim state As String
    Dim zip As Long
    Dim phone As Long
    Dim Uname As String
    Dim Pword As String

    'load form
    Private Sub LoginAndCreateUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'split container
    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles splitContainer1.SplitterMoved

    End Sub 'may not need?

    'left pane-- Login info'
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles splitContainer1.Panel1.Paint

    End Sub
    'pic
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub

    'labels'
    'login-title
    Private Sub LoginFormLable_Click(sender As Object, e As EventArgs) Handles loginFormLable.Click

    End Sub

    'user name
    Private Sub LoginFormUsrLabel_Click(sender As Object, e As EventArgs) Handles loginFormUsrLabel.Click

    End Sub

    'password
    Private Sub LoginformPassLabel_Click(sender As Object, e As EventArgs) Handles loginformPassLabel.Click

    End Sub
    'end of labels'

    'interactive components- left pane'
    'textboxes'
    'login
    Private Sub LoginFormUsrTxtBox_TextChanged(sender As Object, e As EventArgs) Handles loginFormUsrTxtBox.TextChanged

    End Sub

    'password
    Private Sub LoginFormPassTxtBox_TextChanged(sender As Object, e As EventArgs) Handles loginFormPassTxtBox.TextChanged

    End Sub

    'login button'

    Private Sub LoginFormButton_Click(sender As Object, e As EventArgs) Handles loginFormButton.Click

    End Sub
    'end of buttons'
    'end of interactive components- left pane'
    'end of left pane'

    'right pane-- user generation'
    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles splitContainer1.Panel2.Paint

    End Sub 'may not need?

    'labels'
    'Create New User- title'
    Private Sub UserGenFormLabel_Click(sender As Object, e As EventArgs) Handles userGenFormLabel.Click

    End Sub

    'first name
    Private Sub UsrGenFormFirstNameLabel_Click(sender As Object, e As EventArgs) Handles usrGenFormFirstNameLabel.Click

    End Sub

    'last name
    Private Sub UsrGenFormLastNameLabel_Click(sender As Object, e As EventArgs) Handles usrGenFormLastNameLabel.Click

    End Sub

    'address
    Private Sub UsrGenFormAddyLabel_Click(sender As Object, e As EventArgs) Handles usrGenFormAddyLabel.Click

    End Sub

    'state
    Private Sub UsrGenFormStateLabel_Click(sender As Object, e As EventArgs) Handles usrGenFormStateLabel.Click

    End Sub

    'zip
    Private Sub UsrGenFormZipLabel_Click(sender As Object, e As EventArgs) Handles usrGenFormZipLabel.Click

    End Sub

    'phone
    Private Sub UsrGenFormPhoneLabel_Click(sender As Object, e As EventArgs) Handles usrGenFormPhoneLabel.Click

    End Sub

    'user name
    Private Sub UsrGenFormUsrNameLabel_Click(sender As Object, e As EventArgs) Handles usrGenFormUsrNameLabel.Click

    End Sub

    'password
    Private Sub UserGenFormPassLabel_Click(sender As Object, e As EventArgs) Handles userGenFormPassLabel.Click

    End Sub

    'verify password
    Private Sub UserGenFormPassVrfyLabel_Click(sender As Object, e As EventArgs) Handles userGenFormPassVrfyLabel.Click

    End Sub
    'end of labels'

    'interactive components- right pane'
    'text boxes'
    'first name
    Private Sub UsrGenFormFirstNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles usrGenFormFirstNameTxtBox.TextChanged

    End Sub

    'last name
    Private Sub UsrGenFormLastNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles usrGenFormLastNameTxtBox.TextChanged

    End Sub

    'address
    Private Sub UsrGenFormAddyTxtBox_TextChanged(sender As Object, e As EventArgs) Handles usrGenFormAddyTxtBox.TextChanged

    End Sub

    'state
    Private Sub UsrGenFormStateTxtBox_TextChanged(sender As Object, e As EventArgs) Handles usrGenFormStateTxtBox.TextChanged

    End Sub

    'zip
    Private Sub UsrGenFormZipTxtBox_TextChanged(sender As Object, e As EventArgs) Handles usrGenFormZipTxtBox.TextChanged

    End Sub

    'phone
    Private Sub UsrGenFormPhoneTxtBox_TextChanged(sender As Object, e As EventArgs) Handles usrGenFormPhoneTxtBox.TextChanged

    End Sub

    'user name
    Private Sub UsrGenFormUsrNameTxtBox_TextChanged(sender As Object, e As EventArgs) Handles usrGenFormUsrNameTxtBox.TextChanged

    End Sub

    'password
    Private Sub UsrGenFormPassTxtBox_TextChanged(sender As Object, e As EventArgs) Handles usrGenFormPassTxtBox.TextChanged

    End Sub

    'verify password
    Private Sub UsrGenFormPassVryfyTxtBox_TextChanged(sender As Object, e As EventArgs) Handles usrGenFormPassVryfyTxtBox.TextChanged

    End Sub
    'end of textboxes'

    'create user button
    Private Sub UsrGenFormCreateUsrButton_Click(sender As Object, e As EventArgs) Handles usrGenFormCreateUsrButton.Click
        Fname = usrGenFormFirstNameTxtBox.Text
        Lname = usrGenFormLastNameTxtBox.Text
        address = usrGenFormAddyTxtBox.Text
        state = usrGenFormStateTxtBox.Text
        zip = usrGenFormZipTxtBox.Text
        phone = usrGenFormPhoneTxtBox.Text
        Uname = usrGenFormUsrNameTxtBox.Text
        Pword = usrGenFormPassTxtBox.Text

        Dim AddEmployeeForm As New Form(Fname, Lname, address, state, zip, phone, Uname, Pword)
        AddEmployeeForm.ShowDialog()

        'Console.WriteLine(Fname)
        'Console.WriteLine(Lname)
        'Console.WriteLine(address)
        'Console.WriteLine(state)
        'Console.WriteLine(zip)
        'Console.WriteLine(phone)
        'Console.WriteLine(Uname)
        'Console.WriteLine(Pword)
    End Sub
    'end of interactive components- right pane
    'end of right pane'

End Class