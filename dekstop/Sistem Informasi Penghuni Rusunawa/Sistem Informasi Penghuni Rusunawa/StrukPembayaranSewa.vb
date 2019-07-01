Imports System.Drawing.Printing
Public Class StrukPembayaranSewa

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        PrintDialog1.PrinterSettings = PrintForm1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings

            With Me.PrintForm1
                .PrintAction = Printing.PrintAction.PrintToPreview



                Dim MyMargins As New Margins

                With MyMargins
                    .Left = 20
                    .Right = 20
                    .Top = 20
                    .Bottom = 20
                End With

                .PrinterSettings.DefaultPageSettings.Margins = MyMargins

                PrintForm1.DocumentName = TextBox2.Text + " " + TextBox13.Text
                .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)

            End With

        End If
        Button1.Visible = True
    End Sub

    Private Sub StrukPembayaranSewa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Focus()
    End Sub
End Class