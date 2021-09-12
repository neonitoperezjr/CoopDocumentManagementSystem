Public Class NoConnection

    Dim drag As Boolean
    Dim cursorX As Integer
    Dim cursorY As Integer

    Private Sub FormHandler_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles FormHandler.MouseDown
        drag = True
        cursorX = Windows.Forms.Cursor.Position.X - Me.Left
        cursorY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub FormHandler_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles FormHandler.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - cursorX
            Me.Top = Windows.Forms.Cursor.Position.Y - cursorY
        End If
    End Sub

    Private Sub FormHandler_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles FormHandler.MouseUp
        drag = False
    End Sub

    Sub initialize()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Private Sub Btn_OK_Click(sender As System.Object, e As System.EventArgs) Handles Btn_OK.Click
        Me.Close()
    End Sub
End Class