Imports MyFavorites
Public Class Form4
    'members...
    Public Favorites As New Favorites()

    Protected Overrides Sub OnLoad(e As EventArgs)
        'load the favorites...
        Favorites.ScanFavorites()
        'create a new context menu...
        Dim menu As New ContextMenu()
        'go through each favorite...
        Dim favorite As WebFavorite
        For Each favorite In Favorites.Favorites
            'create a menu item and add it to menu...
            Dim item As New WebFavoriteMenuItem(favorite)
            menu.MenuItems.Add(item)
        Next
        'add a separator...
        menu.MenuItems.Add("-")
        'then, add an exit option...
        menu.MenuItems.Add(New ExitMenuItem)
        'finally, tell the tray icon to use this menu...
        icnNotify.ContextMenu = menu
    End Sub

    Protected Overloads Overrides Sub OnVisibleChanged(e As System.EventArgs)
        'if the user can see us, hide us...
        If Me.Visible = True Then Me.Visible = False
    End Sub
End Class