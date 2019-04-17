Imports MySql.Data.MySqlClient
Public Class MasterInventory

    Sub kosong()
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        TextBox2.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox11.Clear()
        ComboBox3.ResetText()
        TextBox10.Clear()
        Button2.Enabled = False
        Button1.Enabled = True
        Button3.Enabled = False
        TextBox1.Focus()
        TextBox7.Enabled = True
        tampil()
        kolomGrid()
    End Sub

    Sub noInventoryElektronik()
        koneksi()
        Dim otomatis As Single
        CMD = New MySqlCommand("SELECT COUNT(*) AS no_inventory FROM tbl_inventory", CONN)
        DR = CMD.ExecuteReader
        While DR.Read()
            otomatis = Val(DR.Item("no_inventory").ToString) + 1
        End While
        Select Case Len(Trim(otomatis))
            Case 1 : TextBox7.Text = "EL0000" + Trim(Str(otomatis))
            Case 2 : TextBox7.Text = "EL000" + Trim(Str(otomatis))
            Case 3 : TextBox7.Text = "EL00" + Trim(Str(otomatis))
            Case 4 : TextBox7.Text = "EL0" + Trim(Str(otomatis))
        End Select
        CONN.Close()
        TextBox7.Enabled = False
    End Sub

    Sub noInventoryNonElektronik()
        koneksi()
        Dim otomatis As Single
        CMD = New MySqlCommand("SELECT COUNT(*) AS no_inventory FROM tbl_inventory", CONN)
        DR = CMD.ExecuteReader
        While DR.Read()
            otomatis = Val(DR.Item("no_inventory").ToString) + 1
        End While
        Select Case Len(Trim(otomatis))
            Case 1 : TextBox7.Text = "NE0000" + Trim(Str(otomatis))
            Case 2 : TextBox7.Text = "NE000" + Trim(Str(otomatis))
            Case 3 : TextBox7.Text = "NE00" + Trim(Str(otomatis))
            Case 4 : TextBox7.Text = "NE0" + Trim(Str(otomatis))
        End Select
        CONN.Close()
        TextBox7.Enabled = False
    End Sub

    Sub tampil()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_inventory", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 30
        DataGridView1.Columns(1).Width = 120
        DataGridView1.Columns(2).Width = 80
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 80
        DataGridView1.Columns(6).Width = 80
        DataGridView1.Columns(7).Width = 80
        DataGridView1.Columns(8).Width = 80
        DataGridView1.Columns(9).Width = 100
        DataGridView1.Columns(10).Width = 80
        DataGridView1.Columns(11).Width = 80
        DataGridView1.Columns(12).Width = 100
        DataGridView1.Columns(13).Width = 100

        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Nama Barang"
        DataGridView1.Columns(2).HeaderText = "Merk"
        DataGridView1.Columns(3).HeaderText = "No Seri"
        DataGridView1.Columns(4).HeaderText = "No inventory"
        DataGridView1.Columns(5).HeaderText = "Ukuran"
        DataGridView1.Columns(6).HeaderText = "Bahan"
        DataGridView1.Columns(7).HeaderText = "Tahun Pembuatan"
        DataGridView1.Columns(8).HeaderText = "Jumlah"
        DataGridView1.Columns(9).HeaderText = "Kategori"
        DataGridView1.Columns(10).HeaderText = "Perolehan"
        DataGridView1.Columns(11).HeaderText = "Keadaan"
        DataGridView1.Columns(12).HeaderText = "Lokasi"
        DataGridView1.Columns(13).HeaderText = "Keterangan"
    End Sub

    Private Sub MasterInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Elektronik" Then
            noInventoryElektronik()
        ElseIf ComboBox1.Text = "Non Elektronik" Then
            noInventoryNonElektronik()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kosong()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        Label14.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox11.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        TextBox8.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        ComboBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value
        TextBox10.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value

        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            koneksi()
            Dim simpan As String = "INSERT INTO tbl_inventory VALUES(NULL,'" & TextBox1.Text & "','" & TextBox11.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & TextBox8.Text & "','" & ComboBox3.Text & "','" & ComboBox2.Text & "','" & TextBox10.Text & "')"
            CMD = New MySqlCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Inventory - Aplikasi SIAP")
            kosong()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            koneksi()
            Dim edit As String = "UPDATE tbl_inventory SET nama_barang = '" & TextBox1.Text & "', kategori = '" & ComboBox1.Text & "', ukuran = '" & TextBox2.Text & "', bahan = '" & TextBox3.Text & " ', tahun_pembuatan ='" & TextBox4.Text & "', jumlah_barang = '" & TextBox5.Text & "', merk ='" & TextBox11.Text & "', no_seri = '" & TextBox6.Text & "', no_inventory = '" & TextBox7.Text & "', perolehan = '" & TextBox8.Text & "', keadaan = '" & ComboBox3.Text & "', ruangan = '" & ComboBox2.Text & "', ket = '" & TextBox10.Text & "' WHERE id = '" & Label14.Text & "'"
            CMD = New MySqlCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Inventory - Aplikasi SIAP")
            kosong()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Data akan dihapus?", "Master Inventory - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            koneksi()
            CMD = New MySqlCommand("DELETE FROM tbl_inventory WHERE id = '" & Label14.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Master Inventory - Aplikasi SIAP")
            kosong()
            tampil()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class