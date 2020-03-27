Imports MySql.Data.MySqlClient
Public Class MenuUtama

    Sub Add_Transaksi_Bulan()
        koneksi()
        DA = New MySqlDataAdapter("SELECT id_unit, harga FROM tbl_unit JOIN tbl_keluarga ON tbl_unit.id_unit = tbl_keluarga.id_penghuni", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)

        CMD = New MySqlCommand("SELECT * FROM tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan WHERE MONTH(tbl_pembayaran.tgl_transaksi) = '" & Format(Now, "MM") & "' AND YEAR(tbl_pembayaran.tgl_transaksi) = '" & Format(Now, "yyyy") & "' AND tbl_pembayaran.bulan = '" & Format(Now, "MMMM yyyy") & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            Try
                For i As Integer = 0 To DataGridView1.Rows.Count - 2
                    koneksi()
                    Dim transaksi As String = "INSERT INTO tbl_pembayaran(no_transaksi, tgl_transaksi, jatuh_tempo, id_pelanggan, bulan, jumlah, keterangan) VALUES('" & i & "-" & Format(Now, "MM-yyyy") & "','" & Format(Now, "yyyy-MM") & "-01','" & Format(Now, "yyyy-MM") & "-20','" & DataGridView1.Rows(i).Cells(0).Value & "','" & Format(Now, "MMMM yyyy") & "','" & DataGridView1.Rows(i).Cells(1).Value & "','BELUM BAYAR')"
                    CMD = New MySqlCommand(transaksi, CONN)
                    CMD.ExecuteNonQuery()
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

        End If
        
    End Sub

    Sub menunggak()
        If TextBox1.Text > "20" Then
            koneksi()
            DA = New MySqlDataAdapter("SELECT no_transaksi, keterangan FROM tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan WHERE MONTH(tbl_pembayaran.tgl_transaksi) = '" & Format(Now, "MM") & "' AND YEAR(tbl_pembayaran.tgl_transaksi) = '" & Format(Now, "yyyy") & "' AND tbl_pembayaran.keterangan = 'BELUM BAYAR'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView2.DataSource = DS.Tables(0)

            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_pembayaran JOIN tbl_unit ON tbl_unit.id_unit = tbl_pembayaran.id_pelanggan WHERE MONTH(tbl_pembayaran.tgl_transaksi) = '" & Format(Now, "MM") & "' AND YEAR(tbl_pembayaran.tgl_transaksi) = '" & Format(Now, "yyyy") & "' AND tbl_pembayaran.keterangan = 'BELUM BAYAR'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Try
                    For i As Integer = 0 To DataGridView2.Rows.Count - 2
                        koneksi()
                        CMD = New MySqlCommand("UPDATE tbl_pembayaran SET keterangan = 'MENUNGGAK' WHERE no_transaksi = '" & DataGridView2.Rows(i).Cells(0).Value & "'", CONN)
                        CMD.ExecuteNonQuery()
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
            End If
        End If
    End Sub

    Sub Akses()
        koneksi()
        CMD = New MySqlCommand("SELECT * FROM tbl_m_user WHERE user_id = '" & ToolStripStatusLabel1.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            MsgBox("Akses tidak tersedia!", MsgBoxStyle.Critical, "Aplikasi SIAP")
        Else
            If DR.Item("user_role") = "1" Then
                CariIDPenghuni.ShowDialog()
            Else
                Try
                    Process.Start("C:\Program Files (x86)\Droid4X\Droid4X.exe")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampilMenu()
        DateTimePicker1.Text = DateTime.Parse("20-" + Format(Now(), "MM") + "-" + Format(Now(), "yyyy"))
        TextBox1.Text = Format(Now, "dd")
    End Sub

    Sub tampilMenu()
        StatusStrip1.Visible = False

        LoginToolStripMenuItem1.Visible = True
        LogoutToolStripMenuItem.Visible = False
        KeluarToolStripMenuItem.Visible = True

        MasterToolStripMenuItem.Visible = False
        ReservasiUnitToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem.Visible = False
        FasilitasToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Apakah anda yakin ingin logout?", "Logout Sistem - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            tampilMenu()
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Apakah anda yakin ingin keluar aplikasi?", "Close Sistem - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem1.Click
        LoginForm1.ShowDialog()
    End Sub

    Private Sub ProfilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfilToolStripMenuItem.Click
        MasterLembaga.ShowDialog()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryToolStripMenuItem.Click
        MasterInventory.ShowDialog()
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        MasterUser.ShowDialog()
    End Sub

    Private Sub UnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitToolStripMenuItem.Click
        MasterUnit.ShowDialog()
    End Sub

    Private Sub TokenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TokenToolStripMenuItem.Click
        MasterToken.ShowDialog()
    End Sub

    Private Sub KependudukanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KependudukanToolStripMenuItem.Click
        MasterPenduduk.ShowDialog()
    End Sub

    Private Sub PembayaranSewaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembayaranSewaToolStripMenuItem.Click
        TransaksiIuran.ShowDialog()
    End Sub

    Private Sub PembelianListrikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianListrikToolStripMenuItem.Click
        TransaksiListrik.ShowDialog()
    End Sub

    Private Sub AirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AirToolStripMenuItem.Click
        Akses()
    End Sub

    Private Sub ListrikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListrikToolStripMenuItem.Click
        Akses()
    End Sub

    Private Sub KependudukanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KependudukanToolStripMenuItem1.Click
        LaporanPenduduk.ShowDialog()
    End Sub

    Private Sub PendudukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendudukToolStripMenuItem.Click
        TabelPenduduk.ShowDialog()
    End Sub

    Private Sub KeluargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluargaToolStripMenuItem.Click
        DetailKeluarga.ShowDialog()
    End Sub

    Private Sub PendapatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendapatanToolStripMenuItem.Click
        GrafikPendapatan.ShowDialog()
    End Sub

    Private Sub PembayaranSewaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembayaranSewaToolStripMenuItem1.Click
        LaporanPembayaranSewa.ShowDialog()
    End Sub

    Private Sub PembelianListrikToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianListrikToolStripMenuItem1.Click
        LaporanPembelianToken.ShowDialog()
    End Sub

    Private Sub InventoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryToolStripMenuItem1.Click
        LaporanInventory.ShowDialog()
    End Sub

    Private Sub KepalaKeluargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KepalaKeluargaToolStripMenuItem.Click
        KepalaKeluarga.ShowDialog()
    End Sub

    Private Sub UnitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitToolStripMenuItem1.Click
        GrafikUnit.ShowDialog()
    End Sub

    Private Sub SewaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewaToolStripMenuItem.Click
        GrafikSewa.ShowDialog()
    End Sub

    Private Sub ReservasiUnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasiUnitToolStripMenuItem.Click
        CariKodeBooking.ShowDialog()
    End Sub

    Private Sub UnitExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitExcelToolStripMenuItem.Click
        ExcelUnit.ShowDialog()
    End Sub

    Private Sub UploadTokenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadTokenToolStripMenuItem.Click
        UploadToken.ShowDialog()
    End Sub
End Class
