Imports MySql.Data.MySqlClient
Public Class GrafikPendapatan

    Sub pendapatanSemua()
        koneksi()
        CMD = New MySqlCommand("SELECT SUM(harga) FROM tbl_unit", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not IsDBNull(DR.Item(0)) Then
            Label4.Text = DR.Item(0)
        Else
            Label4.Text = "0"
        End If
        
        koneksi()
        CMD = New MySqlCommand("SELECT SUM(harga) FROM tbl_unit WHERE status != 'Rusak Ringan' AND status != 'Rusak Berat'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not IsDBNull(DR.Item(0)) Then
            Label5.Text = DR.Item(0)
        Else
            Label5.Text = "0"
        End If

        koneksi()
        CMD = New MySqlCommand("SELECT SUM(harga) FROM tbl_unit WHERE status = 'Isi'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not IsDBNull(DR.Item(0)) Then
            Label1.Text = DR.Item(0)
        Else
            Label1.Text = "0"
        End If
        
        koneksi()
        CMD = New MySqlCommand("SELECT SUM(jumlah) FROM tbl_pembayaran JOIN tbl_unit ON tbl_pembayaran.id_pelanggan = tbl_unit.id_unit WHERE tbl_pembayaran.keterangan = 'LUNAS' AND tbl_pembayaran.bulan = '" & DateTimePicker1.Text & "' AND tbl_unit.status = 'Isi'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not IsDBNull(DR.Item(0)) Then
            Label2.Text = DR.Item(0)
        Else
            Label2.Text = "0"
        End If

        koneksi()
        CMD = New MySqlCommand("SELECT SUM(jumlah) FROM tbl_pembayaran JOIN tbl_unit ON tbl_pembayaran.id_pelanggan = tbl_unit.id_unit WHERE tbl_pembayaran.keterangan != 'LUNAS' AND tbl_pembayaran.bulan = '" & DateTimePicker1.Text & "' AND tbl_unit.status = 'Isi'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not IsDBNull(DR.Item(0)) Then
            Label3.Text = DR.Item(0)
        Else
            Label3.Text = "0"
        End If
    End Sub

    Sub pendapatanGedung()
        koneksi()
        DA = New MySqlDataAdapter("SELECT harga FROM tbl_unit WHERE gedung = '" & ComboBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim a As Integer
        For line As Integer = 0 To DataGridView4.RowCount - 1
            a = a + DataGridView4.Rows(line).Cells(0).Value
        Next
        Label4.Text = a

        koneksi()
        DA = New MySqlDataAdapter("SELECT harga FROM tbl_unit WHERE gedung = '" & ComboBox1.Text & "' AND status != 'Rusak Ringan' AND status != 'Rusak Berat'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim b As Integer
        For line As Integer = 0 To DataGridView5.RowCount - 1
            b = b + DataGridView5.Rows(line).Cells(0).Value
        Next
        Label5.Text = b

        koneksi()
        DA = New MySqlDataAdapter("SELECT harga FROM tbl_unit WHERE status = 'Isi' AND gedung = '" & ComboBox1.Text & "'", CONN)
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
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran JOIN tbl_unit ON tbl_pembayaran.id_pelanggan = tbl_unit.id_unit WHERE tbl_pembayaran.keterangan = 'LUNAS' AND tbl_unit.gedung = '" & ComboBox1.Text & "' AND tbl_pembayaran.bulan = '" & DateTimePicker1.Text & "' AND tbl_unit.status = 'Isi'", CONN)
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
        DA = New MySqlDataAdapter("SELECT jumlah FROM tbl_pembayaran JOIN tbl_unit ON tbl_pembayaran.id_pelanggan = tbl_unit.id_unit WHERE tbl_pembayaran.keterangan != 'LUNAS' AND tbl_unit.gedung = '" & ComboBox1.Text & "' AND tbl_pembayaran.bulan = '" & DateTimePicker1.Text & "' AND tbl_unit.status = 'Isi'", CONN)
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
        Me.Chart1.Series("Pendapatan Maksimal (" + Format(Val(Label4.Text), "Rp, ###,###.#0") + ")").Points.AddXY("Grafik Pendapatan Sewa Rusunawa", Label4.Text)
        Me.Chart1.Series("Pendapatan Optimal (" + Format(Val(Label5.Text), "Rp, ###,###.#0") + ")").Points.AddXY("Pendapatan Optimal", Label5.Text)
        Me.Chart1.Series("Realisasi Pendapatan (" + Format(Val(Label1.Text), "Rp, ###,###.#0") + ")").Points.AddXY("Realisasi Pendapatan", Label1.Text)
        Me.Chart1.Series("Pendapatan Real (" + Format(Val(Label2.Text), "Rp, ###,###.#0") + ")").Points.AddXY("Pendapatan Real", Label2.Text)
        Me.Chart1.Series("Pendapatan Tertunggak (" + Format(Val(Label3.Text), "Rp, ###,###.#0") + ")").Points.AddXY("Pendapatan Tertunggak", Label3.Text)

        Chart1.Visible = True
    End Sub

    Sub tambahSeries()
        Chart1.Series.Add("Pendapatan Maksimal (" + Format(Val(Label4.Text), "Rp, ###,###.#0") + ")")
        Chart1.Series.Add("Pendapatan Optimal (" + Format(Val(Label5.Text), "Rp, ###,###.#0") + ")")
        Chart1.Series.Add("Realisasi Pendapatan (" + Format(Val(Label1.Text), "Rp, ###,###.#0") + ")")
        Chart1.Series.Add("Pendapatan Real (" + Format(Val(Label2.Text), "Rp, ###,###.#0") + ")")
        Chart1.Series.Add("Pendapatan Tertunggak (" + Format(Val(Label3.Text), "Rp, ###,###.#0") + ")")
    End Sub

    Sub kosongChart()
        Chart1.Series.Clear()
    End Sub

    Private Sub GrafikPendapatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Chart1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kosongChart()
        pendapatanSemua()
        tambahSeries()
        tambahChart()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ComboBox1.Text = "" Or ComboBox1.Text = "Gedung" Then
            MsgBox("Pilih Gedung Terlebih Dahulu", MsgBoxStyle.Exclamation, "Grafik Pendapatan - Aplikasi SIAP")
        Else
            kosongChart()
            pendapatanGedung()
            tambahSeries()
            tambahChart()
        End If
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