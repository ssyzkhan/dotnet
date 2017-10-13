Public Class ColorPalette
    'members...
    Public Buttons As New ArrayList()
    Public ButtonSize As Integer = 15
    Public ButtonSpacing As Integer = 5
    Public LeftColor As Color = Color.Black
    Public RightColor As Color = Color.White
    'events...
    Event LeftClick(sender As Object, e As EventArgs)
    Event RightClick(sender As Object, e As EventArgs)
    Public Function GetButtonAt(x As Integer, y As Integer) As ColorPaletteButton
        'go through each button in turn...
        Dim button As ColorPaletteButton
        For Each button In Buttons
            'is this button in the rectangle...
            If button.Rectangle.Contains(x, y) = True Then Return button

        Next
    End Function
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        'find the button that we clicked on...
        Dim button As ColorPaletteButton = GetButtonAt(e.X, e.Y)
        If Not button Is Nothing Then
            'select this color...
            If e.Button = MouseButtons.Left Then
                'set the color...
                LeftColor = button.Color
                'fire the event...
                RaiseEvent LeftClick(Me, New EventArgs())
            End If
            'did we click with the right?
            If e.Button = MouseButtons.Right Then
                'set right color...
                RightColor = button.Color
                'fire the event...
                RaiseEvent RightClick(Me, New EventArgs())
            End If
        End If

    End Sub
    Public Sub New()
        MyBase.New()
        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        'add the colors...
        AddColor(Color.Black)
        AddColor(Color.White)
        AddColor(Color.Red)

        AddColor(Color.Blue)
        AddColor(Color.Green)
        AddColor(Color.Gray)
        AddColor(Color.DarkRed)
        AddColor(Color.DarkBlue)
        AddColor(Color.DarkGreen)
        AddColor(Color.DarkGray)
    End Sub
    'AddColor - add a new color button to the control...
    Public Function AddColor(newColor As Color) As ColorPaletteButton
        'create the button...
        Dim button As New ColorPaletteButton(New Color)
        'add it to the list...
        Buttons.Add(button)

    End Function
    'OnResize - called when the control is resized...
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        'variables to hold the position
        Dim x As Integer, y As Integer
        'go through the array and position the buttons...
        Dim button As ColorPaletteButton
        For Each button In Buttons
            'position the button...
            button.SetPosition(x, y, ButtonSize)
            'move for the next one...
            x += (ButtonSize + ButtonSpacing)
            'do we need to go down to the next row?
            If x + ButtonSize > Width Then
                'move y...
                y += (ButtonSize + ButtonSpacing)
                'reset x...
                x = 0
            End If
        Next
        'redraw...
        Invalidate()
    End Sub
    'OnPaint - called when the control needs painting...
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        'loop through...
        Dim button As ColorPaletteButton
        For Each button In Buttons
            'do we need to draw?
            If e.ClipRectangle.IntersectsWith(button.Rectangle) Then
                button.Draw(e.Graphics)
            End If
        Next
    End Sub


End Class
