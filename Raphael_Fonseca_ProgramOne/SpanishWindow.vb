Public Class SpanishWindow

    Private Sub exit2_Click(sender As Object, e As EventArgs) Handles exit2.Click
        Me.Close()
    End Sub

    Private Sub spanishHello_Click(sender As Object, e As EventArgs) Handles spanishHello.Click
        Dim frmMessage As New noMatter
        frmMessage.ShowDialog()
        Me.Close()
    End Sub
End Class