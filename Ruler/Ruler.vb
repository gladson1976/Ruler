Imports System.Runtime.InteropServices

Public Class Ruler
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2
    Public Const DPI_RATIO As Double = 21.7
    Public isVisible As Boolean = True
    Public isPinned As Boolean = False
    Public isLocked As Boolean = False
    Public isFlipped As Boolean = False
    Public isDrag As Boolean = False
    Public dpIX As Double, dpIY As Double
    Public dpMMX As Double, dpMMY As Double
    Public graph As Graphics
    Private handCursor As Cursor = Cursors.Hand
    Private oldXY As Point = Point.Empty
    Private savedWidth As Integer = 600, savedHeight As Integer = 600
    Public trackCursor As System.IO.MemoryStream

    <DllImport("User32")> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("User32")> Private Shared Function LockWindowUpdate(ByVal hWndLock As IntPtr) As Boolean
    End Function

    Private Sub LockWindow()
        If Not isLocked = True Then
            isLocked = True
            LockWindowUpdate(Me.Handle)
        End If
    End Sub

    Private Sub UnlockWindow()
        If isLocked = True Then
            isLocked = False
            LockWindowUpdate(IntPtr.Zero)
        End If
        Me.Refresh()
    End Sub

    Public Sub positionIcons()
        'If Not isDrag Then
        If Not isFlipped = True Then
            btnClose.Top = 2
            btnClose.Left = Me.Width - 22
            btnVisible.Top = 2
            btnVisible.Left = Me.Width - 44
            btnPin.Top = 2
            btnPin.Left = Me.Width - 66
            btnLock.Top = 2
            btnLock.Left = Me.Width - 88
            btnErase.Top = 2
            btnErase.Left = Me.Width - 110

            'btnResize.Top = 2
            'btnResize.Left = Me.Width - 120
            'btnFlip.Top = 2
            'btnFlip.Left = Me.Width - 142
            'btnSlide.Top = 2
            'btnSlide.Left = Me.Width - 164

            btnResize.Top = 2
            btnResize.Left = 44
            btnFlip.Top = 2
            btnFlip.Left = 22
            btnSlide.Top = 2
            btnSlide.Left = 2
        Else
            btnClose.Top = 2
            btnClose.Left = 2
            btnVisible.Top = 22
            btnVisible.Left = 2
            btnPin.Top = 44
            btnPin.Left = 2
            btnLock.Top = 66
            btnLock.Left = 2
            btnErase.Top = 66
            btnErase.Left = 2

            'btnResize.Top = 98
            'btnResize.Left = 2
            'btnFlip.Top = 120
            'btnFlip.Left = 2
            'btnSlide.Top = 142
            'btnSlide.Left = 2

            btnResize.Top = Me.Height - 66
            btnResize.Left = 2
            btnFlip.Top = Me.Height - 44
            btnFlip.Left = 2
            btnSlide.Top = Me.Height - 22
            btnSlide.Left = 2
        End If
        'End If
    End Sub

    Public Sub setDPI(ByVal inGraph As Graphics)
        dpMMX = inGraph.DpiX() / DPI_RATIO
        dpMMY = inGraph.DpiY() / DPI_RATIO
        dpIX = inGraph.DpiX
        dpIY = inGraph.DpiY
    End Sub

    Private Sub Ruler_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                If Me.Left > 0 Then Me.Left = Me.Left - 1
            Case Keys.Right
                Me.Left = Me.Left + 1
            Case Keys.Up
                If Me.Top > 0 Then Me.Top = Me.Top - 1
            Case Keys.Down
                Me.Top = Me.Top + 1
            Case Else
        End Select
    End Sub

    Private Sub Ruler_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        trackCursor = New System.IO.MemoryStream(My.Resources.cur_vert)
        graph = Me.CreateGraphics()
        setDPI(graph)

        tipRuler.SetToolTip(btnPin, "Pin ruler")
        tipRuler.SetToolTip(btnLock, "Lock ruler")
        tipRuler.SetToolTip(btnVisible, "Transparent ruler")

        lblTrack.Cursor = New Cursor(trackCursor)
    End Sub

    Private Sub Ruler_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If (e.Button = MouseButtons.Left And Not isLocked = True) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Ruler_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'If Not isDrag = True Then positionIcons()
        positionIcons()
    End Sub

    Private Sub btnVisible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisible.Click
        If isVisible = True Then
            isVisible = False
            Me.Opacity = 0.5
            btnVisible.Image = My.Resources.eye_slash
            tipRuler.SetToolTip(btnVisible, "Opaque ruler")
        Else
            isVisible = True
            Me.Opacity = 1
            btnVisible.Image = My.Resources.eye
            tipRuler.SetToolTip(btnVisible, "Transparent ruler")
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnSlide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlide.Click
        mnsSlide.Visible = True
        mnsSlide.Left = Me.Location.X + btnSlide.Left + btnSlide.Width + 2
        mnsSlide.Top = Me.Location.Y + btnSlide.Top + 2
    End Sub

    Private Sub TopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopToolStripMenuItem.Click
        Me.Top = 0
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        Me.Left = My.Computer.Screen.Bounds.Width - Me.Width
    End Sub

    Private Sub BottomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomToolStripMenuItem.Click
        Me.Top = My.Computer.Screen.Bounds.Height - Me.Height
    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        Me.Left = 0
    End Sub

    Private Sub btnPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin.Click
        isPinned = Not isPinned
        If isPinned = True Then
            btnPin.Image = My.Resources.pin_on
            Me.TopMost = True
            tipRuler.SetToolTip(btnPin, "Unpin ruler")
        Else
            btnPin.Image = My.Resources.pin_off
            Me.TopMost = False
            tipRuler.SetToolTip(btnPin, "Pin ruler")
        End If
    End Sub

    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
        isLocked = Not isLocked
        If isLocked = True Then
            btnLock.Image = My.Resources.lock
            tipRuler.SetToolTip(btnLock, "Unlock ruler")
        Else
            btnLock.Image = My.Resources.unlock
            tipRuler.SetToolTip(btnLock, "Lock ruler")
        End If
    End Sub

    Private Sub btnFlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlip.Click
        Dim tempLength As Integer = 0
        isFlipped = Not isFlipped
        If isFlipped = True Then
            savedWidth = Me.Width
            btnFlip.Image = My.Resources.rotate_right
            btnResize.Image = My.Resources.arrows_v
            'Me.Height = Me.Width
            Me.Height = savedHeight
            Me.Width = 80
            lblTrack.Height = savedHeight
            lblTrack.Width = 24
            lblTrack.Top = 0
            lblTrack.Left = 56
            trackCursor = New System.IO.MemoryStream(My.Resources.cur_horiz)
            lblTrack.Cursor = New Cursor(trackCursor)
        Else
            savedHeight = Me.Height
            btnFlip.Image = My.Resources.rotate_left
            btnResize.Image = My.Resources.arrows_h
            Me.Width = savedWidth
            Me.Height = 80
            lblTrack.Height = 24
            lblTrack.Width = savedWidth
            lblTrack.Top = 56
            lblTrack.Left = 0
            trackCursor = New System.IO.MemoryStream(My.Resources.cur_vert)
            lblTrack.Cursor = New Cursor(trackCursor)
        End If
        MyBase.Refresh()
    End Sub

    Private Sub btnResize_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnResize.MouseDown
        'oldXY = Cursor.Position
        isDrag = True
        If Not isFlipped = True Then
            Me.Cursor = Cursors.SizeWE
        Else
            Me.Cursor = Cursors.SizeNS
        End If
        'LockWindow()
    End Sub

    Private Sub btnResize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnResize.MouseLeave
        isDrag = False
        oldXY = Point.Empty
        Me.Cursor = handCursor
        If isFlipped = True Then
            lblTrack.Height = Me.Height
            lblTrack.Width = 24
            lblTrack.Top = 0
            lblTrack.Left = 56
        Else
            lblTrack.Height = 24
            lblTrack.Width = Me.Width
            lblTrack.Top = 56
            lblTrack.Left = 0
        End If
        'UnlockWindow()
        positionIcons()
    End Sub

    Private Sub btnResize_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnResize.MouseMove
        Dim deltaMove As Integer = 0

        If oldXY = Point.Empty Then
            oldXY = e.Location
        End If
        If isDrag Then
            If Not isFlipped = True Then
                deltaMove = Math.Abs(oldXY.X - e.X)
                If e.X < oldXY.X Then
                    If Me.Width - deltaMove > 250 Then Me.Width = Me.Width - deltaMove
                ElseIf e.X > oldXY.X Then
                    Me.Width = Me.Width + deltaMove
                End If
                oldXY = e.Location
            Else
                deltaMove = Math.Abs(oldXY.Y - e.Y)
                If e.Y < oldXY.Y Then
                    If Me.Height - deltaMove > 250 Then Me.Height = Me.Height - deltaMove
                ElseIf e.Y > oldXY.Y Then
                    Me.Height = Me.Height + deltaMove
                End If
                oldXY = e.Location
            End If
        End If
    End Sub

    Private Sub Ruler_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim scaleNum As String
        Dim countVal As Integer = 1
        Dim beginVal As Double = 0
        Dim incrementVal As Double

        graph = e.Graphics
        graph.ScaleTransform(1, 1)
        'setDPI(graph)
        'dpMMX = graph.DpiX / 25.4F
        'dpMMY = graph.DpiY / 25.4F
        'dpIX = graph.DpiX
        'dpIY = graph.DpiY
        If isFlipped = True Then
            'incrementVal = Math.Ceiling(dpMMY)
            incrementVal = dpMMY
            beginVal = dpMMY
            Do While (beginVal < MyBase.Height)
                If ((countVal Mod 10) = 0) Then
                    scaleNum = (countVal / 10).ToString()
                    graph.DrawLine(Pens.Black, New Point(MyBase.Width - 5, beginVal), New Point(MyBase.Width - 22, beginVal))
                    graph.DrawString(scaleNum, New Font("Arial", 8.0!), Brushes.Black, New Point(MyBase.Width - 25, beginVal))
                ElseIf ((countVal Mod 5) = 0) Then
                    graph.DrawLine(Pens.Black, New Point(MyBase.Width - 5, beginVal), New Point(MyBase.Width - 16, beginVal))
                Else
                    graph.DrawLine(Pens.Black, New Point(MyBase.Width - 5, beginVal), New Point(MyBase.Width - 10, beginVal))
                End If
                countVal += 1
                beginVal = (beginVal + incrementVal)
            Loop
        Else
            'incrementVal = Math.Ceiling(dpMMX)
            incrementVal = dpMMX
            beginVal = dpMMX
            Do While (beginVal < MyBase.Width)
                If ((countVal Mod 10) = 0) Then
                    scaleNum = (countVal / 10).ToString()
                    graph.DrawLine(Pens.Black, New Point(beginVal, MyBase.Height - 5), New Point(beginVal, MyBase.Height - 22))
                    graph.DrawString(scaleNum, New Font("Arial", 8.0!), Brushes.Black, New Point(beginVal, MyBase.Height - 25))
                ElseIf ((countVal Mod 5) = 0) Then
                    graph.DrawLine(Pens.Black, New Point(beginVal, MyBase.Height - 5), New Point(beginVal, MyBase.Height - 16))
                Else
                    graph.DrawLine(Pens.Black, New Point(beginVal, MyBase.Height - 5), New Point(beginVal, MyBase.Height - 10))
                End If
                countVal += 1
                beginVal = (beginVal + incrementVal)
            Loop
        End If
    End Sub

    Private Sub lblTrack_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTrack.MouseDown
        Dim trackHandle = lblTrack.CreateGraphics()
        If isFlipped = True Then
            trackHandle.DrawLine(Pens.Red, New Point(4, e.Y), New Point(lblTrack.Width - 2, e.Y))
        Else
            trackHandle.DrawLine(Pens.Red, New Point(e.X, 4), New Point(e.X, lblTrack.Height - 2))
        End If
    End Sub

    Private Sub btnErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErase.Click
        Dim trackHandle = lblTrack.CreateGraphics()
        trackHandle.Clear(Color.Transparent)
        Me.Refresh()
    End Sub

    Private Sub btnResize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResize.Click

    End Sub

    Private Sub pxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pxToolStripMenuItem.Click
        pxToolStripMenuItem.Checked = True
        cmToolStripMenuItem.Checked = False
        inToolStripMenuItem.Checked = False
    End Sub

    Private Sub cmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmToolStripMenuItem.Click
        pxToolStripMenuItem.Checked = False
        cmToolStripMenuItem.Checked = True
        inToolStripMenuItem.Checked = False
    End Sub

    Private Sub inToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inToolStripMenuItem.Click
        pxToolStripMenuItem.Checked = False
        cmToolStripMenuItem.Checked = False
        inToolStripMenuItem.Checked = True
    End Sub

    Private Sub lblTrack_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTrack.MouseMove
        If isFlipped = True Then
            tipPosition.SetToolTip(lblTrack, e.Y)
        Else
            tipPosition.SetToolTip(lblTrack, e.X)
        End If
    End Sub

    Private Sub lblTrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTrack.Click

    End Sub
End Class
