Imports MyFavorites
Public Class Form3
    'members...
    Private _selectedFavorite As WebFavorite
    'SelectedFavorite property...
    Public Property SelectedFavorite() As WebFavorite
        Get
            Return _selectedFavorite
        End Get
        Set(value As WebFavorite)
            'store the item...
            _selectedFavorite = value
            'did we select anything?
            If Not _selectedFavorite Is Nothing Then
                'update the link label control...
                LinkLabel1.Text = "Visit " & _selectedFavorite.Name
                LinkLabel1.Enabled = True
            Else
                'disable the link...
                LinkLabel1.Enabled = False

            End If
        End Set
    End Property
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        'create a favorites object...
        Dim favorites As New Favorites()
        favorites.ScanFavorites()
        'go through each favorite...
        Dim favorite As WebFavorite
        For Each favorite In favorites.Favorites
            'add it to the list...
            ' Dim item As New ListViewItem()
            'item.Text = favorite.Name
            ' item.SubItems.Add(favorite.Url)
            Dim item As New WebFavoriteListViewItem(favorite)
            lstFavorites.Items.Add(item)

            'if this is the first item, select it...
            If lstFavorites.Items.Count = 1 Then
                'select it...
                item.Selected = True
                SelectedFavorite = favorite

            End If
        Next
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'do we have a selection?
        If Not SelectedFavorite Is Nothing Then
            'show it...
            SelectedFavorite.Open()
        End If
    End Sub

    Private Sub lstFavorites_Click(sender As Object, e As EventArgs) Handles lstFavorites.Click
        'reset the selection...
        SelectedFavorite = Nothing
        'go through each item looking for the selected one...
        Dim item As WebFavoriteListViewItem
        For Each item In lstFavorites.Items
            'selected?
            If item.Selected = True Then
                'store the selected item...
                SelectedFavorite = item.Favorite

                'exit the loop...
                Exit For

            End If
        Next
    End Sub
End Class