<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnApply = New System.Windows.Forms.Button()
        Me.dropProfile = New System.Windows.Forms.ComboBox()
        Me.lblSelectProfile = New System.Windows.Forms.Label()
        Me.lblSelectRegion = New System.Windows.Forms.Label()
        Me.dropRegion = New System.Windows.Forms.ComboBox()
        Me.cbReadOnly = New System.Windows.Forms.CheckBox()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.pbInfo = New System.Windows.Forms.PictureBox()
        Me.pbBackGr = New System.Windows.Forms.PictureBox()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBackGr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(271, 180)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 27)
        Me.btnApply.TabIndex = 0
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'dropProfile
        '
        Me.dropProfile.BackColor = System.Drawing.Color.White
        Me.dropProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropProfile.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropProfile.FormattingEnabled = True
        Me.dropProfile.Location = New System.Drawing.Point(109, 98)
        Me.dropProfile.Name = "dropProfile"
        Me.dropProfile.Size = New System.Drawing.Size(237, 22)
        Me.dropProfile.TabIndex = 1
        '
        'lblSelectProfile
        '
        Me.lblSelectProfile.AutoSize = True
        Me.lblSelectProfile.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectProfile.Location = New System.Drawing.Point(9, 101)
        Me.lblSelectProfile.Name = "lblSelectProfile"
        Me.lblSelectProfile.Size = New System.Drawing.Size(87, 15)
        Me.lblSelectProfile.TabIndex = 2
        Me.lblSelectProfile.Text = "Select UplayID"
        '
        'lblSelectRegion
        '
        Me.lblSelectRegion.AutoSize = True
        Me.lblSelectRegion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectRegion.Location = New System.Drawing.Point(9, 128)
        Me.lblSelectRegion.Name = "lblSelectRegion"
        Me.lblSelectRegion.Size = New System.Drawing.Size(84, 15)
        Me.lblSelectRegion.TabIndex = 3
        Me.lblSelectRegion.Text = "Select Region"
        '
        'dropRegion
        '
        Me.dropRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropRegion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropRegion.FormattingEnabled = True
        Me.dropRegion.Items.AddRange(New Object() {"", "default (ping based) [recommended]", "eastus (US East)", "centralus (US Central)", "southcentralus (US South Central)", "westus (US West)", "brazilsouth (Brazil South)", "northeurope (Europe North)", "westeurope (Europe West)", "southafricanorth (Africa South North)", "eastasia (Asia East)", "southeastasia (Asia South East)", "australiaeast (Australia East)", "australiasoutheast (Australia South East)", "japanwest (Japan West)"})
        Me.dropRegion.Location = New System.Drawing.Point(109, 125)
        Me.dropRegion.Name = "dropRegion"
        Me.dropRegion.Size = New System.Drawing.Size(237, 22)
        Me.dropRegion.TabIndex = 4
        '
        'cbReadOnly
        '
        Me.cbReadOnly.AutoSize = True
        Me.cbReadOnly.BackColor = System.Drawing.SystemColors.Control
        Me.cbReadOnly.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReadOnly.Location = New System.Drawing.Point(190, 185)
        Me.cbReadOnly.Name = "cbReadOnly"
        Me.cbReadOnly.Size = New System.Drawing.Size(75, 18)
        Me.cbReadOnly.TabIndex = 5
        Me.cbReadOnly.Text = "Read-only"
        Me.cbReadOnly.UseVisualStyleBackColor = False
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.Red
        Me.lblInformation.Location = New System.Drawing.Point(106, 81)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(0, 14)
        Me.lblInformation.TabIndex = 7
        '
        'pbLogo
        '
        Me.pbLogo.ErrorImage = Global.R6RegionChanger.My.Resources.Resources.picBanner
        Me.pbLogo.Image = Global.R6RegionChanger.My.Resources.Resources.picBanner
        Me.pbLogo.InitialImage = Global.R6RegionChanger.My.Resources.Resources.picBanner
        Me.pbLogo.Location = New System.Drawing.Point(-2, -1)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(363, 66)
        Me.pbLogo.TabIndex = 11
        Me.pbLogo.TabStop = False
        '
        'pbInfo
        '
        Me.pbInfo.BackColor = System.Drawing.SystemColors.Control
        Me.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbInfo.ErrorImage = CType(resources.GetObject("pbInfo.ErrorImage"), System.Drawing.Image)
        Me.pbInfo.Image = CType(resources.GetObject("pbInfo.Image"), System.Drawing.Image)
        Me.pbInfo.InitialImage = CType(resources.GetObject("pbInfo.InitialImage"), System.Drawing.Image)
        Me.pbInfo.Location = New System.Drawing.Point(12, 185)
        Me.pbInfo.Name = "pbInfo"
        Me.pbInfo.Size = New System.Drawing.Size(17, 18)
        Me.pbInfo.TabIndex = 10
        Me.pbInfo.TabStop = False
        '
        'pbBackGr
        '
        Me.pbBackGr.BackColor = System.Drawing.SystemColors.Control
        Me.pbBackGr.Location = New System.Drawing.Point(-3, 173)
        Me.pbBackGr.Name = "pbBackGr"
        Me.pbBackGr.Size = New System.Drawing.Size(366, 42)
        Me.pbBackGr.TabIndex = 9
        Me.pbBackGr.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(358, 214)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.pbInfo)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.cbReadOnly)
        Me.Controls.Add(Me.dropRegion)
        Me.Controls.Add(Me.lblSelectRegion)
        Me.Controls.Add(Me.lblSelectProfile)
        Me.Controls.Add(Me.dropProfile)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.pbBackGr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "R6 Region Changer Tool"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBackGr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents dropProfile As ComboBox
    Friend WithEvents lblSelectProfile As Label
    Friend WithEvents lblSelectRegion As Label
    Friend WithEvents dropRegion As ComboBox
    Friend WithEvents cbReadOnly As CheckBox
    Friend WithEvents lblInformation As Label
    Friend WithEvents pbBackGr As PictureBox
    Friend WithEvents pbInfo As PictureBox
    Friend WithEvents pbLogo As PictureBox
End Class
