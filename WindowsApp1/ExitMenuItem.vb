Public Class ExitMenuItem
    Inherits MenuItem
    'Constructor...
    Public Sub New()
        Text = "Exit"
    End Sub
    'onClick...
    Protected Overrides Sub OnClick(e As EventArgs)
        Application.Exit()
    End Sub
End Class
