Public Class PaintCanvas
    'enums...
    Public Enum GraphicTools As Integer
        CirclePen = 0
    End Enum

    Public Enum GraphicSizes As Integer
        Small = 4
        Medium = 10
        Large = 20
    End Enum

    'members...
    Public GraphicsItems As New ArrayList()
    Public graphicTool As GraphicTools = GraphicTools.CirclePen
    Public GraphicSize As GraphicSizes = GraphicSizes.Medium
    Public GraphicColor As Color = Color.Black

    'DoMousePatin - respond to a mouse movement...
    Private Sub DoMousePaint(e As MouseEventArgs)
        'store the new item somewhere...
        Dim newItem As GraphicsItem

        'what tool are we using?
        Select Case graphicTool
            Case GraphicTools.CirclePen
                'create a new graphics circle...
                Dim circle As New GraphicsCircle()
                circle.SetPoint(e.X, e.Y, GraphicSize, GraphicColor, True)

                'store this for addition...
                newItem = circle

        End Select

        'were we given an item?
        If Not newItem Is Nothing Then
            'add it to the list...
            GraphicsItems.Add(newItem)

            'invalidate...
            'Invalidate()
            Invalidate(newItem.Rectangle)
        End If
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        'is the button down?
        If e.Button = MouseButtons.Left Then
            DoMousePaint(e)
        End If
    End Sub
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        'is the button down?
        If e.Button = MouseButtons.Left Then
            DoMousePaint(e)
        End If
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        'go through the list...
        Dim item As GraphicsItem
        For Each item In GraphicsItems
            'do we need to be drawn?
            If e.ClipRectangle.IntersectsWith(item.Rectangle) = True Then
                'ask each item to draw itself...
                item.Draw(e.Graphics)
            End If

        Next
    End Sub
End Class
