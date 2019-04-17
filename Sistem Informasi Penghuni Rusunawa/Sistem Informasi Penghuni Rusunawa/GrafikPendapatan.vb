Imports MySql.Data.MySqlClient
Public Class GrafikPendapatan

    Sub pendapatanSemua()
        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim x As Integer
        For line As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(line).Cells(0).Value
        Next
        Label1.Text = x

        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim y As Integer
        For line As Integer = 0 To DataGridView2.RowCount - 1
            y = y + DataGridView2.Rows(line).Cells(0).Value
        Next
        Label2.Text = y

        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE keterangan NOT LIKE 'LUNAS%'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim z As Integer
        For line As Integer = 0 To DataGridView3.RowCount - 1
            z = z + DataGridView3.Rows(line).Cells(0).Value
        Next
        Label3.Text = z
    End Sub

    Sub pendapatanGedung()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.jumlah FROM tbl_pembayaran, tbl_unit WHERE tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_unit.gedung = '" & ComboBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim x As Integer
        For line As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(line).Cells(0).Value
        Next
        Label1.Text = x

        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.jumlah FROM tbl_pembayaran, tbl_unit WHERE tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_unit.gedung = '" & ComboBox1.Text & "' AND keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim y As Integer
        For line As Integer = 0 To DataGridView2.RowCount - 1
            y = y + DataGridView2.Rows(line).Cells(0).Value
        Next
        Label2.Text = y

        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.jumlah FROM tbl_pembayaran, tbl_unit WHERE tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_unit.gedung = '" & ComboBox1.Text & "' AND keterangan NOT LIKE 'LUNAS%'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim z As Integer
        For line As Integer = 0 To DataGridView3.RowCount - 1
            z = z + DataGridView3.Rows(line).Cells(0).Value
        Next
        Label3.Text = z
    End Sub

    Sub pendapatanTanggal()
        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE  tgl_transaksi > '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND tgl_transaksi < '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim x As Integer
        For line As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(line).Cells(0).Value
        Next
        Label1.Text = x

        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE tgl_transaksi > '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND tgl_transaksi < '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' AND keterangan = 'LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim y As Integer
        For line As Integer = 0 To DataGridView2.RowCount - 1
            y = y + DataGridView2.Rows(line).Cells(0).Value
        Next
        Label2.Text = y

        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE tgl_transaksi > '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND tgl_transaksi < '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' AND keterangan NOT LIKE 'LUNAS%'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim z As Integer
        For line As Integer = 0 To DataGridView3.RowCount - 1
            z = z + DataGridView3.Rows(line).Cells(0).Value
        Next
        Label3.Text = z
    End Sub

    Sub pendapatanBulan()
        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE bulan = '" & DateTimePicker3.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim x As Integer
        For line As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(line).Cells(0).Value
        Next
        Label1.Text = x

        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE keterangan = 'LUNAS' AND bulan = '" & DateTimePicker3.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim y As Integer
        For line As Integer = 0 To DataGridView2.RowCount - 1
            y = y + DataGridView2.Rows(line).Cells(0).Value
        Next
        Label2.Text = y

        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE keterangan NOT LIKE 'LUNAS%' AND bulan = '" & DateTimePicker3.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim z As Integer
        For line As Integer = 0 To DataGridView3.RowCount - 1
            z = z + DataGridView3.Rows(line).Cells(0).Value
        Next
        Label3.Text = z
    End Sub

    Sub pendapatanTahun()
        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE year(tgl_transaksi) = '" & DateTimePicker4.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim x As Integer
        For line As Integer = 0 To DataGridView1.RowCount - 1
            x = x + DataGridView1.Rows(line).Cells(0).Value
        Next
        Label1.Text = x

        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE keterangan = 'LUNAS' AND year(tgl_transaksi) = '" & DateTimePicker4.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim y As Integer
        For line As Integer = 0 To DataGridView2.RowCount - 1
            y = y + DataGridView2.Rows(line).Cells(0).Value
        Next
        Label2.Text = y

        koneksi()
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran WHERE keterangan NOT LIKE 'LUNAS%' AND year(tgl_transaksi) = '" & DateTimePicker4.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim z As Integer
        For line As Integer = 0 To DataGridView3.RowCount - 1
            z = z + DataGridView3.Rows(line).Cells(0).Value
        Next
        Label3.Text = z
    End Sub

    Sub tambahChart()
        Me.Chart1.Series("Pendapatan Seharusnya").Points.AddXY("Grafik Pendapatan Sewa Rusunawa", Label1.Text)
        Me.Chart1.Series("Pendapatan Sekarang").Points.AddXY("Pendapatan Sekarang", Label2.Text)
        Me.Chart1.Series("Pendapatan Tertunda").Points.AddXY("Pendapatan Tertunda", Label3.Text)

        Chart1.Visible = True
    End Sub

    Sub tambahSeries()
        Chart1.Series.Add("Pendapatan Seharusnya")
        Chart1.Series.Add("Pendapatan Sekarang")
        Chart1.Series.Add("Pendapatan Tertunda")
    End Sub

    Sub kosongChart()
        Chart1.Series.Clear()

        tambahSeries()
    End Sub

    Private Sub GrafikPendapatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Chart1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kosongChart()
        pendapatanSemua()
        tambahChart()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        kosongChart()
        pendapatanGedung()
        tambahChart()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        kosongChart()
        pendapatanTanggal()
        tambahChart()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        kosongChart()
        pendapatanBulan()
        tambahChart()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kosongChart()
        pendapatanTahun()
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