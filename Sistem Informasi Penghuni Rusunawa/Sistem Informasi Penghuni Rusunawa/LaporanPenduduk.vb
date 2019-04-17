Imports MySql.Data.MySqlClient
Public Class LaporanPenduduk

    Sub tampilPenduduk()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        Label1.Text = JmlData - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_keluarga", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim JmlData2 As Integer
        JmlData2 = DataGridView2.RowCount
        Label2.Text = JmlData2 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk WHERE jenis_kelamin = 'LK' ", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk WHERE jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk WHERE status_kawin = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk WHERE status_kawin = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir FROM umur_p WHERE t_lahir < 6", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView7.DataSource = DS.Tables(0)
        DataGridView7.ReadOnly = True
        Dim JmlData7 As Integer
        JmlData7 = DataGridView7.RowCount
        Label7.Text = JmlData7 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir FROM umur_p WHERE t_lahir > 5 AND t_lahir < 13", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView8.DataSource = DS.Tables(0)
        DataGridView8.ReadOnly = True
        Dim JmlData8 As Integer
        JmlData8 = DataGridView8.RowCount
        Label8.Text = JmlData8 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir FROM umur_p WHERE t_lahir > 20 AND t_lahir < 51", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView9.DataSource = DS.Tables(0)
        DataGridView9.ReadOnly = True
        Dim JmlData9 As Integer
        JmlData9 = DataGridView9.RowCount
        Label9.Text = JmlData9 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir FROM umur_p WHERE t_lahir > 16", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView10.DataSource = DS.Tables(0)
        DataGridView10.ReadOnly = True
        Dim JmlData10 As Integer
        JmlData10 = DataGridView10.RowCount
        Label10.Text = JmlData10 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir FROM umur_p WHERE t_lahir > 59", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView11.DataSource = DS.Tables(0)
        DataGridView11.ReadOnly = True
        Dim JmlData11 As Integer
        JmlData11 = DataGridView11.RowCount
        Label11.Text = JmlData11 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir FROM umur_p WHERE t_lahir < 5", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView12.DataSource = DS.Tables(0)
        DataGridView12.ReadOnly = True
        Dim JmlData12 As Integer
        JmlData12 = DataGridView12.RowCount
        Label12.Text = JmlData12 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT umur_p.t_lahir, tbl_penduduk.jenis_kelamin FROM umur_p, tbl_penduduk WHERE tbl_penduduk.nik = umur_p.nik AND umur_p.t_lahir > 5 AND t_lahir < 13 AND tbl_penduduk.jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView13.DataSource = DS.Tables(0)
        DataGridView13.ReadOnly = True
        Dim JmlData13 As Integer
        JmlData13 = DataGridView13.RowCount
        Label13.Text = JmlData13 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT umur_p.t_lahir, tbl_penduduk.jenis_kelamin FROM umur_p, tbl_penduduk WHERE tbl_penduduk.nik = umur_p.nik AND umur_p.t_lahir BETWEEN 20 AND 51 AND tbl_penduduk.jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView14.DataSource = DS.Tables(0)
        DataGridView14.ReadOnly = True
        Dim JmlData14 As Integer
        JmlData14 = DataGridView14.RowCount
        Label14.Text = JmlData14 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT umur_p.t_lahir, tbl_penduduk.jenis_kelamin FROM umur_p, tbl_penduduk WHERE tbl_penduduk.nik = umur_p.nik AND umur_p.t_lahir > 16 AND tbl_penduduk.jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView15.DataSource = DS.Tables(0)
        DataGridView15.ReadOnly = True
        Dim JmlData15 As Integer
        JmlData15 = DataGridView15.RowCount
        Label15.Text = JmlData15 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin, status FROM umur_p WHERE t_lahir > 16 AND jenis_kelamin = 'LK' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView16.DataSource = DS.Tables(0)
        DataGridView16.ReadOnly = True
        Dim JmlData16 As Integer
        JmlData16 = DataGridView16.RowCount
        Label16.Text = JmlData16 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin, status FROM umur_p WHERE t_lahir < 17 AND jenis_kelamin = 'LK' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView17.DataSource = DS.Tables(0)
        DataGridView17.ReadOnly = True
        Dim JmlData17 As Integer
        JmlData17 = DataGridView17.RowCount
        Label17.Text = JmlData17 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin, status FROM umur_p WHERE t_lahir > 16 AND jenis_kelamin = 'LK' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView18.DataSource = DS.Tables(0)
        DataGridView18.ReadOnly = True
        Dim JmlData18 As Integer
        JmlData18 = DataGridView18.RowCount
        Label18.Text = JmlData18 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin, status FROM umur_p WHERE t_lahir < 17 AND jenis_kelamin = 'LK' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView19.DataSource = DS.Tables(0)
        DataGridView19.ReadOnly = True
        Dim JmlData19 As Integer
        JmlData19 = DataGridView19.RowCount
        Label19.Text = JmlData19 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin FROM umur_p WHERE t_lahir > 59 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView20.DataSource = DS.Tables(0)
        DataGridView20.ReadOnly = True
        Dim JmlData20 As Integer
        JmlData20 = DataGridView20.RowCount
        Label20.Text = JmlData20 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT umur_p.t_lahir, tbl_penduduk.jenis_kelamin FROM umur_p, tbl_penduduk WHERE tbl_penduduk.nik = umur_p.nik AND umur_p.t_lahir < 6 AND tbl_penduduk.jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView21.DataSource = DS.Tables(0)
        DataGridView21.ReadOnly = True
        Dim JmlData21 As Integer
        JmlData21 = DataGridView21.RowCount
        Label21.Text = JmlData21 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT umur_p.t_lahir, tbl_penduduk.jenis_kelamin FROM umur_p, tbl_penduduk WHERE tbl_penduduk.nik = umur_p.nik AND umur_p.t_lahir > 5 AND t_lahir < 13 AND tbl_penduduk.jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView22.DataSource = DS.Tables(0)
        DataGridView22.ReadOnly = True
        Dim JmlData22 As Integer
        JmlData22 = DataGridView22.RowCount
        Label22.Text = JmlData22 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT umur_p.t_lahir, tbl_penduduk.jenis_kelamin FROM umur_p, tbl_penduduk WHERE tbl_penduduk.nik = umur_p.nik AND umur_p.t_lahir > 20 AND umur_p.t_lahir < 51 AND tbl_penduduk.jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView23.DataSource = DS.Tables(0)
        DataGridView23.ReadOnly = True
        Dim JmlData23 As Integer
        JmlData23 = DataGridView23.RowCount
        Label23.Text = JmlData23 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT umur_p.t_lahir, tbl_penduduk.jenis_kelamin FROM umur_p, tbl_penduduk WHERE tbl_penduduk.nik = umur_p.nik AND umur_p.t_lahir > 16 AND tbl_penduduk.jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView24.DataSource = DS.Tables(0)
        DataGridView24.ReadOnly = True
        Dim JmlData24 As Integer
        JmlData24 = DataGridView24.RowCount
        Label24.Text = JmlData24 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin, status FROM umur_p WHERE t_lahir > 16 AND jenis_kelamin = 'P' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView25.DataSource = DS.Tables(0)
        DataGridView25.ReadOnly = True
        Dim JmlData25 As Integer
        JmlData25 = DataGridView25.RowCount
        Label25.Text = JmlData25 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin, status FROM umur_p WHERE t_lahir < 17 AND jenis_kelamin = 'P' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView26.DataSource = DS.Tables(0)
        DataGridView26.ReadOnly = True
        Dim JmlData26 As Integer
        JmlData26 = DataGridView26.RowCount
        Label26.Text = JmlData26 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin, status FROM umur_p WHERE t_lahir > 16 AND jenis_kelamin = 'P' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView27.DataSource = DS.Tables(0)
        DataGridView27.ReadOnly = True
        Dim JmlData27 As Integer
        JmlData27 = DataGridView27.RowCount
        Label27.Text = JmlData27 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin, status FROM umur_p WHERE t_lahir < 17 AND jenis_kelamin = 'P' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView28.DataSource = DS.Tables(0)
        DataGridView28.ReadOnly = True
        Dim JmlData28 As Integer
        JmlData28 = DataGridView28.RowCount
        Label28.Text = JmlData28 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT t_lahir,jenis_kelamin FROM umur_p WHERE t_lahir > 59 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView29.DataSource = DS.Tables(0)
        DataGridView29.ReadOnly = True
        Dim JmlData29 As Integer
        JmlData29 = DataGridView29.RowCount
        Label29.Text = JmlData29 - 1
    End Sub

    Sub tampilPendudukGedung()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        Label1.Text = JmlData - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_keluarga, tbl_unit WHERE tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim JmlData2 As Integer
        JmlData2 = DataGridView2.RowCount
        Label2.Text = JmlData2 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox1.Text & "' AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox1.Text & "' AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox1.Text & "' AND status_kawin = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox1.Text & "' AND status_kawin = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir < 6", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView7.DataSource = DS.Tables(0)
        DataGridView7.ReadOnly = True
        Dim JmlData7 As Integer
        JmlData7 = DataGridView7.RowCount
        Label7.Text = JmlData7 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir > 5 AND t_lahir < 13", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView8.DataSource = DS.Tables(0)
        DataGridView8.ReadOnly = True
        Dim JmlData8 As Integer
        JmlData8 = DataGridView8.RowCount
        Label8.Text = JmlData8 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir > 20 AND t_lahir < 51", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView9.DataSource = DS.Tables(0)
        DataGridView9.ReadOnly = True
        Dim JmlData9 As Integer
        JmlData9 = DataGridView9.RowCount
        Label9.Text = JmlData9 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir > 16", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView10.DataSource = DS.Tables(0)
        DataGridView10.ReadOnly = True
        Dim JmlData10 As Integer
        JmlData10 = DataGridView10.RowCount
        Label10.Text = JmlData10 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir > 59", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView11.DataSource = DS.Tables(0)
        DataGridView11.ReadOnly = True
        Dim JmlData11 As Integer
        JmlData11 = DataGridView11.RowCount
        Label11.Text = JmlData11 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir < 5 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView12.DataSource = DS.Tables(0)
        DataGridView12.ReadOnly = True
        Dim JmlData12 As Integer
        JmlData12 = DataGridView12.RowCount
        Label12.Text = JmlData12 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir > 5 AND t_lahir < 13 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView13.DataSource = DS.Tables(0)
        DataGridView13.ReadOnly = True
        Dim JmlData13 As Integer
        JmlData13 = DataGridView13.RowCount
        Label13.Text = JmlData13 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir > 20 AND t_lahir < 51 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView14.DataSource = DS.Tables(0)
        DataGridView14.ReadOnly = True
        Dim JmlData14 As Integer
        JmlData14 = DataGridView14.RowCount
        Label14.Text = JmlData14 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView15.DataSource = DS.Tables(0)
        DataGridView15.ReadOnly = True
        Dim JmlData15 As Integer
        JmlData15 = DataGridView15.RowCount
        Label15.Text = JmlData15 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'LK' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView16.DataSource = DS.Tables(0)
        DataGridView16.ReadOnly = True
        Dim JmlData16 As Integer
        JmlData16 = DataGridView16.RowCount
        Label16.Text = JmlData16 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir < 17 AND jenis_kelamin = 'LK' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView17.DataSource = DS.Tables(0)
        DataGridView17.ReadOnly = True
        Dim JmlData17 As Integer
        JmlData17 = DataGridView17.RowCount
        Label17.Text = JmlData17 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'LK' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView18.DataSource = DS.Tables(0)
        DataGridView18.ReadOnly = True
        Dim JmlData18 As Integer
        JmlData18 = DataGridView18.RowCount
        Label18.Text = JmlData18 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir < 17 AND jenis_kelamin = 'LK' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView19.DataSource = DS.Tables(0)
        DataGridView19.ReadOnly = True
        Dim JmlData19 As Integer
        JmlData19 = DataGridView19.RowCount
        Label19.Text = JmlData19 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir > 59 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView20.DataSource = DS.Tables(0)
        DataGridView20.ReadOnly = True
        Dim JmlData20 As Integer
        JmlData20 = DataGridView20.RowCount
        Label20.Text = JmlData20 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir < 5 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView21.DataSource = DS.Tables(0)
        DataGridView21.ReadOnly = True
        Dim JmlData21 As Integer
        JmlData21 = DataGridView21.RowCount
        Label21.Text = JmlData21 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir > 5 AND t_lahir < 13 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView22.DataSource = DS.Tables(0)
        DataGridView22.ReadOnly = True
        Dim JmlData22 As Integer
        JmlData22 = DataGridView22.RowCount
        Label22.Text = JmlData22 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "' AND t_lahir > 20 AND t_lahir < 51 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView23.DataSource = DS.Tables(0)
        DataGridView23.ReadOnly = True
        Dim JmlData23 As Integer
        JmlData23 = DataGridView23.RowCount
        Label23.Text = JmlData23 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView24.DataSource = DS.Tables(0)
        DataGridView24.ReadOnly = True
        Dim JmlData24 As Integer
        JmlData24 = DataGridView24.RowCount
        Label24.Text = JmlData24 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'P' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView25.DataSource = DS.Tables(0)
        DataGridView25.ReadOnly = True
        Dim JmlData25 As Integer
        JmlData25 = DataGridView25.RowCount
        Label25.Text = JmlData25 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir < 17 AND jenis_kelamin = 'P' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView26.DataSource = DS.Tables(0)
        DataGridView26.ReadOnly = True
        Dim JmlData26 As Integer
        JmlData26 = DataGridView26.RowCount
        Label26.Text = JmlData26 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'P' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView27.DataSource = DS.Tables(0)
        DataGridView27.ReadOnly = True
        Dim JmlData27 As Integer
        JmlData27 = DataGridView27.RowCount
        Label27.Text = JmlData27 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir < 17 AND jenis_kelamin = 'P' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView28.DataSource = DS.Tables(0)
        DataGridView28.ReadOnly = True
        Dim JmlData28 As Integer
        JmlData28 = DataGridView28.RowCount
        Label28.Text = JmlData28 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox1.Text & "'AND t_lahir > 59 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView29.DataSource = DS.Tables(0)
        DataGridView29.ReadOnly = True
        Dim JmlData29 As Integer
        JmlData29 = DataGridView29.RowCount
        Label29.Text = JmlData29 - 1
    End Sub

    Sub tampilPendudukLantai()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.lantai = '" & ComboBox2.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        Label1.Text = JmlData - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_keluarga, tbl_unit WHERE tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.lantai = '" & ComboBox2.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim JmlData2 As Integer
        JmlData2 = DataGridView2.RowCount
        Label2.Text = JmlData2 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.lantai = '" & ComboBox2.Text & "' AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.lantai = '" & ComboBox2.Text & "' AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.lantai = '" & ComboBox2.Text & "' AND status_kawin = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.lantai = '" & ComboBox2.Text & "' AND status_kawin = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir < 6", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView7.DataSource = DS.Tables(0)
        DataGridView7.ReadOnly = True
        Dim JmlData7 As Integer
        JmlData7 = DataGridView7.RowCount
        Label7.Text = JmlData7 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir > 5 AND t_lahir < 13", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView8.DataSource = DS.Tables(0)
        DataGridView8.ReadOnly = True
        Dim JmlData8 As Integer
        JmlData8 = DataGridView8.RowCount
        Label8.Text = JmlData8 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir > 20 AND t_lahir < 51", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView9.DataSource = DS.Tables(0)
        DataGridView9.ReadOnly = True
        Dim JmlData9 As Integer
        JmlData9 = DataGridView9.RowCount
        Label9.Text = JmlData9 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir > 16", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView10.DataSource = DS.Tables(0)
        DataGridView10.ReadOnly = True
        Dim JmlData10 As Integer
        JmlData10 = DataGridView10.RowCount
        Label10.Text = JmlData10 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir > 59", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView11.DataSource = DS.Tables(0)
        DataGridView11.ReadOnly = True
        Dim JmlData11 As Integer
        JmlData11 = DataGridView11.RowCount
        Label11.Text = JmlData11 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir < 5 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView12.DataSource = DS.Tables(0)
        DataGridView12.ReadOnly = True
        Dim JmlData12 As Integer
        JmlData12 = DataGridView12.RowCount
        Label12.Text = JmlData12 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir > 5 AND t_lahir < 13 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView13.DataSource = DS.Tables(0)
        DataGridView13.ReadOnly = True
        Dim JmlData13 As Integer
        JmlData13 = DataGridView13.RowCount
        Label13.Text = JmlData13 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir > 20 AND t_lahir < 51 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView14.DataSource = DS.Tables(0)
        DataGridView14.ReadOnly = True
        Dim JmlData14 As Integer
        JmlData14 = DataGridView14.RowCount
        Label14.Text = JmlData14 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView15.DataSource = DS.Tables(0)
        DataGridView15.ReadOnly = True
        Dim JmlData15 As Integer
        JmlData15 = DataGridView15.RowCount
        Label15.Text = JmlData15 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'LK' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView16.DataSource = DS.Tables(0)
        DataGridView16.ReadOnly = True
        Dim JmlData16 As Integer
        JmlData16 = DataGridView16.RowCount
        Label16.Text = JmlData16 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir < 17 AND jenis_kelamin = 'LK' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView17.DataSource = DS.Tables(0)
        DataGridView17.ReadOnly = True
        Dim JmlData17 As Integer
        JmlData17 = DataGridView17.RowCount
        Label17.Text = JmlData17 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'LK' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView18.DataSource = DS.Tables(0)
        DataGridView18.ReadOnly = True
        Dim JmlData18 As Integer
        JmlData18 = DataGridView18.RowCount
        Label18.Text = JmlData18 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir < 17 AND jenis_kelamin = 'LK' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView19.DataSource = DS.Tables(0)
        DataGridView19.ReadOnly = True
        Dim JmlData19 As Integer
        JmlData19 = DataGridView19.RowCount
        Label19.Text = JmlData19 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir > 59 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView20.DataSource = DS.Tables(0)
        DataGridView20.ReadOnly = True
        Dim JmlData20 As Integer
        JmlData20 = DataGridView20.RowCount
        Label20.Text = JmlData20 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir < 5 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView21.DataSource = DS.Tables(0)
        DataGridView21.ReadOnly = True
        Dim JmlData21 As Integer
        JmlData21 = DataGridView21.RowCount
        Label21.Text = JmlData21 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir > 5 AND t_lahir < 13 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView22.DataSource = DS.Tables(0)
        DataGridView22.ReadOnly = True
        Dim JmlData22 As Integer
        JmlData22 = DataGridView22.RowCount
        Label22.Text = JmlData22 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "' AND t_lahir > 20 AND t_lahir < 51 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView23.DataSource = DS.Tables(0)
        DataGridView23.ReadOnly = True
        Dim JmlData23 As Integer
        JmlData23 = DataGridView23.RowCount
        Label23.Text = JmlData23 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView24.DataSource = DS.Tables(0)
        DataGridView24.ReadOnly = True
        Dim JmlData24 As Integer
        JmlData24 = DataGridView24.RowCount
        Label24.Text = JmlData24 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'P' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView25.DataSource = DS.Tables(0)
        DataGridView25.ReadOnly = True
        Dim JmlData25 As Integer
        JmlData25 = DataGridView25.RowCount
        Label25.Text = JmlData25 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir < 17 AND jenis_kelamin = 'P' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView26.DataSource = DS.Tables(0)
        DataGridView26.ReadOnly = True
        Dim JmlData26 As Integer
        JmlData26 = DataGridView26.RowCount
        Label26.Text = JmlData26 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir > 16 AND jenis_kelamin = 'P' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView27.DataSource = DS.Tables(0)
        DataGridView27.ReadOnly = True
        Dim JmlData27 As Integer
        JmlData27 = DataGridView27.RowCount
        Label27.Text = JmlData27 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir < 17 AND jenis_kelamin = 'P' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView28.DataSource = DS.Tables(0)
        DataGridView28.ReadOnly = True
        Dim JmlData28 As Integer
        JmlData28 = DataGridView28.RowCount
        Label28.Text = JmlData28 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE lantai = '" & ComboBox2.Text & "'AND t_lahir > 59 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView29.DataSource = DS.Tables(0)
        DataGridView29.ReadOnly = True
        Dim JmlData29 As Integer
        JmlData29 = DataGridView29.RowCount
        Label29.Text = JmlData29 - 1
    End Sub

    Sub tampilPendudukGedungLantai()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox3.Text & "' AND tbl_unit.lantai = '" & ComboBox4.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        Label1.Text = JmlData - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_keluarga, tbl_unit WHERE tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox3.Text & "' AND tbl_unit.lantai = '" & ComboBox4.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim JmlData2 As Integer
        JmlData2 = DataGridView2.RowCount
        Label2.Text = JmlData2 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox3.Text & "' AND tbl_unit.lantai = '" & ComboBox4.Text & "' AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox3.Text & "' AND tbl_unit.lantai = '" & ComboBox4.Text & "' AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox3.Text & "' AND tbl_unit.lantai = '" & ComboBox4.Text & "' AND status_kawin = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_penduduk, tbl_keluarga, tbl_unit WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.gedung = '" & ComboBox3.Text & "' AND tbl_unit.lantai = '" & ComboBox4.Text & "' AND status_kawin = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir < 6", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView7.DataSource = DS.Tables(0)
        DataGridView7.ReadOnly = True
        Dim JmlData7 As Integer
        JmlData7 = DataGridView7.RowCount
        Label7.Text = JmlData7 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 5 AND t_lahir < 13", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView8.DataSource = DS.Tables(0)
        DataGridView8.ReadOnly = True
        Dim JmlData8 As Integer
        JmlData8 = DataGridView8.RowCount
        Label8.Text = JmlData8 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 20 AND t_lahir < 51", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView9.DataSource = DS.Tables(0)
        DataGridView9.ReadOnly = True
        Dim JmlData9 As Integer
        JmlData9 = DataGridView9.RowCount
        Label9.Text = JmlData9 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 16", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView10.DataSource = DS.Tables(0)
        DataGridView10.ReadOnly = True
        Dim JmlData10 As Integer
        JmlData10 = DataGridView10.RowCount
        Label10.Text = JmlData10 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 59", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView11.DataSource = DS.Tables(0)
        DataGridView11.ReadOnly = True
        Dim JmlData11 As Integer
        JmlData11 = DataGridView11.RowCount
        Label11.Text = JmlData11 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir < 5 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView12.DataSource = DS.Tables(0)
        DataGridView12.ReadOnly = True
        Dim JmlData12 As Integer
        JmlData12 = DataGridView12.RowCount
        Label12.Text = JmlData12 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 5 AND t_lahir < 13 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView13.DataSource = DS.Tables(0)
        DataGridView13.ReadOnly = True
        Dim JmlData13 As Integer
        JmlData13 = DataGridView13.RowCount
        Label13.Text = JmlData13 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 20 AND t_lahir < 51 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView14.DataSource = DS.Tables(0)
        DataGridView14.ReadOnly = True
        Dim JmlData14 As Integer
        JmlData14 = DataGridView14.RowCount
        Label14.Text = JmlData14 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 16 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView15.DataSource = DS.Tables(0)
        DataGridView15.ReadOnly = True
        Dim JmlData15 As Integer
        JmlData15 = DataGridView15.RowCount
        Label15.Text = JmlData15 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 16 AND jenis_kelamin = 'LK' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView16.DataSource = DS.Tables(0)
        DataGridView16.ReadOnly = True
        Dim JmlData16 As Integer
        JmlData16 = DataGridView16.RowCount
        Label16.Text = JmlData16 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir < 17 AND jenis_kelamin = 'LK' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView17.DataSource = DS.Tables(0)
        DataGridView17.ReadOnly = True
        Dim JmlData17 As Integer
        JmlData17 = DataGridView17.RowCount
        Label17.Text = JmlData17 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 16 AND jenis_kelamin = 'LK' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView18.DataSource = DS.Tables(0)
        DataGridView18.ReadOnly = True
        Dim JmlData18 As Integer
        JmlData18 = DataGridView18.RowCount
        Label18.Text = JmlData18 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir < 17 AND jenis_kelamin = 'LK' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView19.DataSource = DS.Tables(0)
        DataGridView19.ReadOnly = True
        Dim JmlData19 As Integer
        JmlData19 = DataGridView19.RowCount
        Label19.Text = JmlData19 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 59 AND jenis_kelamin = 'LK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView20.DataSource = DS.Tables(0)
        DataGridView20.ReadOnly = True
        Dim JmlData20 As Integer
        JmlData20 = DataGridView20.RowCount
        Label20.Text = JmlData20 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir < 5 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView21.DataSource = DS.Tables(0)
        DataGridView21.ReadOnly = True
        Dim JmlData21 As Integer
        JmlData21 = DataGridView21.RowCount
        Label21.Text = JmlData21 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 5 AND t_lahir < 13 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView22.DataSource = DS.Tables(0)
        DataGridView22.ReadOnly = True
        Dim JmlData22 As Integer
        JmlData22 = DataGridView22.RowCount
        Label22.Text = JmlData22 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 20 AND t_lahir < 51 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView23.DataSource = DS.Tables(0)
        DataGridView23.ReadOnly = True
        Dim JmlData23 As Integer
        JmlData23 = DataGridView23.RowCount
        Label23.Text = JmlData23 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 16 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView24.DataSource = DS.Tables(0)
        DataGridView24.ReadOnly = True
        Dim JmlData24 As Integer
        JmlData24 = DataGridView24.RowCount
        Label24.Text = JmlData24 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 16 AND jenis_kelamin = 'P' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView25.DataSource = DS.Tables(0)
        DataGridView25.ReadOnly = True
        Dim JmlData25 As Integer
        JmlData25 = DataGridView25.RowCount
        Label25.Text = JmlData25 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir < 17 AND jenis_kelamin = 'P' AND status = 'K'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView26.DataSource = DS.Tables(0)
        DataGridView26.ReadOnly = True
        Dim JmlData26 As Integer
        JmlData26 = DataGridView26.RowCount
        Label26.Text = JmlData26 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 16 AND jenis_kelamin = 'P' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView27.DataSource = DS.Tables(0)
        DataGridView27.ReadOnly = True
        Dim JmlData27 As Integer
        JmlData27 = DataGridView27.RowCount
        Label27.Text = JmlData27 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir < 17 AND jenis_kelamin = 'P' AND status = 'BK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView28.DataSource = DS.Tables(0)
        DataGridView28.ReadOnly = True
        Dim JmlData28 As Integer
        JmlData28 = DataGridView28.RowCount
        Label28.Text = JmlData28 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM umur_p WHERE gedung = '" & ComboBox3.Text & "' AND lantai = '" & ComboBox4.Text & "' AND t_lahir > 59 AND jenis_kelamin = 'P'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView29.DataSource = DS.Tables(0)
        DataGridView29.ReadOnly = True
        Dim JmlData29 As Integer
        JmlData29 = DataGridView29.RowCount
        Label29.Text = JmlData29 - 1
    End Sub

    Sub tambahChart()
        Me.Chart1.Series("Penduduk").Points.AddXY("Penduduk", Label1.Text)
        Me.Chart1.Series("Kepala Keluarga").Points.AddXY("Kepala Keluarga", Label2.Text)
        Me.Chart1.Series("Jumlah Pria").Points.AddXY("Jumlah Pria", Label3.Text)
        Me.Chart1.Series("Jumlah Wanita").Points.AddXY("Jumlah Wanita", Label4.Text)
        Me.Chart1.Series("Kawin").Points.AddXY("Kawin", Label5.Text)
        Me.Chart1.Series("Belum Kawin").Points.AddXY("Belum Kawin", Label6.Text)
        Me.Chart1.Series("Jumlah Balita").Points.AddXY("Jumlah Balita", Label7.Text)
        Me.Chart1.Series("Jumlah Anak Diatas 5 Tahun").Points.AddXY("Jumlah Anak Diatas 5 Tahun", Label8.Text)
        Me.Chart1.Series("Usia Produktif").Points.AddXY("Jumlah Usia Produktif", Label9.Text)
        Me.Chart1.Series("17 Tahun Keatas").Points.AddXY("Jumlah Usia 17 Tahun Keatas", Label10.Text)
        Me.Chart1.Series("Lansia").Points.AddXY("Jumlah Usia 60 Tahun Keatas", Label11.Text)

        Me.Chart2.Series("Jumlah pria").Points.AddXY("Jumlah Pria", Label3.Text)
        Me.Chart2.Series("Balita laki-laki").Points.AddXY("Balita Laki-Laki", Label12.Text)
        Me.Chart2.Series("Anak laki-laki diatas 5 tahun").Points.AddXY("Anak Laki-laki Diatas 5 Tahun", Label13.Text)
        Me.Chart2.Series("Pria usia produktif").Points.AddXY("Pria Usia Produktif", Label14.Text)
        Me.Chart2.Series("Pria diatas 17 Tahun").Points.AddXY("Pria Diatas 17 Tahun", Label15.Text)
        Me.Chart2.Series("Pria menikah diatas 17 tahun").Points.AddXY("Pria Menikah Diatas 17 Tahun", Label16.Text)
        Me.Chart2.Series("Pria menikah dibawah 17 tahun").Points.AddXY("Pria Menikah Dibawah 17 Tahun", Label17.Text)
        Me.Chart2.Series("Pria belum menikah diatas 17 tahun").Points.AddXY("Pria Belum Menikah Diatas 17 Tahun", Label18.Text)
        Me.Chart2.Series("Pria belum menikah dibawah 17 tahun").Points.AddXY("Pria Belum Menikah Dibawah 17 Tahun", Label19.Text)
        Me.Chart2.Series("Pria diatas 60 tahun").Points.AddXY("Pria Diatas 60 Tahun", Label20.Text)

        Me.Chart3.Series("Jumlah wanita").Points.AddXY("jumlah Wanita", Label4.Text)
        Me.Chart3.Series("Balita perempuan").Points.AddXY("Balita Perempuan", Label21.Text)
        Me.Chart3.Series("Anak perempuan diatas 5 tahun").Points.AddXY("Anak Perempuan Diatas 5 Tahun", Label22.Text)
        Me.Chart3.Series("Wanita usia produktif").Points.AddXY("Wanita Usia Produktif", Label23.Text)
        Me.Chart3.Series("Wanita diatas 17 tahun").Points.AddXY("Wanita Diatas 17 Tahun", Label24.Text)
        Me.Chart3.Series("Wanita menikah diatas 17 tahun").Points.AddXY("Wanita Menikah Diatas 17 Tahun", Label25.Text)
        Me.Chart3.Series("Wanita menikah dibawah 17 tahun").Points.AddXY("Wnita Menikah Dibawah 17 Tahun", Label26.Text)
        Me.Chart3.Series("Wanita belum menikah diatas 17 tahun").Points.AddXY("Wanita Belum Menikah Diatas 17 Tahun", Label27.Text)
        Me.Chart3.Series("Wanita belum menikah dibawah 17 tahun").Points.AddXY("Wanita Belum Menikah Dibawah 17 Tahun", Label28.Text)
        Me.Chart3.Series("Wanita diatas 60 tahun").Points.AddXY("Wanita Diatas 60 Tahun", Label29.Text)

        Chart1.Visible = True
        Chart2.Visible = True
        Chart3.Visible = True
    End Sub

    Sub tambahSeries()
        Chart1.Series.Add("Penduduk")
        Chart1.Series.Add("Kepala Keluarga")
        Chart1.Series.Add("Jumlah Pria")
        Chart1.Series.Add("Jumlah Wanita")
        Chart1.Series.Add("Kawin")
        Chart1.Series.Add("Belum Kawin")
        Chart1.Series.Add("Jumlah Balita")
        Chart1.Series.Add("Jumlah Anak Diatas 5 Tahun")
        Chart1.Series.Add("Usia Produktif")
        Chart1.Series.Add("17 Tahun Keatas")
        Chart1.Series.Add("Lansia")

        Chart2.Series.Add("Jumlah pria")
        Chart2.Series.Add("Balita laki-laki")
        Chart2.Series.Add("Anak laki-laki diatas 5 tahun")
        Chart2.Series.Add("Pria usia produktif")
        Chart2.Series.Add("Pria diatas 17 Tahun")
        Chart2.Series.Add("Pria menikah diatas 17 tahun")
        Chart2.Series.Add("Pria menikah dibawah 17 tahun")
        Chart2.Series.Add("Pria belum menikah diatas 17 tahun")
        Chart2.Series.Add("Pria belum menikah dibawah 17 tahun")
        Chart2.Series.Add("Pria diatas 60 tahun")

        Chart3.Series.Add("Jumlah wanita")
        Chart3.Series.Add("Balita perempuan")
        Chart3.Series.Add("Anak perempuan diatas 5 tahun")
        Chart3.Series.Add("Wanita usia produktif")
        Chart3.Series.Add("Wanita diatas 17 tahun")
        Chart3.Series.Add("Wanita menikah diatas 17 tahun")
        Chart3.Series.Add("Wanita menikah dibawah 17 tahun")
        Chart3.Series.Add("Wanita belum menikah diatas 17 tahun")
        Chart3.Series.Add("Wanita belum menikah dibawah 17 tahun")
        Chart3.Series.Add("Wanita diatas 60 tahun")
    End Sub

    Sub kosongChart()
        Chart1.Series.Clear()
        Chart2.Series.Clear()
        Chart3.Series.Clear()
        Chart1.ResetText()
        Chart2.ResetText()
        Chart3.ResetText()

        tambahSeries()
    End Sub

    Private Sub LaporanPenduduk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kosongChart()
        tampilPenduduk()
        tambahChart()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        kosongChart()
        tampilPendudukGedung()
        tambahChart()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        kosongChart()
        tampilPendudukLantai()
        tambahChart()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kosongChart()
        tampilPendudukGedungLantai()
        tambahChart()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim SD As New SaveFileDialog
        
        SD.Filter = "PNG file|*.png"

        If SD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Chart1.SaveImage(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        Dim SD2 As New SaveFileDialog

        SD2.Filter = "PNG file|*.png"

        If SD2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Chart2.SaveImage(SD2.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        Dim SD3 As New SaveFileDialog

        SD3.Filter = "PNG file|*.png"

        If SD3.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Chart3.SaveImage(SD3.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class