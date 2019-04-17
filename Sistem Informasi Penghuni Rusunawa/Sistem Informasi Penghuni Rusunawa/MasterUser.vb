Imports MySql.Data.MySqlClient
Public Class MasterUser

    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        TextBox1.Focus()
        Button2.Enabled = False
        Button1.Enabled = True
    End Sub

    Sub tampilData()
        DA = New MySqlDataAdapter("SELECT user_id, user_name, user_password, user_nama, user_role FROM tbl_m_user", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 73

        DataGridView1.Columns(0).HeaderText = "ID USER"
        DataGridView1.Columns(1).HeaderText = "USERNAME"
        DataGridView1.Columns(2).HeaderText = "PASSWORD"
        DataGridView1.Columns(3).HeaderText = "NAMA"
        DataGridView1.Columns(4).HeaderText = "LEVEL"
    End Sub

    Private Sub MasterUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
        tampilData()
        kolomGrid()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "1" Then
            TextBox4.Text = "OPERATOR"
        ElseIf ComboBox1.Text = "2" Then
            TextBox4.Text = "ADMIN"
        ElseIf ComboBox1.Text = "3" Then
            TextBox4.Text = "SUPER ADMIN"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Isikan data dengan lengkap", MsgBoxStyle.Information, "Master User - Aplikasi SIAP")
            TextBox1.Focus()
            Exit Sub
        Else
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_m_user WHERE user_id = '" & Label5.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            Try
                If Not DR.HasRows Then
                    koneksi()
                    Dim simpan As String = "INSERT INTO tbl_m_user (user_id, user_name, user_password, user_nama, user_role) VALUES (NULL, '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "')"
                    CMD = New MySqlCommand(simpan, CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master User - Aplikasi SIAP")
                    kosong()
                    tampilData()
                Else
                    koneksi()
                    Dim edit As String = "UPDATE tbl_m_user SET user_name = '" & TextBox1.Text & "', user_password = '" & TextBox2.Text & "', user_nama = '" & TextBox3.Text & "', user_role = '" & ComboBox1.Text & "' WHERE user_id = '" & Label5.Text & "'"
                    CMD = New MySqlCommand(edit, CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master User - Aplikasi SIAP")
                    kosong()
                    tampilData()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Username harus diisi", MsgBoxStyle.Information, "Master User - Aplikasi SIAP")
            kosong()
            tampilData()
            Exit Sub
        End If
        If MessageBox.Show("Data akan dihapus?", "Master User - Aplikasi SIAP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            koneksi()
            CMD = New MySqlCommand("DELETE FROM tbl_m_user WHERE user_id = '" & Label5.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Master User - Aplikasi SIAP")
            kosong()
            tampilData()
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
        Label5.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value

        If ComboBox1.Text = "1" Then
            TextBox4.Text = "OPERATOR"
        ElseIf ComboBox1.Text = "2" Then
            TextBox4.Text = "ADMIN"
        ElseIf ComboBox1.Text = "3" Then
            TextBox4.Text = "SUPER ADMIN"
        End If

        Button1.Enabled = True
        Button2.Enabled = True
    End Sub
End Class