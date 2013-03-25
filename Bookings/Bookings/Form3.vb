Public Class Form3

    Private Sub BackBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackBtn.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (bookingID - 1 < 0) Then
            Label1.Text = "No Current Bookings"
            DataGridView1.Visible = False
        Else
            DataGridView1.Visible = True
            Try
                Dim dt As New DataTable()

                dt.Columns.Add("First Name", Type.GetType("System.String"))

                dt.Columns.Add("Last Name", Type.GetType("System.String"))

                dt.Columns.Add("Address", Type.GetType("System.String"))

                dt.Columns.Add("City", Type.GetType("System.String"))

                dt.Columns.Add("State/Provance", Type.GetType("System.String"))

                dt.Columns.Add("Postal/Zip Code", Type.GetType("System.String"))

                dt.Columns.Add("Country", Type.GetType("System.String"))

                dt.Columns.Add("E-Mail", Type.GetType("System.String"))

                dt.Columns.Add("Phone", Type.GetType("System.String"))

                dt.Columns.Add("Number of Adults", Type.GetType("System.String"))

                dt.Columns.Add("Number of Kids", Type.GetType("System.String"))

                dt.Columns.Add("Room Number", Type.GetType("System.String"))

                dt.Columns.Add("Room Type", Type.GetType("System.String"))

                dt.Columns.Add("Arrival Date", Type.GetType("System.String"))

                dt.Columns.Add("Departure Date", Type.GetType("System.String"))

                dt.Columns.Add("Payment Method", Type.GetType("System.String"))

                dt.Columns.Add("Additional Requests", Type.GetType("System.String"))

                Dim tmpData As New bookingDB

                tmpData.load()

                'For i As Integer = 0 To tmpData.Bookings.Count
                For Each item As Booking In tmpData.Bookings
                    dt.Rows.Add()

                    dt.Rows(dt.Rows.Count - 1)("First Name") = item.Guest.Firstname

                    dt.Rows(dt.Rows.Count - 1)("Last Name") = item.Guest.Lastname

                    dt.Rows(dt.Rows.Count - 1)("Address") = item.Guest.Address

                    dt.Rows(dt.Rows.Count - 1)("City") = item.Guest.City

                    dt.Rows(dt.Rows.Count - 1)("State/Provance") = item.Guest.State

                    dt.Rows(dt.Rows.Count - 1)("Postal/Zip code") = item.Guest.Zip

                    dt.Rows(dt.Rows.Count - 1)("Country") = item.Guest.Country

                    dt.Rows(dt.Rows.Count - 1)("E-Mail") = item.Guest.Email

                    dt.Rows(dt.Rows.Count - 1)("Phone") = item.Guest.Phone

                    dt.Rows(dt.Rows.Count - 1)("Number of Adults") = item.Guest.NumberofAdults

                    dt.Rows(dt.Rows.Count - 1)("Number of Kids") = item.Guest.NumberofAdults

                    dt.Rows(dt.Rows.Count - 1)("Room Number") = item.Room.Number

                    dt.Rows(dt.Rows.Count - 1)("Room Type") = item.Room.RoomType

                    dt.Rows(dt.Rows.Count - 1)("Arrival Date") = item.Arrival

                    dt.Rows(dt.Rows.Count - 1)("Departure Date") = item.Departure

                    dt.Rows(dt.Rows.Count - 1)("Payment Method") = item.PaymentMethod.ToString

                    dt.Rows(dt.Rows.Count - 1)("Additional Requests") = item.Room.BedType + " -- " + item.Room.Smoking
                Next

                DataGridView1.DataSource = dt
            Catch ex As Exception
                Label1.Text = ex.ToString
            End Try
        End If
        
    End Sub
End Class