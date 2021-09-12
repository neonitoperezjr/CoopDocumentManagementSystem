
''' <summary>
''' Login form
''' <para>Author: Neonito Perez Jr.</para>
''' </summary>
''' <remarks></remarks>
Public Class Login

    ''' <summary>
    ''' Reset form input fields
    ''' </summary>
    ''' <remarks></remarks>
    Sub initialize()
        TxtboxUsername.Text = ""
        SetFocus(TxtboxUsername)
        TxtboxPassword.Text = ""
        LblErrorMsg.Visible = False
    End Sub

    Function ValidateUID() As Boolean
        Dim no_error As Boolean = True
        If no_error Then
            If TxtboxUsername.Text = "" Then
                SetFocus(TxtboxUsername)
                LblErrorMsg.Text = "Please provide Username."
                LblErrorMsg.BackColor = Color.FromArgb(244, 67, 54)
                LblErrorMsg.Visible = True
                no_error = False
            Else
                LblErrorMsg.Visible = False
                no_error = True
            End If
        End If
        If no_error Then
            uuid = GetDBValue(Constant.GET_USERNAME & " WHERE uid = '" & TxtboxUsername.Text & "'")
            If uuid.Equals("") Then
                SetFocus(TxtboxUsername)
                LblErrorMsg.Text = "Username does not exist."
                LblErrorMsg.BackColor = Color.FromArgb(244, 67, 54)
                LblErrorMsg.Visible = True
                no_error = False
            Else
                LblErrorMsg.Visible = False
                no_error = True
            End If
        End If
        Return no_error
    End Function

    Function ValidatePW() As Boolean
        Dim no_error As Boolean = True
        If no_error Then
            If TxtboxPassword.Text = "" Then
                SetFocus(TxtboxPassword)
                LblErrorMsg.Text = "Please provide Password."
                LblErrorMsg.BackColor = Color.FromArgb(244, 67, 54)
                LblErrorMsg.Visible = True
                no_error = False
            Else
                LblErrorMsg.Visible = False
                no_error = True
            End If
        End If
        If no_error Then
            upwd = GetDBValue(Constant.GET_PASSWORD & " WHERE uid ='" & TxtboxUsername.Text & "' AND pword ='" & TxtboxPassword.Text & "'")
            If upwd.Equals("") Then
                SetFocus(TxtboxPassword)
                LblErrorMsg.Text = "Password is incorrect."
                LblErrorMsg.BackColor = Color.FromArgb(244, 67, 54)
                LblErrorMsg.Visible = True
                no_error = False
            Else
                LblErrorMsg.Visible = False
                no_error = True
            End If
        End If
        Return no_error
    End Function

    Function Authenticate() As Boolean
        Dim auth As Boolean = False
        If ValidateUID() = True Then
            If ValidatePW() = True Then
                auth = True
            End If
        End If
        Return auth
    End Function

    ''' <summary>
    ''' Form Border Shadow
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub FormHandler_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FormHandler.MouseDown
        drag = True
        cursorX = Windows.Forms.Cursor.Position.X - Me.Left
        cursorY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub FormHandler_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FormHandler.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - cursorY
            Me.Left = Windows.Forms.Cursor.Position.X - cursorX
        End If
    End Sub

    Private Sub FormHandler_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FormHandler.MouseUp
        drag = False
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FormHandler.Text = _software_title
        initialize()
        FileManager.ReadAppConfig()
        ConnectionString = "server=" & server & ";user id=" & db_uid & ";password=" & db_pword & ";database=" & DB & charset_utf8
    End Sub

    Private Sub Login_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtboxUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtboxUsername.TextChanged
        TxtboxPassword.Text = ""
        ErrorProvider.Clear()
        LblErrorMsg.Visible = False
    End Sub

    Private Sub TxtboxUsername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtboxUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidateUID().Equals(True) Then
                SetFocus(TxtboxPassword)
            End If
        End If
    End Sub

    Private Sub TxtboxPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtboxPassword.TextChanged
        ErrorProvider.SetError(TxtboxPassword, "")
        LblErrorMsg.Visible = False
    End Sub

    Private Sub TxtboxPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtboxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Authenticate.Equals(True) Then
                Me.Hide()
                Me.Visible = False
                Me.Opacity = 0
                'SaveLog(DateTime.Now, TxtboxUsername.Text, "Logged in")
                If Not Application.OpenForms().OfType(Of Dashboard).Any Then
                    Dashboard.Show()
                    Dashboard.Activate()
                    Dashboard.BringToFront()
                Else
                    Dashboard.Activate()
                    Dashboard.BringToFront()
                End If
            End If
        End If
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If Authenticate.Equals(True) Then
            Me.Hide()
            Me.Visible = False
            Me.Opacity = 0
            'SaveLog(DateTime.Now, TxtboxUsername.Text, "Logged in")
            If Not Application.OpenForms().OfType(Of Dashboard).Any Then
                Dashboard.Show()
                Dashboard.Activate()
                Dashboard.BringToFront()
            Else
                Dashboard.Activate()
                Dashboard.BringToFront()
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
