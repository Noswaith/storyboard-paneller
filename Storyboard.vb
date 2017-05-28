Imports Microsoft.VisualBasic

Public Class Storyboard
    Dim rectangles As List(Of Rectangle)

    Function DrawRectangles(gfx As Graphics)
        For Each rectangle As Rectangle In rectangles
            gfx.DrawRectangle(Pens.Black, rectangle)
        Next
    End Function
End Class