<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmToolbox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmToolbox))
        Me.grpProperties = New System.Windows.Forms.GroupBox()
        Me.nudMarginSize = New System.Windows.Forms.NumericUpDown()
        Me.lblMarginSize = New System.Windows.Forms.Label()
        Me.nudMarginDistance = New System.Windows.Forms.NumericUpDown()
        Me.nudPanelThickness = New System.Windows.Forms.NumericUpDown()
        Me.lblMarginDistance = New System.Windows.Forms.Label()
        Me.lblPanelThickness = New System.Windows.Forms.Label()
        Me.nudHorizontal = New System.Windows.Forms.NumericUpDown()
        Me.lblHPD = New System.Windows.Forms.Label()
        Me.cbxTemplates = New System.Windows.Forms.ComboBox()
        Me.nudVertical = New System.Windows.Forms.NumericUpDown()
        Me.lblVPD = New System.Windows.Forms.Label()
        Me.lblTemplates = New System.Windows.Forms.Label()
        Me.grpPanels = New System.Windows.Forms.GroupBox()
        Me.picPanel = New System.Windows.Forms.PictureBox()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.btnSupport = New System.Windows.Forms.Button()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.cbxStyles = New System.Windows.Forms.ComboBox()
        Me.cbxShape = New System.Windows.Forms.ComboBox()
        Me.lblStyles = New System.Windows.Forms.Label()
        Me.grpProperties.SuspendLayout()
        CType(Me.nudMarginSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMarginDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPanelThickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPanels.SuspendLayout()
        CType(Me.picPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProperties
        '
        Me.grpProperties.Controls.Add(Me.nudMarginSize)
        Me.grpProperties.Controls.Add(Me.lblMarginSize)
        Me.grpProperties.Controls.Add(Me.nudMarginDistance)
        Me.grpProperties.Controls.Add(Me.nudPanelThickness)
        Me.grpProperties.Controls.Add(Me.lblMarginDistance)
        Me.grpProperties.Controls.Add(Me.lblPanelThickness)
        Me.grpProperties.Controls.Add(Me.nudHorizontal)
        Me.grpProperties.Controls.Add(Me.lblHPD)
        Me.grpProperties.Controls.Add(Me.cbxTemplates)
        Me.grpProperties.Controls.Add(Me.nudVertical)
        Me.grpProperties.Controls.Add(Me.lblVPD)
        Me.grpProperties.Controls.Add(Me.lblTemplates)
        Me.grpProperties.Location = New System.Drawing.Point(12, 573)
        Me.grpProperties.Name = "grpProperties"
        Me.grpProperties.Size = New System.Drawing.Size(573, 101)
        Me.grpProperties.TabIndex = 0
        Me.grpProperties.TabStop = False
        Me.grpProperties.Text = "Properties"
        '
        'nudMarginSize
        '
        Me.nudMarginSize.Location = New System.Drawing.Point(517, 57)
        Me.nudMarginSize.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMarginSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMarginSize.Name = "nudMarginSize"
        Me.nudMarginSize.Size = New System.Drawing.Size(49, 22)
        Me.nudMarginSize.TabIndex = 10
        Me.nudMarginSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMarginSize
        '
        Me.lblMarginSize.AutoSize = True
        Me.lblMarginSize.Location = New System.Drawing.Point(425, 57)
        Me.lblMarginSize.Name = "lblMarginSize"
        Me.lblMarginSize.Size = New System.Drawing.Size(86, 17)
        Me.lblMarginSize.TabIndex = 9
        Me.lblMarginSize.Text = "Margin Size:"
        '
        'nudMarginDistance
        '
        Me.nudMarginDistance.Location = New System.Drawing.Point(370, 70)
        Me.nudMarginDistance.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudMarginDistance.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMarginDistance.Name = "nudMarginDistance"
        Me.nudMarginDistance.Size = New System.Drawing.Size(49, 22)
        Me.nudMarginDistance.TabIndex = 8
        Me.nudMarginDistance.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPanelThickness
        '
        Me.nudPanelThickness.Location = New System.Drawing.Point(370, 45)
        Me.nudPanelThickness.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPanelThickness.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPanelThickness.Name = "nudPanelThickness"
        Me.nudPanelThickness.Size = New System.Drawing.Size(49, 22)
        Me.nudPanelThickness.TabIndex = 7
        Me.nudPanelThickness.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMarginDistance
        '
        Me.lblMarginDistance.AutoSize = True
        Me.lblMarginDistance.Location = New System.Drawing.Point(245, 70)
        Me.lblMarginDistance.Name = "lblMarginDistance"
        Me.lblMarginDistance.Size = New System.Drawing.Size(114, 17)
        Me.lblMarginDistance.TabIndex = 6
        Me.lblMarginDistance.Text = "Margin Distance:"
        '
        'lblPanelThickness
        '
        Me.lblPanelThickness.AutoSize = True
        Me.lblPanelThickness.Location = New System.Drawing.Point(245, 45)
        Me.lblPanelThickness.Name = "lblPanelThickness"
        Me.lblPanelThickness.Size = New System.Drawing.Size(116, 17)
        Me.lblPanelThickness.TabIndex = 5
        Me.lblPanelThickness.Text = "Panel Thickness:"
        '
        'nudHorizontal
        '
        Me.nudHorizontal.Location = New System.Drawing.Point(190, 70)
        Me.nudHorizontal.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudHorizontal.Name = "nudHorizontal"
        Me.nudHorizontal.Size = New System.Drawing.Size(49, 22)
        Me.nudHorizontal.TabIndex = 4
        Me.nudHorizontal.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblHPD
        '
        Me.lblHPD.AutoSize = True
        Me.lblHPD.Location = New System.Drawing.Point(6, 70)
        Me.lblHPD.Name = "lblHPD"
        Me.lblHPD.Size = New System.Drawing.Size(175, 17)
        Me.lblHPD.TabIndex = 3
        Me.lblHPD.Text = "Horizontal Panel Distance:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbxTemplates
        '
        Me.cbxTemplates.FormattingEnabled = True
        Me.cbxTemplates.Items.AddRange(New Object() {"Dragon Fiction Publishing - Ceidwaid"})
        Me.cbxTemplates.Location = New System.Drawing.Point(81, 15)
        Me.cbxTemplates.Name = "cbxTemplates"
        Me.cbxTemplates.Size = New System.Drawing.Size(485, 24)
        Me.cbxTemplates.TabIndex = 1
        '
        'nudVertical
        '
        Me.nudVertical.Location = New System.Drawing.Point(190, 45)
        Me.nudVertical.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudVertical.Name = "nudVertical"
        Me.nudVertical.Size = New System.Drawing.Size(49, 22)
        Me.nudVertical.TabIndex = 1
        Me.nudVertical.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblVPD
        '
        Me.lblVPD.AutoSize = True
        Me.lblVPD.Location = New System.Drawing.Point(6, 45)
        Me.lblVPD.Name = "lblVPD"
        Me.lblVPD.Size = New System.Drawing.Size(158, 17)
        Me.lblVPD.TabIndex = 2
        Me.lblVPD.Text = "Vertical Panel Distance:"
        '
        'lblTemplates
        '
        Me.lblTemplates.AutoSize = True
        Me.lblTemplates.Location = New System.Drawing.Point(6, 18)
        Me.lblTemplates.Name = "lblTemplates"
        Me.lblTemplates.Size = New System.Drawing.Size(78, 17)
        Me.lblTemplates.TabIndex = 2
        Me.lblTemplates.Text = "Templates:"
        '
        'grpPanels
        '
        Me.grpPanels.Controls.Add(Me.picPanel)
        Me.grpPanels.Controls.Add(Me.grpFilter)
        Me.grpPanels.Location = New System.Drawing.Point(12, 12)
        Me.grpPanels.Name = "grpPanels"
        Me.grpPanels.Size = New System.Drawing.Size(573, 555)
        Me.grpPanels.TabIndex = 1
        Me.grpPanels.TabStop = False
        Me.grpPanels.Text = "Panels"
        '
        'picPanel
        '
        Me.picPanel.Location = New System.Drawing.Point(6, 81)
        Me.picPanel.Name = "picPanel"
        Me.picPanel.Size = New System.Drawing.Size(567, 468)
        Me.picPanel.TabIndex = 15
        Me.picPanel.TabStop = False
        '
        'grpFilter
        '
        Me.grpFilter.Controls.Add(Me.btnSupport)
        Me.grpFilter.Controls.Add(Me.btnCustom)
        Me.grpFilter.Controls.Add(Me.lblShape)
        Me.grpFilter.Controls.Add(Me.cbxStyles)
        Me.grpFilter.Controls.Add(Me.cbxShape)
        Me.grpFilter.Controls.Add(Me.lblStyles)
        Me.grpFilter.Location = New System.Drawing.Point(6, 21)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(560, 54)
        Me.grpFilter.TabIndex = 14
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Filter"
        '
        'btnSupport
        '
        Me.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupport.Image = CType(resources.GetObject("btnSupport.Image"), System.Drawing.Image)
        Me.btnSupport.Location = New System.Drawing.Point(464, 9)
        Me.btnSupport.Name = "btnSupport"
        Me.btnSupport.Size = New System.Drawing.Size(41, 41)
        Me.btnSupport.TabIndex = 16
        Me.btnSupport.UseVisualStyleBackColor = True
        '
        'btnCustom
        '
        Me.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustom.Image = CType(resources.GetObject("btnCustom.Image"), System.Drawing.Image)
        Me.btnCustom.Location = New System.Drawing.Point(511, 9)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(41, 41)
        Me.btnCustom.TabIndex = 15
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(6, 18)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(60, 17)
        Me.lblShape.TabIndex = 11
        Me.lblShape.Text = "Shapes:"
        '
        'cbxStyles
        '
        Me.cbxStyles.FormattingEnabled = True
        Me.cbxStyles.Location = New System.Drawing.Point(256, 18)
        Me.cbxStyles.Name = "cbxStyles"
        Me.cbxStyles.Size = New System.Drawing.Size(121, 24)
        Me.cbxStyles.TabIndex = 13
        '
        'cbxShape
        '
        Me.cbxShape.FormattingEnabled = True
        Me.cbxShape.Items.AddRange(New Object() {"Diagonals", "Rectangles", "Special", "Squares", "Triangles", "-------------", "Custom"})
        Me.cbxShape.Location = New System.Drawing.Point(71, 18)
        Me.cbxShape.Name = "cbxShape"
        Me.cbxShape.Size = New System.Drawing.Size(121, 24)
        Me.cbxShape.TabIndex = 0
        '
        'lblStyles
        '
        Me.lblStyles.AutoSize = True
        Me.lblStyles.Location = New System.Drawing.Point(198, 18)
        Me.lblStyles.Name = "lblStyles"
        Me.lblStyles.Size = New System.Drawing.Size(50, 17)
        Me.lblStyles.TabIndex = 12
        Me.lblStyles.Text = "Styles:"
        '
        'frmToolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 686)
        Me.Controls.Add(Me.grpPanels)
        Me.Controls.Add(Me.grpProperties)
        Me.Location = New System.Drawing.Point(1010, 0)
        Me.Name = "frmToolbox"
        Me.Text = "Storyboard Creator - Toolbox"
        Me.grpProperties.ResumeLayout(False)
        Me.grpProperties.PerformLayout()
        CType(Me.nudMarginSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMarginDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPanelThickness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPanels.ResumeLayout(False)
        CType(Me.picPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpProperties As GroupBox
    Friend WithEvents nudMarginSize As NumericUpDown
    Friend WithEvents lblMarginSize As Label
    Friend WithEvents nudMarginDistance As NumericUpDown
    Friend WithEvents nudPanelThickness As NumericUpDown
    Friend WithEvents lblMarginDistance As Label
    Friend WithEvents lblPanelThickness As Label
    Friend WithEvents nudHorizontal As NumericUpDown
    Friend WithEvents lblHPD As Label
    Friend WithEvents cbxTemplates As ComboBox
    Friend WithEvents nudVertical As NumericUpDown
    Friend WithEvents lblVPD As Label
    Friend WithEvents lblTemplates As Label
    Friend WithEvents grpPanels As GroupBox
    Friend WithEvents grpFilter As GroupBox
    Friend WithEvents btnCustom As Button
    Friend WithEvents lblShape As Label
    Friend WithEvents cbxStyles As ComboBox
    Friend WithEvents cbxShape As ComboBox
    Friend WithEvents lblStyles As Label
    Friend WithEvents picPanel As PictureBox
    Friend WithEvents btnSupport As Button
End Class
