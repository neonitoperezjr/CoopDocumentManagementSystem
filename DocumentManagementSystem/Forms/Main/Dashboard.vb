
Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private row_index As Integer

    Sub cls()
        DocumentInformation.Visible = False
        ContentPanel4.Size = New Size(1063, 616)
        Dgv1.Rows.Clear()
    End Sub

    Private Sub Dashboard_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        OpenDocumentDetail()
        LblDocumentNo.Text = Dgv1.Rows(row_index).Cells(0).Value
        LblFilename.Text = Dgv1.Rows(row_index).Cells(1).Value
        lblFileType.Text = ""
        lblFileLocation.Text = ""
        lblFileSize.Text = ""
        lblUploadBy.Text = ""
        lblUploadDate.Text = ""
        lblModifiedDate.Text = ""
        lblAccessedDate.Text = ""
        cbReadOnly.Checked = True
        cbLock.Checked = False
    End Sub

    Private Sub Dashboard_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        Me.Text = _software_title
        search_condition = " WHERE uid = '" & uuid & "' AND pword = '" & upwd & "'"
        fname = GetDBValue(Constant.GET_FNAME & search_condition)
        lname = GetDBValue(Constant.GET_LNAME & search_condition)
        repository_path = GetDBValue(Constant.GET_REPOSITORY_PATH)
        Label5.Text = fname & " " & lname
        CloseDocumentDetail()
        DgvDoubleBuffered(Dgv1)
        If Bgw1.IsBusy() = False Then
            Bgw1.WorkerSupportsCancellation = True
            Bgw1.WorkerReportsProgress = True
            Bgw1.RunWorkerAsync()
        End If
    End Sub

    Private Sub Dashboard_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim resp As DialogResult
        resp = MessageBox.Show("Do you want to logout?", " Document Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            Login.Visible = True
            Login.Opacity = 1
            Login.Show()
            Login.Activate()
            Login.BringToFront()
            'SaveLog(DateTime.Now, uuid, "Logged out")
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnFileUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileUpload.Click
        If Not Application.OpenForms().OfType(Of FileUpload).Any Then
            FileUpload.Show()
            FileUpload.Activate()
            FileUpload.BringToFront()
        Else
            FileUpload.Activate()
            FileUpload.BringToFront()
        End If
    End Sub

    Private Sub Dgv1_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv1.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                If Dgv1.Rows.Count > 0 Then
                    Dgv1.Rows(e.RowIndex).Selected = True
                    row_index = e.RowIndex
                    Dgv1.CurrentCell = Dgv1.Rows(e.RowIndex).Cells(1)
                    Cms1.Show(Dgv1, e.Location)
                    Cms1.Show(Cursor.Position)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If Not Application.OpenForms().OfType(Of FileUpload).Any Then
            FileUpload.Show()
            FileUpload.Activate()
            FileUpload.BringToFront()
        Else
            FileUpload.Activate()
            FileUpload.BringToFront()
        End If
    End Sub

    ''' <summary>
    ''' First load backgroundworker
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Bgw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgw1.DoWork
        Dim condition As String = " LIMIT 50 OFFSET o"
        GetCategory(Constant.GET_DOCUMENT_CATEGORY)
        GetDocuments(Dgv1, Constant.GET_DOCUMENTS, True)
    End Sub

    Private Sub Bgw1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Bgw1.RunWorkerCompleted
        PageNo = 1
        lblPageInfo.Text = "Page " & PageNo() & " of " & TotalPageCount()
        btnPrevious.Enabled = False
        btnNext.Enabled = False
    End Sub

    Private selectedNode As String

    ''' <summary>
    ''' Tree node selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        selectedNode = e.Node.Text
        CloseDocumentDetail()
        Dgv1.Rows.Clear()
        DgvDoubleBuffered(Dgv1)
        If Bgw2.IsBusy() = False Then
            Bgw2.WorkerSupportsCancellation = True
            Bgw2.WorkerReportsProgress = True
            Bgw2.RunWorkerAsync()
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Bgw2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgw2.DoWork
        Dim condition As String = String.Empty
        If selectedNode <> "All" Then
            For Each category In categoryDic
                If category.Value.Equals(selectedNode) Then
                    selectedNode = category.Key
                End If
            Next
            condition = " WHERE `dc_category` = '" & selectedNode & "' LIMIT 50 OFFSET 0"
        End If
        GetDocuments(Dgv1, Constant.GET_DOCUMENTS & condition, True)
    End Sub

    Private Sub Bgw2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Bgw2.RunWorkerCompleted

        If DocumentCount() > 0 Then
            LblDgv1Message.Visible = False
        Else
            LblDgv1Message.Text = "No document found"
            LblDgv1Message.Visible = True
        End If

        PageNo = 1
        lblPageInfo.Text = "Page " & PageNo() & " of " & TotalPageCount()
        btnPrevious.Enabled = False
        btnNext.Enabled = False


    End Sub

    ''' <summary>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OpenDocumentDetail()
        ContentPanel4.Size = New Size(1083, 270)
        Dgv1.Size = New Size(1083, 250)
        btnPrevious.Location = New Point(282, 278)
        btnNext.Location = New Point(360, 278)
        lblPageInfo.Location = New Point(1270, 282)
        DocumentInformation.Visible = True
    End Sub

    ''' <summary>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CloseDocumentDetail()
        ContentPanel4.Size = New Size(1083, 630)
        Dgv1.Size = New Size(1083, 530)
        TreeView1.Size = New Size(260, 555)
        btnPrevious.Location = New Point(282, 585)
        btnNext.Location = New Point(360, 585)
        lblPageInfo.Location = New Point(1270, 590)
        DocumentInformation.Visible = False
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenDocumentDetail()
    End Sub

    Private Sub LockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockToolStripMenuItem.Click

    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub TxtboxSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtboxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Search document name or document number
            For Each category In categoryDic
                If category.Value.Equals(TxtboxSearch.Text) Then
                    Dim condition As String
                    condition = " WHERE dc_category = '" & category.Key & "'"
                    GetDocuments(Dgv1, Constant.GET_DOCUMENTS & condition, True)
                Else
                    ' Not found
                End If
            Next
        End If
    End Sub

    Private Sub Bgw3_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgw3.DoWork
        Dim condition As String = ""
        condition = " WHERE dc_name = '" & TxtboxSearch.Text & "' OR dc_no = '" & TxtboxSearch.Text & "' LIMIT 50 OFFSET 0"
        GetDocuments(Dgv1, Constant.GET_DOCUMENTS & condition, True)
    End Sub


    Private Sub Bgw3_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Bgw3.RunWorkerCompleted

    End Sub

    
    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub

    Private Sub TreeView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.Click
        Console.WriteLine("Clicked")
    End Sub

    Private Sub BtnCloseDocDtl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CloseDocumentDetail()
    End Sub

    Private Sub Dgv1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv1.CellDoubleClick
        OpenDocumentDetail()
        Console.WriteLine("row_index value: " & row_index)
        LblDocumentNo.Text = Dgv1.Rows(row_index).Cells(0).Value
        LblFilename.Text = Dgv1.Rows(row_index).Cells(1).Value
        lblFileType.Text = Dgv1.Rows(row_index).Cells(2).Value
        lblFileLocation.Text = Dgv1.Rows(row_index).Cells(3).Value
        lblFileSize.Text = Dgv1.Rows(row_index).Cells(4).Value
        lblUploadBy.Text = Dgv1.Rows(row_index).Cells(5).Value
        lblUploadDate.Text = Dgv1.Rows(row_index).Cells(6).Value
        lblModifiedDate.Text = ""
        lblAccessedDate.Text = ""
        cbReadOnly.Checked = True
        cbLock.Checked = False
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        CloseDocumentDetail()
    End Sub
End Class