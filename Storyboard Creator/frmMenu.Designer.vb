﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnChangelog = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblVersionNumber = New System.Windows.Forms.Label()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpButtons
        '
        Me.grpButtons.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpButtons.BackColor = System.Drawing.Color.Transparent
        Me.grpButtons.Controls.Add(Me.btnChangelog)
        Me.grpButtons.Controls.Add(Me.btnQuit)
        Me.grpButtons.Controls.Add(Me.btnLoad)
        Me.grpButtons.Controls.Add(Me.btnNew)
        Me.grpButtons.Location = New System.Drawing.Point(50, 25)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(300, 210)
        Me.grpButtons.TabIndex = 0
        Me.grpButtons.TabStop = False
        '
        'btnChangelog
        '
        Me.btnChangelog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnChangelog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangelog.Image = CType(resources.GetObject("btnChangelog.Image"), System.Drawing.Image)
        Me.btnChangelog.Location = New System.Drawing.Point(105, 170)
        Me.btnChangelog.Name = "btnChangelog"
        Me.btnChangelog.Size = New System.Drawing.Size(90, 30)
        Me.btnChangelog.TabIndex = 3
        Me.btnChangelog.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuit.Location = New System.Drawing.Point(105, 120)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(90, 30)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Location = New System.Drawing.Point(105, 70)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(90, 30)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Location = New System.Drawing.Point(105, 20)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 30)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblVersionNumber
        '
        Me.lblVersionNumber.AutoSize = True
        Me.lblVersionNumber.Location = New System.Drawing.Point(339, 264)
        Me.lblVersionNumber.Name = "lblVersionNumber"
        Me.lblVersionNumber.Size = New System.Drawing.Size(39, 17)
        Me.lblVersionNumber.TabIndex = 1
        Me.lblVersionNumber.Text = "v.0.8"
        Me.lblVersionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(402, 290)
        Me.Controls.Add(Me.lblVersionNumber)
        Me.Controls.Add(Me.grpButtons)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.Text = "Storyboard Creator - Menu"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnChangelog As Button
    Friend WithEvents lblVersionNumber As Label
End Class
