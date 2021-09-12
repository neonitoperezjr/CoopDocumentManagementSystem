
Imports MySql.Data.MySqlClient

Public Class Settings

    ' Class name
    Private m_class_name As String = GetType(FileUpload).Name

    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        Dim folderBrowseDialog As New FolderBrowserDialog
        If folderBrowseDialog.ShowDialog() Then
            TxtboxRepo.Text = folderBrowseDialog.SelectedPath()
        End If

        ' Browse folder dialog cancelled
        If folderBrowseDialog.ShowDialog() = Windows.Forms.DialogResult.Cancel And
            repository_path.Length > 0 Then
            TxtboxRepo.Text = repository_path
        End If

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Timer1.Start()
        Label5.Visible = True
        Using conn As New MySqlConnection(ConnectionString)
            Try
                Dim cmd As New MySqlCommand(Constant.UPDATE_SETTING_REPO, conn)
                cmd.Parameters.Add(New MySqlParameter("@setting_value", TxtboxRepo.Text))
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                         errlog_path)
            End Try
        End Using
    End Sub

    Dim tmrCount As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tmrCount += 1
        If tmrCount = 5 Then
            Timer1.Stop()
            Label5.Visible = False
            tmrCount = 0
        End If
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If repository_path.Length > 0 Then
            TxtboxRepo.Text = repository_path
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class