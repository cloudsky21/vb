Imports MySql.Data.MySqlClient
Module ConnectMySQL
    Public conn As New MySql.Data.MySqlClient.MySqlConnection
    Public Sub Connect()
        Dim DatabaseName As String = "livestock"
        Dim Server As String = "localhost"
        Dim UserName As String = "root "
        Dim Password As String = "pinipirawako100"
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", Server, UserName, Password, DatabaseName)
        Try
            conn.Open()
            MsgBox(conn.State.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module