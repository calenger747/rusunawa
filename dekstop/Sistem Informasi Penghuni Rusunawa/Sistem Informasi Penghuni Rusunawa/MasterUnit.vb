Imports MySql.Data.MySqlClient
Public Class MasterUnit

    Sub kosong()
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        ComboBox4.ResetText()
        Button2.Enabled = False
        Button1.Enabled = True
        TextBox1.Focus()
        TextBox3.Enabled = False
        TextBox1.Enabled = True
        tampil()
        kolomGrid()
    End Sub

    Sub dataBaru()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        ComboBox4.ResetText()
        TextBox4.Focus()
    End Sub

    Sub ketemu()
        TextBox1.Enabled = False
        TextBox3.Text = DR.Item("harga")
        TextBox4.Text = DR.Item("no_kwh")
        ComboBox1.Text = DR.Item("gedung")
        ComboBox2.Text = DR.Item("lantai")
        ComboBox3.Text = DR.Item("kamar")
        ComboBox4.Text = DR.Item("status")
        TextBox4.Focus()

        Button2.Enabled = True
    End Sub

    Sub tampil()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 50
        DataGridView1.Columns(3).Width = 55
        DataGridView1.Columns(4).Width = 50
        DataGridView1.Columns(5).Width = 50
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 80

        DataGridView1.Columns(0).HeaderText = "Unit Id"
        DataGridView1.Columns(1).HeaderText = "No Kwh"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "Gedung"
        DataGridView1.Columns(4).HeaderText = "Lantai"
        DataGridView1.Columns(5).HeaderText = "Kamar"
        DataGridView1.Columns(6).HeaderText = "Harga"
        DataGridView1.Columns(7).HeaderText = "Status"
    End Sub

    Private Sub MasterUnit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        ComboBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        ComboBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value

        Button2.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox2.Text = "1" Then
            TextBox3.Text = "250000"
        ElseIf ComboBox2.Text = "2" Then
            TextBox3.Text = "225000"
        ElseIf ComboBox2.Text = "3" Then
            TextBox3.Text = "200000"
        ElseIf ComboBox2.Text = "4" Then
            TextBox3.Text = "170000"
        Else
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "1" Then
            TextBox3.Text = "250000"
        ElseIf ComboBox2.Text = "2" Then
            TextBox3.Text = "225000"
        ElseIf ComboBox2.Text = "3" Then
            TextBox3.Text = "200000"
        ElseIf ComboBox2.Text = "4" Then
            TextBox3.Text = "170000"
        Else
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox2.Text = "1" Then
            TextBox3.Text = "250000"
        ElseIf ComboBox2.Text = "2" Then
            TextBox3.Text = "225000"
        ElseIf ComboBox2.Text = "3" Then
            TextBox3.Text = "200000"
        ElseIf ComboBox2.Text = "4" Then
            TextBox3.Text = "170000"
        Else
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Unit Id harus diisi", MsgBoxStyle.Information, "Master Unit - Aplikasi SIAP")
            TextBox1.Focus()
            Exit Sub
        Else
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_unit WHERE id_unit = '" & TextBox1.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            Try
                If Not DR.HasRows Then
                    koneksi()
                    Dim simpan As String = "INSERT INTO tbl_unit VALUES('" & TextBox1.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & ComboBox2.Text & ComboBox3.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & TextBox3.Text & "','" & ComboBox4.Text & "')"
                    CMD = New MySqlCommand(simpan, CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Unit - Aplikasi SIAP")
                    kosong()
                Else
                    koneksi()
                    Dim edit As String = "UPDATE tbl_unit SET no_kwh = '" & TextBox4.Text & "', unit = '" & ComboBox1.Text & ComboBox2.Text & ComboBox3.Text & "', gedung ='" & ComboBox1.Text & "', lantai = '" & ComboBox2.Text & "', kamar ='" & ComboBox3.Text & "', harga = '" & TextBox3.Text & "', status = '" & ComboBox4.Text & "' WHERE id_unit = '" & TextBox1.Text & "'"
                    CMD = New MySqlCommand(edit, CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Unit - Aplikasi SIAP")
                    kosong()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Unit Id harus diisi", MsgBoxStyle.Information, "Master Unit - Aplikasi SIAP")
            TextBox1.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Data akan dihapus?", "Master Unit - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            koneksi()
            CMD = New MySqlCommand("DELETE FROM tbl_unit WHERE id_unit = '" & TextBox1.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Master Unit - Aplikasi SIAP")
            kosong()
            tampil()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        kosong()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_unit WHERE id_unit = '" & TextBox1.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                dataBaru()
            Else
                ketemu()
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()
        End If
    End Sub
End Class