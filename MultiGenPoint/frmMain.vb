Imports Syncfusion.Windows.Forms

Public Class frmMain
    Inherits MetroForm

    Private Sub ConfigurazioneImpiantoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazioneImpiantoToolStripMenuItem.Click
        frmConfImpianti.Show
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmConfImpianti.visualizzaGeneratoriAttivi()

    End Sub

    Private Sub ConfigurazioneTemperatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazioneTemperatureToolStripMenuItem.Click
        frmConfTemperature.show
    End Sub
End Class
