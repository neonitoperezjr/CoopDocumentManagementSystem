Imports System.Configuration
Imports System.Text

''' <summary>
''' Manages file
''' <para>Author: Neonito Perez Jr.</para>
''' </summary>
''' <remarks></remarks>
Module FileManager

    ' Module class name
    Private m_class_name As String = GetType(FileManager).Name

    ''' <summary>
    ''' Reads application settings.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadAppConfig() As Boolean
        Dim status As Boolean = False
        Try
            Dim reader As New System.Configuration.AppSettingsReader
            server = reader.GetValue("server", GetType(String))
            DB = reader.GetValue("database", GetType(String))
            db_uid = reader.GetValue("db_uid", GetType(String))
            db_pword = reader.GetValue("db_pword", GetType(String))
        Catch ex As Exception
            MessageBox.Show("Error occured", m_class_name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LogWrite(ex.Message.ToString() & vbCrLf & ex.StackTrace.ToString(),
                     errlog_path)
        End Try
        Return status
    End Function

End Module
