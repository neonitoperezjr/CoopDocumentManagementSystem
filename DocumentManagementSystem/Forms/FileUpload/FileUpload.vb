
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.IO
Imports Microsoft.Office.Interop
Imports Office = Microsoft.Office.Core

''' <summary>
''' Allows user to upload file using bulk multiple file upload or single file upload.
''' <para>Author: Neonito Perez Jr.</para>
''' </summary>
''' <remarks></remarks>
Public Class FileUpload

    ' Class name
    Private m_class_name As String = GetType(FileUpload).Name

    ' Variables
    Dim bUploadFlg As Boolean
    Dim dcName As String = String.Empty
    Dim dcDesc As String = String.Empty
    Dim dcPath As String = String.Empty
    Dim dcNo As String = String.Empty
    Dim dcCategory As String = String.Empty
    Dim dcKeyWord As String = String.Empty
    Dim dcUploadDate As Date
    Dim dcUploadBy As String = String.Empty
    Dim dcRevisionNo As String = String.Empty

    Dim numOfFileUpload As Integer

    ''' <summary>
    ''' Sets input fields to a default state.
    ''' </summary>
    ''' <remarks></remarks>
    Sub cls()
        txtboxDocumentFile.Text = ""
        txtboxDocumentName.Text = ""
        txtboxDocumentNum.Text = ""
        txtboxDocumentDesc.Text = ""
        cmbDocumentCategory.Text = ""
        txtboxKeyword.Text = ""
        SetFocus(txtboxDocumentFile)
    End Sub

    Private Function ValidateFile() As Boolean
        Dim no_error As Boolean = True
        If no_error Then
            If txtboxDocumentName.Text.Trim() = "" Then
                ErrorProvider1.SetError(txtboxDocumentName, "Document name is empty")
                no_error = False
            Else
                ErrorProvider1.SetError(txtboxDocumentName, "")
                no_error = True
            End If
        End If
        If no_error Then
            If cmbDocumentCategory.Text = "" Then
                ErrorProvider1.SetError(cmbDocumentCategory, "Document Category is empty")
                no_error = False
            Else
                ErrorProvider1.SetError(cmbDocumentCategory, "")
                no_error = True
            End If
        End If
        If no_error Then

        End If
        Return no_error
    End Function

    Sub start_backgroundworker(ByVal csf As Integer)
        Select Case csf
            Case 1
                Bgw1.WorkerReportsProgress = True
                Bgw1.WorkerSupportsCancellation = True
                If Not Bgw1.IsBusy() Then
                    Bgw1.RunWorkerAsync()
                End If
        End Select
    End Sub

    ''' <summary>
    ''' Saves document information to database.
    ''' </summary>
    ''' <param name="dc_no">Document Name</param>
    ''' <param name="dc_name">Document Number</param>
    ''' <param name="dc_desc">Document Description</param>
    ''' <param name="dc_category">Document Category</param>
    ''' <param name="dc_keyword">Document Keyword</param>
    ''' <param name="dc_upload_date">Upload Date</param>
    ''' <param name="dc_upload_by">Upload By</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SaveFileInfo(ByVal dc_no As String, ByVal dc_name As String, ByVal dc_desc As String, ByVal dc_category As String, ByVal dc_keyword As String, ByVal dc_upload_date As Date, ByVal dc_upload_by As String,
                                  ByVal dc_revision_no As String) As Boolean
        Dim cmdStatus As Boolean = False
        Using conn As New MySqlConnection(ConnectionString)
            Try
                Dim cmd As New MySqlCommand(Constant.INSERT_DOCUMENT, conn)
                cmd.Parameters.Add(New MySqlParameter("@dc_no", dc_no))
                cmd.Parameters.Add(New MySqlParameter("@dc_name", dc_name))
                cmd.Parameters.Add(New MySqlParameter("@dc_desc", dc_desc))
                cmd.Parameters.Add(New MySqlParameter("@dc_category", dc_category))
                cmd.Parameters.Add(New MySqlParameter("@dc_keyword", dc_keyword))
                cmd.Parameters.Add(New MySqlParameter("@dc_upload_date", dc_upload_date.ToString("yyyy-MM-dd hh:mm:ss tt")))
                cmd.Parameters.Add(New MySqlParameter("@dc_upload_by", dc_upload_by))
                cmd.Parameters.Add(New MySqlParameter("@dc_revision_no", dc_revision_no))
                conn.Open()
                cmd.ExecuteNonQuery()
                cmdStatus = True
                bUploadFlg = True
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                         errlog_path)
                bUploadFlg = False
            Finally
                conn.Close()
            End Try
        End Using
        Return cmdStatus
    End Function

    Private Sub MoveFile(ByVal dir As String)
        Try
            If Not Directory.Exists(dir) Then
                MkDir(dir) ' creates a directory for specified path if doesn't exists
            End If

            bUploadFlg = True
        Catch ex As Exception
            bUploadFlg = False

        End Try
    End Sub

    Private Sub FileUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Sets input fields to a default state
        cls()
        ' Retrieve document categories
        For Each category In categoryDic
            cmbDocumentCategory.Items.Add(category.Value)
        Next
        dtpUploadDate.Value = DateTime.Now
        txtboxUploadBy.Text = fname & " " & lname
        ' Retrive number of file upload per day
        search_condition = " WHERE dc_upload_date LIKE '%" & DateTime.Now.ToString("yyyy-MM-dd") & "%'"
        numOfFileUpload = Integer.Parse(GetDBValue(Constant.GET_NUM_OF_UPLOAD_FILE & search_condition))
        Label11.Text = numOfFileUpload & " files uploaded."
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        panelDocumentInfo.Visible = False
        btnUpload.Visible = False
        btnCancel.Visible = False
        panelDropItem.Visible = True
        btnMultipleUpload.Visible = True
    End Sub

    Private Function GetFileTypeFromResource() As List(Of String)
        Dim fileTypeList As New List(Of String)
        Dim runTimeResourceSet As Object
        Dim dictEntry As DictionaryEntry

        runTimeResourceSet = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, False, True)
        For Each dictEntry In runTimeResourceSet
            If (dictEntry.Value.GetType() Is GetType(Icon)) Then
                fileTypeList.Add(dictEntry.Key)
            End If
        Next
        Return fileTypeList
    End Function

    ''' <summary>
    ''' Automatically set image to a PictureBox component.
    ''' </summary>
    ''' <param name="picbox"></param>
    ''' <param name="fileExtension"></param>
    ''' <remarks></remarks>
    Private Sub SetFileTypeImage(ByVal picbox As PictureBox, ByVal fileExtension As String)

        Dim fileImage As Image
        Dim fileTypeList As List(Of String) = GetFileTypeFromResource()
        Dim sExtension As String = String.Empty

        For Each item As String In fileTypeList
            If item.Contains(fileExtension) Then
                sExtension = item
            End If
        Next
        fileImage = CType(My.Resources.ResourceManager.GetObject(sExtension), Image)

        If IsNothing(fileImage) Then
            ' Set the picture box image property to default
            picbox.Image = My.Resources.no_image_available
        Else
            ' Get the object image from resource
            picbox.Image = fileImage
        End If

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim resp As DialogResult = OpenFileDialog1.ShowDialog()
        If resp = Windows.Forms.DialogResult.OK Then

            Dim file_path As String = OpenFileDialog1.FileName
            Dim file_name As String = String.Empty
            Dim content() As String
            Dim extension As String = String.Empty

            content = file_path.Split(New String() {"\"}, StringSplitOptions.None)
            file_name = content(content.Length() - 1)
            content = file_name.Split(New String() {"."}, StringSplitOptions.None)
            extension = content(content.Length() - 1)

            If file_path.Trim() <> "" Then
                panelDropItem.Visible = False
                panelDocumentInfo.BringToFront()
                panelDocumentInfo.Visible = True
                btnMultipleUpload.Visible = False
                txtboxDocumentName.Text = file_name

                ' Check if filename already exists in db.
                'If CheckDocumentName() Then
                ' Retrieve revision number
                'txtboxRevisionNo.Text = GetDBValue(Constant.GET_REVISION_NO)
                'End If

                SetFileTypeImage(pbFileType, extension)
                btnUpload.Visible = True
                btnCancel.Visible = True
            Else
                panelDropItem.BringToFront()
                panelDropItem.Visible = True
                btnUpload.Visible = False
                btnCancel.Visible = False
            End If
        End If
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        dcNo = txtboxDocumentNum.Text
        dcName = txtboxDocumentName.Text
        dcDesc = txtboxDocumentDesc.Text
        For Each category In categoryDic
            If category.Value.Equals(cmbDocumentCategory.Text) Then
                dcCategory = category.Key
            End If
        Next
        dcKeyWord = txtboxKeyword.Text
        dcUploadDate = dtpUploadDate.Value
        dcUploadBy = txtboxUploadBy.Text
        dcRevisionNo = txtboxRevisionNo.Text
        If ValidateFile() Then
            start_backgroundworker(1)
        End If
    End Sub

    Private Sub Bgw1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgw1.DoWork
        ' Save document information
        SaveFileInfo(dc_name:=dcName,
                     dc_no:=dcNo,
                     dc_desc:=dcDesc,
                     dc_category:=dcCategory,
                     dc_keyword:=dcKeyWord,
                     dc_upload_date:=dcUploadDate,
                     dc_upload_by:=dcUploadBy,
                     dc_revision_no:=dcRevisionNo)
        ' Save transaction event
        SaveLog(DateTime.Now, uuid, "Document: " & dcName & " is inserted to database.")
        ' Moves file to a directory
        'MoveFile(dir:="")
    End Sub

    Private Sub Bgw1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Bgw1.RunWorkerCompleted
        If bUploadFlg = True Then
            MessageBox.Show("File upload successfully", " Document Control", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Retrive number of file upload per day
            search_condition = " WHERE dc_upload_date LIKE '%" & DateTime.Now.ToString("yyyy-MM-dd") & "%'"
            numOfFileUpload = Integer.Parse(GetDBValue(Constant.GET_NUM_OF_UPLOAD_FILE & search_condition))
            Label11.Text = numOfFileUpload & " files uploaded."

            panelDocumentInfo.Visible = False
            btnUpload.Visible = False
            btnCancel.Visible = False
            panelDropItem.Visible = True
            btnMultipleUpload.Visible = True
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        panelDocumentInfo.Visible = False
        btnUpload.Visible = False
        btnCancel.Visible = False
        panelDropItem.Visible = True
        btnMultipleUpload.Visible = True
    End Sub

    Private Sub panelDropItem_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles panelDropItem.DragDrop
        Dim file_name As String = ""
        Dim file_path As String = ""
        Try
            If e.Data.GetDataPresent("FileGroupDescriptor") Then
                Try
                    'FROM OUTLOOK
                    Dim ol_app As New Outlook.Application
                    Dim ol_stream_reader As Stream = CType(e.Data.GetData("FileGroupDescriptor"), Stream)
                    Dim file_group_descriptor(512) As Byte
                    ol_stream_reader.Read(file_group_descriptor, 0, 512)
                    Dim file_sbuilder As System.Text.StringBuilder = New System.Text.StringBuilder("")
                    Dim i As Integer = 76
                    While Not (file_group_descriptor(i) = 0)
                        file_sbuilder.Append(Convert.ToChar(file_group_descriptor(i)))
                        System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
                    End While
                    ol_stream_reader.Close()
                    file_name = file_sbuilder.ToString()
                    If Not File.Exists(file_name) Then
                        For Each mail_item In ol_app.ActiveExplorer.Selection
                            get_outlook_attachment(mail_item, outlook_path, file_sbuilder.ToString())
                        Next
                    End If

                Catch ex As Exception

                End Try
            Else
                Try
                    'FROM DESKTOP
                    Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
                    Dim content() As String

                    For Each path_ In files
                        file_path &= path_
                        content = path_.Split(New String() {"\"}, StringSplitOptions.None)
                        file_name = content(content.Length - 1) ' file name drag in the panelDropItem component.
                    Next

                    If Trim(file_name) <> "" Then
                        panelDropItem.Visible = False
                        panelDocumentInfo.BringToFront()
                        panelDocumentInfo.Visible = True
                        txtboxDocumentName.Text = file_name

                        btnUpload.Visible = True
                        btnCancel.Visible = True
                    Else
                        panelDropItem.BringToFront()
                        panelDropItem.Visible = True
                        btnUpload.Visible = False
                        btnCancel.Visible = False
                    End If
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub panelDropItem_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles panelDropItem.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub txtboxDocumentFile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtboxDocumentFile.KeyDown

        Dim file_path As String = String.Empty
        Dim file_name As String = String.Empty

        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            If Clipboard.ContainsData("FileGroupDescriptor") Then
                ' Copy Paste file from outlook
            Else
                Try
                    Dim files() As String = Clipboard.GetData(DataFormats.FileDrop)
                    Dim content() As String

                    For Each path In files
                        content = path.Split(New String() {"\"}, StringSplitOptions.None)
                        file_name = content(content.Length - 1)
                    Next

                    For i As Integer = 0 To content.Length - 1
                        file_path = String.Join("\", content)
                    Next

                    If Trim(file_path) <> "" Then
                        panelDropItem.Visible = False
                        panelDocumentInfo.BringToFront()
                        panelDocumentInfo.Visible = True
                        btnUpload.Visible = True
                        btnCancel.Visible = True
                        btnMultipleUpload.Visible = False
                        txtboxDocumentName.Text = file_name
                    Else
                        panelDropItem.BringToFront()
                        panelDropItem.Visible = True
                        btnUpload.Visible = False
                        btnCancel.Visible = False
                        btnMultipleUpload.Visible = True
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnMultipleUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultipleUpload.Click

        Dim filePaths As New List(Of String)

        Using ofd As New OpenFileDialog()
            ofd.Multiselect = True
            ofd.Title = "Select files to upload"
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                For Each file As String In ofd.FileNames
                    filePaths.Add(System.IO.Path.GetFullPath(file))
                Next
            End If
        End Using

        ' Retrieve file path from open file dialog
        For Each filePath As String In filePaths
            ' add datagridview here
        Next
    End Sub
End Class