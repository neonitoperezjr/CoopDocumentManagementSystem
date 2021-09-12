<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ContentPanel1 = New DocumentManagementSystem.DoubleBufferedPanel()
        Me.ContentPanel2 = New DocumentManagementSystem.DoubleBufferedPanel()
        Me.LblErrorMsg = New System.Windows.Forms.Label()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContentPanel3 = New DocumentManagementSystem.DoubleBufferedPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.TxtboxUsername = New System.Windows.Forms.TextBox()
        Me.TxtboxPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.FormHandler = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContentPanel1.SuspendLayout()
        Me.ContentPanel2.SuspendLayout()
        Me.ContentPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(704, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1, 616)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "  HCT WORK DAY"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, -6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1, 616)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "  HCT WORK DAY"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 598)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(708, 1)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "  HCT WORK DAY"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'ContentPanel1
        '
        Me.ContentPanel1.Controls.Add(Me.ContentPanel2)
        Me.ContentPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ContentPanel1.Name = "ContentPanel1"
        Me.ContentPanel1.Size = New System.Drawing.Size(705, 558)
        Me.ContentPanel1.TabIndex = 13
        '
        'ContentPanel2
        '
        Me.ContentPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ContentPanel2.Controls.Add(Me.LblErrorMsg)
        Me.ContentPanel2.Controls.Add(Me.BtnRegister)
        Me.ContentPanel2.Controls.Add(Me.Label2)
        Me.ContentPanel2.Controls.Add(Me.ContentPanel3)
        Me.ContentPanel2.Controls.Add(Me.Label1)
        Me.ContentPanel2.Controls.Add(Me.Label4)
        Me.ContentPanel2.Controls.Add(Me.BtnClose)
        Me.ContentPanel2.Controls.Add(Me.FormHandler)
        Me.ContentPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel2.Location = New System.Drawing.Point(0, 0)
        Me.ContentPanel2.Name = "ContentPanel2"
        Me.ContentPanel2.Size = New System.Drawing.Size(705, 558)
        Me.ContentPanel2.TabIndex = 12
        '
        'LblErrorMsg
        '
        Me.LblErrorMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LblErrorMsg.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblErrorMsg.ForeColor = System.Drawing.Color.White
        Me.LblErrorMsg.Location = New System.Drawing.Point(141, 446)
        Me.LblErrorMsg.Name = "LblErrorMsg"
        Me.LblErrorMsg.Size = New System.Drawing.Size(437, 40)
        Me.LblErrorMsg.TabIndex = 7
        Me.LblErrorMsg.Text = "  Username doesn't exist."
        Me.LblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblErrorMsg.Visible = False
        '
        'BtnRegister
        '
        Me.BtnRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRegister.FlatAppearance.BorderSize = 0
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.Color.White
        Me.BtnRegister.Location = New System.Drawing.Point(605, 36)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(87, 30)
        Me.BtnRegister.TabIndex = 16
        Me.BtnRegister.Text = "REGISTER"
        Me.BtnRegister.UseVisualStyleBackColor = False
        Me.BtnRegister.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-2, 555)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(709, 3)
        Me.Label2.TabIndex = 21
        '
        'ContentPanel3
        '
        Me.ContentPanel3.BackColor = System.Drawing.Color.White
        Me.ContentPanel3.Controls.Add(Me.Label13)
        Me.ContentPanel3.Controls.Add(Me.Label10)
        Me.ContentPanel3.Controls.Add(Me.Label11)
        Me.ContentPanel3.Controls.Add(Me.Label12)
        Me.ContentPanel3.Controls.Add(Me.Label9)
        Me.ContentPanel3.Controls.Add(Me.Label8)
        Me.ContentPanel3.Controls.Add(Me.LblUsername)
        Me.ContentPanel3.Controls.Add(Me.TxtboxUsername)
        Me.ContentPanel3.Controls.Add(Me.TxtboxPassword)
        Me.ContentPanel3.Controls.Add(Me.LblPassword)
        Me.ContentPanel3.Controls.Add(Me.BtnLogin)
        Me.ContentPanel3.Controls.Add(Me.Label3)
        Me.ContentPanel3.Location = New System.Drawing.Point(141, 135)
        Me.ContentPanel3.Name = "ContentPanel3"
        Me.ContentPanel3.Size = New System.Drawing.Size(437, 294)
        Me.ContentPanel3.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(-3, 293)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(440, 2)
        Me.Label13.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(0, -4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1, 299)
        Me.Label10.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(436, -1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 299)
        Me.Label11.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(438, 4)
        Me.Label12.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(17, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 14)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "LOGIN"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(0, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(6, 34)
        Me.Label8.TabIndex = 15
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.BackColor = System.Drawing.Color.White
        Me.LblUsername.Location = New System.Drawing.Point(75, 79)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(71, 14)
        Me.LblUsername.TabIndex = 2
        Me.LblUsername.Text = "Username"
        '
        'TxtboxUsername
        '
        Me.TxtboxUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtboxUsername.Location = New System.Drawing.Point(78, 103)
        Me.TxtboxUsername.Name = "TxtboxUsername"
        Me.TxtboxUsername.Size = New System.Drawing.Size(289, 27)
        Me.TxtboxUsername.TabIndex = 3
        '
        'TxtboxPassword
        '
        Me.TxtboxPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtboxPassword.Location = New System.Drawing.Point(78, 165)
        Me.TxtboxPassword.Name = "TxtboxPassword"
        Me.TxtboxPassword.Size = New System.Drawing.Size(289, 27)
        Me.TxtboxPassword.TabIndex = 5
        Me.TxtboxPassword.UseSystemPasswordChar = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.White
        Me.LblPassword.Location = New System.Drawing.Point(76, 141)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(69, 14)
        Me.LblPassword.TabIndex = 4
        Me.LblPassword.Text = "Password"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Gray
        Me.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(280, 199)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(87, 30)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(76, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 2)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "  Team Coop Document Management System"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-2, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(707, 226)
        Me.Label1.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(180, 529)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(366, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "All Rights Reserved 2018 | COOP Document Control Management"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(674, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(31, 30)
        Me.BtnClose.TabIndex = 18
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FormHandler
        '
        Me.FormHandler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormHandler.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.FormHandler.ForeColor = System.Drawing.Color.White
        Me.FormHandler.Location = New System.Drawing.Point(-2, 0)
        Me.FormHandler.Name = "FormHandler"
        Me.FormHandler.Size = New System.Drawing.Size(707, 30)
        Me.FormHandler.TabIndex = 15
        Me.FormHandler.Text = "  Team Coop Document Management System "
        Me.FormHandler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 558)
        Me.Controls.Add(Me.ContentPanel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContentPanel1.ResumeLayout(False)
        Me.ContentPanel2.ResumeLayout(False)
        Me.ContentPanel2.PerformLayout()
        Me.ContentPanel3.ResumeLayout(False)
        Me.ContentPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblErrorMsg As System.Windows.Forms.Label
    Friend WithEvents ContentPanel1 As DocumentManagementSystem.DoubleBufferedPanel
    Friend WithEvents ContentPanel2 As DocumentManagementSystem.DoubleBufferedPanel
    Friend WithEvents ContentPanel3 As DocumentManagementSystem.DoubleBufferedPanel
    Friend WithEvents BtnRegister As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents TxtboxUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtboxPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents FormHandler As System.Windows.Forms.Label

End Class
