Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        If currForm = "LoginForm" Then
            LoginForm.Show()
        End If
        If currForm = "MainForm" Then
            MainForm.Show()
        End If
    End Sub
End Class