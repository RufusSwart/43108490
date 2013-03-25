Public Class MainForm
    Private type As String
    Private bookDB As New bookingDB

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        LoginForm.UserNameTb.Text = ""
        LoginForm.PasswordTb.Text = ""
        LoginForm.Show()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disableGroupboxes()
        Dim tmpbook As Booking
        tmpbook = bookDB.getLastBooking()
        'Dim ID As String
        'ID = readID()
        'bookingID = Convert.ToInt32(ID) + 1
        If (tmpbook Is Nothing) Then
            bookingID = 0
        Else
            bookingID = tmpbook.ID + 1
        End If

    End Sub

    Private Sub SingleBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SingleBookingToolStripMenuItem.Click
        type = "Single Room"
        ArrivalDate.Value = DateAdd(DateInterval.Day, 1, Now)
        DepartureDate.Value = DateAdd(DateInterval.Day, 3, Now)
        enableGroupboxes()
        populateSingleRooms()
        errTb.Text = ""
    End Sub

    Private Sub DoubleBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoubleBookingToolStripMenuItem.Click
        type = "Double Room"
        ArrivalDate.Value = DateAdd(DateInterval.Day, 1, Now)
        DepartureDate.Value = DateAdd(DateInterval.Day, 3, Now)
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
                PopulateBooking()
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

    Private Sub ArrivalDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrivalDate.ValueChanged
        DepartureDate.Value = DateAdd(DateInterval.Day, 3, ArrivalDate.Value)
    End Sub

    Private Sub RoomListbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomListbox.SelectedIndexChanged
        errTb.Text = ""
    End Sub

    Private Sub PopulateBooking()
        Dim CurrentBooking = New Booking()
        Try
            Dim guest As New Guest()
            guest.Firstname = FirstNameTb.Text
            guest.Lastname = LastNameTb.Text
            guest.Address = AddressTb.Text.Replace(vbCr, "").Replace(vbLf, "")
            guest.City = CityTb.Text
            guest.State = StateTb.Text
            guest.Zip = zipTb.Text
            guest.Country = CountryCb.SelectedItem.ToString
            guest.Email = emailTb.Text
            guest.Phone = phoneTb.Text
            guest.NumberofAdults = NumadultsCb.SelectedItem
            guest.NumberofChildren = NumKidsCB.SelectedItem

            CurrentBooking.ID = bookingID
            CurrentBooking.CurrentUser = CurrUser
            CurrentBooking.LastLoginTime = loginTime
            CurrentBooking.BookedTime = Now
            CurrentBooking.Arrival = ArrivalDate.Value.Date
            CurrentBooking.Departure = DepartureDate.Value.Date
            If (CreditCardRBtn.Checked) Then
                CurrentBooking.PaymentMethod = PaymentMethos.CreditCard
            End If
            If (EFTRBtn.Checked) Then
                CurrentBooking.PaymentMethod = PaymentMethos.ElectroniceTransfer
            End If
            If (ChequeRbtn.Checked) Then
                CurrentBooking.PaymentMethod = PaymentMethos.Cheque
            End If
            If (CashRbtn.Checked) Then
                CurrentBooking.PaymentMethod = PaymentMethos.Cash
            End If
            CurrentBooking.Guest = guest
            Dim SmokeStr As String
            If (SmokingRBtn.Checked) Then
                SmokeStr = SmokingRBtn.Text
            Else
                SmokeStr = nonSmokingRbtn.Text
            End If
            Dim bedstr As String
            If (doublebedRbtn.Checked) Then
                bedstr = doublebedRbtn.Text
            Else
                bedstr = twinSingleBeds.Text
            End If
            CurrentBooking.reserveRoom(RoomListbox.SelectedItem, type, SmokeStr, bedstr)

            bookingID = bookingID + 1
            disableGroupboxes()
            clearFieldData()

        Catch ex As Exception
            errTb.Text = ex.ToString
            CurrentBooking = Nothing
        End Try
        If (Not CurrentBooking Is Nothing) Then
            'savetoDisk(CurrentBooking)
            Dim db As New bookingDB
            db.save(CurrentBooking)
            MsgBox(CurrentBooking.Room.Number + " Successfully booked! Thank you :)")
        End If
    End Sub

End Class