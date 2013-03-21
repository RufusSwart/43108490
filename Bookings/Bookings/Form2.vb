Public Class MainForm

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        LoginForm.UserNameTb.Text = ""
        LoginForm.PasswordTb.Text = ""
        LoginForm.Show()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disableGroupboxes()
    End Sub

    Private Sub SingleBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SingleBookingToolStripMenuItem.Click
        enableGroupboxes()
        populateSingleRooms()
    End Sub

    Private Sub DoubleBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoubleBookingToolStripMenuItem.Click
        enableGroupboxes()
        populateDoubleRooms()
    End Sub
End Class