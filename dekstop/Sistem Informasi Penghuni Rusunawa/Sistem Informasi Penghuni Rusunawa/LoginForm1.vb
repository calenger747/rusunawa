Imports MySql.Data.MySqlClient
Public Class LoginForm1

    Dim hitung As Integer

    Sub kosong()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        UsernameTextBox.Focus()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Isikan data dengan lengkap!", MsgBoxStyle.Information, "Login Aplikasi SIAP")
            Exit Sub
        Else
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM tbl_m_user WHERE user_name ='" & UsernameTextBox.Text & "' AND user_password ='" & PasswordTextBox.Text & "'", CONN)
            DR = CMD.ExecuteReader()
            DR.Read()
            If DR.HasRows Then
                MsgBox("Login Berhasil, Selamat Datang " & UsernameTextBox.Text & " !", MsgBoxStyle.Information, "Login Aplikasi SIAP")
                Me.Visible = False
                MenuUtama.StatusStrip1.Visible = True
                MenuUtama.ToolStripStatusLabel1.Text = DR.Item(0)
                MenuUtama.ToolStripStatusLabel2.Text = DR.Item(1)
                MenuUtama.ToolStripStatusLabel3.Text = UCase(DR.Item(4))
                MenuUtama.LoginToolStripMenuItem1.Visible = False
                MenuUtama.LogoutToolStripMenuItem.Visible = True
                MenuUtama.KeluarToolStripMenuItem.Visible = True
                MenuUtama.MasterToolStripMenuItem.Visible = True
                MenuUtama.ReservasiUnitToolStripMenuItem.Visible = True
                MenuUtama.TransaksiToolStripMenuItem.Visible = True
                MenuUtama.FasilitasToolStripMenuItem.Visible = True
                If DR.Item("user_role") = "1" Then
                    MenuUtama.LaporanToolStripMenuItem.Visible = False
                Else
                    MenuUtama.LaporanToolStripMenuItem.Visible = True
                End If
            Else
                MsgBox("Login Gagal!", MsgBoxStyle.Exclamation, "Login Aplikasi SIAP")
                kosong()

                hitung = hitung + 1
                If hitung = 3 Then
                    MsgBox("Login sudah 3x salah", MsgBoxStyle.Critical, "Login Aplikasi SIAP")
                    End
                End If
            End If
        End If

        koneksi()
        CMD = New MySqlCommand("SELECT * FROM tbl_lembaga", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            MenuUtama.ToolStripStatusLabel4.Text = DR.Item(0)
        Else
            MsgBox("Profil lembaga harus segera diisi", MsgBoxStyle.Information, "Profil Lembaga - Aplikasi SIAP")
            MasterLembaga.ShowDialog()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosong()
        koneksi()
        On Error Resume Next
    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PasswordTextBox.Focus()
        End If
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK.Focus()
        End If
    End Sub

End Class
