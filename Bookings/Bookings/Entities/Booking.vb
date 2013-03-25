Imports System.String
Public Enum PaymentMethos As Integer
    CreditCard = 1
    ElectroniceTransfer = 2
    Cheque = 3
    Cash = 4
End Enum
Public Class Booking
    Private _paymentMehod As PaymentMethos
    Private _arrival As Date
    Private _departure As Date
    Private _Id As Short
    Private _user As String
    Private _loginTime As String
    Private _bookingTime As Date
    Private _room As Room
    Private _guest As Guest

    Public Property Guest() As Guest
        Get
            Return _guest
        End Get
        Set(ByVal value As Guest)
            _guest = value
        End Set
    End Property

    Public Property Room() As Room
        Get
            Return _room
        End Get
        Set(ByVal value As Room)
            _room = value
        End Set
    End Property

    Public Property BookedTime() As Date
        Get
            Return _bookingTime
        End Get
        Set(ByVal value As Date)
            _bookingTime = value
        End Set
    End Property

    Public Property LastLoginTime() As String
        Get
            Return _loginTime
        End Get
        Set(ByVal value As String)
            _loginTime = value
        End Set
    End Property

    Public Property CurrentUser() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property

    Public Property ID As Short
        Get
            Return _Id
        End Get
        Set(ByVal value As Short)
            _Id = value
        End Set
    End Property

    Public Property PaymentMethod() As PaymentMethos
        Get
            Return _paymentMehod
        End Get
        Set(ByVal value As PaymentMethos)
            _paymentMehod = value
        End Set
    End Property

    Public Property Arrival() As Date
        Get
            Return _arrival
        End Get
        Set(ByVal value As Date)
            _arrival = value
        End Set
    End Property

    Public Property Departure() As Date
        Get
            Return _departure
        End Get
        Set(ByVal value As Date)
            _departure = value
        End Set
    End Property

    Public Sub reserveRoom(ByVal number As String, ByVal type As String, ByVal somking As String, ByVal bed As String)
        _room = New Room()
        _room.Number = number
        _room.RoomType = type
        _room.Smoking = somking
        _room.BedType = bed
    End Sub

    Public Function serialize() As String
        Dim strData = ""
        strData = strData + ID.ToString + "|" + _
            _arrival.Date.ToString + "|" + _
            _departure.Date.ToString + "|" + _
            CType(_paymentMehod, Integer).ToString + "|" + _
            _user + "|" + _
            _loginTime + "|" + _
            _bookingTime.ToString + "|" + _
            _guest.Firstname + "|" + _
            _guest.Lastname + "|" + _
            _guest.Address + "|" + _
            _guest.City + "|" + _
            _guest.State + "|" + _
            _guest.Zip + "|" + _
            _guest.Country + "|" + _
            _guest.Email + "|" + _
            _guest.Phone + "|" + _
            _guest.NumberofAdults.ToString + "|" + _
            _guest.NumberofChildren.ToString + "|" + _
            _room.Number + "|" + _
            _room.RoomType + "|" + _
            _room.BedType + "|" + _
            _room.Smoking

        Return strData
    End Function

    Public Sub deserialize(ByVal data As String)
        Dim startIndex As Integer = 0
        Dim endIndex As Integer = 0
        Try

        endIndex = data.IndexOf("|")
        If (endIndex = -1) Then
            Return
        End If
        ID = CType(data.Substring(startIndex, endIndex), Short)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Arrival = CType(data.Substring(startIndex, endIndex - startIndex), Date)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Departure = CType(data.Substring(startIndex, endIndex - startIndex), Date)
        startIndex = endIndex + 1


        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
            PaymentMethod = CType(data.Substring(startIndex, endIndex - startIndex), Integer)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        CurrentUser = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1


        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        loginTime = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        BookedTime = CType(data.Substring(startIndex, endIndex - startIndex), Date)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest = New Guest
        Guest.Firstname = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.Lastname = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.Address = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.City = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.State = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.Zip = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.Country = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.Email = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.Phone = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.NumberofAdults = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Guest.NumberofChildren = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        Room = New Room
        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Room.Number = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Room.RoomType = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Room.BedType = data.Substring(startIndex, endIndex - startIndex)
        startIndex = endIndex + 1

        endIndex = data.IndexOf("|", startIndex)
        If (endIndex = -1) Then
            Return
        End If
        Room.Smoking = data.Substring(startIndex, endIndex - startIndex)
            startIndex = endIndex + 1
        Catch ex As Exception
            Dim tmp As String
            tmp = ex.Message
        End Try

    End Sub

End Class
