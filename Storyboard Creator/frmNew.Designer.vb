<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreator))
        Me.grpFile = New System.Windows.Forms.GroupBox()
        Me.btnSupport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnNewFile = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpFile.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpFile
        '
        Me.grpFile.Controls.Add(Me.btnSupport)
        Me.grpFile.Controls.Add(Me.btnSave)
        Me.grpFile.Controls.Add(Me.btnOpen)
        Me.grpFile.Controls.Add(Me.btnReturn)
        Me.grpFile.Controls.Add(Me.btnNewFile)
        Me.grpFile.Location = New System.Drawing.Point(1, 1)
        Me.grpFile.Name = "grpFile"
        Me.grpFile.Size = New System.Drawing.Size(223, 62)
        Me.grpFile.TabIndex = 0
        Me.grpFile.TabStop = False
        Me.grpFile.Text = "File"
        '
        'btnSupport
        '
        Me.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupport.Image = CType(resources.GetObject("btnSupport.Image"), System.Drawing.Image)
        Me.btnSupport.Location = New System.Drawing.Point(182, 20)
        Me.btnSupport.Name = "btnSupport"
        Me.btnSupport.Size = New System.Drawing.Size(35, 35)
        Me.btnSupport.TabIndex = 5
        Me.btnSupport.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(94, 20)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(35, 35)
        Me.btnSave.TabIndex = 4
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.Location = New System.Drawing.Point(50, 20)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(35, 35)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Image = CType(resources.GetObject("btnReturn.Image"), System.Drawing.Image)
        Me.btnReturn.Location = New System.Drawing.Point(138, 20)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(35, 35)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnNewFile
        '
        Me.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewFile.Image = CType(resources.GetObject("btnNewFile.Image"), System.Drawing.Image)
        Me.btnNewFile.Location = New System.Drawing.Point(6, 20)
        Me.btnNewFile.Name = "btnNewFile"
        Me.btnNewFile.Size = New System.Drawing.Size(35, 35)
        Me.btnNewFile.TabIndex = 1
        Me.btnNewFile.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(901, 964)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(920, 1045)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCreator"
        Me.Text = "Storyboard Creator - New"
        Me.grpFile.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpFile As GroupBox
    Friend WithEvents btnNewFile As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSupport As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
