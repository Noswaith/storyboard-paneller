<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustom))
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.grpYPoint = New System.Windows.Forms.GroupBox()
        Me.lblY4 = New System.Windows.Forms.Label()
        Me.nudY4 = New System.Windows.Forms.NumericUpDown()
        Me.lblY3 = New System.Windows.Forms.Label()
        Me.nudY1 = New System.Windows.Forms.NumericUpDown()
        Me.lblY2 = New System.Windows.Forms.Label()
        Me.nudY3 = New System.Windows.Forms.NumericUpDown()
        Me.lblY1 = New System.Windows.Forms.Label()
        Me.nudY2 = New System.Windows.Forms.NumericUpDown()
        Me.grpXPoint = New System.Windows.Forms.GroupBox()
        Me.lblX4 = New System.Windows.Forms.Label()
        Me.lblX3 = New System.Windows.Forms.Label()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.lblX1 = New System.Windows.Forms.Label()
        Me.nudX4 = New System.Windows.Forms.NumericUpDown()
        Me.nudX3 = New System.Windows.Forms.NumericUpDown()
        Me.nudX2 = New System.Windows.Forms.NumericUpDown()
        Me.nudX1 = New System.Windows.Forms.NumericUpDown()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.btnSupport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.picCustomPanel = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpControls.SuspendLayout()
        Me.grpYPoint.SuspendLayout()
        CType(Me.nudY4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudY1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudY3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudY2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpXPoint.SuspendLayout()
        CType(Me.nudX4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCustomPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.btnClear)
        Me.grpControls.Controls.Add(Me.grpYPoint)
        Me.grpControls.Controls.Add(Me.grpXPoint)
        Me.grpControls.Controls.Add(Me.btnDraw)
        Me.grpControls.Controls.Add(Me.btnSupport)
        Me.grpControls.Controls.Add(Me.btnSave)
        Me.grpControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpControls.Location = New System.Drawing.Point(0, 653)
        Me.grpControls.Margin = New System.Windows.Forms.Padding(0)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Padding = New System.Windows.Forms.Padding(0)
        Me.grpControls.Size = New System.Drawing.Size(732, 100)
        Me.grpControls.TabIndex = 0
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "Controls"
        '
        'grpYPoint
        '
        Me.grpYPoint.Controls.Add(Me.lblY4)
        Me.grpYPoint.Controls.Add(Me.nudY4)
        Me.grpYPoint.Controls.Add(Me.lblY3)
        Me.grpYPoint.Controls.Add(Me.nudY1)
        Me.grpYPoint.Controls.Add(Me.lblY2)
        Me.grpYPoint.Controls.Add(Me.nudY3)
        Me.grpYPoint.Controls.Add(Me.lblY1)
        Me.grpYPoint.Controls.Add(Me.nudY2)
        Me.grpYPoint.Location = New System.Drawing.Point(290, 32)
        Me.grpYPoint.Name = "grpYPoint"
        Me.grpYPoint.Size = New System.Drawing.Size(272, 68)
        Me.grpYPoint.TabIndex = 3
        Me.grpYPoint.TabStop = False
        Me.grpYPoint.Text = "Vertical Points"
        '
        'lblY4
        '
        Me.lblY4.AutoSize = True
        Me.lblY4.Location = New System.Drawing.Point(156, 23)
        Me.lblY4.Name = "lblY4"
        Me.lblY4.Size = New System.Drawing.Size(25, 17)
        Me.lblY4.TabIndex = 12
        Me.lblY4.Text = "Y4"
        '
        'nudY4
        '
        Me.nudY4.Location = New System.Drawing.Point(159, 43)
        Me.nudY4.Maximum = New Decimal(New Integer() {648, 0, 0, 0})
        Me.nudY4.Name = "nudY4"
        Me.nudY4.Size = New System.Drawing.Size(45, 22)
        Me.nudY4.TabIndex = 12
        Me.nudY4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblY3
        '
        Me.lblY3.AutoSize = True
        Me.lblY3.Location = New System.Drawing.Point(105, 23)
        Me.lblY3.Name = "lblY3"
        Me.lblY3.Size = New System.Drawing.Size(25, 17)
        Me.lblY3.TabIndex = 11
        Me.lblY3.Text = "Y3"
        '
        'nudY1
        '
        Me.nudY1.Location = New System.Drawing.Point(6, 43)
        Me.nudY1.Maximum = New Decimal(New Integer() {648, 0, 0, 0})
        Me.nudY1.Name = "nudY1"
        Me.nudY1.Size = New System.Drawing.Size(45, 22)
        Me.nudY1.TabIndex = 9
        Me.nudY1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblY2
        '
        Me.lblY2.AutoSize = True
        Me.lblY2.Location = New System.Drawing.Point(54, 23)
        Me.lblY2.Name = "lblY2"
        Me.lblY2.Size = New System.Drawing.Size(25, 17)
        Me.lblY2.TabIndex = 10
        Me.lblY2.Text = "Y2"
        '
        'nudY3
        '
        Me.nudY3.Location = New System.Drawing.Point(108, 43)
        Me.nudY3.Maximum = New Decimal(New Integer() {648, 0, 0, 0})
        Me.nudY3.Name = "nudY3"
        Me.nudY3.Size = New System.Drawing.Size(45, 22)
        Me.nudY3.TabIndex = 11
        Me.nudY3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblY1
        '
        Me.lblY1.AutoSize = True
        Me.lblY1.Location = New System.Drawing.Point(6, 23)
        Me.lblY1.Name = "lblY1"
        Me.lblY1.Size = New System.Drawing.Size(25, 17)
        Me.lblY1.TabIndex = 9
        Me.lblY1.Text = "Y1"
        '
        'nudY2
        '
        Me.nudY2.Location = New System.Drawing.Point(57, 43)
        Me.nudY2.Maximum = New Decimal(New Integer() {648, 0, 0, 0})
        Me.nudY2.Name = "nudY2"
        Me.nudY2.Size = New System.Drawing.Size(45, 22)
        Me.nudY2.TabIndex = 10
        Me.nudY2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grpXPoint
        '
        Me.grpXPoint.Controls.Add(Me.lblX4)
        Me.grpXPoint.Controls.Add(Me.lblX3)
        Me.grpXPoint.Controls.Add(Me.lblX2)
        Me.grpXPoint.Controls.Add(Me.lblX1)
        Me.grpXPoint.Controls.Add(Me.nudX4)
        Me.grpXPoint.Controls.Add(Me.nudX3)
        Me.grpXPoint.Controls.Add(Me.nudX2)
        Me.grpXPoint.Controls.Add(Me.nudX1)
        Me.grpXPoint.Location = New System.Drawing.Point(12, 32)
        Me.grpXPoint.Name = "grpXPoint"
        Me.grpXPoint.Size = New System.Drawing.Size(272, 68)
        Me.grpXPoint.TabIndex = 2
        Me.grpXPoint.TabStop = False
        Me.grpXPoint.Text = "Horizontal Points"
        '
        'lblX4
        '
        Me.lblX4.AutoSize = True
        Me.lblX4.Location = New System.Drawing.Point(156, 23)
        Me.lblX4.Name = "lblX4"
        Me.lblX4.Size = New System.Drawing.Size(25, 17)
        Me.lblX4.TabIndex = 8
        Me.lblX4.Text = "X4"
        '
        'lblX3
        '
        Me.lblX3.AutoSize = True
        Me.lblX3.Location = New System.Drawing.Point(105, 23)
        Me.lblX3.Name = "lblX3"
        Me.lblX3.Size = New System.Drawing.Size(25, 17)
        Me.lblX3.TabIndex = 7
        Me.lblX3.Text = "X3"
        '
        'lblX2
        '
        Me.lblX2.AutoSize = True
        Me.lblX2.Location = New System.Drawing.Point(54, 23)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(25, 17)
        Me.lblX2.TabIndex = 6
        Me.lblX2.Text = "X2"
        '
        'lblX1
        '
        Me.lblX1.AutoSize = True
        Me.lblX1.Location = New System.Drawing.Point(6, 23)
        Me.lblX1.Name = "lblX1"
        Me.lblX1.Size = New System.Drawing.Size(25, 17)
        Me.lblX1.TabIndex = 2
        Me.lblX1.Text = "X1"
        '
        'nudX4
        '
        Me.nudX4.Location = New System.Drawing.Point(159, 43)
        Me.nudX4.Maximum = New Decimal(New Integer() {732, 0, 0, 0})
        Me.nudX4.Name = "nudX4"
        Me.nudX4.Size = New System.Drawing.Size(45, 22)
        Me.nudX4.TabIndex = 5
        Me.nudX4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudX3
        '
        Me.nudX3.Location = New System.Drawing.Point(108, 43)
        Me.nudX3.Maximum = New Decimal(New Integer() {732, 0, 0, 0})
        Me.nudX3.Name = "nudX3"
        Me.nudX3.Size = New System.Drawing.Size(45, 22)
        Me.nudX3.TabIndex = 4
        Me.nudX3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudX2
        '
        Me.nudX2.Location = New System.Drawing.Point(57, 43)
        Me.nudX2.Maximum = New Decimal(New Integer() {732, 0, 0, 0})
        Me.nudX2.Name = "nudX2"
        Me.nudX2.Size = New System.Drawing.Size(45, 22)
        Me.nudX2.TabIndex = 3
        Me.nudX2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudX1
        '
        Me.nudX1.Location = New System.Drawing.Point(6, 43)
        Me.nudX1.Maximum = New Decimal(New Integer() {732, 0, 0, 0})
        Me.nudX1.Name = "nudX1"
        Me.nudX1.Size = New System.Drawing.Size(45, 22)
        Me.nudX1.TabIndex = 2
        Me.nudX1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnDraw
        '
        Me.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDraw.Image = CType(resources.GetObject("btnDraw.Image"), System.Drawing.Image)
        Me.btnDraw.Location = New System.Drawing.Point(603, 62)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(35, 35)
        Me.btnDraw.TabIndex = 16
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'btnSupport
        '
        Me.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupport.Image = CType(resources.GetObject("btnSupport.Image"), System.Drawing.Image)
        Me.btnSupport.Location = New System.Drawing.Point(685, 62)
        Me.btnSupport.Name = "btnSupport"
        Me.btnSupport.Size = New System.Drawing.Size(35, 35)
        Me.btnSupport.TabIndex = 7
        Me.btnSupport.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(644, 62)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(35, 35)
        Me.btnSave.TabIndex = 6
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'picCustomPanel
        '
        Me.picCustomPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.picCustomPanel.Location = New System.Drawing.Point(0, 0)
        Me.picCustomPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.picCustomPanel.Name = "picCustomPanel"
        Me.picCustomPanel.Size = New System.Drawing.Size(732, 648)
        Me.picCustomPanel.TabIndex = 1
        Me.picCustomPanel.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(562, 62)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(35, 35)
        Me.btnClear.TabIndex = 2
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmCustom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 753)
        Me.Controls.Add(Me.picCustomPanel)
        Me.Controls.Add(Me.grpControls)
        Me.Name = "frmCustom"
        Me.Text = "Custom Panel"
        Me.grpControls.ResumeLayout(False)
        Me.grpYPoint.ResumeLayout(False)
        Me.grpYPoint.PerformLayout()
        CType(Me.nudY4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudY1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudY3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudY2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpXPoint.ResumeLayout(False)
        Me.grpXPoint.PerformLayout()
        CType(Me.nudX4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCustomPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpControls As GroupBox
    Friend WithEvents picCustomPanel As PictureBox
    Friend WithEvents btnSupport As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDraw As Button
    Friend WithEvents grpYPoint As GroupBox
    Friend WithEvents grpXPoint As GroupBox
    Friend WithEvents nudX4 As NumericUpDown
    Friend WithEvents nudX3 As NumericUpDown
    Friend WithEvents nudX2 As NumericUpDown
    Friend WithEvents nudX1 As NumericUpDown
    Friend WithEvents lblY4 As Label
    Friend WithEvents nudY4 As NumericUpDown
    Friend WithEvents lblY3 As Label
    Friend WithEvents nudY1 As NumericUpDown
    Friend WithEvents lblY2 As Label
    Friend WithEvents nudY3 As NumericUpDown
    Friend WithEvents lblY1 As Label
    Friend WithEvents nudY2 As NumericUpDown
    Friend WithEvents lblX4 As Label
    Friend WithEvents lblX3 As Label
    Friend WithEvents lblX2 As Label
    Friend WithEvents lblX1 As Label
    Friend WithEvents btnClear As Button
End Class
