Imports MySql.Data.MySqlClient
Imports System.Reflection
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data.OleDb

Module Base

    Public Const _software_version = "v1.0.0"
    Public _software_title As String = "  Team Coop Document Management System " & _software_version
    Public _dir As String

    Public configuration() As String
    Public application_data_path As String = "C:\DocumentControl\SETUP\Config"
    Public configuration_path As String = "\config.ini"

    Sub DgvDoubleBuffered(ByVal Dgv As DataGridView)
        If Not System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Dim dgvType As Type = Dgv.GetType()
            Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            pi.SetValue(Dgv, True, Nothing)
        End If
    End Sub

    Private Delegate Sub ComboBoxInvoker(ByVal [combobox] As ComboBox, ByVal [item] As String)
    Sub delegate_item_add(ByVal [combobox] As ComboBox, ByVal [item] As String)
        If [combobox].InvokeRequired = True Then
            [combobox].Invoke(New ComboBoxInvoker(AddressOf delegate_item_add), [combobox], [item])
        Else
            [combobox].Items.Add([item])
        End If
    End Sub

    Private Delegate Sub DataGridViewInvoker(ByVal [datagridview] As DataGridView, ByVal [row] As DataGridViewRow)
    Sub delegate_row_add(ByVal [datagridview] As DataGridView, ByVal [row] As DataGridViewRow)
        If [datagridview].InvokeRequired Then
            [datagridview].Invoke(New DataGridViewInvoker(AddressOf delegate_row_add), [datagridview], [row])
        Else
            [datagridview].Rows.Add([row])
        End If
    End Sub

    Public Sub SetFocus(ByVal control As Control)
        ' Set focus to the control, if it can receive focus.
        If control.CanFocus Then
            control.Focus()
        Else
            control.Select()
        End If
    End Sub

    Public Sub get_outlook_attachment(ByVal email As Outlook.MailItem, ByVal my_dir As String, ByVal file_name As String)
        Dim attachmentInfo As StringBuilder = New StringBuilder()
        Dim mailAttachments As Outlook.Attachments = email.Attachments
        If Not IsNothing(mailAttachments) Then
            For i As Integer = 1 To mailAttachments.Count
                Dim currentAttachment As Outlook.Attachment = mailAttachments.Item(i)
                If file_name = currentAttachment.FileName Then
                    Dim str_file As String = System.IO.Path.Combine(my_dir, currentAttachment.FileName)
                    currentAttachment.SaveAsFile(str_file)
                End If
            Next
        End If
    End Sub

    Function outlook_path() As String
        Dim dir As String = configuration(0).ToString().Trim()
        Dim new_dir As String = ""
        Dim folder_name As String
        Dim batch_num_count As Integer = 0
        If auto_create_folder() Then
            folder_name = "Outlook-" & DateTime.Now.ToString("yy") & DateTime.Today.ToString("MM") & DateTime.Today.ToString("dd")
            MkDir(dir & "\" & new_dir & "\" & folder_name)
            _dir = dir & "\" & new_dir & "\" & folder_name
            Return dir & "\" & new_dir & "\" & folder_name
        Else
            _dir = dir & "\" & new_dir
            Return dir & "\" & new_dir
        End If
    End Function

    Function MkDir(ByVal dir As String) As String
        If (Not System.IO.Directory.Exists(dir)) Then
            System.IO.Directory.CreateDirectory(dir)
            Return dir
        Else
            Return dir
        End If
    End Function

    Function auto_create_folder() As Boolean
        Dim flag As Boolean
        If configuration(2) = "YES" Then
            flag = True
        ElseIf configuration(2) = "NO" Then
            flag = False
        End If
        Return flag
    End Function

    Function by_format() As String
        Return configuration(3).ToString().Trim()
    End Function

    Sub delete_dir(ByVal dir As String)
        My.Computer.FileSystem.DeleteDirectory(dir, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub

    Sub delete_this_file_from_dir(ByVal dir As String)
        Try
            My.Computer.FileSystem.DeleteFile(dir)
        Catch ex As Exception
        End Try
    End Sub

    Sub delete_all_files_from_dir(ByVal dir As String)
        If dir <> "" Then
            For Each this_file In Directory.GetFiles(dir, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(this_file)
            Next
        Else
            For Each this_file In Directory.GetFiles(outlook_path(), "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(this_file)
            Next
        End If
    End Sub

End Module
