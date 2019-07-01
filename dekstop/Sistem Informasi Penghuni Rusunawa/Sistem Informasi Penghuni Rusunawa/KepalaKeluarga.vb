Imports MySql.Data.MySqlClient
Imports System.IO
Public Class KepalaKeluarga
    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 145
        DataGridView1.Columns(1).Width = 185
        DataGridView1.Columns(2).Width = 70
        DataGridView1.Columns(3).Width = 110
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 70
        DataGridView1.Columns(6).Width = 77

        DataGridView1.Columns(0).HeaderText = "NIK"
        DataGridView1.Columns(1).HeaderText = "Nama Lengkap"
        DataGridView1.Columns(2).HeaderText = "Jenis Kelamin"
        DataGridView1.Columns(3).HeaderText = "Tempat Lahir"
        DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns(5).HeaderText = "Status Keluarga"
        DataGridView1.Columns(6).HeaderText = "Alamat Unit"

        DataGridView1.Visible = True
    End Sub

    Sub tampilSeluruhData()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_penduduk.nik, tbl_penduduk.nama, tbl_penduduk.jenis_kelamin, tbl_penduduk.tmpt_lahir, tbl_penduduk.tgl_lahir, tbl_penduduk.status_kk, tbl_unit.id_unit, tbl_pembayaran.keterangan FROM tbl_penduduk, tbl_unit, tbl_keluarga, tbl_pembayaran WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_penduduk.status_kk = 'KK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilSeluruhDataGedung()
        If ComboBox5.Text = "" Or ComboBox5.Text = "Keterangan" Then
            koneksi()
            DA = New MySqlDataAdapter("SELECT tbl_penduduk.nik, tbl_penduduk.nama, tbl_penduduk.jenis_kelamin, tbl_penduduk.tmpt_lahir, tbl_penduduk.tgl_lahir, tbl_penduduk.status_kk, tbl_unit.id_unit, tbl_pembayaran.keterangan FROM tbl_penduduk, tbl_unit, tbl_keluarga, tbl_pembayaran WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_penduduk.status_kk = 'KK' AND tbl_unit.gedung ='" & ComboBox1.Text & "'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.ReadOnly = True
            DataGridView1.Visible = True
        Else
            koneksi()
            DA = New MySqlDataAdapter("SELECT tbl_penduduk.nik, tbl_penduduk.nama, tbl_penduduk.jenis_kelamin, tbl_penduduk.tmpt_lahir, tbl_penduduk.tgl_lahir, tbl_penduduk.status_kk, tbl_unit.id_unit, tbl_pembayaran.keterangan FROM tbl_penduduk, tbl_unit, tbl_keluarga, tbl_pembayaran WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_penduduk.status_kk = 'KK' AND tbl_unit.gedung ='" & ComboBox1.Text & "' AND tbl_pembayaran.keterangan ='" & ComboBox5.Text & "'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.ReadOnly = True
            DataGridView1.Visible = True
        End If
        
    End Sub

    Sub tampilSeluruhDataLantai()
        If ComboBox6.Text = "" Or ComboBox6.Text = "Keterangan" Then
            koneksi()
            DA = New MySqlDataAdapter("SELECT tbl_penduduk.nik, tbl_penduduk.nama, tbl_penduduk.jenis_kelamin, tbl_penduduk.tmpt_lahir, tbl_penduduk.tgl_lahir, tbl_penduduk.status_kk, tbl_unit.id_unit, tbl_pembayaran.keterangan FROM tbl_penduduk, tbl_unit, tbl_keluarga, tbl_pembayaran WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_penduduk.status_kk = 'KK' AND tbl_unit.lantai ='" & ComboBox2.Text & "'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.ReadOnly = True
            DataGridView1.Visible = True
        Else
            koneksi()
            DA = New MySqlDataAdapter("SELECT tbl_penduduk.nik, tbl_penduduk.nama, tbl_penduduk.jenis_kelamin, tbl_penduduk.tmpt_lahir, tbl_penduduk.tgl_lahir, tbl_penduduk.status_kk, tbl_unit.id_unit, tbl_pembayaran.keterangan FROM tbl_penduduk, tbl_unit, tbl_keluarga, tbl_pembayaran WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_penduduk.status_kk = 'KK' AND tbl_unit.lantai ='" & ComboBox2.Text & "' AND tbl_pembayaran.keterangan ='" & ComboBox6.Text & "'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.ReadOnly = True
            DataGridView1.Visible = True
        End If
    End Sub

    Sub tampilSeluruhDataGedungLantai()
        If ComboBox7.Text = "" Or ComboBox7.Text = "Keterangan" Then
            koneksi()
            DA = New MySqlDataAdapter("SELECT tbl_penduduk.nik, tbl_penduduk.nama, tbl_penduduk.jenis_kelamin, tbl_penduduk.tmpt_lahir, tbl_penduduk.tgl_lahir, tbl_penduduk.status_kk, tbl_unit.id_unit, tbl_pembayaran.keterangan FROM tbl_penduduk, tbl_unit, tbl_keluarga, tbl_pembayaran WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_penduduk.status_kk = 'KK' AND tbl_unit.gedung = '" & ComboBox3.Text & "' AND tbl_unit.lantai = '" & ComboBox4.Text & "'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.ReadOnly = True
            DataGridView1.Visible = True
        Else
            koneksi()
            DA = New MySqlDataAdapter("SELECT tbl_penduduk.nik, tbl_penduduk.nama, tbl_penduduk.jenis_kelamin, tbl_penduduk.tmpt_lahir, tbl_penduduk.tgl_lahir, tbl_penduduk.status_kk, tbl_unit.id_unit, tbl_pembayaran.keterangan FROM tbl_penduduk, tbl_unit, tbl_keluarga, tbl_pembayaran WHERE tbl_penduduk.id_kk = tbl_keluarga.id_kk AND tbl_keluarga.id_penghuni = tbl_unit.id_unit AND tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_penduduk.status_kk = 'KK' AND tbl_unit.gedung = '" & ComboBox3.Text & "' AND tbl_unit.lantai = '" & ComboBox4.Text & "' AND tbl_pembayaran.keterangan ='" & ComboBox7.Text & "'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.ReadOnly = True
            DataGridView1.Visible = True
        End If
    End Sub

    Private Sub KepalaKeluarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        DataGridView1.Visible = False
    End Sub

    Private Sub TabelPenduduk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        DataGridView1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tampilSeluruhData()
        kolomGrid()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DataGridView1.RowCount = 0 Then Return

        Button5.Text = "Please Wait..."
        Button5.Enabled = False
        Application.DoEvents()

        Dim xlApp As New Microsoft.Office.Interop.Excel.Application

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        Try
            With xlApp

                .Workbooks.Open(Application.StartupPath & "\Kepala Keluarga.xltx")

                'data
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    .Range("B" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(0).Value
                    .Range("C" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(1).Value
                    .Range("D" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(2).Value
                    .Range("E" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(3).Value
                    .Range("F" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(4).Value
                    .Range("G" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(5).Value
                    .Range("H" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(6).Value
                    .Range("I" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(7).Value
                Next

                .Range("B5").Select()
                .Visible = True
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            xlApp.ActiveWorkbook.Close(False)
        End Try

        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

        Button5.Text = "Export"
        Button5.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampilSeluruhDataGedung()
        kolomGrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tampilSeluruhDataLantai()
        kolomGrid()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        tampilSeluruhDataGedungLantai()
        kolomGrid()
    End Sub
End Class