<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfImpianti
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.clbConfImpianto = New System.Windows.Forms.CheckedListBox()
        Me.nupConfImpianto0 = New System.Windows.Forms.NumericUpDown()
        Me.nupConfImpianto1 = New System.Windows.Forms.NumericUpDown()
        Me.nupConfImpianto2 = New System.Windows.Forms.NumericUpDown()
        Me.nupConfImpianto3 = New System.Windows.Forms.NumericUpDown()
        Me.nupConfImpianto4 = New System.Windows.Forms.NumericUpDown()
        Me.nupConfImpianto5 = New System.Windows.Forms.NumericUpDown()
        Me.nupConfImpianto6 = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nupConfImpianto0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupConfImpianto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupConfImpianto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupConfImpianto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupConfImpianto4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupConfImpianto5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupConfImpianto6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(443, 208)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annulla"
        '
        'clbConfImpianto
        '
        Me.clbConfImpianto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbConfImpianto.CheckOnClick = True
        Me.clbConfImpianto.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbConfImpianto.FormattingEnabled = True
        Me.clbConfImpianto.Items.AddRange(New Object() {"Caldaia o bruciatore a fonte fossile (metano, gasolio, gpl…) (CFFS)", "Caldaia o bruciatore a FER (cippato, pellet, biomassa in genere) (CFER)", "Pompa di calore ad aria (ASHP)", "Pompa di calore ad acqua, inclusa geotermica (GSHP)", "Pannelli solari non destinati a produzione di ACS (PSGS)", "Cascame termico e recuperi di calore vari (CTPI)", "Pannelli solari destinati a produzione esclusiva di ACS (PSEC)"})
        Me.clbConfImpianto.Location = New System.Drawing.Point(12, 32)
        Me.clbConfImpianto.Name = "clbConfImpianto"
        Me.clbConfImpianto.Size = New System.Drawing.Size(386, 126)
        Me.clbConfImpianto.TabIndex = 3
        '
        'nupConfImpianto0
        '
        Me.nupConfImpianto0.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupConfImpianto0.Location = New System.Drawing.Point(471, 32)
        Me.nupConfImpianto0.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nupConfImpianto0.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupConfImpianto0.Name = "nupConfImpianto0"
        Me.nupConfImpianto0.Size = New System.Drawing.Size(35, 23)
        Me.nupConfImpianto0.TabIndex = 4
        Me.nupConfImpianto0.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nupConfImpianto1
        '
        Me.nupConfImpianto1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupConfImpianto1.Location = New System.Drawing.Point(425, 49)
        Me.nupConfImpianto1.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nupConfImpianto1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupConfImpianto1.Name = "nupConfImpianto1"
        Me.nupConfImpianto1.Size = New System.Drawing.Size(35, 23)
        Me.nupConfImpianto1.TabIndex = 4
        Me.nupConfImpianto1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nupConfImpianto2
        '
        Me.nupConfImpianto2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupConfImpianto2.Location = New System.Drawing.Point(471, 66)
        Me.nupConfImpianto2.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nupConfImpianto2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupConfImpianto2.Name = "nupConfImpianto2"
        Me.nupConfImpianto2.Size = New System.Drawing.Size(35, 23)
        Me.nupConfImpianto2.TabIndex = 4
        Me.nupConfImpianto2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nupConfImpianto3
        '
        Me.nupConfImpianto3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupConfImpianto3.Location = New System.Drawing.Point(425, 81)
        Me.nupConfImpianto3.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nupConfImpianto3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupConfImpianto3.Name = "nupConfImpianto3"
        Me.nupConfImpianto3.Size = New System.Drawing.Size(35, 23)
        Me.nupConfImpianto3.TabIndex = 4
        Me.nupConfImpianto3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nupConfImpianto4
        '
        Me.nupConfImpianto4.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupConfImpianto4.Location = New System.Drawing.Point(471, 99)
        Me.nupConfImpianto4.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nupConfImpianto4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupConfImpianto4.Name = "nupConfImpianto4"
        Me.nupConfImpianto4.Size = New System.Drawing.Size(35, 23)
        Me.nupConfImpianto4.TabIndex = 4
        Me.nupConfImpianto4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nupConfImpianto5
        '
        Me.nupConfImpianto5.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupConfImpianto5.Location = New System.Drawing.Point(425, 116)
        Me.nupConfImpianto5.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nupConfImpianto5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupConfImpianto5.Name = "nupConfImpianto5"
        Me.nupConfImpianto5.Size = New System.Drawing.Size(35, 23)
        Me.nupConfImpianto5.TabIndex = 4
        Me.nupConfImpianto5.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nupConfImpianto6
        '
        Me.nupConfImpianto6.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupConfImpianto6.Location = New System.Drawing.Point(471, 133)
        Me.nupConfImpianto6.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nupConfImpianto6.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupConfImpianto6.Name = "nupConfImpianto6"
        Me.nupConfImpianto6.Size = New System.Drawing.Size(35, 23)
        Me.nupConfImpianto6.TabIndex = 4
        Me.nupConfImpianto6.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmConfImpianti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 249)
        Me.Controls.Add(Me.nupConfImpianto6)
        Me.Controls.Add(Me.nupConfImpianto5)
        Me.Controls.Add(Me.nupConfImpianto4)
        Me.Controls.Add(Me.nupConfImpianto3)
        Me.Controls.Add(Me.nupConfImpianto2)
        Me.Controls.Add(Me.nupConfImpianto1)
        Me.Controls.Add(Me.nupConfImpianto0)
        Me.Controls.Add(Me.clbConfImpianto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmConfImpianti"
        Me.ShowIcon = False
        Me.ShowMaximizeBox = False
        Me.ShowMinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurazione impianto"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nupConfImpianto0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupConfImpianto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupConfImpianto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupConfImpianto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupConfImpianto4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupConfImpianto5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupConfImpianto6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents clbConfImpianto As CheckedListBox
    Friend WithEvents nupConfImpianto0 As NumericUpDown
    Friend WithEvents nupConfImpianto1 As NumericUpDown
    Friend WithEvents nupConfImpianto2 As NumericUpDown
    Friend WithEvents nupConfImpianto3 As NumericUpDown
    Friend WithEvents nupConfImpianto4 As NumericUpDown
    Friend WithEvents nupConfImpianto5 As NumericUpDown
    Friend WithEvents nupConfImpianto6 As NumericUpDown
End Class