Imports MySql.Data.MySqlClient

Module Module1

    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public DA As MySqlDataAdapter
    Public DR As MySqlDataReader
    Public DS As DataSet

    Sub koneksi()
        Try
            Dim Str As String = "Server=103.28.12.107;user id=k0762615_rusunawa;password=Rusunawa123!@#;database=k0762615_rusunawa;"

            CONN = New MySqlConnection(Str)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub koneksiServer()
        Try
            Dim Str As String = "Server=192.168.50.3;user id=root;password=;database=db_siap;"

            CONN = New MySqlConnection(Str)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
