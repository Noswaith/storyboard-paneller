Public Class frmToolbox
    Private Sub cbxTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTemplates.SelectedIndexChanged
        Select Case cbxTemplates.Text
            Case "Dragon Fiction Publishing - Ceidwaid"
                nudVertical.Value = 10
                nudHorizontal.Value = 7
                nudPanelThickness.Value = 4
                nudMarginDistance.Value = 10
                nudMarginSize.Value = 1
        End Select
    End Sub

    Private Sub frmToolbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cbxShape.Text = "" Then
            cbxStyles.Visible = False
            lblStyles.Visible = False
        Else
            cbxStyles.Visible = True
            lblStyles.Visible = True
        End If

    End Sub

    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        MsgBox("This function is under development. We're sorry about that!")
    End Sub

    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click
        System.Diagnostics.Process.Start("https://github.com/Noswaith/noswaiths-projects/blob/master/storyboard-paneller/documentation/toolbox")
    End Sub

    Private Sub cbxShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxShape.SelectedIndexChanged
        Select Case cbxShape.Text
            Case "Special"
                cbxStyles.Items.Add("Star Shape")
                cbxStyles.Items.Add("Wavy Border")
        End Select
    End Sub
End Class