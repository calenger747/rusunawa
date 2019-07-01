Imports MySql.Data.MySqlClient
Public Class DetailKeluarga

    Sub kosong()
        TextBox1.Clear()
        TextBox4.ResetText()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.ResetText()
        TextBox6.ResetText()
        TextBox7.ResetText()
        TextBox8.ResetText()
        DataGridView1.Columns.Clear()
        TextBox1.Focus()
    End Sub

    Sub ketemu()
        TextBox4.Text = UCase(DR.Item("nama_kk"))
        TextBox3.Text = DR.Item("id_kk")
        TextBox2.Text = DR.Item("id_unit")
        TextBox5.Text = DR.Item("no_kwh")
        TextBox6.Text = "Jl. " + UCase(DR.Item("jalan")) + ", RT." + DR.Item("rt") + "/" + DR.Item("rw") + ", No." + DR.Item("no") + ", Kel. " + (UCase(DR.Item("kelurahan")) + ", Kec. " + UCase(DR.Item("kecamatan")) + ", Kota. " + UCase(DR.Item("kota")) + ", Provinsi. " + UCase(DR.Item("provinsi")) + " - " + DR.Item("kode_pos"))
        TextBox7.Text = "Gedung " + DR.Item("gedung") + " Lantai " + DR.Item("lantai") + " Kamar " + DR.Item("kamar") + " (" + DR.Item("unit") + ")"
    End Sub

    Sub tampilPendudukCari()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_penduduk.nik, tbl_penduduk.nama, tbl_penduduk.status_kk, tbl_penduduk.jenis_kelamin, tbl_penduduk.tmpt_lahir, tbl_penduduk.tgl_lahir, umur_p.t_lahir FROM tbl_penduduk, umur_p WHERE tbl_penduduk.nik = umur_p.nik AND tbl_penduduk.id_kk = '" & TextBox3.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True

        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        TextBox8.Text = JmlData
    End Sub

    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 150
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 50

        DataGridView1.Columns(0).HeaderText = "NIK"
        DataGridView1.Columns(1).HeaderText = "Nama Lengkap"
        DataGridView1.Columns(2).HeaderText = "Status Keluarga"
        DataGridView1.Columns(3).HeaderText = "Jenis Kelamin"
        DataGridView1.Columns(4).HeaderText = "Tempat Lahir"
        DataGridView1.Columns(5).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns(6).HeaderText = "Usia"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_keluarga,tbl_alamat,tbl_penduduk,tbl_keluarga_get_modal,tbl_keluarga_meninggal,tbl_keluarga_sejahtera,tbl_keluarga_status_dan_kb,tbl_unit WHERE tbl_keluarga.id_kk = tbl_penduduk.id_kk AND tbl_keluarga.id_kk = tbl_keluarga_get_modal.id_kk AND tbl_keluarga.id_kk = tbl_keluarga_meninggal.id_kk AND tbl_keluarga.id_kk = tbl_keluarga_sejahtera.id_kk AND tbl_keluarga.id_kk = tbl_keluarga_status_dan_kb.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_keluarga.id_kk = tbl_alamat.id_kk AND tbl_unit.id_unit = '" & TextBox1.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Data penghuni tidak ditemukan atau unit kosong!", MsgBoxStyle.Information, "Cari Data Keluarga - Aplikasi SIAP")
                kosong()
            Else
                ketemu()
                tampilPendudukCari()
                kolomGrid()
                DataGridView1.Visible = True
            End If
        End If
    End Sub

    Private Sub DetailKeluarga_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        kosong()
    End Sub

    Private Sub DetailKeluarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
        DataGridView1.Visible = False
    End Sub
End Class