<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmError))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblErrorMsg = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReportBug = New System.Windows.Forms.Button()
        Me.pbBackGr = New System.Windows.Forms.PictureBox()
        Me.pbError = New System.Windows.Forms.PictureBox()
        CType(Me.pbBackGr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(90, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(274, 19)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "An unexpected error has occurred!"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(9, 62)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(93, 16)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "Error message"
        '
        'lblErrorMsg
        '
        Me.lblErrorMsg.Location = New System.Drawing.Point(12, 81)
        Me.lblErrorMsg.Multiline = True
        Me.lblErrorMsg.Name = "lblErrorMsg"
        Me.lblErrorMsg.ReadOnly = True
        Me.lblErrorMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lblErrorMsg.Size = New System.Drawing.Size(374, 60)
        Me.lblErrorMsg.TabIndex = 0
        Me.lblErrorMsg.TabStop = False
        Me.lblErrorMsg.Text = "(null)"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(311, 172)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReportBug
        '
        Me.btnReportBug.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportBug.Location = New System.Drawing.Point(217, 172)
        Me.btnReportBug.Name = "btnReportBug"
        Me.btnReportBug.Size = New System.Drawing.Size(88, 23)
        Me.btnReportBug.TabIndex = 2
        Me.btnReportBug.Text = "Report error"
        Me.btnReportBug.UseVisualStyleBackColor = True
        '
        'pbBackGr
        '
        Me.pbBackGr.BackColor = System.Drawing.SystemColors.Control
        Me.pbBackGr.Location = New System.Drawing.Point(-1, 163)
        Me.pbBackGr.Name = "pbBackGr"
        Me.pbBackGr.Size = New System.Drawing.Size(401, 42)
        Me.pbBackGr.TabIndex = 8
        Me.pbBackGr.TabStop = False
        '
        'pbError
        '
        Me.pbError.Image = Global.R6RegionChanger.My.Resources.Resources.picError
        Me.pbError.Location = New System.Drawing.Point(42, 13)
        Me.pbError.Name = "pbError"
        Me.pbError.Size = New System.Drawing.Size(32, 32)
        Me.pbError.TabIndex = 0
        Me.pbError.TabStop = False
        '
        'frmError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(398, 204)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReportBug)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pbBackGr)
        Me.Controls.Add(Me.lblErrorMsg)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmError"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unexspected error"
        CType(Me.pbBackGr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbError As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblErrorMsg As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReportBug As System.Windows.Forms.Button
    Friend WithEvents pbBackGr As System.Windows.Forms.PictureBox
End Class
