<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CreateBookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SingleBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoubleBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestInfoGrb = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.numKidsLbl = New System.Windows.Forms.Label()
        Me.NumadultsCb = New System.Windows.Forms.ComboBox()
        Me.numAdultsLbl = New System.Windows.Forms.Label()
        Me.zipTb = New System.Windows.Forms.MaskedTextBox()
        Me.phoneTb = New System.Windows.Forms.MaskedTextBox()
        Me.phoneLbl = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.confirmEmailLbl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.emailLbl = New System.Windows.Forms.Label()
        Me.CountryCb = New System.Windows.Forms.ComboBox()
        Me.CountryLbl = New System.Windows.Forms.Label()
        Me.PostalCodeLbl = New System.Windows.Forms.Label()
        Me.StateTb = New System.Windows.Forms.TextBox()
        Me.StateLbl = New System.Windows.Forms.Label()
        Me.CityTb = New System.Windows.Forms.TextBox()
        Me.CityLbl = New System.Windows.Forms.Label()
        Me.AddressTb = New System.Windows.Forms.TextBox()
        Me.AddressLbl = New System.Windows.Forms.Label()
        Me.LastNameTb = New System.Windows.Forms.TextBox()
        Me.LastNameLbl = New System.Windows.Forms.Label()
        Me.FirstNameTb = New System.Windows.Forms.TextBox()
        Me.FirstNameLbl = New System.Windows.Forms.Label()
        Me.RoomGrb = New System.Windows.Forms.GroupBox()
        Me.DepartureDate = New System.Windows.Forms.DateTimePicker()
        Me.departurelbl = New System.Windows.Forms.Label()
        Me.ArrivalLbl = New System.Windows.Forms.Label()
        Me.ArrivalDate = New System.Windows.Forms.DateTimePicker()
        Me.RoomListbox = New System.Windows.Forms.ListBox()
        Me.StatusGrb = New System.Windows.Forms.GroupBox()
        Me.SpecialRequestGrb = New System.Windows.Forms.GroupBox()
        Me.confirmBookBtn = New System.Windows.Forms.Button()
        Me.ClearFromBtn = New System.Windows.Forms.Button()
        Me.PaymentGrb = New System.Windows.Forms.GroupBox()
        Me.CurrentUserLbl = New System.Windows.Forms.Label()
        Me.LoginDateTimeLbl = New System.Windows.Forms.Label()
        Me.CreditCardRBtn = New System.Windows.Forms.RadioButton()
        Me.EFTRBtn = New System.Windows.Forms.RadioButton()
        Me.ChequeRbtn = New System.Windows.Forms.RadioButton()
        Me.CashRbtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SmokingRBtn = New System.Windows.Forms.RadioButton()
        Me.nonSmokingRbtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.doublebedRbtn = New System.Windows.Forms.RadioButton()
        Me.twinSingleBeds = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GuestInfoGrb.SuspendLayout()
        Me.RoomGrb.SuspendLayout()
        Me.SpecialRequestGrb.SuspendLayout()
        Me.PaymentGrb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateBookingsToolStripMenuItem, Me.ViewBookingsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(924, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CreateBookingsToolStripMenuItem
        '
        Me.CreateBookingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SingleBookingToolStripMenuItem, Me.DoubleBookingToolStripMenuItem})
        Me.CreateBookingsToolStripMenuItem.Name = "CreateBookingsToolStripMenuItem"
        Me.CreateBookingsToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.CreateBookingsToolStripMenuItem.Text = "Create Bookings"
        '
        'SingleBookingToolStripMenuItem
        '
        Me.SingleBookingToolStripMenuItem.Name = "SingleBookingToolStripMenuItem"
        Me.SingleBookingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SingleBookingToolStripMenuItem.Text = "Single Room"
        '
        'DoubleBookingToolStripMenuItem
        '
        Me.DoubleBookingToolStripMenuItem.Name = "DoubleBookingToolStripMenuItem"
        Me.DoubleBookingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DoubleBookingToolStripMenuItem.Text = "Double Room"
        '
        'ViewBookingsToolStripMenuItem
        '
        Me.ViewBookingsToolStripMenuItem.Name = "ViewBookingsToolStripMenuItem"
        Me.ViewBookingsToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ViewBookingsToolStripMenuItem.Text = "View Bookings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Margin = New System.Windows.Forms.Padding(150, 0, 0, 0)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'GuestInfoGrb
        '
        Me.GuestInfoGrb.Controls.Add(Me.ComboBox1)
        Me.GuestInfoGrb.Controls.Add(Me.numKidsLbl)
        Me.GuestInfoGrb.Controls.Add(Me.NumadultsCb)
        Me.GuestInfoGrb.Controls.Add(Me.numAdultsLbl)
        Me.GuestInfoGrb.Controls.Add(Me.zipTb)
        Me.GuestInfoGrb.Controls.Add(Me.phoneTb)
        Me.GuestInfoGrb.Controls.Add(Me.phoneLbl)
        Me.GuestInfoGrb.Controls.Add(Me.TextBox2)
        Me.GuestInfoGrb.Controls.Add(Me.confirmEmailLbl)
        Me.GuestInfoGrb.Controls.Add(Me.TextBox1)
        Me.GuestInfoGrb.Controls.Add(Me.emailLbl)
        Me.GuestInfoGrb.Controls.Add(Me.CountryCb)
        Me.GuestInfoGrb.Controls.Add(Me.CountryLbl)
        Me.GuestInfoGrb.Controls.Add(Me.PostalCodeLbl)
        Me.GuestInfoGrb.Controls.Add(Me.StateTb)
        Me.GuestInfoGrb.Controls.Add(Me.StateLbl)
        Me.GuestInfoGrb.Controls.Add(Me.CityTb)
        Me.GuestInfoGrb.Controls.Add(Me.CityLbl)
        Me.GuestInfoGrb.Controls.Add(Me.AddressTb)
        Me.GuestInfoGrb.Controls.Add(Me.AddressLbl)
        Me.GuestInfoGrb.Controls.Add(Me.LastNameTb)
        Me.GuestInfoGrb.Controls.Add(Me.LastNameLbl)
        Me.GuestInfoGrb.Controls.Add(Me.FirstNameTb)
        Me.GuestInfoGrb.Controls.Add(Me.FirstNameLbl)
        Me.GuestInfoGrb.Location = New System.Drawing.Point(13, 48)
        Me.GuestInfoGrb.Name = "GuestInfoGrb"
        Me.GuestInfoGrb.Size = New System.Drawing.Size(327, 393)
        Me.GuestInfoGrb.TabIndex = 1
        Me.GuestInfoGrb.TabStop = False
        Me.GuestInfoGrb.Text = "Guest Information"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.ComboBox1.Location = New System.Drawing.Point(256, 349)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(57, 22)
        Me.ComboBox1.TabIndex = 24
        '
        'numKidsLbl
        '
        Me.numKidsLbl.AutoSize = True
        Me.numKidsLbl.Location = New System.Drawing.Point(197, 355)
        Me.numKidsLbl.Name = "numKidsLbl"
        Me.numKidsLbl.Size = New System.Drawing.Size(53, 14)
        Me.numKidsLbl.TabIndex = 23
        Me.numKidsLbl.Text = "Children"
        '
        'NumadultsCb
        '
        Me.NumadultsCb.FormattingEnabled = True
        Me.NumadultsCb.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.NumadultsCb.Location = New System.Drawing.Point(123, 349)
        Me.NumadultsCb.Name = "NumadultsCb"
        Me.NumadultsCb.Size = New System.Drawing.Size(53, 22)
        Me.NumadultsCb.TabIndex = 22
        '
        'numAdultsLbl
        '
        Me.numAdultsLbl.AutoSize = True
        Me.numAdultsLbl.Location = New System.Drawing.Point(56, 355)
        Me.numAdultsLbl.Name = "numAdultsLbl"
        Me.numAdultsLbl.Size = New System.Drawing.Size(45, 14)
        Me.numAdultsLbl.TabIndex = 21
        Me.numAdultsLbl.Text = "Adults:"
        '
        'zipTb
        '
        Me.zipTb.Location = New System.Drawing.Point(283, 209)
        Me.zipTb.Mask = "0000"
        Me.zipTb.Name = "zipTb"
        Me.zipTb.Size = New System.Drawing.Size(30, 22)
        Me.zipTb.TabIndex = 20
        '
        'phoneTb
        '
        Me.phoneTb.Location = New System.Drawing.Point(233, 321)
        Me.phoneTb.Mask = "(999) 000-0000"
        Me.phoneTb.Name = "phoneTb"
        Me.phoneTb.Size = New System.Drawing.Size(80, 22)
        Me.phoneTb.TabIndex = 19
        '
        'phoneLbl
        '
        Me.phoneLbl.AutoSize = True
        Me.phoneLbl.Location = New System.Drawing.Point(56, 327)
        Me.phoneLbl.Name = "phoneLbl"
        Me.phoneLbl.Size = New System.Drawing.Size(44, 14)
        Me.phoneLbl.TabIndex = 18
        Me.phoneLbl.Text = "Phone:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(112, 293)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 22)
        Me.TextBox2.TabIndex = 17
        '
        'confirmEmailLbl
        '
        Me.confirmEmailLbl.AutoSize = True
        Me.confirmEmailLbl.Location = New System.Drawing.Point(18, 296)
        Me.confirmEmailLbl.Name = "confirmEmailLbl"
        Me.confirmEmailLbl.Size = New System.Drawing.Size(88, 14)
        Me.confirmEmailLbl.TabIndex = 16
        Me.confirmEmailLbl.Text = "Confirm E-mail:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 267)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 22)
        Me.TextBox1.TabIndex = 15
        '
        'emailLbl
        '
        Me.emailLbl.AutoSize = True
        Me.emailLbl.Location = New System.Drawing.Point(62, 270)
        Me.emailLbl.Name = "emailLbl"
        Me.emailLbl.Size = New System.Drawing.Size(45, 14)
        Me.emailLbl.TabIndex = 14
        Me.emailLbl.Text = "E-mail:"
        '
        'CountryCb
        '
        Me.CountryCb.FormattingEnabled = True
        Me.CountryCb.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia-Herzegovina", "Botswana", "Bouvet Island", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Christmas Island", "Cocos (Keeling) Islands", "Colombia", "Comoros", "Congo, Democratic Republic of the (Zaire)", "Congo, Republic of", "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", "Fiji", "Finland", "France", "French Guiana", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe (French)", "Guam (USA)", "Guatemala", "Guinea", "Guinea Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Ivory Coast (Cote D`Ivoire)", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique (French)", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia (French)", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "North Korea", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn Island", "Poland", "Polynesia (French)", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russia", "Rwanda", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Pierre and Miquelon", "Saint Vincent and Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia and South Sandwich Islands", "South Korea", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard and Jan Mayen Islands", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste (East Timor)", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Virgin Islands", "Wallis and Futuna Islands", "Yemen", "Zambia", "Zimbabwe"})
        Me.CountryCb.Location = New System.Drawing.Point(112, 239)
        Me.CountryCb.Name = "CountryCb"
        Me.CountryCb.Size = New System.Drawing.Size(201, 22)
        Me.CountryCb.TabIndex = 13
        '
        'CountryLbl
        '
        Me.CountryLbl.AutoSize = True
        Me.CountryLbl.Location = New System.Drawing.Point(53, 240)
        Me.CountryLbl.Name = "CountryLbl"
        Me.CountryLbl.Size = New System.Drawing.Size(50, 14)
        Me.CountryLbl.TabIndex = 12
        Me.CountryLbl.Text = "Country:"
        '
        'PostalCodeLbl
        '
        Me.PostalCodeLbl.AutoSize = True
        Me.PostalCodeLbl.Location = New System.Drawing.Point(35, 213)
        Me.PostalCodeLbl.Name = "PostalCodeLbl"
        Me.PostalCodeLbl.Size = New System.Drawing.Size(72, 14)
        Me.PostalCodeLbl.TabIndex = 10
        Me.PostalCodeLbl.Text = "Postal / Zip:"
        '
        'StateTb
        '
        Me.StateTb.Location = New System.Drawing.Point(112, 181)
        Me.StateTb.Name = "StateTb"
        Me.StateTb.Size = New System.Drawing.Size(201, 22)
        Me.StateTb.TabIndex = 9
        '
        'StateLbl
        '
        Me.StateLbl.AutoSize = True
        Me.StateLbl.Location = New System.Drawing.Point(13, 184)
        Me.StateLbl.Name = "StateLbl"
        Me.StateLbl.Size = New System.Drawing.Size(94, 14)
        Me.StateLbl.TabIndex = 8
        Me.StateLbl.Text = "State / Province:"
        '
        'CityTb
        '
        Me.CityTb.Location = New System.Drawing.Point(112, 153)
        Me.CityTb.Name = "CityTb"
        Me.CityTb.Size = New System.Drawing.Size(201, 22)
        Me.CityTb.TabIndex = 7
        '
        'CityLbl
        '
        Me.CityLbl.AutoSize = True
        Me.CityLbl.Location = New System.Drawing.Point(78, 156)
        Me.CityLbl.Name = "CityLbl"
        Me.CityLbl.Size = New System.Drawing.Size(29, 14)
        Me.CityLbl.TabIndex = 6
        Me.CityLbl.Text = "City:"
        '
        'AddressTb
        '
        Me.AddressTb.Location = New System.Drawing.Point(112, 87)
        Me.AddressTb.Multiline = True
        Me.AddressTb.Name = "AddressTb"
        Me.AddressTb.Size = New System.Drawing.Size(201, 60)
        Me.AddressTb.TabIndex = 5
        '
        'AddressLbl
        '
        Me.AddressLbl.AutoSize = True
        Me.AddressLbl.Location = New System.Drawing.Point(53, 108)
        Me.AddressLbl.Name = "AddressLbl"
        Me.AddressLbl.Size = New System.Drawing.Size(54, 14)
        Me.AddressLbl.TabIndex = 4
        Me.AddressLbl.Text = "Address:"
        '
        'LastNameTb
        '
        Me.LastNameTb.Location = New System.Drawing.Point(112, 59)
        Me.LastNameTb.Name = "LastNameTb"
        Me.LastNameTb.Size = New System.Drawing.Size(201, 22)
        Me.LastNameTb.TabIndex = 3
        '
        'LastNameLbl
        '
        Me.LastNameLbl.AutoSize = True
        Me.LastNameLbl.Location = New System.Drawing.Point(40, 62)
        Me.LastNameLbl.Name = "LastNameLbl"
        Me.LastNameLbl.Size = New System.Drawing.Size(67, 14)
        Me.LastNameLbl.TabIndex = 2
        Me.LastNameLbl.Text = "Last Name:"
        '
        'FirstNameTb
        '
        Me.FirstNameTb.Location = New System.Drawing.Point(112, 31)
        Me.FirstNameTb.Name = "FirstNameTb"
        Me.FirstNameTb.Size = New System.Drawing.Size(201, 22)
        Me.FirstNameTb.TabIndex = 1
        '
        'FirstNameLbl
        '
        Me.FirstNameLbl.AutoSize = True
        Me.FirstNameLbl.Location = New System.Drawing.Point(40, 34)
        Me.FirstNameLbl.Name = "FirstNameLbl"
        Me.FirstNameLbl.Size = New System.Drawing.Size(69, 14)
        Me.FirstNameLbl.TabIndex = 0
        Me.FirstNameLbl.Text = "First Name:"
        Me.FirstNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RoomGrb
        '
        Me.RoomGrb.Controls.Add(Me.DepartureDate)
        Me.RoomGrb.Controls.Add(Me.departurelbl)
        Me.RoomGrb.Controls.Add(Me.ArrivalLbl)
        Me.RoomGrb.Controls.Add(Me.ArrivalDate)
        Me.RoomGrb.Controls.Add(Me.RoomListbox)
        Me.RoomGrb.Location = New System.Drawing.Point(346, 48)
        Me.RoomGrb.Name = "RoomGrb"
        Me.RoomGrb.Size = New System.Drawing.Size(258, 276)
        Me.RoomGrb.TabIndex = 2
        Me.RoomGrb.TabStop = False
        Me.RoomGrb.Text = "Room Detail"
        '
        'DepartureDate
        '
        Me.DepartureDate.Location = New System.Drawing.Point(6, 232)
        Me.DepartureDate.Name = "DepartureDate"
        Me.DepartureDate.Size = New System.Drawing.Size(200, 22)
        Me.DepartureDate.TabIndex = 4
        '
        'departurelbl
        '
        Me.departurelbl.AutoSize = True
        Me.departurelbl.Location = New System.Drawing.Point(7, 213)
        Me.departurelbl.Name = "departurelbl"
        Me.departurelbl.Size = New System.Drawing.Size(91, 14)
        Me.departurelbl.TabIndex = 3
        Me.departurelbl.Text = "Departure Date"
        '
        'ArrivalLbl
        '
        Me.ArrivalLbl.AutoSize = True
        Me.ArrivalLbl.Location = New System.Drawing.Point(7, 161)
        Me.ArrivalLbl.Name = "ArrivalLbl"
        Me.ArrivalLbl.Size = New System.Drawing.Size(71, 14)
        Me.ArrivalLbl.TabIndex = 2
        Me.ArrivalLbl.Text = "Arrival Date"
        '
        'ArrivalDate
        '
        Me.ArrivalDate.Location = New System.Drawing.Point(7, 178)
        Me.ArrivalDate.Name = "ArrivalDate"
        Me.ArrivalDate.Size = New System.Drawing.Size(200, 22)
        Me.ArrivalDate.TabIndex = 1
        '
        'RoomListbox
        '
        Me.RoomListbox.FormattingEnabled = True
        Me.RoomListbox.ItemHeight = 14
        Me.RoomListbox.Location = New System.Drawing.Point(7, 22)
        Me.RoomListbox.Name = "RoomListbox"
        Me.RoomListbox.Size = New System.Drawing.Size(245, 130)
        Me.RoomListbox.TabIndex = 0
        '
        'StatusGrb
        '
        Me.StatusGrb.Location = New System.Drawing.Point(610, 253)
        Me.StatusGrb.Name = "StatusGrb"
        Me.StatusGrb.Size = New System.Drawing.Size(310, 188)
        Me.StatusGrb.TabIndex = 3
        Me.StatusGrb.TabStop = False
        Me.StatusGrb.Text = "Status"
        '
        'SpecialRequestGrb
        '
        Me.SpecialRequestGrb.Controls.Add(Me.GroupBox2)
        Me.SpecialRequestGrb.Controls.Add(Me.GroupBox1)
        Me.SpecialRequestGrb.Location = New System.Drawing.Point(610, 49)
        Me.SpecialRequestGrb.Name = "SpecialRequestGrb"
        Me.SpecialRequestGrb.Size = New System.Drawing.Size(310, 198)
        Me.SpecialRequestGrb.TabIndex = 4
        Me.SpecialRequestGrb.TabStop = False
        Me.SpecialRequestGrb.Text = "Special  Requests"
        '
        'confirmBookBtn
        '
        Me.confirmBookBtn.Location = New System.Drawing.Point(719, 447)
        Me.confirmBookBtn.Name = "confirmBookBtn"
        Me.confirmBookBtn.Size = New System.Drawing.Size(112, 23)
        Me.confirmBookBtn.TabIndex = 5
        Me.confirmBookBtn.Text = "Confirm Booking"
        Me.confirmBookBtn.UseVisualStyleBackColor = True
        '
        'ClearFromBtn
        '
        Me.ClearFromBtn.Location = New System.Drawing.Point(837, 446)
        Me.ClearFromBtn.Name = "ClearFromBtn"
        Me.ClearFromBtn.Size = New System.Drawing.Size(75, 23)
        Me.ClearFromBtn.TabIndex = 6
        Me.ClearFromBtn.Text = "Clear"
        Me.ClearFromBtn.UseVisualStyleBackColor = True
        '
        'PaymentGrb
        '
        Me.PaymentGrb.Controls.Add(Me.CashRbtn)
        Me.PaymentGrb.Controls.Add(Me.ChequeRbtn)
        Me.PaymentGrb.Controls.Add(Me.EFTRBtn)
        Me.PaymentGrb.Controls.Add(Me.CreditCardRBtn)
        Me.PaymentGrb.Location = New System.Drawing.Point(346, 329)
        Me.PaymentGrb.Name = "PaymentGrb"
        Me.PaymentGrb.Size = New System.Drawing.Size(258, 111)
        Me.PaymentGrb.TabIndex = 7
        Me.PaymentGrb.TabStop = False
        Me.PaymentGrb.Text = "Payment Info"
        '
        'CurrentUserLbl
        '
        Me.CurrentUserLbl.AutoSize = True
        Me.CurrentUserLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CurrentUserLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentUserLbl.Location = New System.Drawing.Point(484, 0)
        Me.CurrentUserLbl.Name = "CurrentUserLbl"
        Me.CurrentUserLbl.Size = New System.Drawing.Size(91, 19)
        Me.CurrentUserLbl.TabIndex = 8
        Me.CurrentUserLbl.Text = "CurrentUser"
        '
        'LoginDateTimeLbl
        '
        Me.LoginDateTimeLbl.AutoSize = True
        Me.LoginDateTimeLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LoginDateTimeLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginDateTimeLbl.Location = New System.Drawing.Point(684, 0)
        Me.LoginDateTimeLbl.Name = "LoginDateTimeLbl"
        Me.LoginDateTimeLbl.Size = New System.Drawing.Size(119, 19)
        Me.LoginDateTimeLbl.TabIndex = 9
        Me.LoginDateTimeLbl.Text = "Login Date+Time"
        '
        'CreditCardRBtn
        '
        Me.CreditCardRBtn.AutoSize = True
        Me.CreditCardRBtn.Location = New System.Drawing.Point(10, 22)
        Me.CreditCardRBtn.Name = "CreditCardRBtn"
        Me.CreditCardRBtn.Size = New System.Drawing.Size(84, 18)
        Me.CreditCardRBtn.TabIndex = 0
        Me.CreditCardRBtn.TabStop = True
        Me.CreditCardRBtn.Text = "Credit Card"
        Me.CreditCardRBtn.UseVisualStyleBackColor = True
        '
        'EFTRBtn
        '
        Me.EFTRBtn.AutoSize = True
        Me.EFTRBtn.Location = New System.Drawing.Point(108, 22)
        Me.EFTRBtn.Name = "EFTRBtn"
        Me.EFTRBtn.Size = New System.Drawing.Size(125, 18)
        Me.EFTRBtn.TabIndex = 1
        Me.EFTRBtn.TabStop = True
        Me.EFTRBtn.Text = "Electronic Transfer"
        Me.EFTRBtn.UseVisualStyleBackColor = True
        '
        'ChequeRbtn
        '
        Me.ChequeRbtn.AutoSize = True
        Me.ChequeRbtn.Location = New System.Drawing.Point(7, 68)
        Me.ChequeRbtn.Name = "ChequeRbtn"
        Me.ChequeRbtn.Size = New System.Drawing.Size(66, 18)
        Me.ChequeRbtn.TabIndex = 2
        Me.ChequeRbtn.TabStop = True
        Me.ChequeRbtn.Text = "Cheque"
        Me.ChequeRbtn.UseVisualStyleBackColor = True
        '
        'CashRbtn
        '
        Me.CashRbtn.AutoSize = True
        Me.CashRbtn.Location = New System.Drawing.Point(108, 68)
        Me.CashRbtn.Name = "CashRbtn"
        Me.CashRbtn.Size = New System.Drawing.Size(51, 18)
        Me.CashRbtn.TabIndex = 3
        Me.CashRbtn.TabStop = True
        Me.CashRbtn.Text = "Cash"
        Me.CashRbtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nonSmokingRbtn)
        Me.GroupBox1.Controls.Add(Me.SmokingRBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'SmokingRBtn
        '
        Me.SmokingRBtn.AutoSize = True
        Me.SmokingRBtn.Location = New System.Drawing.Point(7, 35)
        Me.SmokingRBtn.Name = "SmokingRBtn"
        Me.SmokingRBtn.Size = New System.Drawing.Size(71, 18)
        Me.SmokingRBtn.TabIndex = 0
        Me.SmokingRBtn.TabStop = True
        Me.SmokingRBtn.Text = "Smoking"
        Me.SmokingRBtn.UseVisualStyleBackColor = True
        '
        'nonSmokingRbtn
        '
        Me.nonSmokingRbtn.AutoSize = True
        Me.nonSmokingRbtn.Location = New System.Drawing.Point(165, 35)
        Me.nonSmokingRbtn.Name = "nonSmokingRbtn"
        Me.nonSmokingRbtn.Size = New System.Drawing.Size(97, 18)
        Me.nonSmokingRbtn.TabIndex = 1
        Me.nonSmokingRbtn.TabStop = True
        Me.nonSmokingRbtn.Text = "Non-Smoking"
        Me.nonSmokingRbtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.twinSingleBeds)
        Me.GroupBox2.Controls.Add(Me.doublebedRbtn)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 76)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'doublebedRbtn
        '
        Me.doublebedRbtn.AutoSize = True
        Me.doublebedRbtn.Location = New System.Drawing.Point(7, 26)
        Me.doublebedRbtn.Name = "doublebedRbtn"
        Me.doublebedRbtn.Size = New System.Drawing.Size(89, 18)
        Me.doublebedRbtn.TabIndex = 0
        Me.doublebedRbtn.TabStop = True
        Me.doublebedRbtn.Text = "Double Bed"
        Me.doublebedRbtn.UseVisualStyleBackColor = True
        '
        'twinSingleBeds
        '
        Me.twinSingleBeds.AutoSize = True
        Me.twinSingleBeds.Location = New System.Drawing.Point(163, 26)
        Me.twinSingleBeds.Name = "twinSingleBeds"
        Me.twinSingleBeds.Size = New System.Drawing.Size(117, 18)
        Me.twinSingleBeds.TabIndex = 1
        Me.twinSingleBeds.TabStop = True
        Me.twinSingleBeds.Text = "Twin Single Beds"
        Me.twinSingleBeds.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 475)
        Me.Controls.Add(Me.LoginDateTimeLbl)
        Me.Controls.Add(Me.CurrentUserLbl)
        Me.Controls.Add(Me.PaymentGrb)
        Me.Controls.Add(Me.ClearFromBtn)
        Me.Controls.Add(Me.confirmBookBtn)
        Me.Controls.Add(Me.SpecialRequestGrb)
        Me.Controls.Add(Me.StatusGrb)
        Me.Controls.Add(Me.RoomGrb)
        Me.Controls.Add(Me.GuestInfoGrb)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GuestInfoGrb.ResumeLayout(False)
        Me.GuestInfoGrb.PerformLayout()
        Me.RoomGrb.ResumeLayout(False)
        Me.RoomGrb.PerformLayout()
        Me.SpecialRequestGrb.ResumeLayout(False)
        Me.PaymentGrb.ResumeLayout(False)
        Me.PaymentGrb.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CreateBookingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SingleBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoubleBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewBookingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuestInfoGrb As System.Windows.Forms.GroupBox
    Friend WithEvents FirstNameLbl As System.Windows.Forms.Label
    Friend WithEvents AddressTb As System.Windows.Forms.TextBox
    Friend WithEvents AddressLbl As System.Windows.Forms.Label
    Friend WithEvents LastNameTb As System.Windows.Forms.TextBox
    Friend WithEvents LastNameLbl As System.Windows.Forms.Label
    Friend WithEvents FirstNameTb As System.Windows.Forms.TextBox
    Friend WithEvents StateTb As System.Windows.Forms.TextBox
    Friend WithEvents StateLbl As System.Windows.Forms.Label
    Friend WithEvents CityTb As System.Windows.Forms.TextBox
    Friend WithEvents CityLbl As System.Windows.Forms.Label
    Friend WithEvents PostalCodeLbl As System.Windows.Forms.Label
    Friend WithEvents CountryCb As System.Windows.Forms.ComboBox
    Friend WithEvents CountryLbl As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents confirmEmailLbl As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents emailLbl As System.Windows.Forms.Label
    Friend WithEvents zipTb As System.Windows.Forms.MaskedTextBox
    Friend WithEvents phoneTb As System.Windows.Forms.MaskedTextBox
    Friend WithEvents phoneLbl As System.Windows.Forms.Label
    Friend WithEvents NumadultsCb As System.Windows.Forms.ComboBox
    Friend WithEvents numAdultsLbl As System.Windows.Forms.Label
    Friend WithEvents numKidsLbl As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RoomGrb As System.Windows.Forms.GroupBox
    Friend WithEvents StatusGrb As System.Windows.Forms.GroupBox
    Friend WithEvents SpecialRequestGrb As System.Windows.Forms.GroupBox
    Friend WithEvents confirmBookBtn As System.Windows.Forms.Button
    Friend WithEvents ClearFromBtn As System.Windows.Forms.Button
    Friend WithEvents PaymentGrb As System.Windows.Forms.GroupBox
    Friend WithEvents CurrentUserLbl As System.Windows.Forms.Label
    Friend WithEvents LoginDateTimeLbl As System.Windows.Forms.Label
    Friend WithEvents DepartureDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents departurelbl As System.Windows.Forms.Label
    Friend WithEvents ArrivalLbl As System.Windows.Forms.Label
    Friend WithEvents ArrivalDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents RoomListbox As System.Windows.Forms.ListBox
    Friend WithEvents CashRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents ChequeRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents EFTRBtn As System.Windows.Forms.RadioButton
    Friend WithEvents CreditCardRBtn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents twinSingleBeds As System.Windows.Forms.RadioButton
    Friend WithEvents doublebedRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nonSmokingRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents SmokingRBtn As System.Windows.Forms.RadioButton
End Class
