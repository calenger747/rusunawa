Imports MySql.Data.MySqlClient
Public Class CariKodeBooking

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM booking_unit JOIN tbl_unit ON tbl_unit.id_unit = booking_unit.kode_unit WHERE booking_unit.kode_booking = '" & TextBox1.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Maaf Kode Booking Tidak Terdaftar!", MsgBoxStyle.Critical, "Aplikasi SIAP")
            Else
                MasterPenduduk.TextBox1.Text = DR.Item("no_kk")
                MasterPenduduk.TextBox2.Text = DR.Item("nama")
                MasterPenduduk.TextBox3.Text = DR.Item("id_unit")
                MasterPenduduk.cariUnit()
                MasterPenduduk.noSuratpernyataan()
                MasterPenduduk.TextBox7.Focus()
                MasterPenduduk.TextBox4.Enabled = False
                MasterPenduduk.TextBox5.Enabled = False
                MasterPenduduk.TextBox6.Enabled = False
                MasterPenduduk.TextBox22.Enabled = False
                Me.Visible = False
                MasterPenduduk.ShowDialog()
            End If
        End If
    End Sub
End Class