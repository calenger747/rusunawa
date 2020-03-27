Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient.MySqlDataReader
Imports System.IO


Public Class UploadToken
    Dim tblImport As DataTable

    Sub Kosong()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        ListBox1.Items.Clear()
        TextBox1.Text = String.Empty
        Button7.Enabled = False
    End Sub

    Private Sub UploadToken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Kosong()
    End Sub


    Public Sub AmbilNamaSheet(ByVal FileName As String)
        Dim sConn As String
        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"

        Dim conn As New OleDbConnection(sConn)

        conn.Open()

        Dim dtSheets As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        Dim drSheet As DataRow

        ListBox1.Items.Clear()
        For Each drSheet In dtSheets.Rows
            ListBox1.Items.Add(drSheet("TABLE_NAME").ToString())
        Next

        TampilEcxelKeGrid(FileName, ListBox1.Items(0).ToString)

        conn.Close()
    End Sub
    Sub kolomGrid()
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 50

        DataGridView1.Columns(0).HeaderText = "No Unit"
        DataGridView1.Columns(1).HeaderText = "No Token"
        DataGridView1.Columns(2).HeaderText = "Jumlah KWH"
        DataGridView1.Columns(3).HeaderText = "Harga"
        DataGridView1.Columns(4).HeaderText = "Tax"
    End Sub


    Public Sub TampilEcxelKeGrid(ByVal FileName As String, ByVal SheetName As String)
        Dim exConn As OleDbConnection 'MySqlConnection
        Dim dt As DataSet
        Dim cmd As OleDbDataAdapter 'MySqlDataAdapter

        Dim sConn As String
        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"

        'exConn = New MySql.Data.MySqlClient.MySqlConnection(sConn)
        exConn = New System.Data.OleDb.OleDbConnection(sConn)
        'cmd = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from [" & SheetName & "]", exConn)
        cmd = New System.Data.OleDb.OleDbDataAdapter("select * from [" & SheetName & "]", exConn)
        cmd.TableMappings.Add("Table", SheetName)
        dt = New System.Data.DataSet
        cmd.Fill(dt)
        tblImport = dt.Tables(0)
        DataGridView1.DataSource = tblImport
        kolomGrid()
        Button7.Enabled = True
        exConn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .FileName = String.Empty
            .InitialDirectory = "C:\"
            .Title = "Pilih File Excel"
            .Filter = "Excel|*.xls;*.xlsx"
        End With

        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Try
                TextBox1.Text = OpenFileDialog1.FileName
                AmbilNamaSheet(TextBox1.Text)
            Catch ex As Exception
                MsgBox("Error : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        TampilEcxelKeGrid(TextBox1.Text, ListBox1.SelectedItem.ToString)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            koneksi()
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                koneksi()
                Dim simpanPenduduk As String = "INSERT INTO tbl_token (id_penghuni, no_token, jumlah_kwh, harga_token, tax, status) VALUES('" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(4).Value & "','Belum Terjual')"
                CMD = New MySqlCommand(simpanPenduduk, CONN)
                CMD.ExecuteNonQuery()
            Next
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Upload Token - Aplikasi SIAP")
            Kosong()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Kosong()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.DoEvents()

        Dim xlApp As New Microsoft.Office.Interop.Excel.Application

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        Try
            With xlApp

                .Workbooks.Open(Application.StartupPath & "\Template Upload Token.xltx")
                .Range("A2").Select()
                .Visible = True
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            xlApp.ActiveWorkbook.Close(False)
        End Try

        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub
End Class