Public Class EnglishWindow

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub exit3_Click(sender As Object, e As EventArgs) Handles exit3.Click
        Me.Close()
    End Sub

    Private Sub englishHello_Click(sender As Object, e As EventArgs) Handles englishHello.Click
        Dim frmMessage As New noMatter
        frmMessage.ShowDialog()
        Me.Close()
    End Sub
End Class