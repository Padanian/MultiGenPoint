<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits Syncfusion.Windows.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurazioneImpiantoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurazioneTemperatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurazonePrioritàEPotenzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mgtiCTPI = New MultiGenTemperatureIconLeft.MultiGenTemperatureIconLeft()
        Me.mgtiCFFS = New MultiGenTemperatureIconRight.MultiGenTemperatureIconRight()
        Me.mgtiCFER = New MultiGenTemperatureIconRight.MultiGenTemperatureIconRight()
        Me.mgtiASHP = New MultiGenTemperatureIconRight.MultiGenTemperatureIconRight()
        Me.mgtiGSHP = New MultiGenTemperatureIconRight.MultiGenTemperatureIconRight()
        Me.mgtiPSGS = New MultiGenTemperatureIconRight.MultiGenTemperatureIconRight()
        Me.pbCFFSburner = New System.Windows.Forms.PictureBox()
        Me.pbCFERburner = New System.Windows.Forms.PictureBox()
        Me.pbPSECsolar = New System.Windows.Forms.PictureBox()
        Me.pbGSHP = New System.Windows.Forms.PictureBox()
        Me.pbASHP = New System.Windows.Forms.PictureBox()
        Me.pbCTPI = New System.Windows.Forms.PictureBox()
        Me.pbGSHPField = New System.Windows.Forms.PictureBox()
        Me.pbPSGS = New System.Windows.Forms.PictureBox()
        Me.pbSfondo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbCFFSburner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCFERburner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPSECsolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGSHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbASHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCTPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGSHPField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPSGS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSfondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ModificaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1012, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EsciToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EsciToolStripMenuItem.Text = "&Esci"
        '
        'ModificaToolStripMenuItem
        '
        Me.ModificaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurazioneImpiantoToolStripMenuItem, Me.ConfigurazioneTemperatureToolStripMenuItem, Me.ConfigurazonePrioritàEPotenzeToolStripMenuItem, Me.ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem})
        Me.ModificaToolStripMenuItem.Name = "ModificaToolStripMenuItem"
        Me.ModificaToolStripMenuItem.Size = New System.Drawing.Size(148, 20)
        Me.ModificaToolStripMenuItem.Text = "&Modifica configurazione"
        '
        'ConfigurazioneImpiantoToolStripMenuItem
        '
        Me.ConfigurazioneImpiantoToolStripMenuItem.Name = "ConfigurazioneImpiantoToolStripMenuItem"
        Me.ConfigurazioneImpiantoToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.ConfigurazioneImpiantoToolStripMenuItem.Text = "&Configurazione impianto..."
        '
        'ConfigurazioneTemperatureToolStripMenuItem
        '
        Me.ConfigurazioneTemperatureToolStripMenuItem.Name = "ConfigurazioneTemperatureToolStripMenuItem"
        Me.ConfigurazioneTemperatureToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.ConfigurazioneTemperatureToolStripMenuItem.Text = "C&onfigurazione temperature..."
        '
        'ConfigurazonePrioritàEPotenzeToolStripMenuItem
        '
        Me.ConfigurazonePrioritàEPotenzeToolStripMenuItem.Name = "ConfigurazonePrioritàEPotenzeToolStripMenuItem"
        Me.ConfigurazonePrioritàEPotenzeToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.ConfigurazonePrioritàEPotenzeToolStripMenuItem.Text = "Co&nfigurazione priorità e potenze..."
        '
        'ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem
        '
        Me.ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem.Name = "ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem"
        Me.ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem.Text = "Con&figurazione schedulazione di convenienza..."
        '
        'mgtiCTPI
        '
        Me.mgtiCTPI.BackColor = System.Drawing.Color.Transparent
        Me.mgtiCTPI.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mgtiCTPI.LEDcolor = System.Drawing.Color.Empty
        Me.mgtiCTPI.Location = New System.Drawing.Point(12, 133)
        Me.mgtiCTPI.Name = "mgtiCTPI"
        Me.mgtiCTPI.Size = New System.Drawing.Size(75, 55)
        Me.mgtiCTPI.TabIndex = 22
        Me.mgtiCTPI.TempValue = 0R
        Me.mgtiCTPI.Tname = Nothing
        '
        'mgtiCFFS
        '
        Me.mgtiCFFS.BackColor = System.Drawing.Color.Transparent
        Me.mgtiCFFS.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mgtiCFFS.LEDcolor = System.Drawing.Color.Empty
        Me.mgtiCFFS.Location = New System.Drawing.Point(786, 418)
        Me.mgtiCFFS.Name = "mgtiCFFS"
        Me.mgtiCFFS.Size = New System.Drawing.Size(75, 55)
        Me.mgtiCFFS.TabIndex = 25
        Me.mgtiCFFS.TempValue = 0R
        Me.mgtiCFFS.Tname = Nothing
        '
        'mgtiCFER
        '
        Me.mgtiCFER.BackColor = System.Drawing.Color.Transparent
        Me.mgtiCFER.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mgtiCFER.LEDcolor = System.Drawing.Color.Empty
        Me.mgtiCFER.Location = New System.Drawing.Point(692, 418)
        Me.mgtiCFER.Name = "mgtiCFER"
        Me.mgtiCFER.Size = New System.Drawing.Size(75, 55)
        Me.mgtiCFER.TabIndex = 25
        Me.mgtiCFER.TempValue = 0R
        Me.mgtiCFER.Tname = Nothing
        '
        'mgtiASHP
        '
        Me.mgtiASHP.BackColor = System.Drawing.Color.Transparent
        Me.mgtiASHP.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mgtiASHP.LEDcolor = System.Drawing.Color.Empty
        Me.mgtiASHP.Location = New System.Drawing.Point(295, 495)
        Me.mgtiASHP.Name = "mgtiASHP"
        Me.mgtiASHP.Size = New System.Drawing.Size(75, 55)
        Me.mgtiASHP.TabIndex = 24
        Me.mgtiASHP.TempValue = 0R
        Me.mgtiASHP.Tname = Nothing
        '
        'mgtiGSHP
        '
        Me.mgtiGSHP.BackColor = System.Drawing.Color.Transparent
        Me.mgtiGSHP.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mgtiGSHP.LEDcolor = System.Drawing.Color.Empty
        Me.mgtiGSHP.Location = New System.Drawing.Point(157, 409)
        Me.mgtiGSHP.Name = "mgtiGSHP"
        Me.mgtiGSHP.Size = New System.Drawing.Size(75, 55)
        Me.mgtiGSHP.TabIndex = 23
        Me.mgtiGSHP.TempValue = 0R
        Me.mgtiGSHP.Tname = Nothing
        '
        'mgtiPSGS
        '
        Me.mgtiPSGS.BackColor = System.Drawing.Color.Transparent
        Me.mgtiPSGS.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mgtiPSGS.LEDcolor = System.Drawing.Color.Empty
        Me.mgtiPSGS.Location = New System.Drawing.Point(42, 61)
        Me.mgtiPSGS.Name = "mgtiPSGS"
        Me.mgtiPSGS.Size = New System.Drawing.Size(75, 55)
        Me.mgtiPSGS.TabIndex = 21
        Me.mgtiPSGS.TempValue = 0R
        Me.mgtiPSGS.Tname = ""
        '
        'pbCFFSburner
        '
        Me.pbCFFSburner.Image = Global.MultiGenPoint.My.Resources.Resources.snippet_gas_fired_CFFS
        Me.pbCFFSburner.Location = New System.Drawing.Point(779, 276)
        Me.pbCFFSburner.Name = "pbCFFSburner"
        Me.pbCFFSburner.Size = New System.Drawing.Size(91, 145)
        Me.pbCFFSburner.TabIndex = 7
        Me.pbCFFSburner.TabStop = False
        Me.pbCFFSburner.Visible = False
        '
        'pbCFERburner
        '
        Me.pbCFERburner.Image = Global.MultiGenPoint.My.Resources.Resources.snippet_wood_fired_CFER
        Me.pbCFERburner.Location = New System.Drawing.Point(682, 276)
        Me.pbCFERburner.Name = "pbCFERburner"
        Me.pbCFERburner.Size = New System.Drawing.Size(91, 145)
        Me.pbCFERburner.TabIndex = 7
        Me.pbCFERburner.TabStop = False
        Me.pbCFERburner.Visible = False
        '
        'pbPSECsolar
        '
        Me.pbPSECsolar.Image = Global.MultiGenPoint.My.Resources.Resources.snippet_solare_acs
        Me.pbPSECsolar.Location = New System.Drawing.Point(554, 36)
        Me.pbPSECsolar.Name = "pbPSECsolar"
        Me.pbPSECsolar.Size = New System.Drawing.Size(369, 369)
        Me.pbPSECsolar.TabIndex = 6
        Me.pbPSECsolar.TabStop = False
        Me.pbPSECsolar.Visible = False
        '
        'pbGSHP
        '
        Me.pbGSHP.Image = Global.MultiGenPoint.My.Resources.Resources.snippet_gshp
        Me.pbGSHP.Location = New System.Drawing.Point(376, 230)
        Me.pbGSHP.Name = "pbGSHP"
        Me.pbGSHP.Size = New System.Drawing.Size(315, 180)
        Me.pbGSHP.TabIndex = 3
        Me.pbGSHP.TabStop = False
        Me.pbGSHP.Visible = False
        '
        'pbASHP
        '
        Me.pbASHP.Image = Global.MultiGenPoint.My.Resources.Resources.snippet_ashp
        Me.pbASHP.Location = New System.Drawing.Point(376, 283)
        Me.pbASHP.Name = "pbASHP"
        Me.pbASHP.Size = New System.Drawing.Size(615, 324)
        Me.pbASHP.TabIndex = 8
        Me.pbASHP.TabStop = False
        '
        'pbCTPI
        '
        Me.pbCTPI.Image = Global.MultiGenPoint.My.Resources.Resources.snippet_cascame_ctpi_2
        Me.pbCTPI.Location = New System.Drawing.Point(14, 194)
        Me.pbCTPI.Name = "pbCTPI"
        Me.pbCTPI.Size = New System.Drawing.Size(103, 169)
        Me.pbCTPI.TabIndex = 5
        Me.pbCTPI.TabStop = False
        Me.pbCTPI.Visible = False
        '
        'pbGSHPField
        '
        Me.pbGSHPField.BackColor = System.Drawing.Color.Transparent
        Me.pbGSHPField.Image = Global.MultiGenPoint.My.Resources.Resources.snippet_geothermal_field
        Me.pbGSHPField.Location = New System.Drawing.Point(238, 271)
        Me.pbGSHPField.Name = "pbGSHPField"
        Me.pbGSHPField.Size = New System.Drawing.Size(50, 178)
        Me.pbGSHPField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGSHPField.TabIndex = 2
        Me.pbGSHPField.TabStop = False
        Me.pbGSHPField.Visible = False
        '
        'pbPSGS
        '
        Me.pbPSGS.Image = Global.MultiGenPoint.My.Resources.Resources.snippet_solare_gshp
        Me.pbPSGS.Location = New System.Drawing.Point(119, 36)
        Me.pbPSGS.Name = "pbPSGS"
        Me.pbPSGS.Size = New System.Drawing.Size(208, 367)
        Me.pbPSGS.TabIndex = 4
        Me.pbPSGS.TabStop = False
        Me.pbPSGS.Visible = False
        '
        'pbSfondo
        '
        Me.pbSfondo.Image = Global.MultiGenPoint.My.Resources.Resources.sfondo
        Me.pbSfondo.Location = New System.Drawing.Point(-6, 27)
        Me.pbSfondo.Name = "pbSfondo"
        Me.pbSfondo.Size = New System.Drawing.Size(1023, 711)
        Me.pbSfondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSfondo.TabIndex = 0
        Me.pbSfondo.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 732)
        Me.Controls.Add(Me.pbCFFSburner)
        Me.Controls.Add(Me.pbCFERburner)
        Me.Controls.Add(Me.pbPSECsolar)
        Me.Controls.Add(Me.mgtiCFFS)
        Me.Controls.Add(Me.mgtiCFER)
        Me.Controls.Add(Me.mgtiASHP)
        Me.Controls.Add(Me.mgtiGSHP)
        Me.Controls.Add(Me.mgtiCTPI)
        Me.Controls.Add(Me.mgtiPSGS)
        Me.Controls.Add(Me.pbGSHP)
        Me.Controls.Add(Me.pbASHP)
        Me.Controls.Add(Me.pbCTPI)
        Me.Controls.Add(Me.pbGSHPField)
        Me.Controls.Add(Me.pbPSGS)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pbSfondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MultiGenPoint"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbCFFSburner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCFERburner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPSECsolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGSHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbASHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCTPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGSHPField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPSGS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSfondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurazioneImpiantoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbGSHPField As PictureBox
    Friend WithEvents pbGSHP As PictureBox
    Friend WithEvents pbPSGS As PictureBox
    Friend WithEvents pbCTPI As PictureBox
    Friend WithEvents pbPSECsolar As PictureBox
    Friend WithEvents pbSfondo As PictureBox
    Friend WithEvents pbCFERburner As PictureBox
    Friend WithEvents pbCFFSburner As PictureBox
    Friend WithEvents pbASHP As PictureBox
    Friend WithEvents ConfigurazioneTemperatureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurazonePrioritàEPotenzeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mgtiPSGS As MultiGenTemperatureIconRight.MultiGenTemperatureIconRight
    Friend WithEvents mgtiCTPI As MultiGenTemperatureIconLeft.MultiGenTemperatureIconLeft
    Friend WithEvents mgtiGSHP As MultiGenTemperatureIconRight.MultiGenTemperatureIconRight
    Friend WithEvents mgtiASHP As MultiGenTemperatureIconRight.MultiGenTemperatureIconRight
    Friend WithEvents mgtiCFER As MultiGenTemperatureIconRight.MultiGenTemperatureIconRight
    Friend WithEvents mgtiCFFS As MultiGenTemperatureIconRight.MultiGenTemperatureIconRight
End Class
