Public Class User
    'members...
    Public Username As String
    Public _password As String
    Public Shared MinPasswordLength As Integer = 6
    'Password property...
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            If value.Length >= MinPasswordLength Then
                _password = value
            End If
        End Set
    End Property

End Class
