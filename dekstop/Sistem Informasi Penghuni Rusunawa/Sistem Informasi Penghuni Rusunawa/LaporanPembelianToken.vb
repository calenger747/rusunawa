Imports MySql.Data.MySqlClient
Imports System.IO
Public Class LaporanPembelianToken

    Sub tampilSemua()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembelian_token.no_transaksi, tbl_pembelian_token.tgl_bayar, tbl_token.id_penghuni, tbl_unit.unit, tbl_unit.no_kwh, tbl_token.harga_token, tbl_token.jumlah_kwh, tbl_token.tax, tbl_pembelian_token.total_bayar, tbl_token.no_token FROM tbl_pembelian_token, tbl_token, tbl_unit WHERE tbl_pembelian_token.id_token = tbl_token.id AND tbl_token.id_penghuni = tbl_unit.id_unit", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilTahun()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembelian_token.no_transaksi, tbl_pembelian_token.tgl_bayar, tbl_token.id_penghuni, tbl_unit.unit, tbl_unit.no_kwh, tbl_token.harga_token, tbl_token.jumlah_kwh, tbl_token.tax, tbl_pembelian_token.total_bayar, tbl_token.no_token FROM tbl_pembelian_token, tbl_token, tbl_unit WHERE tbl_pembelian_token.id_token = tbl_token.id AND tbl_token.id_penghuni = tbl_unit.id_unit AND year(tbl_pembelian_token.tgl_transaksi) = '" & DateTimePicker1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilBulan()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembelian_token.no_transaksi, tbl_pembelian_token.tgl_bayar, tbl_token.id_penghuni, tbl_unit.unit, tbl_unit.no_kwh, tbl_token.harga_token, tbl_token.jumlah_kwh, tbl_token.tax, tbl_pembelian_token.total_bayar, tbl_token.no_token FROM tbl_pembelian_token, tbl_token, tbl_unit WHERE tbl_pembelian_token.id_token = tbl_token.id AND tbl_token.id_penghuni = tbl_unit.id_unit AND month(tbl_pembelian_token.tgl_transaksi) = '" & DateTimePicker2.Text & "' AND year(tbl_pembelian_token.tgl_transaksi) = '" & DateTimePicker3.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilPeriode()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembelian_token.no_transaksi, tbl_pembelian_token.tgl_bayar, tbl_token.id_penghuni, tbl_unit.unit, tbl_unit.no_kwh, tbl_token.harga_token, tbl_token.jumlah_kwh, tbl_token.tax, tbl_pembelian_token.total_bayar, tbl_token.no_token FROM tbl_pembelian_token, tbl_token, tbl_unit WHERE tbl_pembelian_token.id_token = tbl_token.id AND tbl_token.id_penghuni = tbl_unit.id_unit AND tbl_pembelian_token.tgl_transaksi BETWEEN '" & DateTimePicker4.Text & "' AND '" & DateTimePicker5.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 145
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 140
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 70
        DataGridView1.Columns(7).Width = 70
        DataGridView1.Columns(8).Width = 100
        DataGridView1.Columns(9).Width = 200

        DataGridView1.Columns(0).HeaderText = "No. Transaksi"
        DataGridView1.Columns(1).HeaderText = "Tanggal Transaksi"
        DataGridView1.Columns(2).HeaderText = "ID Penghuni"
        DataGridView1.Columns(3).HeaderText = "Unit"
        DataGridView1.Columns(4).HeaderText = "No Meter"
        DataGridView1.Columns(5).HeaderText = "Harga Token"
        DataGridView1.Columns(6).HeaderText = "Jumlah KWH"
        DataGridView1.Columns(7).HeaderText = "Tax (%)"
        DataGridView1.Columns(8).HeaderText = "Total Harga"
        DataGridView1.Columns(9).HeaderText = "No Token"

        DataGridView1.Visible = True
    End Sub

    Private Sub LaporanPembelianToken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        DataGridView1.Columns.Clear()
        DataGridView1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tampilSemua()
        kolomGrid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampilTahun()
        kolomGrid()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        tampilBulan()
        kolomGrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tampilPeriode()
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

                .Workbooks.Open(Application.StartupPath & "\Pembelian Token.xltx")

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
                    .Range("J" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(8).Value
                    .Range("K" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(9).Value
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
End Class