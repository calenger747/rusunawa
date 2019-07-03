Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class MasterPenduduk

    Sub kosong()
        koneksi()
        Label51.ResetText()
        Label53.ResetText()
        Label54.ResetText()
        Label55.ResetText()
        Label56.ResetText()
        Label57.ResetText()
        Label59.ResetText()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox21.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        ComboBox1.ResetText()
        ComboBox10.ResetText()
        ComboBox12.ResetText()
        ComboBox11.ResetText()
        ComboBox13.ResetText()
        ComboBox14.ResetText()
        ComboBox15.ResetText()
        ComboBox16.ResetText()
        ComboBox17.ResetText()
        ComboBox18.ResetText()
        ComboBox19.ResetText()
        ComboBox2.ResetText()
        ComboBox20.ResetText()
        ComboBox21.ResetText()
        ComboBox22.ResetText()
        ComboBox23.ResetText()
        ComboBox24.ResetText()
        ComboBox25.ResetText()
        ComboBox26.ResetText()
        ComboBox27.ResetText()
        ComboBox3.ResetText()
        ComboBox4.ResetText()
        ComboBox5.ResetText()
        ComboBox6.ResetText()
        ComboBox7.ResetText()
        ComboBox8.ResetText()
        ComboBox9.ResetText()
        TextBox1.Enabled = True
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox22.Enabled = False
        TextBox1.Focus()
        DateTimePicker1.ResetText()
        DateTimePicker2.ResetText()
        Button8.Enabled = False
        Button7.Enabled = False
        Button2.Enabled = False
        Button5.Enabled = True
        Button6.Enabled = False
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        DateTimePicker3.Enabled = False
        DateTimePicker2.Enabled = False
        ComboBox14.Enabled = False
        ComboBox13.Enabled = True
        DataGridView1.Rows.Clear()
        DataGridView2.Columns.Clear()
    End Sub

    Sub kosongAnggotaKeluarga()
        TextBox16.Clear()
        TextBox17.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        TextBox18.Clear()
        DateTimePicker1.ResetText()
        ComboBox3.ResetText()
        ComboBox4.ResetText()
        ComboBox5.ResetText()
        TextBox19.Clear()
        ComboBox6.ResetText()
        TextBox20.Clear()
        ComboBox7.ResetText()
        Label51.ResetText()
        Button5.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = False
        TextBox16.Focus()
    End Sub

    Sub ketemu()
        On Error Resume Next
        Label53.Text = DR.Item("id_modal")
        Label54.Text = DR.Item("id_meninggal")
        Label55.Text = DR.Item("id_sejahtera")
        Label56.Text = DR.Item("id_sdk")
        Label57.Text = DR.Item("id_alamat")
        TextBox2.Text = DR.Item("nama_kk")
        TextBox1.Text = DR.Item("id_kk")
        TextBox3.Text = DR.Item("id_unit")
        TextBox4.Text = DR.Item("gedung")
        TextBox5.Text = DR.Item("lantai")
        TextBox6.Text = DR.Item("kamar")
        TextBox22.Text = DR.Item("no_kwh")
        TextBox7.Text = DR.Item("jalan")
        TextBox8.Text = DR.Item("rt")
        TextBox9.Text = DR.Item("rw")
        TextBox10.Text = DR.Item("no")
        TextBox11.Text = DR.Item("kelurahan")
        TextBox12.Text = DR.Item("kecamatan")
        TextBox13.Text = DR.Item("kota")
        TextBox14.Text = DR.Item("provinsi")
        TextBox15.Text = DR.Item("kode_pos")
        TextBox21.Text = DR.Item("umur_meninggal")
        ComboBox8.Text = DR.Item("ada_meninggal")
        ComboBox9.Text = DR.Item("jk")
        ComboBox10.Text = DR.Item("ibu_meninggal")
        ComboBox11.Text = DR.Item("jamkesnas")
        ComboBox12.Text = DR.Item("metode_kb")
        ComboBox13.Text = DR.Item("sebab_non_kb")
        ComboBox14.Text = DR.Item("tempat_kb")
        ComboBox15.Text = DR.Item("ikut_posyandu")
        ComboBox16.Text = DR.Item("ikut_bkb")
        ComboBox17.Text = DR.Item("remaja_bkr")
        ComboBox18.Text = DR.Item("remaja_pik")
        ComboBox19.Text = DR.Item("lansia_bkl")
        TextBox1.Enabled = False
        ComboBox20.Text = DR.Item("status_tahapan")
        ComboBox21.Text = DR.Item("alasan")
        ComboBox22.Text = DR.Item("fasilitas_kakus")
        ComboBox23.Text = DR.Item("fasilitas_listrik")
        ComboBox24.Text = DR.Item("fasilitas_airminum")
        ComboBox25.Text = DR.Item("fasilitas_memasak")
        ComboBox26.Text = DR.Item("dapat_modal")
        ComboBox27.Text = DR.Item("ikut_uppks")
        DateTimePicker2.Text = DR.Item("kapan_kb")
        Label61.Text = DR.Item("no_kontrak")
        Button2.Enabled = True
        If ComboBox12.Text = "" Or ComboBox12.Text = "BELUM" Or ComboBox12.Text = "TIDAK" Then
            DateTimePicker2.Enabled = False
            ComboBox14.Enabled = False
            ComboBox13.Enabled = True
        Else
            ComboBox13.Enabled = False
            DateTimePicker2.Enabled = True
            ComboBox14.Enabled = True
        End If
    End Sub

    Sub ketemuKWH()
        Label59.Text = DR.Item("harga")
        TextBox22.Text = DR.Item("no_kwh")
        TextBox4.Text = DR.Item("gedung")
        TextBox5.Text = DR.Item("lantai")
        TextBox6.Text = DR.Item("kamar")
        TextBox7.Focus()
    End Sub

    Sub dataBaru()
        Label51.ResetText()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox21.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        ComboBox1.ResetText()
        ComboBox10.ResetText()
        ComboBox12.ResetText()
        ComboBox11.ResetText()
        ComboBox13.ResetText()
        ComboBox14.ResetText()
        ComboBox15.ResetText()
        ComboBox16.ResetText()
        ComboBox17.ResetText()
        ComboBox18.ResetText()
        ComboBox19.ResetText()
        ComboBox2.ResetText()
        ComboBox20.ResetText()
        ComboBox21.ResetText()
        ComboBox22.ResetText()
        ComboBox23.ResetText()
        ComboBox24.ResetText()
        ComboBox25.ResetText()
        ComboBox26.ResetText()
        ComboBox27.ResetText()
        ComboBox3.ResetText()
        ComboBox4.ResetText()
        ComboBox5.ResetText()
        ComboBox6.ResetText()
        ComboBox7.ResetText()
        ComboBox8.ResetText()
        ComboBox9.ResetText()
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox22.Enabled = False
        TextBox2.Focus()
    End Sub

    Sub tampilPendudukCari()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk WHERE id_kk = '" & TextBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        DataGridView2.Visible = True
        DataGridView1.Visible = False
    End Sub

    Sub noSuratpernyataan()
        Dim year As String
        Dim month As String

        year = Mid(Now.Year, 1, 4)
        month = Mid(Now.Month, 1, 2)
        Select Case True
            Case (month = 1)
                month = "I"
            Case (month = 2)
                month = "II"
            Case (month = 3)
                month = "III"
            Case (month = 4)
                month = "VI"
            Case (month = 5)
                month = "V"
            Case (month = 6)
                month = "VI"
            Case (month = 7)
                month = "VII"
            Case (month = 8)
                month = "VIII"
            Case (month = 9)
                month = "IX"
            Case (month = 10)
                month = "X"
            Case (month = 11)
                month = "XI"
            Case (month = 12)
                month = "XII"


        End Select

        koneksi()
        Dim otomatis As Single
        CMD = New MySqlCommand("SELECT COUNT(*) AS no_kontrak FROM tbl_kontrak", CONN)
        DR = CMD.ExecuteReader
        While DR.Read()
            otomatis = Val(DR.Item("no_kontrak").ToString) + 1
        End While
        Select Case Len(Trim(otomatis))
            Case 1 : Label61.Text = "SP/0000" + Trim(Str(otomatis)) + "/RNSW/" + month + "/" + Format(Now(), "yyyy")
            Case 2 : Label61.Text = "SP/000" + Trim(Str(otomatis)) + "/RNSW/" + month + "/" + Format(Now(), "yyyy")
            Case 3 : Label61.Text = "SP/00" + Trim(Str(otomatis)) + "/RNSW/" + month + "/" + Format(Now(), "yyyy")
            Case 4 : Label61.Text = "SP/0" + Trim(Str(otomatis)) + "/RNSW/" + month + "/" + Format(Now(), "yyyy")
        End Select
        CONN.Close()
    End Sub

    Private Sub MasterPenduduk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
        DateTimePicker3.Text = DateTime.Parse("10-" + Format(Now(), "MM") + "-" + Format(Now(), "yyyy")).AddMonths(1)
        DateTimePicker4.Text = DateTime.Parse(Format(Now(), "dd-MM") + "-" + Format(Now(), "yyyy")).AddYears(3)
        TextBox1.Focus()
        Label60.Text = (Format(Now(), "MMMM yyyy"))
        noSuratpernyataan()

        If TextBox3.Text = "" Then

        Else
            cariUnit()
        End If

        If TextBox1.Text = "" Then

        Else
            cariKK()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            cariKK()
        End If
    End Sub

    Sub cariKK()
        koneksi()
        CMD = New MySqlCommand("SELECT * FROM tbl_keluarga,tbl_alamat,tbl_penduduk,tbl_keluarga_get_modal,tbl_keluarga_meninggal,tbl_keluarga_sejahtera,tbl_keluarga_status_dan_kb,tbl_unit,tbl_kontrak WHERE tbl_keluarga.id_kk = tbl_kontrak.no_kk AND tbl_keluarga.id_kk = tbl_penduduk.id_kk AND tbl_keluarga.id_kk = tbl_keluarga_get_modal.id_kk AND tbl_keluarga.id_kk = tbl_keluarga_meninggal.id_kk AND tbl_keluarga.id_kk = tbl_keluarga_sejahtera.id_kk AND tbl_keluarga.id_kk = tbl_keluarga_status_dan_kb.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_keluarga.id_kk = tbl_alamat.id_kk AND tbl_keluarga.id_kk = '" & TextBox1.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            dataBaru()
            noSuratpernyataan()
        Else
            ketemu()
            tampilPendudukCari()
        End If
    End Sub

    Sub cariUnit()
        koneksi()
        CMD = New MySqlCommand("SELECT * FROM tbl_unit WHERE id_unit = '" & TextBox3.Text & "' AND status = 'Kosong' OR status = 'Booking'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            MsgBox("Id pelanggan tidak ditemukan atau sudah terisi!", MsgBoxStyle.Information, "Master Penduduk - Aplikasi SIAP")
            Exit Sub
        Else
            ketemuKWH()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            cariUnit()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DataGridView1.Visible = True Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_penduduk WHERE nik = '" & TextBox16.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                DataGridView1.Rows.Add(1)
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TextBox16.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox17.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = ComboBox1.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = ComboBox2.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = TextBox18.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = DateTimePicker1.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(6).Value = ComboBox3.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(7).Value = ComboBox4.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(8).Value = ComboBox5.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(9).Value = TextBox19.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(10).Value = ComboBox6.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(11).Value = TextBox20.Text
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(12).Value = ComboBox7.Text
                DataGridView1.Update()
                kosongAnggotaKeluarga()
                Button6.Enabled = True
            Else
                MsgBox("NIK penduduk sudah tersedia", MsgBoxStyle.Information, "Master Penduduk - Aplikasi SIAP")
                TextBox16.Focus()
                Exit Sub
            End If

        ElseIf DataGridView2.Visible = True Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_penduduk WHERE nik = '" & TextBox16.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                'simpan tabel penduduk
                Try
                    koneksi()
                    Dim simpanPenduduk As String = "INSERT INTO tbl_penduduk (id_kk,nik,nama,status_kk,jenis_kelamin,tmpt_lahir,tgl_lahir,agama,akte,pendidikan,pekerjaan,status_kawin,usia_kawin_pertama,status_hidup) VALUES('" & TextBox1.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox18.Text & "','" & Format("yyyy-MM-dd", DateTimePicker1.Text) & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & TextBox19.Text & "','" & ComboBox6.Text & "','" & TextBox20.Text & "','" & ComboBox7.Text & "')"
                    CMD = New MySqlCommand(simpanPenduduk, CONN)
                    CMD.ExecuteNonQuery()
                    tampilPendudukCari()
                    kosongAnggotaKeluarga()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("NIK penduduk sudah tersedia", MsgBoxStyle.Information, "Master Penduduk - Aplikasi SIAP")
                TextBox16.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error GoTo salah
        If DataGridView1.Rows.Count > 0 And DataGridView1.SelectedRows.Count > 0 Then
            Dim index As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
            DataGridView1.Rows.RemoveAt(index)

            Dim bolCount As Boolean = False

            For i As Integer = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Rows(i).Cells.Item(1).Value Is Nothing Or DataGridView1.Rows(i).Cells.Item(2).Value Is Nothing Then
                    bolCount = True
                    Exit For
                Else
                    bolCount = False
                End If
            Next

            If bolCount = True Then
                Button6.Enabled = False
            Else
                Button6.Enabled = True
            End If
            Exit Sub
salah:
            MsgBox("Baris Kosong Tidak Dapat Dihapus", MsgBoxStyle.Critical, "Master Token - Aplikasi SIAP")
        End If
    End Sub

    Sub surat_insert()
        SuratPernyataan.Label5.Text = "No. " + Label61.Text
        SuratPernyataan.Label8.Text = TextBox1.Text
        SuratPernyataan.Label10.Text = TextBox2.Text
        SuratPernyataan.Label12.Text = TextBox7.Text + ", RT. " + TextBox8.Text + ", RW. " + TextBox9.Text + ", " + TextBox11.Text + ", " + TextBox12.Text + ", " + TextBox13.Text + ", " + TextBox14.Text + ", " + TextBox15.Text
        SuratPernyataan.Label7.Text = "     Dengan ini bersedia untuk tunduk dan patuh terhadap aturan yang berlaku untuk bisa tinggal di Rusunawa Kota Depok. Apabila saya melanggar aturan tersebut, saya siap dikeluarkan dari Rusunawa Kota Depok. Surat Perjanjian ini berlaku selama 3 tahun dihitung mulai " + Format(Now(), "dd/MM/yyyy") + " sampai " + DateTime.Parse(Format(Now(), "dd MMMM yyyy")).AddYears(3) + "."
        SuratPernyataan.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Isikan data dengan lengkap", MsgBoxStyle.Information, "Master Penduduk - Aplikasi SIAP")
        Else
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_keluarga WHERE id_kk = '" & TextBox1.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            Try
                If Not DR.HasRows Then
                    'simpan tabel keluarga
                    koneksi()
                    Dim simpanKeluarga As String = "INSERT INTO tbl_keluarga VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & Format("yyyy-MM-dd", DateTimePicker3.Text) & "')"
                    CMD = New MySqlCommand(simpanKeluarga, CONN)
                    CMD.ExecuteNonQuery()

                    'simpan tabel transaksi
                    koneksi()
                    Dim simpanTransaksi As String = "INSERT INTO tbl_pembayaran (no_transaksi,tgl_transaksi,jatuh_tempo,id_pelanggan,bulan,jumlah,keterangan,id_user) VALUES ('" & TextBox1.Text & "','1899-12-31','" & Format("yyyy-MM-dd", DateTimePicker3.Text) & "','" & TextBox3.Text & "','" & Label60.Text & "','" & Label59.Text & "','BELUM BAYAR','" & MenuUtama.ToolStripStatusLabel1.Text & "')"
                    CMD = New MySqlCommand(simpanTransaksi, CONN)
                    CMD.ExecuteNonQuery()

                    'simpan tabel alamat
                    koneksi()
                    Dim simpanAlamat As String = "INSERT INTO tbl_alamat VALUES(NULL,'" & TextBox1.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "')"
                    CMD = New MySqlCommand(simpanAlamat, CONN)
                    CMD.ExecuteNonQuery()

                    'simpan tabel keluarga meninggal
                    koneksi()
                    Dim simpanKeluargaMeninggal As String = "INSERT INTO tbl_keluarga_meninggal VALUES(NULL,'" & TextBox1.Text & "','" & ComboBox8.Text & "','" & TextBox21.Text & "','" & ComboBox9.Text & "','" & ComboBox10.Text & "')"
                    CMD = New MySqlCommand(simpanKeluargaMeninggal, CONN)
                    CMD.ExecuteNonQuery()

                    'simpan tabel keluarga status dan kb
                    If DateTimePicker2.Enabled = False And ComboBox14.Enabled = False Then
                        koneksi()
                        Dim simpanKeluargaStatusdanKB As String = "INSERT INTO tbl_keluarga_status_dan_kb (id_sdk,id_kk,jamkesnas,metode_kb,sebab_non_kb,tempat_kb,ikut_posyandu,ikut_bkb,remaja_bkr,remaja_pik,lansia_bkl) VALUES(NULL,'" & TextBox1.Text & "','" & ComboBox11.Text & "','" & ComboBox12.Text & "','" & ComboBox13.Text & "','-','" & ComboBox15.Text & "','" & ComboBox16.Text & "','" & ComboBox17.Text & "','" & ComboBox18.Text & "','" & ComboBox19.Text & "')"
                        CMD = New MySqlCommand(simpanKeluargaStatusdanKB, CONN)
                        CMD.ExecuteNonQuery()
                    Else
                        koneksi()
                        Dim simpanKeluargaStatusdanKB As String = "INSERT INTO tbl_keluarga_status_dan_kb VALUES(NULL,'" & TextBox1.Text & "','" & ComboBox11.Text & "','" & ComboBox12.Text & "','" & ComboBox13.Text & "','" & Format("yyyy-MM-dd", DateTimePicker2.Text) & "','" & ComboBox14.Text & "','" & ComboBox15.Text & "','" & ComboBox16.Text & "','" & ComboBox17.Text & "','" & ComboBox18.Text & "','" & ComboBox19.Text & "')"
                        CMD = New MySqlCommand(simpanKeluargaStatusdanKB, CONN)
                        CMD.ExecuteNonQuery()
                    End If

                    'simpan tabel keluarga sejahtera
                    koneksi()
                    Dim simpanKeluargaSejahtera As String = "INSERT INTO tbl_keluarga_sejahtera VALUES(NULL,'" & TextBox1.Text & "','" & ComboBox20.Text & "','" & ComboBox21.Text & "','" & ComboBox22.Text & "','" & ComboBox23.Text & "','" & ComboBox24.Text & "','" & ComboBox25.Text & "')"
                    CMD = New MySqlCommand(simpanKeluargaSejahtera, CONN)
                    CMD.ExecuteNonQuery()

                    'simpan tabel keluarga dapat modal
                    koneksi()
                    Dim simpanKeluargaDapatModal As String = "INSERT INTO tbl_keluarga_get_modal VALUES(NULL,'" & TextBox1.Text & "','" & ComboBox26.Text & "','" & ComboBox27.Text & "')"
                    CMD = New MySqlCommand(simpanKeluargaDapatModal, CONN)
                    CMD.ExecuteNonQuery()

                    'ubah tabel unit
                    koneksi()
                    Dim ubahUnit As String = "UPDATE tbl_unit SET status = 'Isi' WHERE id_unit = '" & TextBox3.Text & "'"
                    CMD = New MySqlCommand(ubahUnit, CONN)
                    CMD.ExecuteNonQuery()

                    'simpan tabel penduduk
                    Try
                        koneksi()
                        For i As Integer = 0 To DataGridView1.Rows.Count - 2
                            koneksi()
                            Dim simpanPenduduk As String = "INSERT INTO tbl_penduduk VALUES(NULL,'" & TextBox1.Text & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(4).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "','" & DataGridView1.Rows(i).Cells(6).Value & "','" & DataGridView1.Rows(i).Cells(7).Value & "','" & DataGridView1.Rows(i).Cells(8).Value & "','" & DataGridView1.Rows(i).Cells(9).Value & "','" & DataGridView1.Rows(i).Cells(10).Value & "','" & DataGridView1.Rows(i).Cells(11).Value & "','" & DataGridView1.Rows(i).Cells(12).Value & "')"
                            CMD = New MySqlCommand(simpanPenduduk, CONN)
                            CMD.ExecuteNonQuery()
                        Next

                        'insert tabel kontrak
                        koneksi()
                        Dim simpanKontrak As String = "INSERT INTO tbl_kontrak (no_kontrak, no_kk, id_unit, tgl_mulai, tgl_akhir, status) VALUES ('" & Label61.Text & "', '" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & Format(Now(), "yyyy-MM-dd") & "', '" & Format("yyyy-MM-dd", DateTimePicker4.Text) & "', 'Aktif')"
                        CMD = New MySqlCommand(simpanKontrak, CONN)
                        CMD.ExecuteNonQuery()

                        MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Penduduk - Aplikasi SIAP")
                        surat_insert()
                        TextBox1.Clear()
                        TextBox22.Clear()
                        TextBox2.Clear()
                        TextBox4.Clear()
                        TextBox5.Clear()
                        TextBox6.Clear()
                        kosong()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    If MessageBox.Show("Edit seluruh data keluarga dengan No KK " & TextBox1.Text & " ?", "Master Penduduk - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Try
                            'edit tabel keluarga
                            koneksi()
                            Dim editKeluarga As String = "UPDATE tbl_keluarga SET nama_kk = '" & TextBox2.Text & "', id_penghuni = '" & TextBox3.Text & "' WHERE id_kk = '" & TextBox1.Text & "'"
                            CMD = New MySqlCommand(editKeluarga, CONN)
                            CMD.ExecuteNonQuery()

                            'edit tbl_unit
                            koneksi()
                            Dim editUnit As String = "UPDATE tbl_unit SET status = 'Isi' WHERE id_unit = '" & TextBox3.Text & "'"
                            CMD = New MySqlCommand(editUnit, CONN)
                            CMD.ExecuteNonQuery()

                            'edit tabel keluarga dapat modal
                            koneksi()
                            Dim editKeluargaDapatModal As String = "UPDATE tbl_keluarga_get_modal SET id_kk = '" & TextBox1.Text & "',dapat_modal = '" & ComboBox26.Text & "', ikut_uppks = '" & ComboBox27.Text & "' WHERE id_modal = '" & Label53.Text & "'"
                            CMD = New MySqlCommand(editKeluargaDapatModal, CONN)
                            CMD.ExecuteNonQuery()

                            'edit tabel keluarga meninggal
                            koneksi()
                            Dim editKeluargaMeninggal As String = "UPDATE tbl_keluarga_meninggal SET id_kk = '" & TextBox1.Text & "', ada_meninggal = '" & ComboBox8.Text & "', umur_meninggal = '" & TextBox21.Text & "', jk = '" & ComboBox9.Text & "', ibu_meninggal = '" & ComboBox10.Text & "' WHERE id_meninggal = '" & Label54.Text & "'"
                            CMD = New MySqlCommand(editKeluargaMeninggal, CONN)
                            CMD.ExecuteNonQuery()

                            'edit tabel keluarga sejahtera
                            koneksi()
                            Dim editKeluargaSejahtera As String = "UPDATE tbl_keluarga_sejahtera SET id_kk = '" & TextBox1.Text & "', status_tahapan = '" & ComboBox20.Text & "', alasan = '" & ComboBox21.Text & "', fasilitas_kakus = '" & ComboBox22.Text & "', fasilitas_listrik = '" & ComboBox23.Text & "', fasilitas_airminum = '" & ComboBox24.Text & "', fasilitas_memasak = '" & ComboBox25.Text & "' WHERE id_sejahtera = '" & Label55.Text & "'"
                            CMD = New MySqlCommand(editKeluargaSejahtera, CONN)
                            CMD.ExecuteNonQuery()

                            'edit tabel keluarga status dan kb
                            If DateTimePicker2.Enabled = False And ComboBox14.Enabled = False Then
                                koneksi()
                                Dim editKeluargaStatusdanKb As String = "UPDATE tbl_keluarga_status_dan_kb SET id_kk = '" & TextBox1.Text & "', jamkesnas = '" & ComboBox11.Text & "', metode_kb = '" & ComboBox12.Text & "', sebab_non_kb = '" & ComboBox13.Text & "', tempat_kb = '-', ikut_posyandu = '" & ComboBox15.Text & "', ikut_bkb = '" & ComboBox16.Text & "', remaja_bkr = '" & ComboBox17.Text & "', remaja_pik = '" & ComboBox18.Text & "', lansia_bkl = '" & ComboBox19.Text & "' WHERE id_sdk = '" & Label56.Text & "'"
                                CMD = New MySqlCommand(editKeluargaStatusdanKb, CONN)
                                CMD.ExecuteNonQuery()
                            Else
                                koneksi()
                                Dim editKeluargaStatusdanKb As String = "UPDATE tbl_keluarga_status_dan_kb SET id_kk = '" & TextBox1.Text & "', jamkesnas = '" & ComboBox11.Text & "', metode_kb = '" & ComboBox12.Text & "', sebab_non_kb = '-', kapan_kb = '" & Format("yyyy-MM-dd", DateTimePicker2.Text) & "', tempat_kb = '" & ComboBox14.Text & "', ikut_posyandu = '" & ComboBox15.Text & "', ikut_bkb = '" & ComboBox16.Text & "', remaja_bkr = '" & ComboBox17.Text & "', remaja_pik = '" & ComboBox18.Text & "', lansia_bkl = '" & ComboBox19.Text & "' WHERE id_sdk = '" & Label56.Text & "'"
                                CMD = New MySqlCommand(editKeluargaStatusdanKb, CONN)
                                CMD.ExecuteNonQuery()
                            End If

                            'edit tabel alamat
                            koneksi()
                            Dim editAlamat As String = "UPDATE tbl_alamat SET id_kk = '" & TextBox1.Text & "', jalan = '" & TextBox7.Text & "', rt = '" & TextBox8.Text & "', rw = '" & TextBox9.Text & "', no = '" & TextBox10.Text & "', kelurahan = '" & TextBox11.Text & "', kecamatan = '" & TextBox12.Text & "', kota = '" & TextBox13.Text & "', provinsi = '" & TextBox14.Text & "', kode_pos = '" & TextBox15.Text & "' WHERE id_alamat = '" & Label57.Text & "'"
                            CMD = New MySqlCommand(editAlamat, CONN)
                            CMD.ExecuteNonQuery()

                            'edit tabel kontrak
                            koneksi()
                            Dim editKontrak As String = "UPDATE tbl_kontrak SET no_kk = '" & TextBox1.Text & "', id_unit = '" & TextBox3.Text & "' WHERE no_kontrak = '" & Label61.Text & "'"
                            CMD = New MySqlCommand(editKontrak, CONN)
                            CMD.ExecuteNonQuery()

                            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Penduduk - Aplikasi SIAP")
                            surat_insert()
                            TextBox1.Clear()
                            TextBox22.Clear()
                            TextBox2.Clear()
                            TextBox4.Clear()
                            TextBox5.Clear()
                            TextBox6.Clear()
                            kosong()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Hapus seluruh data keluarga dengan No KK " & TextBox1.Text & " ?", "Master Penduduk - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                'edit tbl_unit
                koneksi()
                Dim editUnit As String = "UPDATE tbl_unit SET status = 'Kosong' WHERE id_unit = '" & TextBox3.Text & "'"
                CMD = New MySqlCommand(editUnit, CONN)
                CMD.ExecuteNonQuery()

                'edit tabel keluarga dapat modal
                koneksi()
                Dim hapusKeluargaDapatModal As String = "DELETE FROM tbl_keluarga_get_modal WHERE id_modal = '" & Label53.Text & "'"
                CMD = New MySqlCommand(hapusKeluargaDapatModal, CONN)
                CMD.ExecuteNonQuery()

                'edit tabel keluarga meninggal
                koneksi()
                Dim hapusKeluargaMeninggal As String = "DELETE FROM tbl_keluarga_meninggal WHERE id_meninggal = '" & Label54.Text & "'"
                CMD = New MySqlCommand(hapusKeluargaMeninggal, CONN)
                CMD.ExecuteNonQuery()

                'edit tabel keluarga sejahtera
                koneksi()
                Dim hapusKeluargaSejahtera As String = "DELETE FROM tbl_keluarga_sejahtera WHERE id_sejahtera = '" & Label55.Text & "'"
                CMD = New MySqlCommand(hapusKeluargaSejahtera, CONN)
                CMD.ExecuteNonQuery()

                'edit tabel keluarga status dan kb
                koneksi()
                Dim hapusKeluargaStatusdanKb As String = "DELETE FROM tbl_keluarga_status_dan_kb WHERE id_sdk = '" & Label56.Text & "'"
                CMD = New MySqlCommand(hapusKeluargaStatusdanKb, CONN)
                CMD.ExecuteNonQuery()

                'edit tabel alamat
                koneksi()
                Dim hapusAlamat As String = "DELETE FROM tbl_alamat WHERE id_alamat = '" & Label57.Text & "'"
                CMD = New MySqlCommand(hapusAlamat, CONN)
                CMD.ExecuteNonQuery()

                'delete tabel penduduk
                koneksi()
                Dim hapusPenduduk As String = "DELETE FROM tbl_penduduk WHERE id_kk = '" & TextBox1.Text & "'"
                CMD = New MySqlCommand(hapusPenduduk, CONN)
                CMD.ExecuteNonQuery()

                'edit tabel keluarga
                koneksi()
                Dim hapusKeluarga As String = "DELETE FROM tbl_keluarga WHERE id_kk = '" & TextBox1.Text & "'"
                CMD = New MySqlCommand(hapusKeluarga, CONN)
                CMD.ExecuteNonQuery()

                'edit tabel kontrak
                koneksi()
                Dim editKontrak As String = "DELETE FROM tbl_kontrak WHERE no_kontrak = '" & Label61.Text & "'"
                CMD = New MySqlCommand(editKontrak, CONN)
                CMD.ExecuteNonQuery()

                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Master Penduduk - Aplikasi SIAP")
                kosong()
                TextBox1.Clear()
                TextBox22.Clear()
                TextBox2.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        kosong()
        TextBox1.Clear()
        TextBox22.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        If ComboBox12.Text = "" Or ComboBox12.Text = "BELUM" Or ComboBox12.Text = "TIDAK" Then
            DateTimePicker2.Enabled = False
            ComboBox14.Enabled = False
            ComboBox13.Enabled = True
        Else
            ComboBox13.Enabled = False
            DateTimePicker2.Enabled = True
            ComboBox14.Enabled = True
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If MessageBox.Show("Edit data penduduk dari NIK " & TextBox16.Text & " ?", "Master Penduduk - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                koneksi()
                Dim editPenduduk As String = "UPDATE tbl_penduduk SET nik = '" & TextBox16.Text & "',nama = '" & TextBox17.Text & "',status_kk = '" & ComboBox1.Text & "', jenis_kelamin = '" & ComboBox2.Text & "',tmpt_lahir = '" & TextBox18.Text & "',tgl_lahir = '" & Format("yyyy-MM-dd", DateTimePicker1.Text) & "',agama = '" & ComboBox3.Text & "',akte = '" & ComboBox4.Text & "',pendidikan = '" & ComboBox5.Text & "',pekerjaan = '" & TextBox19.Text & "',status_kawin = '" & ComboBox6.Text & "',usia_kawin_pertama = '" & TextBox20.Text & "',status_hidup = '" & ComboBox7.Text & "' WHERE id_pend = '" & Label51.Text & "' "
                CMD = New MySqlCommand(editPenduduk, CONN)
                CMD.ExecuteNonQuery()
                kosongAnggotaKeluarga()
                tampilPendudukCari()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        On Error Resume Next
        Label51.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        TextBox16.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        TextBox17.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value
        ComboBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value
        ComboBox2.Text = DataGridView2.Rows(e.RowIndex).Cells(5).Value
        TextBox18.Text = DataGridView2.Rows(e.RowIndex).Cells(6).Value
        DateTimePicker1.Text = DataGridView2.Rows(e.RowIndex).Cells(7).Value
        ComboBox3.Text = DataGridView2.Rows(e.RowIndex).Cells(8).Value
        ComboBox4.Text = DataGridView2.Rows(e.RowIndex).Cells(9).Value
        ComboBox5.Text = DataGridView2.Rows(e.RowIndex).Cells(10).Value
        TextBox19.Text = DataGridView2.Rows(e.RowIndex).Cells(11).Value
        ComboBox6.Text = DataGridView2.Rows(e.RowIndex).Cells(12).Value
        TextBox20.Text = DataGridView2.Rows(e.RowIndex).Cells(13).Value
        ComboBox7.Text = DataGridView2.Rows(e.RowIndex).Cells(14).Value

        Button5.Enabled = False
        Button8.Enabled = True
        Button7.Enabled = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If MessageBox.Show("Hapus data penduduk dengan NIK " & TextBox16.Text & " ?", "Master Penduduk - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                koneksi()
                Dim editPenduduk As String = "DELETE FROM tbl_penduduk WHERE id_pend = '" & Label51.Text & "' "
                CMD = New MySqlCommand(editPenduduk, CONN)
                CMD.ExecuteNonQuery()
                kosongAnggotaKeluarga()
                tampilPendudukCari()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class