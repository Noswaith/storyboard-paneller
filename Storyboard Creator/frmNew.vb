Public Class frmCreator
    Dim CanvasWidth As Integer = 0
    Dim CanvasHeight As Integer = 0
    Public storyboard As Storyboard = New Storyboard()
    Dim mouseIsdown As Boolean = False
    Dim selectedRectangle As Integer
    Dim mouseOffset As Point
    Dim canvasGraphics As Graphics
    Public MarginWidth As Integer
    Public MarginHeight As Integer

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


    Private Sub picCanvas_Paint(sender As Object, e As PaintEventArgs) Handles picCanvas.Paint
        e.Graphics.Clear(Color.White)
        storyboard.DrawRectangles(e.Graphics)
        storyboard.GetWidthMargin = MarginWidth
        storyboard.GetHeightMargin = MarginHeight

    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As MouseEventArgs) Handles picCanvas.MouseDown
        Dim rectIndex As Integer = storyboard.GetRectangleAtPoint(New Point(e.X, e.Y))

        ' If there is a rectangle under this cursor
        If Not rectIndex = -1 Then
            Dim rect As Rectangle = storyboard.rectangles(rectIndex)
            mouseIsdown = True
            selectedRectangle = rectIndex
            mouseOffset = New Point(e.X - rect.X, e.Y - rect.Y)
        End If
    End Sub

    Private Sub picCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles picCanvas.MouseMove
        If mouseIsdown And Not selectedRectangle = -1 Then
            Dim rect As Rectangle = storyboard.rectangles(selectedRectangle)
            rect.X = e.X - mouseOffset.X
            rect.Y = e.Y - mouseOffset.Y

            ' Keep the rectangle bounded within the window
            If rect.X + rect.Width > picCanvas.Width - 5 Then
                rect.X = picCanvas.Width - rect.Width - 5
            End If

            If rect.X < 5 Then
                rect.X = 5
            End If

            If rect.Y < 5 Then
                rect.Y = 5
            End If

            If rect.Y + rect.Height > picCanvas.Height - 5 Then
                rect.Y = picCanvas.Height - rect.Height - 5
            End If

            storyboard.rectangles(selectedRectangle) = rect
            picCanvas.Refresh()
        End If
    End Sub

    Private Sub picCanvas_MouseUp(sender As Object, e As MouseEventArgs) Handles picCanvas.MouseUp
        mouseIsdown = False
        selectedRectangle = -1
    End Sub

    Private Sub frmCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CanvasWidth = picCanvas.Width
        CanvasHeight = picCanvas.Height





        Select Case frmToolbox.cbxTemplates.Text
            Case "Dragon Fiction Publishing - Ceidwaid"
                picCanvas.Width = 800
                picCanvas.Height = 1120
            Case "Dragon Fiction Publishing - Ceidwaid Double Page"
                picCanvas.Width = 1600
                picCanvas.Height = 2240
        End Select
    End Sub
End Class
