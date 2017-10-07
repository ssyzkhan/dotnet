Public Structure Customer
    'members...
    Public FirstName As String
    Public LastName As String
    Public Email As String
    'Name property...
    Public ReadOnly Property Name() As String
        Get
            Return FirstName & " " & LastName
        End Get
    End Property
    'ToString...
    Public Overrides Function ToString() As String
        Return Name & "(" & Email & ")"
    End Function
    'IsEmpty-are we populated?
    Public Function IsEmpty() As Boolean
        If FirstName = "" Then
            Return True
        Else
            Return False

        End If
    End Function
End Structure
