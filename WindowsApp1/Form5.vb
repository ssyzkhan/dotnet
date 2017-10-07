Public Class Form5
    'members...
    Private _userList As New ArrayList()
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim n As Integer
        For n = 1 To 100
            'create a new user...
            Dim newUser As New User()
            newUser.Username = "Fred" & n
            newUser.Password = "password15"
            'add it...
            _userList.Add(newUser)
        Next
        'update the display...
        UpdateDisplay()
    End Sub
    Private Sub UpdateDisplay()
        'clear the list...
        lstUsers.Items.Clear()
        'add them...
        Dim user As User
        For Each user In _userList
            lstUsers.Items.Add(user.Username & "," & user.Password & "(" & User.MinPasswordLength & ")")
        Next
    End Sub

    Private Sub trkMinPasswordLength_Scroll(sender As Object, e As EventArgs) Handles trkMinPasswordLength.Scroll
        'set the minimum password length...
        User.MinPasswordLength = trkMinPasswordLength.Value
        'update the display...
        UpdateDisplay()
    End Sub
End Class