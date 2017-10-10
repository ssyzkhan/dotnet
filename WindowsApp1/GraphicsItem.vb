Public MustInherit Class GraphicsItem
    'members...
    Public Color As Color
    Public IsFilled As Boolean
    Public Rectangle As Rectangle

    'members...
    Public MustOverride Sub Draw(graphics As Graphics)

    'SetPoint - add an item at the given point...
    Public Sub SetPoint(x As Integer, y As Integer, graphicSize As Integer, graphicColor As Color, graphicIsFilled As Boolean)
        'set the rectangle depending on the graphic and the size...
        Rectangle = New Rectangle(x - (graphicSize / 2), y - (graphicSize / 2), graphicSize, graphicSize)

        'set the color and isfilled...
        Color = graphicColor
        IsFilled = graphicIsFilled

    End Sub
End Class
