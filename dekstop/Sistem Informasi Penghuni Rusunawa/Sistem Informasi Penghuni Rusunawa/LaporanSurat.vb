Imports MySql.Data.MySqlClient
Public Class LaporanSurat
    Sub pilih()
        If ComboBox1.Text = "" Or ComboBox1.Text = "Gedung" Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox1.Text = "Gedung" And TextBox1.Text = "" Then
            koneksi()
            DA = New MySqlDataAdapter("SELECT * FROM tbl_kontrak JOIN tbl_keluarga ON tbl_keluarga.id_kk = tbl_kontrak.no_kk JOIN tbl_unit ON tbl_unit.id_unit = tbl_kontrak.id_unit", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
        ElseIf TextBox1.Text = "" Then
            koneksi()
            DA = New MySqlDataAdapter("SELECT * FROM tbl_kontrak JOIN tbl_keluarga ON tbl_keluarga.id_kk = tbl_kontrak.no_kk JOIN tbl_unit ON tbl_unit.id_unit = tbl_kontrak.id_unit WHERE tbl_unit.id_unit = '" & ComboBox1.Text & "' ", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
        ElseIf ComboBox1.Text = "" Or ComboBox1.Text = "Gedung" Then
            koneksi()
            DA = New MySqlDataAdapter("SELECT * FROM tbl_kontrak JOIN tbl_keluarga ON tbl_keluarga.id_kk = tbl_kontrak.no_kk JOIN tbl_unit ON tbl_unit.id_unit = tbl_kontrak.id_unit WHERE tbl_unit.id_unit = '" & TextBox1.Text & "' ", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
        Else
            koneksi()
            DA = New MySqlDataAdapter("SELECT * FROM tbl_kontrak JOIN tbl_keluarga ON tbl_keluarga.id_kk = tbl_kontrak.no_kk JOIN tbl_unit ON tbl_unit.id_unit = tbl_kontrak.id_unit WHERE tbl_unit.id_unit = '" & TextBox1.Text & "' ", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "" Or ComboBox1.Text = "Gedung" Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub
End Class