Imports MySql.Data.MySqlClient
Public Class CariIDPenghuni

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_pembayaran WHERE id_pelanggan = '" & TextBox1.Text & "' AND keterangan = 'MENUNGGAK'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Try
                    Process.Start("C:\Program Files (x86)\Nox\bin\Nox.exe")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Maaf akses tidak dapat dilakukan!", MsgBoxStyle.Critical, "Aplikasi SIAP")
            End If
        End If
    End Sub
End Class