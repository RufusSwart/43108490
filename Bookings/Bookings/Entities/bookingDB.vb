Imports System.Xml.Serialization
Imports System.IO

Public Class bookingDB
    Private _bookings As List(Of Booking)

    Public Property Bookings As List(Of Booking)
        Get
            Return _bookings
        End Get
        Private Set(ByVal value As List(Of Booking))
            _bookings = value
        End Set
    End Property

    Public Sub save(ByVal booking As Booking)
        'Serialize object to a text file.
        Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\Bokings.txt"
        Dim objStreamWriter As New StreamWriter(path, True)
        objStreamWriter.WriteLine(booking.serialize())
        objStreamWriter.Close()
    End Sub

    Public Sub load()
        _bookings = New List(Of Booking)
        Dim StreamReader As StreamReader
        Dim line As String
        Dim Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\Bokings.txt"
        If System.IO.File.Exists(Path) Then
            StreamReader = My.Computer.FileSystem.OpenTextFileReader(Path)
            Do Until StreamReader.EndOfStream
                line = StreamReader.ReadLine()
                Dim nBooking As New Booking
                nBooking.deserialize(line)
                _bookings.Add(nBooking)
            Loop
            StreamReader.Close()
        Else

        End If
    End Sub

    Public Function getLastBooking() As Booking
        load()
        If (Bookings.Count = 0) Then
            Return Nothing
        Else
            Return Bookings(Bookings.Count - 1)
        End If
    End Function

End Class
