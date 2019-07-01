Imports MySql.Data.MySqlClient
Imports System.IO
Public Class LaporanPembayaranSewa

    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 145
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 140
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 113

        DataGridView1.Columns(0).HeaderText = "No. Transaksi"
        DataGridView1.Columns(1).HeaderText = "Tanggal Transaksi"
        DataGridView1.Columns(2).HeaderText = "ID Penghuni"
        DataGridView1.Columns(3).HeaderText = "Unit"
        DataGridView1.Columns(4).HeaderText = "Pembayaran Bulan"
        DataGridView1.Columns(5).HeaderText = "Jumlah"
        DataGridView1.Columns(6).HeaderText = "Keterangan"

        DataGridView1.Visible = True
    End Sub

    Sub tampilSemua()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.no_transaksi, tbl_pembayaran.tgl_transaksi, tbl_pembayaran.id_pelanggan, tbl_unit.unit, tbl_pembayaran.bulan, tbl_pembayaran.jumlah, tbl_pembayaran.keterangan FROM tbl_pembayaran, tbl_unit WHERE tbl_pembayaran.id_pelanggan = tbl_unit.id_unit AND tbl_pembayaran.keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilSemuaGedung()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.no_transaksi, tbl_pembayaran.tgl_transaksi, tbl_pembayaran.id_pelanggan, tbl_unit.unit, tbl_pembayaran.bulan, tbl_pembayaran.jumlah, tbl_pembayaran.keterangan FROM tbl_pembayaran, tbl_unit WHERE tbl_pembayaran.id_pelanggan = tbl_unit.id_unit AND tbl_pembayaran.keterangan = 'LUNAS' AND tbl_unit.gedung = '" & ComboBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilSemuaLantai()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.no_transaksi, tbl_pembayaran.tgl_transaksi, tbl_pembayaran.id_pelanggan, tbl_unit.unit, tbl_pembayaran.bulan, tbl_pembayaran.jumlah, tbl_pembayaran.keterangan FROM tbl_pembayaran, tbl_unit WHERE tbl_pembayaran.id_pelanggan = tbl_unit.id_unit AND tbl_pembayaran.keterangan = 'LUNAS' AND tbl_unit.lantai = '" & ComboBox2.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilSemuaGedungLantai()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.no_transaksi, tbl_pembayaran.tgl_transaksi, tbl_pembayaran.id_pelanggan, tbl_unit.unit, tbl_pembayaran.bulan, tbl_pembayaran.jumlah, tbl_pembayaran.keterangan FROM tbl_pembayaran, tbl_unit WHERE tbl_pembayaran.id_pelanggan = tbl_unit.id_unit AND tbl_pembayaran.keterangan = 'LUNAS' AND tbl_unit.gedung = '" & ComboBox3.Text & "' AND tbl_unit.lantai = '" & ComboBox4.Text & "' ", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilSemuaKet()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.no_transaksi, tbl_pembayaran.tgl_transaksi, tbl_pembayaran.id_pelanggan, tbl_unit.unit, tbl_pembayaran.bulan, tbl_pembayaran.jumlah, tbl_pembayaran.keterangan FROM tbl_pembayaran, tbl_unit WHERE tbl_pembayaran.id_pelanggan = tbl_unit.id_unit AND tbl_pembayaran.keterangan = '" & ComboBox5.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilSemuaID()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.no_transaksi, tbl_pembayaran.tgl_transaksi, tbl_pembayaran.id_pelanggan, tbl_unit.unit, tbl_pembayaran.bulan, tbl_pembayaran.jumlah, tbl_pembayaran.keterangan FROM tbl_pembayaran, tbl_unit WHERE tbl_pembayaran.id_pelanggan = tbl_unit.id_unit AND tbl_pembayaran.id_pelanggan = '" & TextBox1.Text & "' ", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Private Sub LaporanPembayaranSewa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        DataGridView1.Columns.Clear()
        DataGridView1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tampilSemua()
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

                .Workbooks.Open(Application.StartupPath & "\Pembayaran Sewa.xltx")

                'data
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    .Range("B" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(0).Value
                    .Range("C" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(1).Value
                    .Range("D" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(2).Value
                    .Range("E" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(3).Value
                    .Range("F" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(4).Value
                    .Range("G" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(5).Value
                    .Range("H" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(6).Value
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
        tampilSemuaGedung()
        kolomGrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tampilSemuaLantai()
        kolomGrid()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        tampilSemuaGedungLantai()
        kolomGrid()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tampilSemuaKet()
        kolomGrid()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            tampilSemuaID()
            kolomGrid()
        End If
    End Sub
End Class