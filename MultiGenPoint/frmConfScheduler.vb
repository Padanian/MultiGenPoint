Imports Syncfusion.Windows.Forms

Public Class frmConfScheduler
    Inherits MetroForm
    Public callingButton As Integer = 0
    Private Sub MetroForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SfButton1_Click(sender As Object, e As EventArgs) Handles SfButton1.Click, SfButton2.Click, SfButton3.Click,
        SfButton4.Click, SfButton5.Click, SfButton6.Click, SfButton7.Click, SfButton8.Click, SfButton9.Click
        callingButton = Integer.Parse(Strings.Right(sender.name, 1))
        frmTimeshift.ShowDialog()
    End Sub

End Class