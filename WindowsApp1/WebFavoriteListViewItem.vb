Imports MyFavorites
Public Class WebFavoriteListViewItem
    Inherits ListViewItem
    'members...
    Public Favorite As WebFavorite

    'Constructor...
    Public Sub New(ByVal newFavorite As WebFavorite)
        'set the property...
        Favorite = newFavorite
        'set the text...
        Text = Favorite.Name
        SubItems.Add(Favorite.Url)

    End Sub
End Class
