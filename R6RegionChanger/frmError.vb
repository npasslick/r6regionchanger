Option Strict On
Public Class frmError

    ' Report bug button
    Private Sub reportbug_button_Click(sender As Object, e As EventArgs) Handles btnReportBug.Click
        Process.Start("https://passlickdev.com/en/support/bugform.html")
    End Sub

    ' Close button
    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class