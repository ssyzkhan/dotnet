Public Class GraphicsCircle
    Inherits GraphicsItem

    Public Overrides Sub Draw(graphics As Graphics)
        'Throw New NotImplementedException()
        'create a new pen...
        Dim brush As New SolidBrush(Me.Color)

        'draw the circle...
        graphics.FillEllipse(brush, Me.Rectangle)

    End Sub
End Class
