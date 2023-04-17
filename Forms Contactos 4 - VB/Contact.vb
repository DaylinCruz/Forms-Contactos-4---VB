Imports System.Drawing.Imaging

Public Class Contact
    Inherits Person

    Private phone As String
    Private email As String

    Public Property phone_ As String
        Get
            Return phone
        End Get
        Set(ByVal value As String)
            phone = value.Replace(" ", "").Replace("-", "")
        End Set
    End Property

    Public Property email_ As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        phone = String.Empty
        email = String.Empty
    End Sub

    Public Sub New(ByVal name As String, ByVal dateofbirth As DateTime?, ByVal phone As String, ByVal email As String)
        MyBase.New(name, dateofbirth, email)
        Me.phone = phone
        Me.email = email
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " " & phone_ & email_
    End Function

End Class
