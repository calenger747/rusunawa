Imports MySql.Data.MySqlClient

Public Class MasterToken

    Sub kosong()
        koneksi()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Text = "0"
        ComboBox1.ResetText()
        DataGridView1.Rows.Clear()

        TextBox2.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = False
        Button7.Enabled = False
        Button3.Enabled = False
        Button6.Enabled = False

        tampil()
        kolomGrid()
    End Sub

    Sub kosong_()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Text = "0"
        ComboBox1.ResetText()

        TextBox3.Focus()
    End Sub

    Sub ketemu()
        TextBox2.Text = DR.Item("id_unit")
        TextBox3.Focus()
    End Sub

    Sub tampil()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_token", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
    End Sub

    Sub kolomGrid()
        DataGridView2.Columns(0).Width = 30
        DataGridView2.Columns(1).Width = 100
        DataGridView2.Columns(2).Width = 250
        DataGridView2.Columns(3).Width = 100
        DataGridView2.Columns(4).Width = 100
        DataGridView2.Columns(5).Width = 50
        DataGridView2.Columns(6).Width = 120

        DataGridView2.Columns(0).HeaderText = "Id"
        DataGridView2.Columns(1).HeaderText = "Id Penghuni"
        DataGridView2.Columns(2).HeaderText = "No Token"
        DataGridView2.Columns(3).HeaderText = "Jumlah KWH"
        DataGridView2.Columns(4).HeaderText = "Harga"
        DataGridView2.Columns(5).HeaderText = "Tax"
        DataGridView2.Columns(6).HeaderText = "Status"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Unit No Harus Diisi", MsgBoxStyle.Critical, "Master Token - Aplikasi SIAP")
            TextBox1.Focus()
        Else
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TextBox1.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox2.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox3.Text()
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = TextBox4.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = ComboBox1.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = TextBox5.Text
            DataGridView1.Update()
            Button2.Enabled = True
            Button7.Enabled = True
            kosong_()
        End If
    End Sub

    Private Sub MasterToken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo salah
        If DataGridView1.Rows.Count > 0 And DataGridView1.SelectedRows.Count > 0 Then
            Dim index As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
            DataGridView1.Rows.RemoveAt(index)

            Dim bolCount As Boolean = False

            For i As Integer = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Rows(i).Cells.Item(1).Value Is Nothing Or DataGridView1.Rows(i).Cells.Item(2).Value Is Nothing Then
                    bolCount = True
                    Exit For
                Else
                    bolCount = False
                End If
            Next

            If bolCount = True Then
                Button2.Enabled = False
                Button7.Enabled = False
            Else
                Button2.Enabled = True
            End If

        End If

        Exit Sub
salah:
        MsgBox("Baris Kosong Tidak Dapat Dihapus", MsgBoxStyle.Critical, "Master Token - Aplikasi SIAP")
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_unit WHERE unit = '" & TextBox1.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Unit Tidak Ditemukan", MsgBoxStyle.Critical, "Master Token - Aplikasi SIAP")
                TextBox1.Focus()
            Else
                ketemu()
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            koneksi()
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                koneksi()
                Dim simpanPenduduk As String = "INSERT INTO tbl_token (id_penghuni, no_token, jumlah_kwh, harga_token, tax, status) VALUES('" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(4).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "','Belum Terjual')"
                CMD = New MySqlCommand(simpanPenduduk, CONN)
                CMD.ExecuteNonQuery()
            Next
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Token - Aplikasi SIAP")
            kosong()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then
            MsgBox("Unit No harus diisi", MsgBoxStyle.Information, "Master Unit - Aplikasi SIAP")
            TextBox1.Focus()
            Exit Sub
        End If
        koneksi()
        Dim edit As String = "UPDATE tbl_token SET id_penghuni = '" & TextBox2.Text & "', no_token = '" & TextBox3.Text & "', jumlah_kwh ='" & TextBox4.Text & "', harga_token = '" & ComboBox1.Text & "', tax ='" & TextBox5.Text & "' WHERE id = '" & Label8.Text & "'"
        CMD = New MySqlCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Token - Aplikasi SIAP")
        kosong()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Unit No harus diisi", MsgBoxStyle.Information, "Master Unit - Aplikasi SIAP")
            TextBox1.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Data akan dihapus?", "Master Token - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            koneksi()
            CMD = New MySqlCommand("DELETE FROM tbl_token WHERE id = '" & Label8.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Master Unit - Aplikasi SIAP")
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kosong()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        On Error Resume Next
        Label8.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        ComboBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value
        TextBox4.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = DataGridView2.Rows(e.RowIndex).Cells(5).Value

        koneksi()
        CMD = New MySqlCommand("SELECT unit FROM tbl_unit WHERE id_unit = '" & DataGridView2.Rows(e.RowIndex).Cells(1).Value & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            TextBox1.Text = DR.Item("unit")
        End If

        Button1.Enabled = False
        Button6.Enabled = True
        Button3.Enabled = True
    End Sub
End Class