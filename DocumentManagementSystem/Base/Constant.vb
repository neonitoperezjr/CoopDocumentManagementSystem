Module Constant

    Public Const PAGE_COUNT As Integer = 50

    ' Query

    ' t_user
    Public Const GET_USERNAME As String = "SELECT uid FROM t_user"
    Public Const GET_PASSWORD As String = "SELECT pword FROM t_user"
    Public Const GET_FNAME As String = "SELECT fname FROM t_user"
    Public Const GET_LNAME As String = "SELECT lname FROM t_user"

    ' t_category
    Public Const GET_DOCUMENT_CATEGORY As String = "SELECT DISTINCT category_id, category_name FROM t_category"

    ' t_document
    Public Const INSERT_DOCUMENT As String = "INSERT INTO t_document (dc_no, dc_name, dc_desc, dc_category, dc_keyword, dc_upload_date, dc_upload_by, revision_no) " & _
                                                             "VALUES (@dc_no, @dc_name, @dc_desc, @dc_category, @dc_keyword, @dc_upload_date, @dc_upload_by, @dc_revision_no)"

    Public Const GET_NUM_OF_UPLOAD_FILE As String = "SELECT COUNT(*) FROM t_document"

    'Public Const GET_DOCUMENTS As String = "SELECT dc_no, dc_name, dc_category, dc_upload_date, dc_upload_by, revision_no, update_datetime, update_by FROM t_document"

    Public Const GET_DOCUMENTS As String = "SELECT t1.dc_no, t1.dc_name, t2.category_name, t1.dc_upload_date, t1.dc_upload_by, t1.revision_no, t1.update_datetime, t1.update_by FROM T_document t1 INNER JOIN T_category t2 ON t1.dc_category = t2.category_id"

    ' t_log
    Public Const INSERT_LOG As String = "INSERT INTO t_log (logdt, uid, evnt) " & _
                                                        "VALUES (@logdt, @uid, @evnt)"


    ' t_setting
    Public Const UPDATE_SETTING_REPO As String = "UPDATE t_settings SET setting_value=@setting_value WHERE setting_name = 'repository'"
    Public Const GET_REPOSITORY_PATH As String = "SELECT setting_value FROM t_settings"
End Module
