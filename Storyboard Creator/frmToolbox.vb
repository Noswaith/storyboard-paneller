Public Class frmToolbox
    Private Sub cbxTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTemplates.SelectedIndexChanged
        Select Case cbxTemplates.Text
            Case "Dragon Fiction Publishing - Ceidwaid"
                nudVertical.Value = 10
                nudHorizontal.Value = 7
                nudPanelThickness.Value = 4
                nudMarginDistance.Value = 10
                nudMarginSize.Value = 1
            Case "Dragon Fiction Publishing - Ceidwaid Double Page"
                nudVertical.Value = 10
                nudHorizontal.Value = 7
                nudPanelThickness.Value = 4
                nudMarginDistance.Value = 10
                nudMarginSize.Value = 1
        End Select
    End Sub

    Private Sub frmToolbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cbxTemplates.Items.Count > 0 Then
            cbxTemplates.SelectedIndex = 0
        End If

        cbxStyles.Visible = False
        lblStyles.Visible = False
    End Sub

    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        frmCustom.Show()
    End Sub

    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click
        System.Diagnostics.Process.Start("https://github.com/Noswaith/noswaiths-projects/blob/master/storyboard-paneller/documentation/toolbox")
    End Sub

    Private Sub cbxShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxShape.SelectedIndexChanged
        If cbxShape.Text <> "" Then
            cbxStyles.Visible = True
            lblStyles.Visible = True
        End If
    End Sub

    Private Sub cbxStyles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStyles.SelectedIndexChanged

    End Sub

    Public Sub nudMarginDistance_ValueChanged(sender As Object, e As EventArgs) Handles nudMarginDistance.ValueChanged
        frmCreator.storyboard.GetWidthMargin = nudMarginDistance.Value
        frmCreator.storyboard.GetHeightMargin = nudMarginDistance.Value
    End Sub

    Public Sub nudMarginSize_ValueChanged(sender As Object, e As EventArgs) Handles nudMarginSize.ValueChanged

    End Sub


End Class