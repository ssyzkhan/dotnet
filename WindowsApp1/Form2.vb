Public Class Form2
    Private Sub txtWords_TextChanged(sender As Object, e As EventArgs) Handles txtWords.TextChanged
        'something's changed...update the display...
        UpdateDisplay()

    End Sub

    Private Sub radCountChars_CheckedChanged(sender As Object, e As EventArgs) Handles radCountChars.CheckedChanged
        'something's changed... update the display...
        UpdateDisplay()
    End Sub

    Private Sub radCountWords_CheckedChanged(sender As Object, e As EventArgs) Handles radCountWords.CheckedChanged
        'something's changed... update the display...
        UpdateDisplay()
    End Sub

    Private Sub btnShowMe_Click(sender As Object, e As EventArgs) Handles btnShowMe.Click
        'display the text contained in the label...
        MessageBox.Show(lblResults.Text, "Word Counter")
        ToolStripStatusLabel1.Text = lblResults.Text
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MsgBox("The A drive is not ready.", MsgBoxStyle.AbortRetryIgnore, "Device Not Ready")
    End Sub

    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click
        OpenFileDialog1.ShowDialog()

    End Sub

    'CountCharacters - count the characters in a block of text...
    Public Function CountCharacters(ByVal text As String) As Integer
        'return the number of characters...
        Return text.Length
    End Function
    'CountWords - count the number of words in a block of text..
    Public Function CountWords(ByVal text As String) As Integer
        'is the text box empty?
        If txtWords.Text = "" Then Return 0
        'split...
        Dim words() As String = text.Split(" ".ToCharArray())
        Return words.Length
    End Function
    'UpdateDisplay - update the display...
    Public Function UpdateDisplay() As String
        'what text do we want to use?
        Dim countText As String = txtWords.Text
        Dim resultText As String

        'do we want to count words?
        If radCountWords.Checked = True Then
            'count the words...
            Dim numWords As Integer = CountWords(countText)
            'return the text..
            resultText = numWords & " words"
        Else
            'count the characters...
            Dim numChars As Integer = CountCharacters(countText)
            resultText = numChars & " characters"

        End If
        'update the display...
        lblResults.Text = resultText
    End Function
End Class