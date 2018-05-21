<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.llblUpdates = New System.Windows.Forms.LinkLabel()
        Me.pbPD = New System.Windows.Forms.PictureBox()
        CType(Me.pbPD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(92, 108)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(186, 19)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "R6 Region Changer Tool"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(93, 129)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(84, 14)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Version X.X.X.X"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(41, 165)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(299, 14)
        Me.lblCopyright.TabIndex = 0
        Me.lblCopyright.Text = "Copyright © Passlick Development XXXX. All rights reserved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'llblUpdates
        '
        Me.llblUpdates.AutoSize = True
        Me.llblUpdates.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblUpdates.Location = New System.Drawing.Point(181, 129)
        Me.llblUpdates.Name = "llblUpdates"
        Me.llblUpdates.Size = New System.Drawing.Size(97, 14)
        Me.llblUpdates.TabIndex = 7
        Me.llblUpdates.TabStop = True
        Me.llblUpdates.Text = "Check for Updates"
        '
        'pbPD
        '
        Me.pbPD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPD.ErrorImage = Global.R6RegionChanger.My.Resources.Resources.picPD
        Me.pbPD.Image = Global.R6RegionChanger.My.Resources.Resources.picPD
        Me.pbPD.InitialImage = Global.R6RegionChanger.My.Resources.Resources.picPD
        Me.pbPD.Location = New System.Drawing.Point(-2, -1)
        Me.pbPD.Name = "pbPD"
        Me.pbPD.Size = New System.Drawing.Size(382, 96)
        Me.pbPD.TabIndex = 6
        Me.pbPD.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(377, 188)
        Me.Controls.Add(Me.llblUpdates)
        Me.Controls.Add(Me.pbPD)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About R6 Region Changer Tool"
        CType(Me.pbPD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents pbPD As PictureBox
    Friend WithEvents llblUpdates As LinkLabel
End Class
