Module Module1
    Public Sub Login(ByRef User, ByRef Time)
        LoginForm.Hide()
        MainForm.Show()
        MainForm.CurrentUserLbl.Text = "Welcome " + User
        MainForm.LoginDateTimeLbl.Text = "Login Time: " + Time
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
    End Sub

    Public Sub disableGroupboxes()
        MainForm.GuestInfoGrb.Visible = False
        MainForm.RoomGrb.Visible = False
        MainForm.SpecialRequestGrb.Visible = False
        MainForm.PaymentGrb.Visible = False
        MainForm.StatusGrb.Visible = False
    End Sub
End Module
