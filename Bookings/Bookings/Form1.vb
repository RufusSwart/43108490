Imports System.Globalization
Public Class LoginForm

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub


    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserNameTb.Text = ""
        PasswordTb.Text = ""
        TimeLbl.Text = DateString + " - - " + TimeString
        errorLbl1.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TimeLbl.Text = DateString + " - - " + TimeString
    End Sub

    Private Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click
        If ((UserNameTb.Text.ToLower = "user1" And PasswordTb.Text = "123") Or (UserNameTb.Text.ToLower = "user2" And PasswordTb.Text = "321") Or (UserNameTb.Text.ToLower = "admin" And PasswordTb.Text = "admin")) Then
            Login(UserNameTb.Text, TimeLbl.Text)
        Else
            errorLbl1.Text = "Unknown User Name or bad password."
        End If
    End Sub

    Private Sub UserNameTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserNameTb.TextChanged
        errorLbl1.Text = ""
    End Sub

    Private Sub PasswordTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTb.TextChanged
        errorLbl1.Text = ""
    End Sub

    Private Sub HelpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBtn.Click
        Me.Hide()
        currForm = "LoginForm"
        Form4.Show()
    End Sub
End Class
