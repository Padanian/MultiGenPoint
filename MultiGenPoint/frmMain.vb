Imports Syncfusion.Windows.Forms

Public Class frmMain
    Inherits MetroForm

    Public Structure GeneratorSchedulerStructure
        Public F1OnHour As String
        Public F1OnMinute As String
        Public F1OffHour As String
        Public F1OffMinute As String
        Public F1Week As Boolean()
        Public F2OnHour As String
        Public F2OnMinute As String
        Public F2OffHour As String
        Public F2OffMinute As String
        Public F2Week As Boolean()
        Public F3OnHour As String
        Public F3OnMinute As String
        Public F3OffHour As String
        Public F3OffMinute As String
        Public F3Week As Boolean()
        Public Sub New(ByVal a As Boolean)
            F1OnHour = "00"
            F1OnMinute = "00"
            F1OffHour = "00"
            F1OffMinute = "00"
            Array.Resize(F1Week, 7)
            F1Week = {Not a, Not a, Not a, Not a, Not a, Not a, Not a}

            F2OnHour = "00"
            F2OnMinute = "00"
            F2OffHour = "00"
            F2OffMinute = "00"
            Array.Resize(F2Week, 7)
            F2Week = {a, a, a, a, a, a, a}

            F3OnHour = "00"
            F3OnMinute = "00"
            F3OffHour = "00"
            F3OffMinute = "00"
            Array.Resize(F3Week, 7)
            F3Week = {a, a, a, a, a, a, a}

        End Sub
    End Structure

    Public GenCFFS_SchedulerStructure As New GeneratorSchedulerStructure(False)
    Public GenCFER_SchedulerStructure As New GeneratorSchedulerStructure(False)
    Public GenHP_SchedulerStructure As New GeneratorSchedulerStructure(False)


    Private Sub ConfigurazioneImpiantoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazioneImpiantoToolStripMenuItem.Click
        frmConfImpianti.ShowDialog()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmConfImpianti.visualizzaGeneratoriAttivi()
        mgtiPSGS.changeName("Tpsgs")
        mgtiPSGS.changeTemp(0)
        mgtiPSGS.changeLED(Color.Gray)
        mgtiCTPI.changeName("Tctpi")
        mgtiCTPI.changeTemp(0)
        mgtiCTPI.changeLED(Color.Gray)
        mgtiGSHP.changeName("Tgshp")
        mgtiGSHP.changeTemp(0)
        mgtiGSHP.changeLED(Color.Gray)
        mgtiASHP.changeName("Tashp")
        mgtiASHP.changeTemp(0)
        mgtiASHP.changeLED(Color.Gray)
        mgtiCFER.changeName("Tcfer")
        mgtiCFER.changeTemp(0)
        mgtiCFER.changeLED(Color.Gray)
        mgtiCFFS.changeName("Tcffs")
        mgtiCFFS.changeTemp(0)
        mgtiCFFS.changeLED(Color.Gray)

    End Sub


    Private Sub ConfigurazioneTemperatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazioneTemperatureToolStripMenuItem.Click
        frmConfTemperature.ShowDialog()
    End Sub

    Private Sub ConfigurazionePrioritàEPotenzeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazonePrioritàEPotenzeToolStripMenuItem.Click
        frmConfDispPot.ShowDialog()
    End Sub

    Private Sub ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurazioneSchedulazioneDiConvenienzaToolStripMenuItem.Click
        frmConfScheduler.ShowDialog()
    End Sub


End Class
