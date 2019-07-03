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
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE status = 'Kosong' OR status = 'Booking'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

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
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE gedung ='" & ComboBox1.Text & "' AND status = 'Kosong' OR status = 'Booking'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView3.DataSource = DS.Tables(0)
        DataGridView3.ReadOnly = True
        Dim JmlData3 As Integer
        JmlData3 = DataGridView3.RowCount
        Label3.Text = JmlData3 - 1

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
        tampilUnit()
        Chart1.Series.Clear()

        tambahSeries()

        Me.Chart1.Series("Kapasitas Gedung (" + Label1.Text + ")").Points.AddXY("Grafik Unit Rusunawa", Label1.Text)
        Me.Chart1.Series("Unit Rusak Ringan (" + Label5.Text + ")").Points.AddXY("Unit Rusak Ringan", Label5.Text)
        Me.Chart1.Series("Unit Rusak Berat (" + Label6.Text + ")").Points.AddXY("Unit Rusak Berat", Label6.Text)
        Me.Chart1.Series("Unit Terisi (" + Label2.Text + ")").Points.AddXY("Unit Terisi", Label2.Text)
        Me.Chart1.Series("Unit Kosong (" + Label3.Text + ")").Points.AddXY("Unit Kosong", Label3.Text)
        Me.Chart1.Series("Presentase " + Label4.Text + "%").Points.AddXY("Presentase %", Label4.Text)

        Chart1.Visible = True
    End Sub

    Sub tambahChart1()
        tampilUnitGedung()
        Chart1.Series.Clear()

        tambahSeries()

        Me.Chart1.Series("Kapasitas Gedung (" + Label1.Text + ")").Points.AddXY("Grafik Unit Rusunawa", Label1.Text)
        Me.Chart1.Series("Unit Rusak Ringan (" + Label5.Text + ")").Points.AddXY("Unit Rusak Ringan", Label5.Text)
        Me.Chart1.Series("Unit Rusak Berat (" + Label6.Text + ")").Points.AddXY("Unit Rusak Berat", Label6.Text)
        Me.Chart1.Series("Unit Terisi (" + Label2.Text + ")").Points.AddXY("Unit Terisi", Label2.Text)
        Me.Chart1.Series("Unit Kosong (" + Label3.Text + ")").Points.AddXY("Unit Kosong", Label3.Text)
        Me.Chart1.Series("Presentase " + Label4.Text + "%").Points.AddXY("Presentase %", Label4.Text)

        Chart1.Visible = True
    End Sub

    Sub tambahSeries()
        Chart1.Series.Add("Kapasitas Gedung (" + Label1.Text + ")")
        Chart1.Series.Add("Unit Rusak Ringan (" + Label5.Text + ")")
        Chart1.Series.Add("Unit Rusak Berat (" + Label6.Text + ")")
        Chart1.Series.Add("Unit Terisi (" + Label2.Text + ")")
        Chart1.Series.Add("Unit Kosong (" + Label3.Text + ")")
        Chart1.Series.Add("Presentase " + Label4.Text + "%")
    End Sub

    Sub kosong()
        Chart1.Series.Clear()
    End Sub

    Private Sub GrafikUnit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Chart1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox1.Text = "Gedung" Then
            kosong()
            tambahChart()
        Else
            kosong()
            tambahChart1()
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