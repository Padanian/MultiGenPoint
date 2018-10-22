<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTimeshift
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbONhour = New System.Windows.Forms.ComboBox()
        Me.cbONminute = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbOFFhour = New System.Windows.Forms.ComboBox()
        Me.cbOFFminute = New System.Windows.Forms.ComboBox()
        Me.chkLunedi = New System.Windows.Forms.CheckBox()
        Me.chkMartedi = New System.Windows.Forms.CheckBox()
        Me.chkMercoledi = New System.Windows.Forms.CheckBox()
        Me.chkGiovedi = New System.Windows.Forms.CheckBox()
        Me.chkVenerdi = New System.Windows.Forms.CheckBox()
        Me.chkSabato = New System.Windows.Forms.CheckBox()
        Me.chkDomenica = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(209, 169)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fascia oraria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(9, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ":"
        '
        'cbONhour
        '
        Me.cbONhour.FormattingEnabled = True
        Me.cbONhour.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbONhour.Location = New System.Drawing.Point(89, 69)
        Me.cbONhour.Name = "cbONhour"
        Me.cbONhour.Size = New System.Drawing.Size(46, 21)
        Me.cbONhour.TabIndex = 6
        Me.cbONhour.Text = "00"
        '
        'cbONminute
        '
        Me.cbONminute.FormattingEnabled = True
        Me.cbONminute.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbONminute.Location = New System.Drawing.Point(149, 69)
        Me.cbONminute.Name = "cbONminute"
        Me.cbONminute.Size = New System.Drawing.Size(46, 21)
        Me.cbONminute.TabIndex = 6
        Me.cbONminute.Text = "00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(126, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Inizio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(263, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(9, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(252, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Fine"
        '
        'cbOFFhour
        '
        Me.cbOFFhour.FormattingEnabled = True
        Me.cbOFFhour.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbOFFhour.Location = New System.Drawing.Point(215, 69)
        Me.cbOFFhour.Name = "cbOFFhour"
        Me.cbOFFhour.Size = New System.Drawing.Size(46, 21)
        Me.cbOFFhour.TabIndex = 6
        Me.cbOFFhour.Text = "00"
        '
        'cbOFFminute
        '
        Me.cbOFFminute.FormattingEnabled = True
        Me.cbOFFminute.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbOFFminute.Location = New System.Drawing.Point(275, 69)
        Me.cbOFFminute.Name = "cbOFFminute"
        Me.cbOFFminute.Size = New System.Drawing.Size(46, 21)
        Me.cbOFFminute.TabIndex = 6
        Me.cbOFFminute.Text = "00"
        '
        'chkLunedi
        '
        Me.chkLunedi.AutoSize = True
        Me.chkLunedi.Location = New System.Drawing.Point(18, 107)
        Me.chkLunedi.Name = "chkLunedi"
        Me.chkLunedi.Size = New System.Drawing.Size(37, 17)
        Me.chkLunedi.TabIndex = 7
        Me.chkLunedi.Text = "Lu"
        Me.chkLunedi.UseVisualStyleBackColor = True
        '
        'chkMartedi
        '
        Me.chkMartedi.AutoSize = True
        Me.chkMartedi.Location = New System.Drawing.Point(62, 107)
        Me.chkMartedi.Name = "chkMartedi"
        Me.chkMartedi.Size = New System.Drawing.Size(42, 17)
        Me.chkMartedi.TabIndex = 7
        Me.chkMartedi.Text = "Ma"
        Me.chkMartedi.UseVisualStyleBackColor = True
        '
        'chkMercoledi
        '
        Me.chkMercoledi.AutoSize = True
        Me.chkMercoledi.Location = New System.Drawing.Point(111, 107)
        Me.chkMercoledi.Name = "chkMercoledi"
        Me.chkMercoledi.Size = New System.Drawing.Size(42, 17)
        Me.chkMercoledi.TabIndex = 7
        Me.chkMercoledi.Text = "Me"
        Me.chkMercoledi.UseVisualStyleBackColor = True
        '
        'chkGiovedi
        '
        Me.chkGiovedi.AutoSize = True
        Me.chkGiovedi.Location = New System.Drawing.Point(160, 107)
        Me.chkGiovedi.Name = "chkGiovedi"
        Me.chkGiovedi.Size = New System.Drawing.Size(35, 17)
        Me.chkGiovedi.TabIndex = 7
        Me.chkGiovedi.Text = "Gi"
        Me.chkGiovedi.UseVisualStyleBackColor = True
        '
        'chkVenerdi
        '
        Me.chkVenerdi.AutoSize = True
        Me.chkVenerdi.Location = New System.Drawing.Point(202, 107)
        Me.chkVenerdi.Name = "chkVenerdi"
        Me.chkVenerdi.Size = New System.Drawing.Size(38, 17)
        Me.chkVenerdi.TabIndex = 7
        Me.chkVenerdi.Text = "Ve"
        Me.chkVenerdi.UseVisualStyleBackColor = True
        '
        'chkSabato
        '
        Me.chkSabato.AutoSize = True
        Me.chkSabato.Location = New System.Drawing.Point(247, 107)
        Me.chkSabato.Name = "chkSabato"
        Me.chkSabato.Size = New System.Drawing.Size(38, 17)
        Me.chkSabato.TabIndex = 7
        Me.chkSabato.Text = "Sa"
        Me.chkSabato.UseVisualStyleBackColor = True
        '
        'chkDomenica
        '
        Me.chkDomenica.AutoSize = True
        Me.chkDomenica.Location = New System.Drawing.Point(292, 107)
        Me.chkDomenica.Name = "chkDomenica"
        Me.chkDomenica.Size = New System.Drawing.Size(40, 17)
        Me.chkDomenica.TabIndex = 7
        Me.chkDomenica.Text = "Do"
        Me.chkDomenica.UseVisualStyleBackColor = True
        '
        'frmTimeshift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 210)
        Me.Controls.Add(Me.chkDomenica)
        Me.Controls.Add(Me.chkSabato)
        Me.Controls.Add(Me.chkVenerdi)
        Me.Controls.Add(Me.chkGiovedi)
        Me.Controls.Add(Me.chkMercoledi)
        Me.Controls.Add(Me.chkMartedi)
        Me.Controls.Add(Me.chkLunedi)
        Me.Controls.Add(Me.cbOFFminute)
        Me.Controls.Add(Me.cbONminute)
        Me.Controls.Add(Me.cbOFFhour)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbONhour)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTimeshift"
        Me.ShowIcon = False
        Me.ShowMaximizeBox = False
        Me.ShowMinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurazione schedulazione di convenienza delle sorgenti"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbONhour As ComboBox
    Friend WithEvents cbONminute As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbOFFhour As ComboBox
    Friend WithEvents cbOFFminute As ComboBox
    Friend WithEvents chkLunedi As CheckBox
    Friend WithEvents chkMartedi As CheckBox
    Friend WithEvents chkMercoledi As CheckBox
    Friend WithEvents chkGiovedi As CheckBox
    Friend WithEvents chkVenerdi As CheckBox
    Friend WithEvents chkSabato As CheckBox
    Friend WithEvents chkDomenica As CheckBox
End Class