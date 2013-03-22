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
            Dim roomAvailable As Boolean
            roomAvailable = checkRoom(RoomListbox.SelectedItem, ArrivalDate.Value.Date, DepartureDate.Value.Date)
            If (roomAvailable = False) Then
                errTb.Text = "The Room is not available!"
                errTb.ForeColor = Color.Red
            Else
                errTb.Text = "All OK!"
                errTb.ForeColor = Color.Green
                saveData(type)
            End If
        End If
    End Sub

    Private Sub ViewBookingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBookingsToolStripMenuItem.Click
        Dim f3 As New Form3
        Me.Hide()
        f3.Show()
    End Sub

    Private Sub ClearFromBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFromBtn.Click
        clearFieldData()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Hide()
        currForm = "MainForm"
        Form4.Show()
    End Sub
End Class