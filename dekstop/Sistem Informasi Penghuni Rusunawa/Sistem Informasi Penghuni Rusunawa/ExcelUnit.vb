Imports MySql.Data.MySqlClient
Public Class ExcelUnit
    Sub kosong()
        ComboBox1.ResetText()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_unit WHERE gedung ='" & ComboBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
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

                .Workbooks.Open(Application.StartupPath & "\Unit.xltx")

                'data
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    .Range("B" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(0).Value
                    .Range("C" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(1).Value
                    .Range("D" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(3).Value
                    .Range("E" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(4).Value
                    .Range("F" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(5).Value
                    .Range("G" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(6).Value
                    .Range("H" & CStr(i + 5)).Value = DataGridView1.Rows(i).Cells(7).Value
                Next

                .Range("B5").Select()
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