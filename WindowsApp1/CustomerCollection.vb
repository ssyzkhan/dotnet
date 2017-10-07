
Public Class CustomerCollection
    Inherits System.Collections.CollectionBase
    'members...
    Private _emailHashTable As New Hashtable()
    'EmailHashtable - return the E-Mail hashtable...
    Public ReadOnly Property EmailHashtable() As Hashtable
        Get
            Return _emailHashTable
        End Get
    End Property
    'Add - add a customer...
    Public Sub Add(ByVal newCustomer As Customer)
        Me.List.Add(newCustomer)
        'add to the hashtable...
        EmailHashtable.Add(newCustomer.Email, newCustomer)
    End Sub
    'Remove - delete a customer...
    Public Sub Remove(ByVal removeCustomer As Customer)
        Me.List.Remove(removeCustomer)
        'remove frome the hashtable...
        EmailHashtable.Remove(removeCustomer.Email)
    End Sub

    'Item - return a customer given an index...
    Default Public Property Item(ByVal index As Integer) As Customer
        Get
            Return Me.List.Item(index)
        End Get
        Set(value As Customer)
            Me.List.Item(index) = value
        End Set
    End Property
    Default Public ReadOnly Property Item(ByVal email As String) As Customer
        Get
            Return EmailHashtable.Item(email)
        End Get
    End Property

End Class
