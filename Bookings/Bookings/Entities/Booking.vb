Public Enum PaymentMethos As Integer
    CreditCard = 1
    ElectroniceTransfer = 2
    Cheque = 3
    Cash = 4
End Enum
Public Class Booking
    Inherits Guest
    Private _paymentMehod As PaymentMethos
    Private _arrival As Date
    Private _departure As Date

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

End Class
