Imports System.IO
Public Class MyFile
    Implements IDisposable
    'members...
    Private _stream As FileStream
    Private _isDisposed As Boolean
    'Constructor...
    Public Sub New(filename As String)
        'create, or append to the file...
        _stream = New FileStream("C:\Users\field\source\repos\WindowsApp1\ConsoleApp1\files\FinalizeDemo.txt", FileMode.OpenOrCreate)
        'tell the user...
        Console.WriteLine("Object " & GetHashCode() & " create.")
        Console.WriteLine("Using file: " & filename)
    End Sub
    'AddText - add some text to the file...
    Public Function AddText(buf As String)
        'have we been disposed?
        If _isDisposed = True Then
            Throw New ObjectDisposedException("I've been disposed!")
        End If
        'write the time and the message...
        Dim writer As New StreamWriter(_stream)
        writer.WriteLine(Date.Now)
        writer.WriteLine(buf)
        writer.Close()
    End Function
    'Dispose - called when we need disposing...
#Region "IDisposable Support"
    Private disposedValue As Boolean ' 要检测冗余调用

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: 释放托管状态(托管对象)。
            End If

            ' TODO: 释放未托管资源(未托管对象)并在以下内容中替代 Finalize()。
            ' TODO: 将大型字段设置为 null。
        End If
        disposedValue = True
    End Sub

    ' TODO: 仅当以上 Dispose(disposing As Boolean)拥有用于释放未托管资源的代码时才替代 Finalize()。
    Protected Overrides Sub Finalize()
        '    ' 请勿更改此代码。将清理代码放入以上 Dispose(disposing As Boolean)中。
        Dispose(False)
        MyBase.Finalize()
        'tell the user that we've been finalized...
        Console.WriteLine("Object " & GetHashCode() & " finalized.")
    End Sub

    ' Visual Basic 添加此代码以正确实现可释放模式。
    Public Sub Dispose() Implements IDisposable.Dispose
        ' 请勿更改此代码。将清理代码放入以上 Dispose(disposing As Boolean)中。
        Dispose(True)
        ' TODO: 如果在以上内容中替代了 Finalize()，则取消注释以下行。
        ' GC.SuppressFinalize(Me)

        'have we already been disposed?
        If _isDisposed = True Then Return

        'clean up our resources...
        _stream.Close()
        _stream = Nothing

        'flag us as being disposed...
        _isDisposed = True

        'tell the GC not to collect us...
        GC.SuppressFinalize(Me)

        'tell the user that we've been disposed...
        Console.WriteLine("Object " & GetHashCode() & " disposed.")
    End Sub
#End Region
End Class
