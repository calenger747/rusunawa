Imports MySql.Data.MySqlClient
Public Class GrafikUnit

    Sub tampilUnit()
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
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Ringan'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Rusak Berat'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        Dim persen As Double
        persen = Val(Label2.Text) / Val(Label1.Text) * 100
        Label4.Text = FormatNumber(persen, 0)
    End Sub

    Sub tampilUnitGedung()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE gedung ='" & ComboBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        Dim JmlData As Integer
        JmlData = DataGridView1.RowCount
        Label1.Text = JmlData - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE gedung ='" & ComboBox1.Text & "' AND status = 'Isi'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        Dim JmlData2 As Integer
        JmlData2 = DataGridView2.RowCount
        Label2.Text = JmlData2 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE gedung ='" & ComboBox1.Text & "' AND status = 'Kosong'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE gedung ='" & ComboBox1.Text & "' AND status = 'Booking'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView4.DataSource = DS.Tables(0)
        DataGridView4.ReadOnly = True
        Dim JmlData4 As Integer
        JmlData4 = DataGridView4.RowCount
        Label4.Text = JmlData4 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE gedung ='" & ComboBox1.Text & "' AND status = 'Rusak Ringan'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True
        Dim JmlData5 As Integer
        JmlData5 = DataGridView5.RowCount
        Label5.Text = JmlData5 - 1

        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE gedung ='" & ComboBox1.Text & "' AND status = 'Rusak Berat'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView6.DataSource = DS.Tables(0)
        DataGridView6.ReadOnly = True
        Dim JmlData6 As Integer
        JmlData6 = DataGridView6.RowCount
        Label6.Text = JmlData6 - 1

        Dim persen As Double
        persen = Val(Label2.Text) / Val(Label1.Text) * 100
        Label4.Text = FormatNumber(persen, 0)
    End Sub

    Sub tambahChart()
        Me.Chart1.Series("Total Unit").Points.AddXY("Grafik Unit Rusunawa", Label1.Text)
        Me.Chart1.Series("Unit Terisi").Points.AddXY("Unit Terisi", Label2.Text)
        Me.Chart1.Series("Unit Kosong").Points.AddXY("Unit Kosong", Label3.Text)
        Me.Chart1.Series("Unit Terbooking").Points.AddXY("Unit Terbooking", Label5.Text)
        Me.Chart1.Series("Unit Rusak Ringan").Points.AddXY("Unit Rusak Ringan", Label6.Text)
        Me.Chart1.Series("Unit Rusak Berat").Points.AddXY("Unit Rusak Berat", Label7.Text)
        Me.Chart1.Series("Presentase %").Points.AddXY("Presentase %", Label4.Text)

        Chart1.Visible = True
    End Sub

    Sub tambahSeries()
        Chart1.Series.Add("Total Unit")
        Chart1.Series.Add("Unit Terisi")
        Chart1.Series.Add("Unit Kosong")
        Chart1.Series.Add("Unit Terbooking")
        Chart1.Series.Add("Unit Rusak Ringan")
        Chart1.Series.Add("Unit Rusak Berat")
        Chart1.Series.Add("Presentase %")
    End Sub

    Sub kosong()
        Chart1.Series.Clear()

        tambahSeries()
    End Sub

    Private Sub GrafikUnit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Chart1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox1.Text = "Gedung" Then
            kosong()
            tampilUnit()
            tambahChart()
        Else
            kosong()
            tampilUnitGedung()
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