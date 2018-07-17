Namespace My

    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' 
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
    ' UnhandledException: Wird ausgelöst, wenn in der Anwendung ein Ausnahmefehler auftritt.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication

        ' Unhandled Exception
        Public Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

            frmError.lblErrorMsg.Text = e.Exception.Message
            frmError.ShowDialog()

        End Sub

        ' Startup: Variablen
        Dim clsScript As New clsScript()

        ' Startup: Aktionen
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup

            ' Check OS
            If clsScript.GetOSVersion() = 0 Then                  ' TODO: Check for problems
                MessageBox.Show("ERROR: This program is not compatible with your operating system. You need at least Windows 7.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End
            End If

            ' Check prerequisites
            clsScript.StartupCheck()

            ' Change to defaults
            frmMain.dropRegion.Text = ""
            frmMain.dropRegion.Enabled = False
            frmMain.lblInformation.Text = ""
            frmMain.btnApply.Enabled = False
            frmMain.cbReadOnly.Enabled = False

        End Sub

    End Class


End Namespace