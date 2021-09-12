Module GlobalVariables

    ' Mouse drag variables
    Public drag As Boolean
    Public cursorX As Integer
    Public cursorY As Integer
    Public Const CS_DROPSHADOW As Integer = 131072

    ' Log paths
    Public errlog_path As String = Application.StartupPath & "\log\error\"
    Public applog_path As String = Application.StartupPath & "\log\application\"

    ' account
    Public uuid As String
    Public upwd As String
    Public fname As String
    Public lname As String

    ' repository
    Public repository_path As String

    ' database
    Public server As String
    Public db_uid As String
    Public db_pword As String
    Public DB As String
    Public charset_utf8 As String = ";character set=utf8;"

    'Public ConnectionString As String = "server=" & server & ";user id=" & db_uid & ";password=" & db_pword & ";database=" & DB & ";" & charset_utf8
    Public ConnectionString As String

    ' Data
    Public document_category As New List(Of String)

    ' Query Search Condition
    Public search_condition As String

    Private totalPageVal As Integer
    Public Property TotalPageCount() As Integer
        Get
            Return totalPageVal
        End Get
        Set(ByVal value As Integer)
            totalPageVal = value
        End Set
    End Property

    Private pageNoVal As Integer
    Public Property PageNo() As Integer
        Get
            Return pageNoVal
        End Get
        Set(ByVal value As Integer)
            pageNoVal = value
        End Set
    End Property

    Private documentCntValue As Integer
    Public Property DocumentCount() As Integer
        Get
            Return documentCntValue
        End Get
        Set(ByVal value As Integer)
            documentCntValue = value
        End Set
    End Property

    Public categoryDic = New Dictionary(Of String, String)
End Module
