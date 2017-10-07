Imports System.IO
Public Class Favorites
    'members...
    Public Favorites As WebFavoriteCollection
    'FavoritesFolder - return the folder...
    Public ReadOnly Property FavoritesFolder() As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.Favorites)
        End Get
    End Property
    'ScanFavorites - look through the list of favorites...
    Public Sub ScanFavorites()
        ScanFavorites(FavoritesFolder)
    End Sub
    Public Sub ScanFavorites(ByVal folderName As String)
        'double-check... do we have a favorites list?
        If Favorites Is Nothing Then Favorites = New WebFavoriteCollection()
        'get the folder...
        Dim scanFolder As New DirectoryInfo(folderName)
        'look through each one...
        Dim favoriteFile As FileInfo
        For Each favoriteFile In scanFolder.GetFiles
            'is it a .url file?
            If String.Compare(favoriteFile.Extension, ".url", True) = 0 Then
                'create a new webfavorite...
                Dim favorite As New WebFavorite()
                favorite.Load(favoriteFile)
                'add it to the collection...
                Favorites.Add(favorite)
            End If
        Next

    End Sub
End Class
