Imports Syncfusion.Windows.Forms

Public Class frmMain
    Inherits MetroForm

    Private Sub ConfigurazioneImpiantoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazioneImpiantoToolStripMenuItem.Click
        frmConfImpianti.ShowDialog()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmConfImpianti.visualizzaGeneratoriAttivi()
    End Sub

    Private Sub ConfigurazioneTemperatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazioneTemperatureToolStripMenuItem.Click
        frmConfTemperature.ShowDialog()
    End Sub

    Private Sub ConfigurazonePrioritàEPotenzeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazonePrioritàEPotenzeToolStripMenuItem.Click
        frmConfDispPot.ShowDialog()
    End Sub

    Private Sub ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem.Click
        frmConfScheduler.ShowDialog()
    End Sub
End Class
