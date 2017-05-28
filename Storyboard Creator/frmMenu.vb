Public Class frmMenu
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmCreator.Show()
        frmToolbox.Show()
        Me.Hide()
        'Me.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'To Be Completed.
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class