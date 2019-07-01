Imports MySql.Data.MySqlClient
Public Class MasterLembaga

    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox1.Focus()
    End Sub

    Sub ketemu()
        TextBox1.Text = DR.Item("nama_lembaga")
        TextBox2.Text = DR.Item("alamat")
        TextBox3.Text = Microsoft.VisualBasic.Mid(DR.Item("telp"), 6, 20)
        TextBox4.Text = Microsoft.VisualBasic.Mid(DR.Item("fax"), 5, 20)
        TextBox5.Text = Microsoft.VisualBasic.Mid(DR.Item("email"), 7, 43)
        TextBox6.Text = Microsoft.VisualBasic.Mid(DR.Item("website"), 9, 41)
    End Sub

    Sub tampil()
        koneksi()
        CMD = New MySqlCommand("select * from tbl_lembaga WHERE id_lembaga='1'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            TextBox1.Text = DR.Item("nama_lembaga")
            TextBox2.Text = DR.Item("alamat")
            TextBox3.Text = Microsoft.VisualBasic.Mid(DR.Item("telp"), 6, 20)
            TextBox4.Text = Microsoft.VisualBasic.Mid(DR.Item("fax"), 5, 20)
            TextBox5.Text = Microsoft.VisualBasic.Mid(DR.Item("email"), 7, 43)
            TextBox6.Text = Microsoft.VisualBasic.Mid(DR.Item("website"), 9, 41)
        End If
    End Sub

    Private Sub MasterLembaga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Nama Lembaga harus diisi", MsgBoxStyle.Information, "Master Lembaga - Aplikasi SIAP")
            TextBox1.Focus()
            Exit Sub
        Else
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_lembaga WHERE id_lembaga = '1'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            Try
                If Not DR.HasRows Then
                    koneksi()
                    Dim simpan As String = "INSERT INTO tbl_lembaga VALUES (NULL, '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & Label4.Text & Space(1) & TextBox3.Text & "', '" & Label5.Text & Space(1) & TextBox4.Text & "', '" & Label6.Text & Space(1) & TextBox5.Text & "', '" & Label7.Text & Space(1) & TextBox6.Text & "')"
                    CMD = New MySqlCommand(simpan, CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Lembaga - Aplikasi SIAP")
                    Me.Close()

                Else
                    koneksi()
                    Dim edit As String = "UPDATE tbl_lembaga SET nama_lembaga = '" & TextBox1.Text & "', alamat = '" & TextBox2.Text & "', telp = '" & Label4.Text & Space(1) & TextBox3.Text & "', fax = '" & Label5.Text & Space(1) & TextBox4.Text & "', email = '" & Label6.Text & Space(1) & TextBox5.Text & "', website = '" & Label7.Text & Space(1) & TextBox6.Text & "'"
                    CMD = New MySqlCommand(edit, CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Master Lembaga - Aplikasi SIAP")
                    Me.Close()
                End If

                koneksi()
                CMD = New MySqlCommand("SELECT * FROM tbl_lembaga", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MenuUtama.ToolStripStatusLabel4.Text = DR.Item(0)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        koneksi()
        CMD = New MySqlCommand("SELECT * FROM tbl_lembaga WHERE id_lembaga = '1'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            kosong()
        Else
            ketemu()
        End If
    End Sub

End Class