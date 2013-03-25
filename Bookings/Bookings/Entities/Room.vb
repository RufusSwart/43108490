Public Class Room
    Private _number As String
    Private _roomtype As String
    Private _bedtype As String
    Private _smoking As String

    Property Number() As String
        Get
            Return _number
        End Get
        Set(ByVal value As String)
            _number = value
        End Set
    End Property

    Property RoomType() As String
        Get
            Return _roomtype
        End Get
        Set(ByVal value As String)
            _roomtype = value
        End Set
    End Property

    Property BedType() As String
        Get
            Return _bedtype
        End Get
        Set(ByVal value As String)
            _bedtype = value
        End Set
    End Property

    Public Property Smoking() As String

        Get
            Return _smoking
        End Get
        Set(ByVal value As String)
            _smoking = value
        End Set
    End Property

End Class
