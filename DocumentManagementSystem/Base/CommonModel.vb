Imports MySql.Data.MySqlClient

''' <summary>
''' 
''' <para>Author: Neonito Perez Jr.</para>
''' </summary>
''' <remarks></remarks>
Module CommonModel

    ' Module class name
    Private m_class_name As String = GetType(CommonModel).Name

    ''' <summary>
    ''' Populates sql info to a textbox and activate textbox auto suggest feature.
    ''' </summary>
    ''' <param name="txtbox"></param>
    ''' <param name="query"></param>
    ''' <remarks></remarks>
    Public Sub AutoSuggestTextBox(ByVal txtbox As System.Windows.Forms.TextBox, ByVal query As String)
        Using conn As New MySqlConnection(ConnectionString)
            Try
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
                da.Dispose()
                If dt.Rows.Count > 0 Then
                    Dim row As DataRow
                    txtbox.AutoCompleteCustomSource.Clear()
                    For Each row In dt.Rows
                        txtbox.AutoCompleteCustomSource.Add(row.Item(0).ToString)
                    Next
                    txtbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txtbox.AutoCompleteSource = AutoCompleteSource.CustomSource
                End If
            Catch ex As Exception
                MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                         errlog_path)
            End Try
        End Using
    End Sub

    ''' <summary>
    ''' Populates sql info to a textbox component.
    ''' </summary>
    ''' <param name="txtbox"></param>
    ''' <param name="query"></param>
    ''' <remarks></remarks>
    Sub LoadTextBox(ByVal txtbox As System.Windows.Forms.TextBox, ByVal query As String)
        Using conn As New MySqlConnection(ConnectionString)
            Try

                Dim txtbox_collection As New AutoCompleteStringCollection
                Dim dt As New DataTable()
                Dim da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
                da.Dispose()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        txtbox_collection.Add(dt.Rows(i)(0))
                    Next
                End If
                txtbox.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtbox.AutoCompleteCustomSource = txtbox_collection
                txtbox.AutoCompleteMode = AutoCompleteMode.Suggest
            Catch ex As Exception
                MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                         errlog_path)
            End Try
        End Using
    End Sub

    ''' <summary>
    ''' Populates sql info to a combobox component.
    ''' </summary>
    ''' <param name="cmb"></param>
    ''' <param name="query"></param>
    ''' <param name="async"></param>
    ''' <remarks></remarks>
    Sub LoadCmb(ByVal cmb As System.Windows.Forms.ComboBox, ByVal query As String, ByVal async As Boolean)
        Using conn As New MySqlConnection(ConnectionString)
            Try

                Dim dt As New DataTable()
                Dim da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
                da.Dispose()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        If async = True Then
                            delegate_item_add(cmb, dt.Rows(i)(0))
                        Else
                            cmb.Items.Add(dt.Rows(i)(0))
                        End If
                    Next
                End If

                If async = False Then
                    If cmb.Items.Count > 0 Then
                        If cmb.Text <> "" Then
                            cmb.Select(cmb.Text.Length, cmb.Text.Length)
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                         errlog_path)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ''' <summary>
    ''' Retrieves a string value from database.
    ''' </summary>
    ''' <param name="query"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetDBValue(ByVal query As String) As String
        Dim value As String = ""
        Using conn As New MySqlConnection(ConnectionString)
            Try
                Dim dt As New DataTable()
                Dim da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
                da.Dispose()
                If dt.Rows.Count > 0 Then
                    value = dt.Rows(0)(0)
                End If
            Catch ex As Exception
                MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                         errlog_path)
            Finally
                conn.Close()
            End Try
        End Using
        Return value
    End Function

    Public Function GetDBBlob(ByVal query As String) As Drawing.Image
        Dim iImage As Image = My.Resources._default
        Using conn As New MySqlConnection(ConnectionString)
            Try
                Dim cmd As New MySqlCommand(query)
                conn.Open()
                Dim pictureData As Byte() = DirectCast(cmd.ExecuteScalar, Byte())
                Using stream As New IO.MemoryStream(pictureData)
                    iImage = Image.FromStream(stream)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                         errlog_path)
            Finally
                conn.Close()
            End Try
        End Using
        Return iImage
    End Function

    Public Function GetDocuments(ByVal Dgv As System.Windows.Forms.DataGridView, ByVal query As String, ByVal async As Boolean) As Boolean
        Using conn As New MySqlConnection(ConnectionString)
            Try
                Dim dt As New DataTable()
                Dim da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
                da.Dispose()
                DocumentCount = dt.Rows.Count()
                If DocumentCount() > 0 Then
                    TotalPageCount = DocumentCount() / Constant.PAGE_COUNT
                    If TotalPageCount() = 0 Then
                        TotalPageCount = 1
                    End If
                    If async = True Then
                        For i As Integer = 0 To dt.Rows.Count() - 1
                            Dim row As New DataGridViewRow
                            row.Cells.Add(New DataGridViewTextBoxCell With {.Value = dt.Rows(i)(0)}) ' Document number
                            row.Cells.Add(New DataGridViewTextBoxCell With {.Value = dt.Rows(i)(1)}) ' Document name
                            row.Cells.Add(New DataGridViewTextBoxCell With {.Value = dt.Rows(i)(2)}) ' Document category
                            Try
                                row.Cells.Add(New DataGridViewTextBoxCell With {.Value = Convert.ToDateTime(dt.Rows(i)(3)).ToString("MM/dd/yyyy hh:mm:ss tt")}) ' upload date / inserted date
                            Catch ex As Exception
                                row.Cells.Add(New DataGridViewTextBoxCell With {.Value = ""}) ' upload date / inserted date
                            End Try
                            row.Cells.Add(New DataGridViewTextBoxCell With {.Value = dt.Rows(i)(4)}) ' upload by
                            row.Cells.Add(New DataGridViewTextBoxCell With {.Value = dt.Rows(i)(5)}) ' Revision number
                            Try
                                row.Cells.Add(New DataGridViewTextBoxCell With {.Value = Convert.ToDateTime(dt.Rows(i)(6)).ToString("MM/dd/yyyy hh:mm:ss tt")}) ' Changed Date 
                            Catch ex As Exception
                                row.Cells.Add(New DataGridViewTextBoxCell With {.Value = ""}) ' Changed Datetime
                            End Try
                            row.Cells.Add(New DataGridViewTextBoxCell With {.Value = dt.Rows(i)(7)}) ' Changed By
                            delegate_row_add(Dgv, row)
                        Next
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                         errlog_path)
            Finally
                conn.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function GetCategory(ByVal query As String) As Boolean
        Dim tt As Boolean = False
        Using conn As New MySqlConnection(ConnectionString)
            Try
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
                da.Dispose()
                If dt.Rows.Count > 0 Then
                    categoryDic.Clear()
                    For i As Integer = 0 To dt.Rows.Count - 1
                        categoryDic.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString())
                    Next
                    tt = True
                End If
            Catch ex As Exception
                MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                         errlog_path)
                conn.Close()
            End Try
        End Using
        Return tt
    End Function
End Module
