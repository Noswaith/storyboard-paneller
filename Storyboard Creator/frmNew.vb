Public Class frmCreator
    Private Sub btnNewFile_Click(sender As Object, e As EventArgs) Handles btnNewFile.Click
        If MessageBox.Show("Are you sure you want to create a new file?", "New File",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) _
         = DialogResult.Yes Then
            frmMenu.Show() 'Dummy text until I learn how to actually make this work. Probably clearing all.
            Me.Hide()
            Me.Close()
        End If
    End Sub
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        'I think it is awfully bold of you to suggest I know how to code a load/save function.
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'I think it is awfully bold of you to suggest I know how to code a load/save function.
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmMenu.Show()
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click
        System.Diagnostics.Process.Start("https://github.com/Noswaith/noswaiths-projects/blob/master/storyboard-paneller/documentation/new")
    End Sub
End Class
