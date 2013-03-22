Public Class MainForm
    Private CurrentBooking As New Room
    Private type As String

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        LoginForm.UserNameTb.Text = ""
        LoginForm.PasswordTb.Text = ""
        LoginForm.Show()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disableGroupboxes()
        bookingID = 0
    End Sub

    Private Sub SingleBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SingleBookingToolStripMenuItem.Click
        type = "Single Room"
        enableGroupboxes()
        populateSingleRooms()
        errTb.Text = ""
    End Sub

    Private Sub DoubleBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoubleBookingToolStripMenuItem.Click
        type = "Double Room"
        enableGroupboxes()
        populateDoubleRooms()
        errTb.Text = ""
    End Sub

    Private Sub confirmBookBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmBookBtn.Click
        Dim errInForm As Boolean
        errInForm = checkMainformFields()
        If (errInForm = True) Then
            errTb.Text = "We Found the following errors:" + vbCrLf + "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-"
            errTb.ForeColor = Color.Red
            For Each item In errlist
                errTb.Text = errTb.Text + vbCrLf + item
            Next
            Me.StatusGrb.Controls.Add(errTb)
        Else
            errTb.Text = "All OK!"
            errTb.ForeColor = Color.Green
            saveData()
        End If
    End Sub

    Private Sub ViewBookingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBookingsToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class