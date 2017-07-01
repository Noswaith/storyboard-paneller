Public Class frmCustom
    Dim PNL As New Drawing.Bitmap(732, 648)
    Dim GFX As Graphics = Graphics.FromImage(PNL)




    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click

        Dim P1 As New Point(nudX1.Value, nudY1.Value)
        Dim P2 As New Point(nudX2.Value, nudY2.Value)
        Dim P3 As New Point(nudX3.Value, nudY3.Value)
        Dim P4 As New Point(nudX4.Value, nudY4.Value)
        Dim POLYGONPOINTS As Point() = {P1, P2, P3, P4}

        Dim PanelPen As New Pen(Color.Black, frmToolbox.nudPanelThickness.Value)
        GFX.DrawPolygon(PanelPen, POLYGONPOINTS)
        picCustomPanel.Image = PNL
    End Sub

    Private Sub frmCustom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears image.
        picCustomPanel.Image = Nothing
        PNL = Nothing
        'Clears horizontal input.
        nudX1.Value = 1
        nudX2.Value = 1
        nudX3.Value = 1
        nudX4.Value = 1
        'Clears vertical input.
        nudY1.Value = 1
        nudY2.Value = 1
        nudY3.Value = 1
        nudY4.Value = 1
    End Sub
End Class