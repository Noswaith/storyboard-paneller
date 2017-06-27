Imports Microsoft.VisualBasic

Public Class Storyboard
    'List of rectangles
    Public rectangles As List(Of Rectangle) = New List(Of Rectangle)
    Public margins As List(Of Rectangle) = New List(Of Rectangle)

    Public MarginWidth As Integer
    Public MarginHeight As Integer
    Public MarginFirstPos As Integer
    Public MarginSecondPos As Integer

    Public Property GetMarginFirstPos As Integer
        Get
            Return MarginFirstPos
        End Get
        Set(ByVal value As Integer)
            MarginFirstPos = frmToolbox.nudMarginDistance.Value
        End Set
    End Property

    Public Property GetMarginSecondPos As Integer
        Get
            Return MarginSecondPos
        End Get
        Set(ByVal value As Integer)
            MarginSecondPos = frmToolbox.nudMarginDistance.Value
        End Set
    End Property

    Public Property GetWidthMargin As Integer
        Get
            Return MarginWidth
        End Get
        Set(ByVal value As Integer)
            MarginWidth = frmCreator.picCanvas.Width - frmToolbox.nudMarginDistance.Value
        End Set
    End Property

    Public Property GetHeightMargin As Integer
        Get
            Return MarginHeight
        End Get
        Set(ByVal value As Integer)
            MarginHeight = frmCreator.picCanvas.Height - frmToolbox.nudMarginDistance.Value
        End Set
    End Property



    Public Sub New()
        rectangles.Add(New Rectangle(0, 0, 200, 100))
        rectangles.Add(New Rectangle(220, 0, 100, 100))
        rectangles.Add(New Rectangle(340, 0, 100, 100))
        rectangles.Add(New Rectangle(460, 0, 100, 100))

        margins.Add(New Rectangle(MarginFirstPos, MarginSecondPos, MarginWidth, MarginHeight))


    End Sub

    'Get rectangle at a specified point
    Public Function GetRectangleAtPoint(point As Point) As Integer
        For Each rectangle As Rectangle In rectangles
            If rectangle.Contains(point) Then
                Return rectangles.IndexOf(rectangle)
            End If
        Next

        Return -1
    End Function



    'Given the specified graphics context, draw the rectangles and margins
    Sub DrawRectangles(gfx As Graphics)
        For Each rectangle As Rectangle In rectangles
            gfx.DrawRectangle(Pens.Black, rectangle)
        Next
        'Actual drawing of the margin.
        For Each margin As Rectangle In margins
            Dim MarginPen As New Pen(Color.FromArgb(0, 255, 0, 0), frmToolbox.nudMarginSize.Value)
            gfx.DrawRectangle(MarginPen, margin)
        Next

    End Sub

End Class