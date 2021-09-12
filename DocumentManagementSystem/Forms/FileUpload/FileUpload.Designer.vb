<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileUpload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileUpload))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.panelDocumentInfo = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtboxDocumentNum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpUploadDate = New System.Windows.Forms.DateTimePicker()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmbDocumentCategory = New System.Windows.Forms.ComboBox()
        Me.txtboxUploadBy = New System.Windows.Forms.TextBox()
        Me.txtboxKeyword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbFileType = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxDocumentDesc = New System.Windows.Forms.TextBox()
        Me.txtboxDocumentName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Bgw1 = New System.ComponentModel.BackgroundWorker()
        Me.btnMultipleUpload = New System.Windows.Forms.Button()
        Me.panelDropItem = New System.Windows.Forms.Panel()
        Me.txtboxDocumentFile = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtboxRevisionNo = New System.Windows.Forms.TextBox()
        Me.panelDocumentInfo.SuspendLayout()
        CType(Me.pbFileType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDropItem.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelDocumentInfo
        '
        Me.panelDocumentInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelDocumentInfo.Controls.Add(Me.txtboxRevisionNo)
        Me.panelDocumentInfo.Controls.Add(Me.Label13)
        Me.panelDocumentInfo.Controls.Add(Me.Label10)
        Me.panelDocumentInfo.Controls.Add(Me.txtboxDocumentNum)
        Me.panelDocumentInfo.Controls.Add(Me.Label9)
        Me.panelDocumentInfo.Controls.Add(Me.Label12)
        Me.panelDocumentInfo.Controls.Add(Me.dtpUploadDate)
        Me.panelDocumentInfo.Controls.Add(Me.btnClose)
        Me.panelDocumentInfo.Controls.Add(Me.cmbDocumentCategory)
        Me.panelDocumentInfo.Controls.Add(Me.txtboxUploadBy)
        Me.panelDocumentInfo.Controls.Add(Me.txtboxKeyword)
        Me.panelDocumentInfo.Controls.Add(Me.Label4)
        Me.panelDocumentInfo.Controls.Add(Me.pbFileType)
        Me.panelDocumentInfo.Controls.Add(Me.Label3)
        Me.panelDocumentInfo.Controls.Add(Me.txtboxDocumentDesc)
        Me.panelDocumentInfo.Controls.Add(Me.txtboxDocumentName)
        Me.panelDocumentInfo.Controls.Add(Me.Label2)
        Me.panelDocumentInfo.Controls.Add(Me.Label1)
        Me.panelDocumentInfo.Controls.Add(Me.Label7)
        Me.panelDocumentInfo.Controls.Add(Me.Label5)
        Me.panelDocumentInfo.Location = New System.Drawing.Point(12, 14)
        Me.panelDocumentInfo.Name = "panelDocumentInfo"
        Me.panelDocumentInfo.Size = New System.Drawing.Size(902, 432)
        Me.panelDocumentInfo.TabIndex = 2
        Me.panelDocumentInfo.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(516, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 14)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "By:"
        '
        'txtboxDocumentNum
        '
        Me.txtboxDocumentNum.Location = New System.Drawing.Point(663, 131)
        Me.txtboxDocumentNum.Name = "txtboxDocumentNum"
        Me.txtboxDocumentNum.Size = New System.Drawing.Size(197, 22)
        Me.txtboxDocumentNum.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(529, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 14)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Document Number:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(120, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 14)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "By:"
        '
        'dtpUploadDate
        '
        Me.dtpUploadDate.Location = New System.Drawing.Point(152, 316)
        Me.dtpUploadDate.Name = "dtpUploadDate"
        Me.dtpUploadDate.Size = New System.Drawing.Size(358, 22)
        Me.dtpUploadDate.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.DocumentManagementSystem.My.Resources.Resources.rounded_close_btn
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(868, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 8
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cmbDocumentCategory
        '
        Me.cmbDocumentCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDocumentCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDocumentCategory.FormattingEnabled = True
        Me.cmbDocumentCategory.Location = New System.Drawing.Point(152, 254)
        Me.cmbDocumentCategory.Name = "cmbDocumentCategory"
        Me.cmbDocumentCategory.Size = New System.Drawing.Size(358, 22)
        Me.cmbDocumentCategory.TabIndex = 7
        '
        'txtboxUploadBy
        '
        Me.txtboxUploadBy.BackColor = System.Drawing.Color.White
        Me.txtboxUploadBy.Location = New System.Drawing.Point(152, 344)
        Me.txtboxUploadBy.Name = "txtboxUploadBy"
        Me.txtboxUploadBy.ReadOnly = True
        Me.txtboxUploadBy.Size = New System.Drawing.Size(358, 22)
        Me.txtboxUploadBy.TabIndex = 5
        '
        'txtboxKeyword
        '
        Me.txtboxKeyword.Location = New System.Drawing.Point(152, 282)
        Me.txtboxKeyword.Name = "txtboxKeyword"
        Me.txtboxKeyword.Size = New System.Drawing.Size(358, 22)
        Me.txtboxKeyword.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Category:"
        '
        'pbFileType
        '
        Me.pbFileType.Image = Global.DocumentManagementSystem.My.Resources.Resources.no_image_available
        Me.pbFileType.Location = New System.Drawing.Point(152, 42)
        Me.pbFileType.Name = "pbFileType"
        Me.pbFileType.Size = New System.Drawing.Size(95, 83)
        Me.pbFileType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFileType.TabIndex = 3
        Me.pbFileType.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Document :"
        '
        'txtboxDocumentDesc
        '
        Me.txtboxDocumentDesc.Location = New System.Drawing.Point(152, 161)
        Me.txtboxDocumentDesc.Multiline = True
        Me.txtboxDocumentDesc.Name = "txtboxDocumentDesc"
        Me.txtboxDocumentDesc.Size = New System.Drawing.Size(358, 86)
        Me.txtboxDocumentDesc.TabIndex = 1
        '
        'txtboxDocumentName
        '
        Me.txtboxDocumentName.Location = New System.Drawing.Point(152, 131)
        Me.txtboxDocumentName.Name = "txtboxDocumentName"
        Me.txtboxDocumentName.Size = New System.Drawing.Size(358, 22)
        Me.txtboxDocumentName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Document Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Upload:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Keyword:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(902, 7)
        Me.Label6.TabIndex = 6
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnUpload.FlatAppearance.BorderSize = 0
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(737, 455)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(86, 27)
        Me.btnUpload.TabIndex = 0
        Me.btnUpload.Text = "&UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = False
        Me.btnUpload.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(829, 455)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 27)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "&CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(16, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "FILES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(116, 465)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 14)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "No files uploaded"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Bgw1
        '
        '
        'btnMultipleUpload
        '
        Me.btnMultipleUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnMultipleUpload.FlatAppearance.BorderSize = 0
        Me.btnMultipleUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultipleUpload.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnMultipleUpload.ForeColor = System.Drawing.Color.White
        Me.btnMultipleUpload.Location = New System.Drawing.Point(737, 455)
        Me.btnMultipleUpload.Name = "btnMultipleUpload"
        Me.btnMultipleUpload.Size = New System.Drawing.Size(178, 27)
        Me.btnMultipleUpload.TabIndex = 9
        Me.btnMultipleUpload.Text = "Multiple File Upload"
        Me.btnMultipleUpload.UseVisualStyleBackColor = False
        Me.btnMultipleUpload.Visible = False
        '
        'panelDropItem
        '
        Me.panelDropItem.AllowDrop = True
        Me.panelDropItem.BackgroundImage = CType(resources.GetObject("panelDropItem.BackgroundImage"), System.Drawing.Image)
        Me.panelDropItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelDropItem.Controls.Add(Me.txtboxDocumentFile)
        Me.panelDropItem.Controls.Add(Me.btnBrowse)
        Me.panelDropItem.Location = New System.Drawing.Point(12, 14)
        Me.panelDropItem.Name = "panelDropItem"
        Me.panelDropItem.Size = New System.Drawing.Size(902, 432)
        Me.panelDropItem.TabIndex = 0
        '
        'txtboxDocumentFile
        '
        Me.txtboxDocumentFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtboxDocumentFile.Location = New System.Drawing.Point(152, 309)
        Me.txtboxDocumentFile.Name = "txtboxDocumentFile"
        Me.txtboxDocumentFile.Size = New System.Drawing.Size(644, 22)
        Me.txtboxDocumentFile.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBrowse.BackColor = System.Drawing.Color.Gray
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(425, 266)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(83, 29)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DocumentManagementSystem.My.Resources.Resources.folder_vec
        Me.PictureBox2.Location = New System.Drawing.Point(73, 455)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(540, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 14)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Revision Number:"
        '
        'txtboxRevisionNo
        '
        Me.txtboxRevisionNo.Location = New System.Drawing.Point(663, 161)
        Me.txtboxRevisionNo.Name = "txtboxRevisionNo"
        Me.txtboxRevisionNo.Size = New System.Drawing.Size(197, 22)
        Me.txtboxRevisionNo.TabIndex = 16
        '
        'FileUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(926, 498)
        Me.Controls.Add(Me.btnMultipleUpload)
        Me.Controls.Add(Me.panelDocumentInfo)
        Me.Controls.Add(Me.panelDropItem)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnUpload)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(942, 537)
        Me.Name = "FileUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Document"
        Me.panelDocumentInfo.ResumeLayout(False)
        Me.panelDocumentInfo.PerformLayout()
        CType(Me.pbFileType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDropItem.ResumeLayout(False)
        Me.panelDropItem.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelDropItem As System.Windows.Forms.Panel
    Friend WithEvents txtboxDocumentFile As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents panelDocumentInfo As System.Windows.Forms.Panel
    Friend WithEvents pbFileType As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtboxDocumentDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtboxDocumentName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbDocumentCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtboxUploadBy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpUploadDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtboxDocumentNum As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Bgw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtboxKeyword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnMultipleUpload As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtboxRevisionNo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
