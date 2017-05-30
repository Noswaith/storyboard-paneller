Imports Microsoft.VisualBasic

Public Class Storyboard
    ' List of rectangles
    Public Dim rectangles As List(Of Rectangle) = New List(Of Rectangle)

    Public Sub New()
        rectangles.Add(New Rectangle(0, 0, 200, 100))
        rectangles.Add(New Rectangle(220, 0, 100, 100))
        rectangles.Add(New Rectangle(340, 0, 100, 100))
        rectangles.Add(New Rectangle(460, 0, 100, 100))
    End Sub

    ' Get rectangle at a specified point
    Public Function GetRectangleAtPoint(point As Point) As Integer
        For Each rectangle As Rectangle In rectangles
            If rectangle.Contains(point) Then
                Return rectangles.IndexOf(rectangle)
            End If
        Next

        Return -1
    End Function


    ' Given the specified graphics context, draw the rectangles
    Sub DrawRectangles(gfx As Graphics)
        For Each rectangle As Rectangle In rectangles
            gfx.DrawRectangle(Pens.Black, rectangle)
        Next
    End Sub
End Class