Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports MySql.Data
Imports MySql.Data.MySqlClient

Module Logger

    Private m_class_name As String = GetType(Logger).Name

    ''' <summary>
    ''' Writes informative log
    ''' </summary>
    ''' <param name="message"></param>
    ''' <param name="path"></param>
    ''' <remarks></remarks>
    Sub LogWrite(ByVal message As String, ByVal path As String)
        Dim sBuilder As New StringBuilder
        sBuilder.AppendLine("DateTime" & vbTab & "Action")
        sBuilder.AppendLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss:fff tt") & vbTab & message)
        MkDir(path)
        Dim streamWriter As StreamWriter
        streamWriter = My.Computer.FileSystem.OpenTextFileWriter(path & DateTime.Now.ToString("MMddyyyy") & ".log", True)
        streamWriter.WriteLine(sBuilder.ToString())
        streamWriter.Close()
    End Sub

    ''' <summary>
    ''' Saves log to the database
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveLog(ByVal logdt As DateTime, ByVal uid As String, ByVal evnt As String)

        Using conn As New MySqlConnection(ConnectionString)
            Try
                Dim cmd As New MySqlCommand(Constant.INSERT_LOG, conn)
                cmd.Parameters.Add(New MySqlParameter("@logdt", logdt.ToString()))
                cmd.Parameters.Add(New MySqlParameter("@uid", uid.ToString()))
                cmd.Parameters.Add(New MySqlParameter("@evnt", evnt.ToString()))
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



End Module
