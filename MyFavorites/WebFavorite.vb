Imports System.IO
Public Class WebFavorite
    'members...
    Public Name As String
    Public Url As String
    'Load - open .url file and populate ourselves...
    Public Sub Load(ByVal fileInfo As FileInfo)
        'firstly, set the name, but trim off the extension...
        Name = fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length)
        'open the file...
        Dim stream As New FileStream(fileInfo.FullName, FileMode.Open)
        Dim reader As New StreamReader(stream)

        'go through each line...
        Do While True
            'get a line...
            Dim buf As String = reader.ReadLine
            If buf Is Nothing Then Exit Do
            'does the string start with "url="
            If buf.StartsWith("URL=") Then
                'set the url...
                Url = buf.Substring(4)
                'quit...
                Exit Do

            End If
        Loop
        'close the file...
        reader.Close()
        stream.Close()
    End Sub
    'Open-opens the favorite in IE...
    Public Sub Open()
        System.Diagnostics.Process.Start(Url)
    End Sub
End Class
