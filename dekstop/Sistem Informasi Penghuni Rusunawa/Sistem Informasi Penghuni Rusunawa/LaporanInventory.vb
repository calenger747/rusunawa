Imports MySql.Data.MySqlClient
Imports System.IO
Public Class LaporanInventory

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

    Sub tampilSemua()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_inventory ", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Sub tampilRuangan()
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_inventory WHERE ruangan = '" & ComboBox5.Text & "' ", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Visible = True
    End Sub

    Private Sub LaporanInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        DataGridView1.Columns.Clear()
        DataGridView1.Visible = False
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.Rows(e.RowIndex).Cells(0).Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox5.ResetText()
        tampilSemua()
        kolomGrid()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tampilRuangan()
        kolomGrid()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DataGridView1.RowCount = 0 Then Return

        Button5.Text = "Please Wait..."
        Button5.Enabled = False
        Application.DoEvents()

        Dim xlApp As New Microsoft.Office.Interop.Excel.Application

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        Try
            With xlApp

                .Workbooks.Open(Application.StartupPath & "\Inventory.xltx")

                'data
                If ComboBox5.Text = "" Then
                    .Range("D6").Value = ": ALL"
                Else
                    .Range("D6").Value = ": " + ComboBox5.Text
                End If

                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    .Range("B" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(0).Value
                    .Range("C" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(1).Value
                    .Range("D" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(2).Value
                    .Range("E" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(9).Value
                    .Range("F" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(3).Value
                    .Range("G" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(5).Value
                    .Range("H" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(6).Value
                    .Range("I" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(7).Value
                    .Range("J" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(4).Value
                    .Range("K" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(8).Value
                    .Range("L" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(10).Value
                    .Range("M" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(11).Value
                    .Range("N" & CStr(i + 9)).Value = DataGridView1.Rows(i).Cells(13).Value
                Next

                .Range("B9").Select()
                .Visible = True
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            xlApp.ActiveWorkbook.Close(False)
        End Try

        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

        Button5.Text = "Export"
        Button5.Enabled = True
    End Sub
End Class