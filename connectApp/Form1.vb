Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim sqladapter As New MySqlDataAdapter
        Dim sqlcmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable



        Try
            Connect()
            sqlcmd = New MySqlCommand("SELECT * FROM users WHERE usrid = 'root'")
            sqlcmd.Connection = conn
            dr = sqlcmd.ExecuteReader()
            dt.Load(dr)

            TextBox1.Text = dt.Rows(0).Item(0).ToString()

        Catch ex As MysqlException
            MsgBox("Error:" & ex.Message)

        End Try



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
