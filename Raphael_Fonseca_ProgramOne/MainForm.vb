Public Class MainForm

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles spanishButton.Click
        Dim frmMessage As New SpanishWindow
        frmMessage.ShowDialog()

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub englishButton_Click(sender As Object, e As EventArgs) Handles englishButton.Click
        Dim frmMessage As New EnglishWindow
        frmMessage.ShowDialog()
    End Sub
End Class
