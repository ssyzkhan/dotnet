Public Class ColorPaletteButton
    'color...
    Public Color As Color = Color.Black
    Public Rectangle As Rectangle
    'constructor
    Public Sub New(newColor As Color)
        Color = newColor
    End Sub
    'SetPosition - move the button to the given position...
    Public Sub SetPosition(x As Integer, y As Integer, buttonSize As Integer)
        'update the members...
        Rectangle = New Rectangle(x, y, buttonSize, buttonSize)
    End Sub
    'Draw - draw the button...
    Public Sub Draw(graphics As Graphics)
        'draw the color block...
        Dim brush As New SolidBrush(Color)
        graphics.FillRectangle(brush, Rectangle)
        'draw an "edge" around the control...
        Dim pen As New Pen(Color.Black)
        graphics.DrawRectangle(pen, Rectangle)
    End Sub
End Class
