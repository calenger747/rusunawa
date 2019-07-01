Imports MySql.Data.MySqlClient
Public Class TransaksiIuran

    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        DateTimePicker1.ResetText()
        DateTimePicker2.ResetText()
        DateTimePicker3.ResetText()
        Label10.Text = "0"
        Label11.ResetText()
        Label12.ResetText()
        DateTimePicker4.ResetText()
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        DateTimePicker2.Enabled = False
        DateTimePicker3.Enabled = False
        DataGridView1.Columns.Clear()
        Button1.Enabled = True
        Button2.Enabled = False
        Button1.Focus()
        DataGridView1.Visible = False
    End Sub

    Sub ketemu()
        On Error Resume Next
        TextBox2.Text = DR.Item("id_unit")
        TextBox3.Text = DR.Item("nama_kk")
        TextBox4.Text = DR.Item("unit")
        TextBox5.Text = DR.Item("harga")
        DateTimePicker2.Text = DR.Item("jatuh_tempo")
        DateTimePicker3.Text = DateTime.Parse(DateTimePicker2.Text).AddMonths(1)
    End Sub

    Sub ketemuPembayaran()
        koneksi()
        DA = New MySqlDataAdapter("SELECT tbl_pembayaran.no_transaksi,tbl_pembayaran.tgl_transaksi,tbl_pembayaran.jatuh_tempo,tbl_pembayaran.bulan,tbl_pembayaran.jumlah,tbl_pembayaran.keterangan FROM tbl_pembayaran WHERE tbl_pembayaran.id_pelanggan = '" & TextBox2.Text & "' AND tbl_pembayaran.keterangan !='LUNAS'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 130
        DataGridView1.Columns(1).Width = 130
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 90
        DataGridView1.Columns(5).Width = 122

        DataGridView1.Columns(0).HeaderText = "No Transaksi"
        DataGridView1.Columns(1).HeaderText = "Tanggal Transaksi"
        DataGridView1.Columns(2).HeaderText = "Jatuh Tempo"
        DataGridView1.Columns(3).HeaderText = "Bulan"
        DataGridView1.Columns(4).HeaderText = "Jumlah"
        DataGridView1.Columns(5).HeaderText = "Keterangan"
    End Sub

    Sub noTransaksiOtomatis()
        koneksi()
        Dim otomatis As Single
        CMD = New MySqlCommand("SELECT COUNT(*) AS no_transaksi FROM tbl_pembayaran", CONN)
        DR = CMD.ExecuteReader
        While DR.Read()
            otomatis = Val(DR.Item("no_transaksi").ToString) + 1
        End While
        Select Case Len(Trim(otomatis))
            Case 1 : TextBox1.Text = "TRIB0000" + Trim(Str(otomatis)) + Format(Now, "ddMMyyyy")
            Case 2 : TextBox1.Text = "TRIB000" + Trim(Str(otomatis)) + Format(Now, "ddMMyyyy")
            Case 3 : TextBox1.Text = "TRIB00" + Trim(Str(otomatis)) + Format(Now, "ddMMyyyy")
            Case 4 : TextBox1.Text = "TRIB0" + Trim(Str(otomatis)) + Format(Now, "ddMMyyyy")
        End Select
        CONN.Close()
        Button1.Enabled = False
        Button2.Enabled = True
        TextBox2.Focus()
    End Sub

    Private Sub TransaksiIuran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        noTransaksiOtomatis()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_unit, tbl_keluarga, tbl_pembayaran WHERE tbl_unit.id_unit = tbl_keluarga.id_penghuni AND tbl_unit.id_unit = tbl_pembayaran.id_pelanggan AND tbl_unit.id_unit = '" & TextBox2.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Id pelanggan tidak ditemukan !", MsgBoxStyle.Information, "Transaksi Pembayaran Iuran - Aplikasi SIAP")
                TextBox2.Clear()
                TextBox2.Focus()
                Exit Sub
            Else
                ketemu()
                ketemuPembayaran()
                kolomGrid()
                For i As Integer = 0 To DataGridView1.Rows.Count - 2
                    Label10.Text = DataGridView1.Rows(i).Cells(4).Value
                Next
            End If
        End If
    End Sub

    Sub struk()
        StrukPembayaranSewa.TextBox11.Text = "Pembayaran Sewa"
        StrukPembayaranSewa.TextBox12.Text = Format(Now, "dd MMMM yyyy HH:mm:ss")
        StrukPembayaranSewa.TextBox13.Text = TextBox4.Text
        StrukPembayaranSewa.TextBox14.Text = Format(Val(Label10.Text), "Rp, ###,###.#0")
        StrukPembayaranSewa.TextBox15.Text = "Tunai"
        StrukPembayaranSewa.TextBox17.Text = Terbilang(Label10.Text) + "Rupiah"
        StrukPembayaranSewa.TextBox16.Text = "Pelunasan Tagihan Sewa Periode Bulan " + Label12.Text
    End Sub

    Public Function Terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {"", "Satu ", "Dua ", "Tiga ", "Empat ", "Lima ", _
        "Enam ", "Tujuh ", "Delapan ", "Sembilan ", "Sepuluh ", "Sebelas "}
        If nilai < 12 Then
            Return "" & bilangan(nilai)
        ElseIf nilai < 20 Then
            Return Terbilang(nilai - 10) & "Belas "
        ElseIf nilai < 100 Then
            Return (Terbilang(CInt((nilai \ 10))) & "Puluh ") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return "Seratus " & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (Terbilang(CInt((nilai \ 100))) & "Ratus ") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            Return "Seribu " & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            Return (Terbilang(CInt((nilai \ 1000))) & "Ribu ") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000))) & "Juta ") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000))) & "Milyar ") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000000))) & "Trilyun ") + Terbilang(nilai Mod 1000000000000)
        Else
            Return ""
        End If
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MsgBox("Isikan Id pelanggan!", MsgBoxStyle.Information, "Transaksi Pembayaran Iuran - Aplikasi SIAP")
            TextBox2.Focus()
            Exit Sub
        Else
            Try
                'bayar iuran
                koneksi()
                Dim simpanTransaksi As String = "UPDATE tbl_pembayaran SET no_transaksi = '" & TextBox1.Text & "',tgl_transaksi = '" & Format("yyyy-MM-dd", DateTimePicker1.Text) & "',jatuh_tempo ='" & Format("yyyy-MM-dd", DateTimePicker2.Text) & "', id_pelanggan = '" & TextBox2.Text & "',keterangan = 'LUNAS', id_user = '" & MenuUtama.ToolStripStatusLabel1.Text & "' WHERE no_transaksi = '" & Label11.Text & "'"
                CMD = New MySqlCommand(simpanTransaksi, CONN)
                CMD.ExecuteNonQuery()

                ketemuPembayaran()
                kolomGrid()
                Label10.Text = TextBox5.Text

                'iuran bulan depan
                koneksi()
                Dim iuranBulanDepan As String = "INSERT INTO tbl_pembayaran VALUES('" & Format(Now, "yy-MM-dd-hh-mm-ss") & "','" & Format(Now, "yyyy-MM-dd") & "','" & Format("yyyy-MM-dd", DateTimePicker3.Text) & "','" & TextBox2.Text & "','" & DateTimePicker4.Text & "','" & TextBox5.Text & "','BELUM BAYAR','" & MenuUtama.ToolStripStatusLabel1.Text & "')"
                CMD = New MySqlCommand(iuranBulanDepan, CONN)
                CMD.ExecuteNonQuery()


                MsgBox("Transaksi Berhasil", MsgBoxStyle.Information, "Transaksi Pembayaran Iuran - Aplikasi SIAP")
                struk()
                Me.kosong()
                StrukPembayaranSewa.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        kosong()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        Label11.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Label12.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value

        DateTimePicker4.Text = DateTime.Parse(Label12.Text).AddMonths(1)
    End Sub
End Class