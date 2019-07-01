Imports MySql.Data.MySqlClient
Public Class GrafikSewa

    Sub tampilSewa()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        Label1.Text = JmlData - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Isi'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim JmlData2 As Integer
        JmlData2 = DataGridView2.RowCount
        Label2.Text = JmlData2 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Kosong'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Booking'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView8.DataSource = DS.Tables(0)
        DataGridView8.ReadOnly = True
        Dim JmlData8 As Integer
        JmlData8 = DataGridView8.RowCount
        Label8.Text = JmlData8 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Ringan'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView9.DataSource = DS.Tables(0)
        DataGridView9.ReadOnly = True
        Dim JmlData9 As Integer
        JmlData9 = DataGridView9.RowCount
        Label9.Text = JmlData9 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Berat'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView10.DataSource = DS.Tables(0)
        DataGridView10.ReadOnly = True
        Dim JmlData10 As Integer
        JmlData10 = DataGridView10.RowCount
        Label10.Text = JmlData10 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE keterangan = 'BELUM BAYAR'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE keterangan = 'MENUNGGAK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView7.DataSource = DS.Tables(0)
        DataGridView7.ReadOnly = True
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView7.Rows.Count - 1
            total = total + Val(DataGridView7.Rows(t).Cells(5).Value)
            '-----------cell 2 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        Label7.Text = total
    End Sub

    Sub tampilSewaTanggal()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        Label1.Text = JmlData - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Isi'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim JmlData2 As Integer
        JmlData2 = DataGridView2.RowCount
        Label2.Text = JmlData2 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Kosong'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Booking'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView8.DataSource = DS.Tables(0)
        DataGridView8.ReadOnly = True
        Dim JmlData8 As Integer
        JmlData8 = DataGridView8.RowCount
        Label8.Text = JmlData8 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Ringan'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView9.DataSource = DS.Tables(0)
        DataGridView9.ReadOnly = True
        Dim JmlData9 As Integer
        JmlData9 = DataGridView9.RowCount
        Label9.Text = JmlData9 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Berat'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView10.DataSource = DS.Tables(0)
        DataGridView10.ReadOnly = True
        Dim JmlData10 As Integer
        JmlData10 = DataGridView10.RowCount
        Label10.Text = JmlData10 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE tgl_transaksi > '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND tgl_transaksi < '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' AND keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE tgl_transaksi > '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND tgl_transaksi < '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' AND keterangan = 'BELUM BAYAR'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE tgl_transaksi > '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND tgl_transaksi < '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' AND keterangan = 'MENUNGGAK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE tgl_transaksi > '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND tgl_transaksi < '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' AND keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView7.DataSource = DS.Tables(0)
        DataGridView7.ReadOnly = True
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView7.Rows.Count - 1
            total = total + Val(DataGridView7.Rows(t).Cells(5).Value)
            '-----------cell 2 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        Label7.Text = total
    End Sub

    Sub tampilSewaBulan()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        Label1.Text = JmlData - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Isi'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim JmlData2 As Integer
        JmlData2 = DataGridView2.RowCount
        Label2.Text = JmlData2 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Kosong'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Booking'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView8.DataSource = DS.Tables(0)
        DataGridView8.ReadOnly = True
        Dim JmlData8 As Integer
        JmlData8 = DataGridView8.RowCount
        Label8.Text = JmlData8 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Ringan'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView9.DataSource = DS.Tables(0)
        DataGridView9.ReadOnly = True
        Dim JmlData9 As Integer
        JmlData9 = DataGridView9.RowCount
        Label9.Text = JmlData9 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Berat'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView10.DataSource = DS.Tables(0)
        DataGridView10.ReadOnly = True
        Dim JmlData10 As Integer
        JmlData10 = DataGridView10.RowCount
        Label10.Text = JmlData10 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE keterangan = 'LUNAS' AND bulan = '" & DateTimePicker3.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE keterangan = 'BELUM BAYAR' AND bulan = '" & DateTimePicker3.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE keterangan = 'MENUNGGAK' AND bulan = '" & DateTimePicker3.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE keterangan = 'LUNAS' AND bulan = '" & DateTimePicker3.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView7.DataSource = DS.Tables(0)
        DataGridView7.ReadOnly = True
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView7.Rows.Count - 1
            total = total + Val(DataGridView7.Rows(t).Cells(5).Value)
            '-----------cell 2 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        Label7.Text = total
    End Sub

    Sub tampilSewaTahun()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        Label1.Text = JmlData - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Isi'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim JmlData2 As Integer
        JmlData2 = DataGridView2.RowCount
        Label2.Text = JmlData2 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Kosong'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Booking'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView8.DataSource = DS.Tables(0)
        DataGridView8.ReadOnly = True
        Dim JmlData8 As Integer
        JmlData8 = DataGridView8.RowCount
        Label8.Text = JmlData8 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Ringan'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView9.DataSource = DS.Tables(0)
        DataGridView9.ReadOnly = True
        Dim JmlData9 As Integer
        JmlData9 = DataGridView9.RowCount
        Label9.Text = JmlData9 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Berat'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView10.DataSource = DS.Tables(0)
        DataGridView10.ReadOnly = True
        Dim JmlData10 As Integer
        JmlData10 = DataGridView10.RowCount
        Label10.Text = JmlData10 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE year(tgl_transaksi) = '" & DateTimePicker4.Text & "' AND keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE year(jatuh_tempo) = '" & DateTimePicker4.Text & "' AND keterangan = 'BELUM BAYAR'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE year(jatuh_tempo) = '" & DateTimePicker4.Text & "' AND keterangan = 'MENUNGGAK'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_pembayaran WHERE year(tgl_transaksi) = '" & DateTimePicker4.Text & "' AND keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView7.DataSource = DS.Tables(0)
        DataGridView7.ReadOnly = True
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView7.Rows.Count - 1
            total = total + Val(DataGridView7.Rows(t).Cells(5).Value)
            '-----------cell 2 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        Label7.Text = total
    End Sub

    Sub tambahChart()
        Me.Chart1.Series("Unit").Points.AddXY("Grafik Pembayaran Sewa Rusunawa", Label1.Text)
        Me.Chart1.Series("Unit Terisi").Points.AddXY("Unit Terisi", Label2.Text)
        Me.Chart1.Series("Unit Kosong").Points.AddXY("Unit Kosong", Label3.Text)
        Me.Chart1.Series("Unit Terbooking").Points.AddXY("Unit Terbooking", Label8.Text)
        Me.Chart1.Series("Unit Rusak Ringan").Points.AddXY("Unit Rusak Ringan", Label9.Text)
        Me.Chart1.Series("Unit Rusak Berat").Points.AddXY("Unit Rusak Berat", Label10.Text)
        Me.Chart1.Series("Transaksi Lunas").Points.AddXY("Transaksi Lunas", Label4.Text)
        Me.Chart1.Series("Transaksi Belum Terbayar").Points.AddXY("Transaksi Belum Terbayar", Label5.Text)
        Me.Chart1.Series("Transaksi Menunggak").Points.AddXY("Transaksi Menunggak", Label6.Text)

        Chart1.Visible = True
    End Sub

    Sub tambahSeries()
        Chart1.Series.Add("Unit")
        Chart1.Series.Add("Unit Terisi")
        Chart1.Series.Add("Unit Kosong")
        Chart1.Series.Add("Unit Terbooking")
        Chart1.Series.Add("Unit Rusak Ringan")
        Chart1.Series.Add("Unit Rusak Berat")
        Chart1.Series.Add("Transaksi Lunas")
        Chart1.Series.Add("Transaksi Belum Terbayar")
        Chart1.Series.Add("Transaksi Menunggak")
    End Sub

    Sub kosongChart()
        Chart1.Series.Clear()

        tambahSeries()
    End Sub

    Private Sub GrafikSewa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Chart1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kosongChart()
        tampilSewa()
        tambahChart()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kosongChart()
        tampilSewaTahun()
        tambahChart()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        kosongChart()
        tampilSewaBulan()
        tambahChart()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        kosongChart()
        tampilSewaTanggal()
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
    End Sub
End Class