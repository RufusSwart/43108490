Public Class Guest
    Private _adultCount As Integer
    Private _childrenCount As Integer
    Private _firstName As String
    Private _lastName As String
    Private _addr As String
    Private _city As String
    Private _state As String
    Private _zip As String
    Private _country As String
    Private _email As String
    Private _phone As String

    Public Property NumberofAdults() As Integer
        Get
            Return _adultCount
        End Get
        Set(ByVal value As Integer)
            _adultCount = value
        End Set
    End Property

    Public Property NumberofChildren() As Integer
        Get
            Return _childrenCount
        End Get
        Set(ByVal value As Integer)
            _childrenCount = value
        End Set
    End Property

    Public Property Firstname() As String

        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set

    End Property

    Public Property Lastname() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _addr
        End Get
        Set(ByVal value As String)
            _addr = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return _city
        End Get
        Set(ByVal value As String)
            _city = value
        End Set
    End Property

    Public Property State() As String
        Get
            Return _state
        End Get
        Set(ByVal value As String)
            _state = value
        End Set
    End Property

    Public Property Zip() As String
        Get
            Return _zip
        End Get
        Set(ByVal value As String)
            _zip = value
        End Set
    End Property
    Public Property Country() As String
        Get
            Return _country
        End Get
        Set(ByVal value As String)
            _country = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal value As String)
            _phone = value
        End Set
    End Property

End Class
