Imports MySql.Data.MySqlClient

Public Class TransaksiListrik

    Sub kosong()
        koneksi()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        Label10.Text = "0"

        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = False

        DataGridView1.Columns.Clear()
    End Sub

    Sub ketemu()
        On Error Resume Next
        TextBox2.Text = DR.Item("id_unit")
        TextBox3.Text = DR.Item("nama_kk")
        TextBox4.Text = DR.Item("unit")
        TextBox5.Text = DR.Item("no_kwh")
    End Sub

    Sub ketemuPembayaran()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_token WHERE id_penghuni = '" & TextBox2.Text & "' AND status !='Terjual'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 30
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 250
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 50
        DataGridView1.Columns(6).Width = 120

        DataGridView1.Columns(0).HeaderText = "Id"
        DataGridView1.Columns(1).HeaderText = "Id Penghuni"
        DataGridView1.Columns(2).HeaderText = "No Token"
        DataGridView1.Columns(3).HeaderText = "Jumlah KWH"
        DataGridView1.Columns(4).HeaderText = "Harga"
        DataGridView1.Columns(5).HeaderText = "Tax"
        DataGridView1.Columns(6).HeaderText = "Status"
    End Sub

    Sub noTransaksiOtomatis()
        koneksi()
        Dim otomatis As Single
        CMD = New MySqlCommand("SELECT COUNT(*) AS no_transaksi FROM tbl_pembelian_token", CONN)
        DR = CMD.ExecuteReader
        While DR.Read()
            otomatis = Val(DR.Item("no_transaksi").ToString) + 1
        End While
        Select Case Len(Trim(otomatis))
            Case 1 : TextBox1.Text = "TRT0000" + Trim(Str(otomatis)) + Format(Now, "ddMMyyyy")
            Case 2 : TextBox1.Text = "TRT000" + Trim(Str(otomatis)) + Format(Now, "ddMMyyyy")
            Case 3 : TextBox1.Text = "TRT00" + Trim(Str(otomatis)) + Format(Now, "ddMMyyyy")
            Case 4 : TextBox1.Text = "TRT0" + Trim(Str(otomatis)) + Format(Now, "ddMMyyyy")
        End Select
        CONN.Close()
        Button1.Enabled = False
        Button2.Enabled = True
        TextBox2.Focus()
    End Sub

    Sub struk()
        StrukPembelianListrik.Label3.Text = TextBox1.Text
        StrukPembelianListrik.Label5.Text = Format(Now, "dd/MM/yyyy HH:mm:ss")
        StrukPembelianListrik.Label7.Text = TextBox2.Text
        StrukPembelianListrik.Label9.Text = TextBox4.Text
        StrukPembelianListrik.Label11.Text = Label12.Text
        StrukPembelianListrik.Label13.Text = Label8.Text
        StrukPembelianListrik.Label15.Text = TextBox6.Text + "%"
        StrukPembelianListrik.Label17.Text = Format(Val(Label10.Text), "Rp, ###,###.#0")
        StrukPembelianListrik.Label19.Text = Label7.Text
    End Sub

    Private Sub TransaksiListrik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosong()
        Label10.Text = "0"
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_unit, tbl_keluarga WHERE tbl_unit.id_unit = tbl_keluarga.id_penghuni AND tbl_unit.id_unit = '" & TextBox2.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Id pelanggan tidak ditemukan !", MsgBoxStyle.Information, "Transaksi Pembelian Token - Aplikasi SIAP")
                TextBox2.Clear()
                TextBox2.Focus()
                Exit Sub
            Else
                ketemu()
                ketemuPembayaran()
                kolomGrid()
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        noTransaksiOtomatis()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        Label11.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Label12.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Label7.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value

        If TextBox6.Text = "0" Then
            Label10.Text = Label12.Text
        Else
            Dim hitung As Single
            hitung = Val(Label12.Text) * (Val(TextBox6.Text) / 100)
            Label10.Text = Val(Label12.Text) + hitung
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Or Label10.Text = "" Then
            MsgBox("Isikan Data Dengan Lengkap!", MsgBoxStyle.Information, "Transaksi Pembelian Token - Aplikasi SIAP")
            TextBox2.Focus()
            Exit Sub
        Else
            Try
                'Beli Listrik
                koneksi()
                Dim simpanTransaksi As String = "INSERT INTO tbl_pembelian_token (no_transaksi, total_bayar, id_token, id_user) VALUES ('" & TextBox1.Text & "','" & Label10.Text & "','" & Label11.Text & "','" & MenuUtama.ToolStripStatusLabel1.Text & "')"
                CMD = New MySqlCommand(simpanTransaksi, CONN)
                CMD.ExecuteNonQuery()

                ketemuPembayaran()
                kolomGrid()

                'Nonaktifkan Token
                Dim nonaktif As String = "UPDATE tbl_token SET status = 'Terjual' WHERE id='" & Label11.Text & "'"
                CMD = New MySqlCommand(nonaktif, CONN)
                CMD.ExecuteNonQuery()

                MsgBox("Transaksi Berhasil", MsgBoxStyle.Information, "Transaksi Pembelian Token - Aplikasi SIAP")
                struk()
                Me.kosong()
                StrukPembelianListrik.ShowDialog()
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

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_unit, tbl_keluarga WHERE tbl_unit.id_unit = tbl_keluarga.id_penghuni AND tbl_unit.unit = '" & TextBox4.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Unit tidak ditemukan !", MsgBoxStyle.Information, "Transaksi Pembelian Token - Aplikasi SIAP")
                TextBox2.Clear()
                TextBox2.Focus()
                Exit Sub
            Else
                ketemu()
                ketemuPembayaran()
                kolomGrid()
            End If
        End If
    End Sub
End Class