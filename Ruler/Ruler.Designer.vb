<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ruler
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ruler))
        Me.mnsSlide = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tipRuler = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnResize = New System.Windows.Forms.PictureBox
        Me.btnLock = New System.Windows.Forms.PictureBox
        Me.btnPin = New System.Windows.Forms.PictureBox
        Me.btnFlip = New System.Windows.Forms.PictureBox
        Me.btnVisible = New System.Windows.Forms.PictureBox
        Me.btnSlide = New System.Windows.Forms.PictureBox
        Me.btnClose = New System.Windows.Forms.PictureBox
        Me.btnErase = New System.Windows.Forms.PictureBox
        Me.lblTrack = New System.Windows.Forms.Label
        Me.mnuUnits = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.inToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tipPosition = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnsSlide.SuspendLayout()
        CType(Me.btnResize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFlip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnErase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuUnits.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsSlide
        '
        Me.mnsSlide.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopToolStripMenuItem, Me.LeftToolStripMenuItem, Me.BottomToolStripMenuItem, Me.RightToolStripMenuItem})
        Me.mnsSlide.Name = "mnsSlide"
        Me.mnsSlide.Size = New System.Drawing.Size(115, 92)
        '
        'TopToolStripMenuItem
        '
        Me.TopToolStripMenuItem.Image = Global.Ruler.My.Resources.Resources.angle_up
        Me.TopToolStripMenuItem.Name = "TopToolStripMenuItem"
        Me.TopToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.TopToolStripMenuItem.Text = "Top"
        '
        'LeftToolStripMenuItem
        '
        Me.LeftToolStripMenuItem.Image = Global.Ruler.My.Resources.Resources.angle_left
        Me.LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        Me.LeftToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.LeftToolStripMenuItem.Text = "Left"
        '
        'BottomToolStripMenuItem
        '
        Me.BottomToolStripMenuItem.Image = Global.Ruler.My.Resources.Resources.angle_down
        Me.BottomToolStripMenuItem.Name = "BottomToolStripMenuItem"
        Me.BottomToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BottomToolStripMenuItem.Text = "Bottom"
        '
        'RightToolStripMenuItem
        '
        Me.RightToolStripMenuItem.Image = Global.Ruler.My.Resources.Resources.angle_right
        Me.RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        Me.RightToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RightToolStripMenuItem.Text = "Right"
        '
        'btnResize
        '
        Me.btnResize.Image = Global.Ruler.My.Resources.Resources.arrows_h
        Me.btnResize.Location = New System.Drawing.Point(89, 1)
        Me.btnResize.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnResize.Name = "btnResize"
        Me.btnResize.Size = New System.Drawing.Size(16, 16)
        Me.btnResize.TabIndex = 7
        Me.btnResize.TabStop = False
        Me.tipRuler.SetToolTip(Me.btnResize, "Resize (click and drag)")
        '
        'btnLock
        '
        Me.btnLock.Image = Global.Ruler.My.Resources.Resources.unlock
        Me.btnLock.Location = New System.Drawing.Point(233, 1)
        Me.btnLock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(16, 16)
        Me.btnLock.TabIndex = 5
        Me.btnLock.TabStop = False
        Me.tipRuler.SetToolTip(Me.btnLock, "Lock ruler")
        '
        'btnPin
        '
        Me.btnPin.Image = Global.Ruler.My.Resources.Resources.pin_off
        Me.btnPin.Location = New System.Drawing.Point(256, 1)
        Me.btnPin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnPin.Name = "btnPin"
        Me.btnPin.Size = New System.Drawing.Size(16, 16)
        Me.btnPin.TabIndex = 4
        Me.btnPin.TabStop = False
        Me.tipRuler.SetToolTip(Me.btnPin, "Always on top")
        '
        'btnFlip
        '
        Me.btnFlip.Image = Global.Ruler.My.Resources.Resources.rotate_left
        Me.btnFlip.Location = New System.Drawing.Point(67, 1)
        Me.btnFlip.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(16, 16)
        Me.btnFlip.TabIndex = 6
        Me.btnFlip.TabStop = False
        Me.tipRuler.SetToolTip(Me.btnFlip, "Flip ruler")
        '
        'btnVisible
        '
        Me.btnVisible.Image = Global.Ruler.My.Resources.Resources.eye
        Me.btnVisible.Location = New System.Drawing.Point(277, 1)
        Me.btnVisible.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnVisible.Name = "btnVisible"
        Me.btnVisible.Size = New System.Drawing.Size(16, 16)
        Me.btnVisible.TabIndex = 2
        Me.btnVisible.TabStop = False
        Me.tipRuler.SetToolTip(Me.btnVisible, "Show/Hide the ruler")
        '
        'btnSlide
        '
        Me.btnSlide.Image = Global.Ruler.My.Resources.Resources.arrows
        Me.btnSlide.Location = New System.Drawing.Point(46, 1)
        Me.btnSlide.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSlide.Name = "btnSlide"
        Me.btnSlide.Size = New System.Drawing.Size(16, 16)
        Me.btnSlide.TabIndex = 3
        Me.btnSlide.TabStop = False
        Me.tipRuler.SetToolTip(Me.btnSlide, "Slide to corner")
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Ruler.My.Resources.Resources.remove
        Me.btnClose.Location = New System.Drawing.Point(299, 1)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(16, 16)
        Me.btnClose.TabIndex = 1
        Me.btnClose.TabStop = False
        Me.tipRuler.SetToolTip(Me.btnClose, "Exit")
        '
        'btnErase
        '
        Me.btnErase.Image = Global.Ruler.My.Resources.Resources.eraser
        Me.btnErase.Location = New System.Drawing.Point(209, 1)
        Me.btnErase.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(16, 16)
        Me.btnErase.TabIndex = 8
        Me.btnErase.TabStop = False
        Me.tipRuler.SetToolTip(Me.btnErase, "Erase marks")
        '
        'lblTrack
        '
        Me.lblTrack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTrack.BackColor = System.Drawing.Color.Transparent
        Me.lblTrack.Location = New System.Drawing.Point(0, 54)
        Me.lblTrack.Name = "lblTrack"
        Me.lblTrack.Size = New System.Drawing.Size(461, 24)
        Me.lblTrack.TabIndex = 0
        '
        'mnuUnits
        '
        Me.mnuUnits.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pxToolStripMenuItem, Me.cmToolStripMenuItem, Me.inToolStripMenuItem})
        Me.mnuUnits.Name = "mnsSlide"
        Me.mnuUnits.ShowCheckMargin = True
        Me.mnuUnits.ShowImageMargin = False
        Me.mnuUnits.Size = New System.Drawing.Size(92, 70)
        '
        'pxToolStripMenuItem
        '
        Me.pxToolStripMenuItem.Checked = True
        Me.pxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.pxToolStripMenuItem.Name = "pxToolStripMenuItem"
        Me.pxToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.pxToolStripMenuItem.Text = "px"
        '
        'cmToolStripMenuItem
        '
        Me.cmToolStripMenuItem.Name = "cmToolStripMenuItem"
        Me.cmToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.cmToolStripMenuItem.Text = "cm"
        '
        'inToolStripMenuItem
        '
        Me.inToolStripMenuItem.Name = "inToolStripMenuItem"
        Me.inToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.inToolStripMenuItem.Text = "in"
        '
        'tipPosition
        '
        Me.tipPosition.AutomaticDelay = 0
        Me.tipPosition.ShowAlways = True
        '
        'Ruler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(461, 78)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.lblTrack)
        Me.Controls.Add(Me.btnResize)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.btnPin)
        Me.Controls.Add(Me.btnFlip)
        Me.Controls.Add(Me.btnVisible)
        Me.Controls.Add(Me.btnSlide)
        Me.Controls.Add(Me.btnClose)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ruler"
        Me.mnsSlide.ResumeLayout(False)
        CType(Me.btnResize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFlip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnErase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuUnits.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents btnVisible As System.Windows.Forms.PictureBox
    Friend WithEvents btnSlide As System.Windows.Forms.PictureBox
    Friend WithEvents mnsSlide As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPin As System.Windows.Forms.PictureBox
    Friend WithEvents btnLock As System.Windows.Forms.PictureBox
    Friend WithEvents btnFlip As System.Windows.Forms.PictureBox
    Friend WithEvents btnResize As System.Windows.Forms.PictureBox
    Friend WithEvents tipRuler As System.Windows.Forms.ToolTip
    Friend WithEvents lblTrack As System.Windows.Forms.Label
    Friend WithEvents btnErase As System.Windows.Forms.PictureBox
    Friend WithEvents mnuUnits As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents pxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents inToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tipPosition As System.Windows.Forms.ToolTip

End Class
