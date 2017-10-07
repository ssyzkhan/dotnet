Imports MyFavorites
Public Class WebFavoriteMenuItem
    Inherits MenuItem
    'members...
    Public Favorite As WebFavorite
    'Constructor...
    Public Sub New(newFavorite As WebFavorite)
        'set the property...
        Favorite = newFavorite
        'update the text...
        Text = Favorite.Name

    End Sub
    Protected Overrides Sub OnClick(e As EventArgs)
        'open the favorite...
        If Not Favorite Is Nothing Then
            Favorite.Open()
        End If

    End Sub
End Class
