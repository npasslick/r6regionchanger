Option Strict On

Imports System
Imports System.Threading
Imports System.Security.Principal
Imports Microsoft.Win32
Imports System.IO
Imports System.Drawing.Imaging


Public Class clsScript

#Region "Variables"

    Public Shared R6ProfileDirPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Games\Rainbow Six - Siege"

#End Region

#Region "Function: Check OS"

    Public Function GetOSVersion() As Integer

        Select Case Environment.OSVersion.Platform
            Case PlatformID.Win32NT
                Select Case Environment.OSVersion.Version.Major
                    Case 6
                        Select Case Environment.OSVersion.Version.Minor
                            Case 0
                                Return 0
                            Case 1
                                Return 1
                            Case 2
                                Return 1
                            Case 3
                                Return 1
                            Case Else
                                Return 0
                        End Select

                    Case 10
                        Return 1
                    Case > 10
                        Return 1
                    Case Else
                        Return 0

                End Select

            Case Else
                Return 0

        End Select

    End Function

#End Region

#Region "Function: Check elevation"

    Public Function IsAdmin() As Boolean
        IsAdmin = CType(Thread.CurrentPrincipal, WindowsPrincipal).IsInRole(
          WindowsBuiltInRole.Administrator)
    End Function

#End Region

#Region "Function: getIniValue"

    Public Declare Ansi Function GetPrivateProfileString Lib "kernel32.dll" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Public Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

    Public Function getIniValue(ByVal strSection As String, ByVal strKey As String, ByVal strDefault As String, ByVal strFile As String) As String
        Dim strTemp As String = Space(1024), lLength As Integer
        lLength = GetPrivateProfileString(strSection, strKey, strDefault, strTemp, strTemp.Length, strFile)
        Return (strTemp.Substring(0, lLength))
    End Function

#End Region

#Region "Function: writeIniValue"

    Public Function writeIniValue(ByVal strSection As String, ByVal strKey As String, ByVal strValue As String, ByVal strFile As String) As Boolean
        Return (Not (WritePrivateProfileString(strSection, strKey, strValue, strFile) = 0))
    End Function

#End Region

#Region "Sub: Startup Check"

    Public Sub StartupCheck()

        ' Variables
        Dim R6ConfigDirExists As Boolean = IO.Directory.Exists(R6ProfileDirPath)
        Dim R6ProfileDirInfo As DirectoryInfo = New DirectoryInfo(R6ProfileDirPath)

        If R6ConfigDirExists = False Then
            MessageBox.Show("ERROR: No configuration files for Tom Clancy's Rainbow Six® Siege were found on this computer! Please start the game at least once to change the region settings.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End
        ElseIf Not R6ProfileDirInfo.EnumerateDirectories().Any() Then
            MessageBox.Show("ERROR: No configuration files for Tom Clancy's Rainbow Six® Siege were found on this computer! Please start the game at least once to change the region settings.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End
        End If

    End Sub

#End Region

#Region "Sub: Set defaults"

    Public Sub SetDefaults()

        ' Set DropList for available profiles
        For Each R6ProfileDir As IO.DirectoryInfo In New IO.DirectoryInfo(R6ProfileDirPath).GetDirectories()
            frmMain.dropProfile.Items.Add(R6ProfileDir)
        Next

    End Sub

#End Region

#Region "Sub: Apply region change"

    Public Sub Apply()

        ' Variables
        Dim R6FullProfilePath As String = R6ProfileDirPath & "\" & frmMain.dropProfile.Text & "\GameSettings.ini"

        If IO.File.Exists(R6FullProfilePath) Then
            If frmMain.cbReadOnly.Checked = True Then

                Dim R6FullProfilePathFI As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(R6FullProfilePath)
                R6FullProfilePathFI.IsReadOnly = False

                If frmMain.dropRegion.Text = "default (ping based) [recommended]" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/default", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: default" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "eastus (US East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/eastus", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: eastus (US East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "centralus (US Central)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/centralus", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: centralus (US Central)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "southcentralus (US South Central)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/southcentralus", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: southcentralus (US South Central)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "westus (US West)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/westus", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: westus (US West)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "brazilsouth (Brazil South)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/brazilsouth", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: brazilsouth (Brazil South)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "northeurope (Europe North)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/northeurope", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: northeurope (Europe North)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "westeurope (Europe West)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/westeurope", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: westeurope (Europe West)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True
                    
                ElseIf frmMain.dropRegion.Text = "southafricanorth (africa south north)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/southafricanorth", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: southafricanorth (africa south north)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "eastasia (Asia East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/eastasia", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: eastasia (Asia East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "southeastasia (Asia South East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/southeastasia", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: southeastasia (Asia South East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "australiaeast (Australia East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/australiaeast", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: australiaeast (Australia East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True
                    
                ElseIf frmMain.dropRegion.Text = "australiasoutheast (Australia South East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/australiasoutheast", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: australiasoutheast (Australia South East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                ElseIf frmMain.dropRegion.Text = "japanwest (Japan West)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/japanwest", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: japanwest (Japan West)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    R6FullProfilePathFI.IsReadOnly = True

                Else
                    MessageBox.Show("ERROR: Error while applying the region change!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If

            ElseIf frmMain.cbReadOnly.Checked = False Then

                Dim R6FullProfilePathFI As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(R6FullProfilePath)
                R6FullProfilePathFI.IsReadOnly = False

                If frmMain.dropRegion.Text = "default (ping based) [recommended]" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/default", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: default" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "eastus (US East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/eastus", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: eastus (US East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "centralus (US Central)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/centralus", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: centralus (US Central)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "southcentralus (US South Central)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/southcentralus", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: southcentralus (US South Central)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "westus (US West)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/westus", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: westus (US West)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "brazilsouth (Brazil South)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/brazilsouth", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: brazilsouth (Brazil South)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "northeurope (Europe North)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/northeurope", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: northeurope (Europe North)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "westeurope (Europe West)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/westeurope", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: westeurope (Europe West)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    
                ElseIf frmMain.dropRegion.Text = "southafricanorth (Africa South North)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/southafricanorth", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: southafricanorth (Africa South North)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "eastasia (Asia East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/eastasia", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "eastasia (Asia East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "southeastasia (Asia South East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/southeastasia", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: southeastasia (Asia South East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "australiaeast (Australia East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/australiaeast", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: australiaeast (Australia East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    
                ElseIf frmMain.dropRegion.Text = "australiasoutheast (Australia South East)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/australiasoutheast", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: australiasoutheast (Australia South East)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf frmMain.dropRegion.Text = "japanwest (Japan West)" Then
                    writeIniValue("ONLINE", "DataCenterHint", "playfab/japanwest", R6FullProfilePath)
                    frmMain.btnApply.Enabled = False
                    MessageBox.Show("Settings saved successfully!" & vbNewLine & vbNewLine & "Profile: " & frmMain.dropProfile.Text & vbNewLine & "Region: japanwest (Japan West)" & vbNewLine & "Read-only: " & frmMain.cbReadOnly.Checked, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("ERROR: Error while applying the region change!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If

            Else
                MessageBox.Show("ERROR: Error while reading the application state!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End If

        ElseIf Not IO.File.Exists(R6FullProfilePath) Then

            MessageBox.Show("ERROR: No configuration files for Tom Clancy's Rainbow Six® Siege were found for this profile!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            MessageBox.Show("ERROR: Unknown error while applying the region change!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

    End Sub

#End Region


End Class
