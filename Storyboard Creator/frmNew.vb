Public Class frmCreator
    Dim storyboard As Storyboard = New Storyboard()
    Dim mouseIsdown As Boolean = False
    Dim selectedRectangle As Rectangle
    Dim mouseOffset As Point
    Dim canvasGraphics As Graphics

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


    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.Clear(Color.White)
        storyboard.DrawRectangles(e.Graphics)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Dim rect As Rectangle = storyboard.GetRectangleAtPoint(New Point(e.X, e.Y))

        ' If there is a rectangle under this cursor
        If Not IsNothing(rect) Then
            mouseIsdown = True
            selectedRectangle = rect
            rect.X += 10
            mouseOffset = New Point(e.X - rect.X, e.Y - rect.Y)
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If mouseIsdown And Not IsNothing(selectedRectangle) Then
            selectedRectangle.X = e.X
            selectedRectangle.Y = e.Y
            PictureBox1.Refresh()



        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        mouseIsdown = False
    End Sub
End Class
