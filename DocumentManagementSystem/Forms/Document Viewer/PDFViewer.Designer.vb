<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDFViewer
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
        Me.ContentPanel1 = New DocumentManagementSystem.DoubleBufferedPanel()
        Me.SuspendLayout()
        '
        'ContentPanel1
        '
        Me.ContentPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ContentPanel1.Name = "ContentPanel1"
        Me.ContentPanel1.Size = New System.Drawing.Size(1053, 492)
        Me.ContentPanel1.TabIndex = 0
        '
        'PDFViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 492)
        Me.Controls.Add(Me.ContentPanel1)
        Me.Name = "PDFViewer"
        Me.Text = "PDFViewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContentPanel1 As DocumentManagementSystem.DoubleBufferedPanel
End Class
