Option Strict On
Public Class frmAbout

#Region "frmLoad"

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        lblCopyright.Text = String.Format("Copyright © Passlick Development {0}. All rights reserved.", My.Computer.Clock.LocalTime.Year)
    End Sub

#End Region

#Region "Links"

    Private Sub pbPD_Click(sender As Object, e As EventArgs) Handles pbPD.Click
        Process.Start("https://passlickdev.com")
    End Sub

    Private Sub llblUpdates_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblUpdates.LinkClicked
        Process.Start("https://pdev.me/r6tool")
    End Sub

    Private Sub frmAbout_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Process.Start("https://passlickdev.com/support")
    End Sub

#End Region

End Class