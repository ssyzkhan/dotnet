Public Class WebFavoriteCollection
    Inherits CollectionBase
    'Add - add items to the collection...
    Public Sub Add(ByVal favorite As WebFavorite)
        List.Add(favorite)
    End Sub
    'Remove - remove Items from the collection...
    Public Sub Remove(ByVal index As Integer)
        If index >= 0 And index < Count Then
            List.Remove(index)
        End If
    End Sub
    'Item - get items by index...
    Public ReadOnly Property Item(ByVal index As Integer)
        Get
            Return CType(List.Item(index), WebFavorite)
        End Get
    End Property
End Class
