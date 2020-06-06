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
            ElseIf R6ProfileRegionVar = "eastus" Then
                dropRegion.Text = "eastus (us east)"
            ElseIf R6ProfileRegionVar = "centralus" Then
                dropRegion.Text = "centralus (us central)"
            ElseIf R6ProfileRegionVar = "southcentralus" Then
                dropRegion.Text = "southcentralus (us south central)"
            ElseIf R6ProfileRegionVar = "westus" Then
                dropRegion.Text = "westus (us west)"
            ElseIf R6ProfileRegionVar = "brazilsouth" Then
                dropRegion.Text = "brazilsouth (brazil south)"
            ElseIf R6ProfileRegionVar = "northeurope" Then
                dropRegion.Text = "northeurope (europe north)"
            ElseIf R6ProfileRegionVar = "westeurope" Then
                dropRegion.Text = "westeurope (europe west)"
            ElseIf R6ProfileRegionVar = "southafricanorth" Then
                dropRegion.Text = "southafricanorth (africa south north)"
            ElseIf R6ProfileRegionVar = "eastasia" Then
                dropRegion.Text = "eastasia (asia east)"
            ElseIf R6ProfileRegionVar = "southeastasia" Then
                dropRegion.Text = "southeastasia (asia south east)"
            ElseIf R6ProfileRegionVar = "australiaeast" Then
                dropRegion.Text = "australiaeast (australia east)"
            ElseIf R6ProfileRegionVar = "australiasoutheast" Then
                dropRegion.Text = "australiasoutheast (australia south east)"
            ElseIf R6ProfileRegionVar = "japanwest" Then
                dropRegion.Text = "japanwest (japan west)"
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
        ElseIf dropRegion.Text = "eastus (US East)" And R6ProfileRegionVar = "eastus" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "centralus (US Central)" And R6ProfileRegionVar = "centralus" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "southcentralus (US South Central)" And R6ProfileRegionVar = "southcentralus" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "westus (US West)" And R6ProfileRegionVar = "westus" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "brazilsouth (Brazil South)" And R6ProfileRegionVar = "brazilsouth" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "northeurope (Europe North)" And R6ProfileRegionVar = "northeurope" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "westeurope (Europe West)" And R6ProfileRegionVar = "westeurope" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "southafricanorth (Africa South North)" And R6ProfileRegionVar = "southafricanorth" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "eastasia (Asia East)" And R6ProfileRegionVar = "eastasia" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "southeastasia (Asia South East)" And R6ProfileRegionVar = "southeastasia" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "australiaeast (Australia East)" And R6ProfileRegionVar = "australiaeast" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "australiasoutheast (Australia South East)" And R6ProfileRegionVar = "australiasoutheast" Then
            btnApply.Enabled = False
        ElseIf dropRegion.Text = "japanwest (Japan West)" And R6ProfileRegionVar = "japanwest" Then
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
