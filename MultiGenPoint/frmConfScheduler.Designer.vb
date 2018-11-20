<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfScheduler
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SfButton1 = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButton2 = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButton3 = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButton4 = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButton5 = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButton6 = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButton7 = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButton8 = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButton9 = New Syncfusion.WinForms.Controls.SfButton()
        Me.MultiGenPointCalendarStrip1 = New MultiLibrary.MultiGenPointCalendarStrip()
        Me.MultiGenPointCalendarStrip2 = New MultiLibrary.MultiGenPointCalendarStrip()
        Me.MultiGenPointCalendarStrip3 = New MultiLibrary.MultiGenPointCalendarStrip()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(509, 253)
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
        Me.Label3.Location = New System.Drawing.Point(15, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Caldaia a fonte fossile"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Caldaia a fonte rinnovabile"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Pompe di calore (aria/acqua)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Pannelli solari non ACS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cascame termico"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(160, 181)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "(non applicabile)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "(non applicabile)"
        '
        'SfButton1
        '
        Me.SfButton1.AccessibleName = "Button"
        Me.SfButton1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfButton1.Location = New System.Drawing.Point(163, 80)
        Me.SfButton1.Name = "SfButton1"
        Me.SfButton1.Size = New System.Drawing.Size(55, 20)
        Me.SfButton1.TabIndex = 5
        Me.SfButton1.Tag = "CFFS_Fascia1"
        Me.SfButton1.Text = "Fascia 1"
        '
        'SfButton2
        '
        Me.SfButton2.AccessibleName = "Button"
        Me.SfButton2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfButton2.Location = New System.Drawing.Point(224, 80)
        Me.SfButton2.Name = "SfButton2"
        Me.SfButton2.Size = New System.Drawing.Size(55, 20)
        Me.SfButton2.TabIndex = 5
        Me.SfButton2.Tag = "CFFS_Fascia2"
        Me.SfButton2.Text = "Fascia 2"
        '
        'SfButton3
        '
        Me.SfButton3.AccessibleName = "Button"
        Me.SfButton3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfButton3.Location = New System.Drawing.Point(285, 80)
        Me.SfButton3.Name = "SfButton3"
        Me.SfButton3.Size = New System.Drawing.Size(55, 20)
        Me.SfButton3.TabIndex = 5
        Me.SfButton3.Tag = "CFFS_Fascia3"
        Me.SfButton3.Text = "Fascia3"
        '
        'SfButton4
        '
        Me.SfButton4.AccessibleName = "Button"
        Me.SfButton4.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfButton4.Location = New System.Drawing.Point(163, 114)
        Me.SfButton4.Name = "SfButton4"
        Me.SfButton4.Size = New System.Drawing.Size(55, 20)
        Me.SfButton4.TabIndex = 5
        Me.SfButton4.Text = "Fascia 1"
        '
        'SfButton5
        '
        Me.SfButton5.AccessibleName = "Button"
        Me.SfButton5.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfButton5.Location = New System.Drawing.Point(224, 114)
        Me.SfButton5.Name = "SfButton5"
        Me.SfButton5.Size = New System.Drawing.Size(55, 20)
        Me.SfButton5.TabIndex = 5
        Me.SfButton5.Text = "Fascia 2"
        '
        'SfButton6
        '
        Me.SfButton6.AccessibleName = "Button"
        Me.SfButton6.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfButton6.Location = New System.Drawing.Point(285, 114)
        Me.SfButton6.Name = "SfButton6"
        Me.SfButton6.Size = New System.Drawing.Size(55, 20)
        Me.SfButton6.TabIndex = 5
        Me.SfButton6.Text = "Fascia 3"
        '
        'SfButton7
        '
        Me.SfButton7.AccessibleName = "Button"
        Me.SfButton7.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfButton7.Location = New System.Drawing.Point(163, 148)
        Me.SfButton7.Name = "SfButton7"
        Me.SfButton7.Size = New System.Drawing.Size(55, 20)
        Me.SfButton7.TabIndex = 5
        Me.SfButton7.Text = "Fascia 1"
        '
        'SfButton8
        '
        Me.SfButton8.AccessibleName = "Button"
        Me.SfButton8.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfButton8.Location = New System.Drawing.Point(224, 148)
        Me.SfButton8.Name = "SfButton8"
        Me.SfButton8.Size = New System.Drawing.Size(55, 20)
        Me.SfButton8.TabIndex = 5
        Me.SfButton8.Text = "Fascia 2"
        '
        'SfButton9
        '
        Me.SfButton9.AccessibleName = "Button"
        Me.SfButton9.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfButton9.Location = New System.Drawing.Point(285, 148)
        Me.SfButton9.Name = "SfButton9"
        Me.SfButton9.Size = New System.Drawing.Size(55, 20)
        Me.SfButton9.TabIndex = 5
        Me.SfButton9.Text = "Fascia 3"
        '
        'MultiGenPointCalendarStrip1
        '
        Me.MultiGenPointCalendarStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiGenPointCalendarStrip1.Location = New System.Drawing.Point(347, 70)
        Me.MultiGenPointCalendarStrip1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MultiGenPointCalendarStrip1.Name = "MultiGenPointCalendarStrip1"
        Me.MultiGenPointCalendarStrip1.Size = New System.Drawing.Size(288, 30)
        Me.MultiGenPointCalendarStrip1.TabIndex = 6
        '
        'MultiGenPointCalendarStrip2
        '
        Me.MultiGenPointCalendarStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiGenPointCalendarStrip2.Location = New System.Drawing.Point(347, 104)
        Me.MultiGenPointCalendarStrip2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MultiGenPointCalendarStrip2.Name = "MultiGenPointCalendarStrip2"
        Me.MultiGenPointCalendarStrip2.Size = New System.Drawing.Size(288, 30)
        Me.MultiGenPointCalendarStrip2.TabIndex = 6
        '
        'MultiGenPointCalendarStrip3
        '
        Me.MultiGenPointCalendarStrip3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiGenPointCalendarStrip3.Location = New System.Drawing.Point(347, 138)
        Me.MultiGenPointCalendarStrip3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MultiGenPointCalendarStrip3.Name = "MultiGenPointCalendarStrip3"
        Me.MultiGenPointCalendarStrip3.Size = New System.Drawing.Size(288, 30)
        Me.MultiGenPointCalendarStrip3.TabIndex = 6
        '
        'frmConfScheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 294)
        Me.Controls.Add(Me.MultiGenPointCalendarStrip3)
        Me.Controls.Add(Me.MultiGenPointCalendarStrip2)
        Me.Controls.Add(Me.MultiGenPointCalendarStrip1)
        Me.Controls.Add(Me.SfButton9)
        Me.Controls.Add(Me.SfButton6)
        Me.Controls.Add(Me.SfButton3)
        Me.Controls.Add(Me.SfButton8)
        Me.Controls.Add(Me.SfButton5)
        Me.Controls.Add(Me.SfButton2)
        Me.Controls.Add(Me.SfButton7)
        Me.Controls.Add(Me.SfButton4)
        Me.Controls.Add(Me.SfButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmConfScheduler"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SfButton1 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfButton2 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfButton3 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfButton4 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfButton5 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfButton6 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfButton7 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfButton8 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfButton9 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents MultiGenPointCalendarStrip1 As MultiLibrary.MultiGenPointCalendarStrip
    Friend WithEvents MultiGenPointCalendarStrip2 As MultiLibrary.MultiGenPointCalendarStrip
    Friend WithEvents MultiGenPointCalendarStrip3 As MultiLibrary.MultiGenPointCalendarStrip
End Class