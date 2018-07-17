Option Strict On

Imports R6RegionChanger.clsScript
Imports System
Imports System.IO


Public Class frmMain

    ' Variables
    Dim clsScript As New clsScript


#Region "frmLoad"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsScript.SetDefaults()
    End Sub

#End Region

#Region "dropProfile_SelectedIndexChanged"
    Private Sub dropProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropProfile.SelectedIndexChanged

        ' Variables
        Dim R6FullProfilePath As String = clsScript.R6ProfileDirPath & "\" & dropProfile.Text & "\GameSettings.ini"
        Dim R6ConfigFileExists As Boolean = IO.File.Exists(R6FullProfilePath)

        ' Change to defaults
        dropRegion.Text = ""
        dropRegion.Enabled = False
        lblInformation.Text = ""

        If R6ConfigFileExists = True Then

            ' Change to defaults
            dropRegion.Enabled = True
            cbReadOnly.Enabled = True
            lblInformation.Text = ""

            ' Set value for region
            Dim R6ProfileRegionVar As String = clsScript.getIniValue("ONLINE", "DataCenterHint", "", R6FullProfilePath)

            If R6ProfileRegionVar = "default" Then
                dropRegion.Text = "default (ping based) [recommended]"
            ElseIf R6ProfileRegionVar = "eus" Then
                dropRegion.Text = "eus (us east)"
            ElseIf R6ProfileRegionVar = "cus" Then
                dropRegion.Text = "cus (us central)"
            ElseIf R6ProfileRegionVar = "scus" Then
                dropRegion.Text = "scus (us south central)"
            ElseIf R6ProfileRegionVar = "wus" Then
                dropRegion.Text = "wus (us west)"
            ElseIf R6ProfileRegionVar = "sbr" Then
                dropRegion.Text = "sbr (brazil south)"
            ElseIf R6ProfileRegionVar = "neu" Then
                dropRegion.Text = "neu (europe north)"
            ElseIf R6ProfileRegionVar = "weu" Then
                dropRegion.Text = "weu (europe west)"
            ElseIf R6ProfileRegionVar = "eas" Then
                dropRegion.Text = "eas (asia east)"
            ElseIf R6ProfileRegionVar = "seas" Then
                dropRegion.Text = "seas (asia south east)"
            ElseIf R6ProfileRegionVar = "eau" Then
                dropRegion.Text = "eau (australia east)"
            ElseIf R6ProfileRegionVar = "wja" Then
                dropRegion.Text = "wja (japan west)"
            End If

            ' Set value for read-only
            If (File.GetAttributes(R6FullProfilePath) And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
                cbReadOnly.Checked = True

            ElseIf (File.GetAttributes(R6FullProfilePath) And FileAttributes.ReadOnly) <> FileAttributes.ReadOnly Then
                cbReadOnly.Checked = False

            Else
                cbReadOnly.Checked = False

            End If

        ElseIf R6ConfigFileExists = False Then

            ' Change to defaults
            dropRegion.Text = ""
            btnApply.Enabled = False
            dropRegion.Enabled = False
            cbReadOnly.Checked = False
            cbReadOnly.Enabled = False

            lblInformation.Text = "ERROR: Missing configuration file for this profile!"

        Else

            ' Change to defaults
            dropRegion.Text = ""
            btnApply.Enabled = False
            dropRegion.Enabled = False
            cbReadOnly.Checked = False
            cbReadOnly.Enabled = False

            lblInformation.Text = "ERROR: Missing configuration file for this profile!"

        End If
    End Sub

#End Region

#Region "btnApply_Click"
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        clsScript.Apply()

    End Sub

#End Region

#Region "dropRegion_SelectedIndexChanged"
    Private Sub dropRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropRegion.SelectedIndexChanged

        Dim R6FullProfilePath As String = clsScript.R6ProfileDirPath & "\" & dropProfile.Text & "\GameSettings.ini"
        Dim R6ProfileRegionVar As String = clsScript.getIniValue("ONLINE", "DataCenterHint", "", R6FullProfilePath)

        If dropRegion.Text = "" Then
            btnApply.Enabled = False
            cbReadOnly.Enabled = False

        ElseIf dropRegion.Text = "default (ping based) [recommended]" And R6ProfileRegionVar = "default" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "eus (US East)" And R6ProfileRegionVar = "eus" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "cus (US Central)" And R6ProfileRegionVar = "cus" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "scus (US South Central)" And R6ProfileRegionVar = "scus" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "wus (US West)" And R6ProfileRegionVar = "wus" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "sbr (Brazil South)" And R6ProfileRegionVar = "sbr" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "neu (Europe North)" And R6ProfileRegionVar = "neu" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "weu (Europe West)" And R6ProfileRegionVar = "weu" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "eas (Asia East)" And R6ProfileRegionVar = "eas" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "seas (Asia South East)" And R6ProfileRegionVar = "seas" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "eau (Australia East)" And R6ProfileRegionVar = "eau" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "wja (Japan West)" And R6ProfileRegionVar = "wja" Then
            btnApply.Enabled = False

        Else
            btnApply.Enabled = True
            cbReadOnly.Enabled = True

        End If

    End Sub

#End Region

#Region "cbReadOnly_CheckedStateChanged"

    Private Sub cbReadOnly_CheckStateChanged(sender As Object, e As EventArgs) Handles cbReadOnly.CheckStateChanged

        ' Variables
        Dim R6FullProfilePath As String = clsScript.R6ProfileDirPath & "\" & dropProfile.Text & "\GameSettings.ini"
        Dim R6ConfigFileExists As Boolean = IO.File.Exists(R6FullProfilePath)

        If R6ConfigFileExists = True Then
            btnApply.Enabled = True
        End If

    End Sub

#End Region

#Region "pbInfo_Click"
    Private Sub pbInfo_Click(sender As Object, e As EventArgs) Handles pbInfo.Click

        frmAbout.ShowDialog()

    End Sub

#End Region


End Class
