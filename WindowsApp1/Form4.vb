Public Class Form4
    Protected Overloads Overrides Sub OnVisibleChanged(e As System.EventArgs)
        'if the user can see us, hide us...
        If Me.Visible = True Then Me.Visible = False
    End Sub
End Class