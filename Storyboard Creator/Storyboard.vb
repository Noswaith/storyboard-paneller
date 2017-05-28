Imports Microsoft.VisualBasic

Public Class Storyboard
    ' List of rectangles
    Dim rectangles As List(Of Rectangle)

    Public Sub New()
        rectangles.Add(New Rectangle(0, 0, 100, 100))
    End Sub

    ' Given the specified graphics context, draw the rectangles
    Sub DrawRectangles(gfx As Graphics)
        For Each rectangle As Rectangle In rectangles
            gfx.DrawRectangle(Pens.Black, rectangle)
        Next
    End Sub
End Class