Imports System.Reflection.Metadata.Ecma335

Public Class Person
    Protected name As String
    Protected dateofbirth As DateTime?

    Public Property name_ As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Property dateofbirth_ As DateTime?
        Get
            Return dateofbirth
        End Get
        Set(ByVal value As DateTime?)
            dateofbirth = value
        End Set
    End Property

    Public ReadOnly Property Age_ As Integer
        Get
            Dim age As Double
            age = (DateTime.Now.Year - dateofbirth.Value.Year)
            Return age
        End Get
    End Property

    Public Sub New()
        name = String.Empty
        dateofbirth = Nothing
    End Sub

    Public Sub New(ByVal name As String, ByVal dateofbirth As DateTime?)
        Me.name = name
        Me.dateofbirth = dateofbirth
    End Sub

    Public Sub New(ByVal name As String, ByVal dateofbirth As DateTime?, ByVal email As String)
        Me.New(name, dateofbirth)
    End Sub

    Public Overrides Function ToString() As String
        Return name.ToUpper()
        Return Age_

    End Function


End Class
