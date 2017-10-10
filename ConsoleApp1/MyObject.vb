Public Class MyObject
    'Constructor - called when the object is started...
    Public Sub New()
        Console.WriteLine("Object" & GetHashCode() & " created.")
    End Sub
    'finalize - called when the object is removed from memory...
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        'tell the user we've deleted...
        Console.WriteLine("Object" & GetHashCode() & " finalized.")
    End Sub
End Class
