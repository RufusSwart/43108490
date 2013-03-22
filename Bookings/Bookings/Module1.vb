Module Module1
    Public errlist As New ArrayList
    Public CurrUser As String
    Public loginTime As String
    Public bookingID As Integer
    Public arrData(,) As String

    Public Sub Login(ByRef User, ByRef Time)
        LoginForm.Hide()
        MainForm.Show()
        CurrUser = User
        loginTime = Time
        MainForm.CurrentUserLbl.Text = "Welcome " + CurrUser
        MainForm.LoginDateTimeLbl.Text = "Login Time: " + loginTime
    End Sub

    Public Sub populateSingleRooms()
        MainForm.RoomListbox.Items.Add("Room 101")
        MainForm.RoomListbox.Items.Add("Room 103")
        MainForm.RoomListbox.Items.Add("Room 105")
        MainForm.RoomListbox.Items.Add("Room 107")
        MainForm.RoomListbox.Items.Add("Room 109")
    End Sub

    Public Sub populateDoubleRooms()
        MainForm.RoomListbox.Items.Add("Room 102")
        MainForm.RoomListbox.Items.Add("Room 104")
        MainForm.RoomListbox.Items.Add("Room 106")
        MainForm.RoomListbox.Items.Add("Room 108")
        MainForm.RoomListbox.Items.Add("Room 110")
    End Sub

    Public Sub enableGroupboxes()
        MainForm.GuestInfoGrb.Visible = True
        MainForm.RoomGrb.Visible = True
        MainForm.SpecialRequestGrb.Visible = True
        MainForm.PaymentGrb.Visible = True
        MainForm.StatusGrb.Visible = True
        MainForm.confirmBookBtn.Visible = True
        MainForm.ClearFromBtn.Visible = True
    End Sub

    Public Sub disableGroupboxes()
        MainForm.GuestInfoGrb.Visible = False
        MainForm.RoomGrb.Visible = False
        MainForm.SpecialRequestGrb.Visible = False
        MainForm.PaymentGrb.Visible = False
        MainForm.StatusGrb.Visible = False
        MainForm.confirmBookBtn.Visible = False
        MainForm.ClearFromBtn.Visible = False
    End Sub

    Public Function checkMainformFields()
        Dim formErrors As Boolean
        MainForm.phoneTb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        errlist.Clear()
        If (MainForm.FirstNameTb.Text = "") Then
            errlist.Add("First Name must be filled in.")
            formErrors = True
        End If

        If (MainForm.LastNameTb.Text = "") Then
            errlist.Add("Last Name must be filled in.")
            formErrors = True
        End If

        If (MainForm.AddressTb.Text = "") Then
            errlist.Add("Address must be filled in.")
            formErrors = True
        End If

        If (MainForm.CityTb.Text = "") Then
            errlist.Add("City must be filled in.")
            formErrors = True
        End If

        If (MainForm.StateTb.Text = "") Then
            errlist.Add("State/Province must be filled in.")
            formErrors = True
        End If

        If (MainForm.zipTb.Text = "") Then
            errlist.Add("Zip/Postal code must be filled in.")
            formErrors = True
        ElseIf (MainForm.zipTb.Text.Length < 4) Then
            errlist.Add("Zip/Postal code must be 4 numbers.")
            formErrors = True
        End If

        If (MainForm.CountryCb.SelectedIndex = -1) Then
            errlist.Add("Country must be selected.")
            formErrors = True
        End If

        If (MainForm.emailTb.Text = "") Then
            errlist.Add("E-mail must be filled in.")
            formErrors = True
        End If

        If (MainForm.ConfirmEmailTb.Text <> MainForm.emailTb.Text) Then
            errlist.Add("Confirm E-Mail does not match E-mail.")
            formErrors = True
        End If

        If (MainForm.phoneTb.Text = "") Then
            errlist.Add("Phone number must be filled in.")
            formErrors = True
        ElseIf (MainForm.phoneTb.Text.Length <= 9) Then
            errlist.Add("Phone number must be 10 numbers.")
            formErrors = True
        End If

        If (MainForm.NumadultsCb.SelectedIndex = -1) Then
            errlist.Add("Number of adults must be selected.")
            formErrors = True
        End If

        If (MainForm.NumKidsCB.SelectedIndex = -1) Then
            errlist.Add("Number of kids must be selected.")
            formErrors = True
        End If

        Try
            Dim temp As String
            temp = MainForm.RoomListbox.SelectedItem.ToString
        Catch ex As Exception
            formErrors = True
            errlist.Add("You must select a Room.")
        End Try

        If (MainForm.ArrivalDate.Value <= Now) Then
            errlist.Add("The arrival date must be after today.")
            formErrors = True
        End If

        If (MainForm.DepartureDate.Value < MainForm.ArrivalDate.Value) Then
            errlist.Add("The departure date must be after arrival date.")
            formErrors = True
        End If

        If (MainForm.CreditCardRBtn.Checked Or MainForm.EFTRBtn.Checked Or MainForm.ChequeRbtn.Checked Or MainForm.CashRbtn.Checked) Then

        Else
            errlist.Add("Please select a payment method.")
            formErrors = True
        End If

        If (MainForm.SmokingRBtn.Checked Or MainForm.nonSmokingRbtn.Checked) Then

        Else
            errlist.Add("Please indicate smoking or non-smoking.")
            formErrors = True
        End If

        If (MainForm.doublebedRbtn.Checked Or MainForm.twinSingleBeds.Checked) Then

        Else
            errlist.Add("Please indicate double bed or single beds.")
            formErrors = True
        End If

        Return formErrors
    End Function

    Public Sub saveData()
        Try
            arrData(bookingID, 0) = CurrUser
            arrData(bookingID, 1) = loginTime
            arrData(bookingID, 2) = MainForm.FirstNameTb.Text
            arrData(bookingID, 3) = MainForm.LastNameTb.Text
            arrData(bookingID, 4) = MainForm.AddressTb.Text
            arrData(bookingID, 5) = MainForm.CityTb.Text
            arrData(bookingID, 6) = MainForm.StateTb.Text
            arrData(bookingID, 7) = MainForm.zipTb.Text
            arrData(bookingID, 8) = MainForm.CountryCb.SelectedItem
            arrData(bookingID, 9) = MainForm.emailTb.Text
            arrData(bookingID, 10) = MainForm.phoneTb.Text
            arrData(bookingID, 11) = MainForm.NumadultsCb.SelectedItem
            arrData(bookingID, 12) = MainForm.NumKidsCB.SelectedItem
            arrData(bookingID, 13) = MainForm.RoomListbox.SelectedItem.ToString
            arrData(bookingID, 14) = MainForm.ArrivalDate.Value.Date
            arrData(bookingID, 15) = MainForm.DepartureDate.Value.Date
            If (MainForm.CreditCardRBtn.Checked) Then
                arrData(bookingID, 16) = MainForm.CreditCardRBtn.Text
            End If
            If (MainForm.EFTRBtn.Checked) Then
                arrData(bookingID, 16) = MainForm.EFTRBtn.Text
            End If
            If (MainForm.ChequeRbtn.Checked) Then
                arrData(bookingID, 16) = MainForm.ChequeRbtn.Text
            End If
            If (MainForm.CashRbtn.Checked) Then
                arrData(bookingID, 16) = MainForm.CashRbtn.Text
            End If
            If (MainForm.SmokingRBtn.Checked) Then
                arrData(bookingID, 17) = MainForm.SmokingRBtn.Text
            End If
            If (MainForm.nonSmokingRbtn.Checked) Then
                arrData(bookingID, 17) = MainForm.nonSmokingRbtn.Text
            End If
            If (MainForm.doublebedRbtn.Checked) Then
                arrData(bookingID, 18) = MainForm.doublebedRbtn.Text
            End If
            If (MainForm.twinSingleBeds.Checked) Then
                arrData(bookingID, 18) = MainForm.twinSingleBeds.Text
            End If

            disableGroupboxes()
            MsgBox(arrData(bookingID, 13) + " Successfully booked! Thank you :)")
            bookingID = bookingID + 1
        Catch ex As Exception

        End Try
    End Sub
End Module
