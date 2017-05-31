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

    Private Sub frmMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnChangelog_Click(sender As Object, e As EventArgs) Handles btnChangelog.Click
        System.Diagnostics.Process.Start("https://github.com/Noswaith/noswaiths-projects/blob/master/storyboard-paneller/changelog")
        Dim ttpChangelog As New ToolTip()
        ttpChangelog.ShowAlways = True
        ttpChangelog.SetToolTip(btnChangelog, "Changelog. Opens a browser window.")
    End Sub
End Class