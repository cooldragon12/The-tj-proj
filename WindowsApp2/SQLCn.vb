
Imports MySql.Data.MySqlClient
Public Class SQLCn
    Private SQLconn As New MySqlConnection("datasource=localhost;port=3306;user id=root;password=helloworld;database=slotprof")


    ReadOnly Property GetConnection() As MySqlConnection
        Get
            Return SQLconn
        End Get
    End Property

    Sub OpenConnection()
        If SQLconn.State = ConnectionState.Closed Then
            SQLconn.Open()
        End If
    End Sub
    Sub CloseConnection()
        If SQLconn.State = ConnectionState.Open Then
            SQLconn.Close()
        End If
    End Sub
End Class
