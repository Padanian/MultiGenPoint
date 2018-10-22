Imports Syncfusion.Windows.Forms

Public Class frmTimeshift
    Inherits MetroForm

    Private Sub MetroForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmConfScheduler.callingButton = 1 Then
            cbONhour.Text = frmMain.GenCFFS_SchedulerStructure.F1OnHour
            cbONminute.Text = frmMain.GenCFFS_SchedulerStructure.F1OnMinute
            cbOFFhour.Text = frmMain.GenCFFS_SchedulerStructure.F1OffHour
            cbOFFminute.Text = frmMain.GenCFFS_SchedulerStructure.F1OffMinute
            chkLunedi.Checked = frmMain.GenCFFS_SchedulerStructure.F1Week(0)
            chkMartedi.Checked = frmMain.GenCFFS_SchedulerStructure.F1Week(1)
            chkMercoledi.Checked = frmMain.GenCFFS_SchedulerStructure.F1Week(2)
            chkGiovedi.Checked = frmMain.GenCFFS_SchedulerStructure.F1Week(3)
            chkVenerdi.Checked = frmMain.GenCFFS_SchedulerStructure.F1Week(4)
            chkSabato.Checked = frmMain.GenCFFS_SchedulerStructure.F1Week(5)
            chkDomenica.Checked = frmMain.GenCFFS_SchedulerStructure.F1Week(6)
        ElseIf frmConfScheduler.callingButton = 2 Then
            cbONhour.Text = frmMain.GenCFFS_SchedulerStructure.F2OnHour
            cbONminute.Text = frmMain.GenCFFS_SchedulerStructure.F2OnMinute
            cbOFFhour.Text = frmMain.GenCFFS_SchedulerStructure.F2OffHour
            cbOFFminute.Text = frmMain.GenCFFS_SchedulerStructure.F2OffMinute
            chkLunedi.Checked = frmMain.GenCFFS_SchedulerStructure.F2Week(0)
            chkMartedi.Checked = frmMain.GenCFFS_SchedulerStructure.F2Week(1)
            chkMercoledi.Checked = frmMain.GenCFFS_SchedulerStructure.F2Week(2)
            chkGiovedi.Checked = frmMain.GenCFFS_SchedulerStructure.F2Week(3)
            chkVenerdi.Checked = frmMain.GenCFFS_SchedulerStructure.F2Week(4)
            chkSabato.Checked = frmMain.GenCFFS_SchedulerStructure.F2Week(5)
            chkDomenica.Checked = frmMain.GenCFFS_SchedulerStructure.F2Week(6)
        ElseIf frmConfScheduler.callingButton = 3 Then
            cbONhour.Text = frmMain.GenCFFS_SchedulerStructure.F3OnHour
            cbONminute.Text = frmMain.GenCFFS_SchedulerStructure.F3OnMinute
            cbOFFhour.Text = frmMain.GenCFFS_SchedulerStructure.F3OffHour
            cbOFFminute.Text = frmMain.GenCFFS_SchedulerStructure.F3OffMinute
            chkLunedi.Checked = frmMain.GenCFFS_SchedulerStructure.F3Week(0)
            chkMartedi.Checked = frmMain.GenCFFS_SchedulerStructure.F3Week(1)
            chkMercoledi.Checked = frmMain.GenCFFS_SchedulerStructure.F3Week(2)
            chkGiovedi.Checked = frmMain.GenCFFS_SchedulerStructure.F3Week(3)
            chkVenerdi.Checked = frmMain.GenCFFS_SchedulerStructure.F3Week(4)
            chkSabato.Checked = frmMain.GenCFFS_SchedulerStructure.F3Week(5)
            chkDomenica.Checked = frmMain.GenCFFS_SchedulerStructure.F3Week(6)
        End If
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If Integer.Parse(cbONhour.Text) > Integer.Parse(cbOFFhour.Text) Then
            MsgBox("Ora di fine fascia precedente all'ora di inizio fascia. Impossibile procedere.")
            Exit Sub
        ElseIf Integer.Parse(cbONhour.Text) = Integer.Parse(cbOFFhour.Text) And Integer.Parse(cbONminute.Text) > Integer.Parse(cbOFFminute.Text) Then
            MsgBox("Minuto di fine fascia precedente al minuto di inizio fascia. Impossibile procedere.")
            Exit Sub
        End If

        If frmConfScheduler.callingButton = 1 Then
            frmMain.GenCFFS_SchedulerStructure.F1OnHour = cbONhour.Text
            frmMain.GenCFFS_SchedulerStructure.F1OnMinute = cbONminute.Text
            frmMain.GenCFFS_SchedulerStructure.F1OffHour = cbOFFhour.Text
            frmMain.GenCFFS_SchedulerStructure.F1OffMinute = cbOFFminute.Text
            frmMain.GenCFFS_SchedulerStructure.F1Week(0) = chkLunedi.Checked
            frmMain.GenCFFS_SchedulerStructure.F1Week(1) = chkMartedi.Checked
            frmMain.GenCFFS_SchedulerStructure.F1Week(2) = chkMercoledi.Checked
            frmMain.GenCFFS_SchedulerStructure.F1Week(3) = chkGiovedi.Checked
            frmMain.GenCFFS_SchedulerStructure.F1Week(4) = chkVenerdi.Checked
            frmMain.GenCFFS_SchedulerStructure.F1Week(5) = chkSabato.Checked
            frmMain.GenCFFS_SchedulerStructure.F1Week(6) = chkDomenica.Checked
        ElseIf frmConfScheduler.callingButton = 2 Then
            frmMain.GenCFFS_SchedulerStructure.F2OnHour = cbONhour.Text
            frmMain.GenCFFS_SchedulerStructure.F2OnMinute = cbONminute.Text
            frmMain.GenCFFS_SchedulerStructure.F2OffHour = cbOFFhour.Text
            frmMain.GenCFFS_SchedulerStructure.F2OffMinute = cbOFFminute.Text
            frmMain.GenCFFS_SchedulerStructure.F2Week(0) = chkLunedi.Checked
            frmMain.GenCFFS_SchedulerStructure.F2Week(1) = chkMartedi.Checked
            frmMain.GenCFFS_SchedulerStructure.F2Week(2) = chkMercoledi.Checked
            frmMain.GenCFFS_SchedulerStructure.F2Week(3) = chkGiovedi.Checked
            frmMain.GenCFFS_SchedulerStructure.F2Week(4) = chkVenerdi.Checked
            frmMain.GenCFFS_SchedulerStructure.F2Week(5) = chkSabato.Checked
            frmMain.GenCFFS_SchedulerStructure.F2Week(6) = chkDomenica.Checked
        ElseIf frmConfScheduler.callingButton = 3 Then
            frmMain.GenCFFS_SchedulerStructure.F3OnHour = cbONhour.Text
            frmMain.GenCFFS_SchedulerStructure.F3OnMinute = cbONminute.Text
            frmMain.GenCFFS_SchedulerStructure.F3OffHour = cbOFFhour.Text
            frmMain.GenCFFS_SchedulerStructure.F3OffMinute = cbOFFminute.Text
            frmMain.GenCFFS_SchedulerStructure.F3Week(0) = chkLunedi.Checked
            frmMain.GenCFFS_SchedulerStructure.F3Week(1) = chkMartedi.Checked
            frmMain.GenCFFS_SchedulerStructure.F3Week(2) = chkMercoledi.Checked
            frmMain.GenCFFS_SchedulerStructure.F3Week(3) = chkGiovedi.Checked
            frmMain.GenCFFS_SchedulerStructure.F3Week(4) = chkVenerdi.Checked
            frmMain.GenCFFS_SchedulerStructure.F3Week(5) = chkSabato.Checked
            frmMain.GenCFFS_SchedulerStructure.F3Week(6) = chkDomenica.Checked
        ElseIf frmConfScheduler.callingButton = 4 Then
            frmMain.GenCFER_SchedulerStructure.F1OnHour = cbONhour.Text
            frmMain.GenCFER_SchedulerStructure.F1OnMinute = cbONminute.Text
            frmMain.GenCFER_SchedulerStructure.F1OffHour = cbOFFhour.Text
            frmMain.GenCFER_SchedulerStructure.F1OffMinute = cbOFFminute.Text
            frmMain.GenCFER_SchedulerStructure.F1Week(0) = chkLunedi.Checked
            frmMain.GenCFER_SchedulerStructure.F1Week(1) = chkMartedi.Checked
            frmMain.GenCFER_SchedulerStructure.F1Week(2) = chkMercoledi.Checked
            frmMain.GenCFER_SchedulerStructure.F1Week(3) = chkGiovedi.Checked
            frmMain.GenCFER_SchedulerStructure.F1Week(4) = chkVenerdi.Checked
            frmMain.GenCFER_SchedulerStructure.F1Week(5) = chkSabato.Checked
            frmMain.GenCFER_SchedulerStructure.F1Week(6) = chkDomenica.Checked
        ElseIf frmConfScheduler.callingButton = 5 Then
            frmMain.GenCFER_SchedulerStructure.F2OnHour = cbONhour.Text
            frmMain.GenCFER_SchedulerStructure.F2OnMinute = cbONminute.Text
            frmMain.GenCFER_SchedulerStructure.F2OffHour = cbOFFhour.Text
            frmMain.GenCFER_SchedulerStructure.F2OffMinute = cbOFFminute.Text
            frmMain.GenCFER_SchedulerStructure.F2Week(0) = chkLunedi.Checked
            frmMain.GenCFER_SchedulerStructure.F2Week(1) = chkMartedi.Checked
            frmMain.GenCFER_SchedulerStructure.F2Week(2) = chkMercoledi.Checked
            frmMain.GenCFER_SchedulerStructure.F2Week(3) = chkGiovedi.Checked
            frmMain.GenCFER_SchedulerStructure.F2Week(4) = chkVenerdi.Checked
            frmMain.GenCFER_SchedulerStructure.F2Week(5) = chkSabato.Checked
            frmMain.GenCFER_SchedulerStructure.F2Week(6) = chkDomenica.Checked
        ElseIf frmConfScheduler.callingButton = 6 Then
            frmMain.GenCFER_SchedulerStructure.F3OnHour = cbONhour.Text
            frmMain.GenCFER_SchedulerStructure.F3OnMinute = cbONminute.Text
            frmMain.GenCFER_SchedulerStructure.F3OffHour = cbOFFhour.Text
            frmMain.GenCFER_SchedulerStructure.F3OffMinute = cbOFFminute.Text
            frmMain.GenCFER_SchedulerStructure.F3Week(0) = chkLunedi.Checked
            frmMain.GenCFER_SchedulerStructure.F3Week(1) = chkMartedi.Checked
            frmMain.GenCFER_SchedulerStructure.F3Week(2) = chkMercoledi.Checked
            frmMain.GenCFER_SchedulerStructure.F3Week(3) = chkGiovedi.Checked
            frmMain.GenCFER_SchedulerStructure.F3Week(4) = chkVenerdi.Checked
            frmMain.GenCFER_SchedulerStructure.F3Week(5) = chkSabato.Checked
            frmMain.GenCFER_SchedulerStructure.F3Week(6) = chkDomenica.Checked
        ElseIf frmConfScheduler.callingButton = 7 Then
            frmMain.GenHP_SchedulerStructure.F1OnHour = cbONhour.Text
            frmMain.GenHP_SchedulerStructure.F1OnMinute = cbONminute.Text
            frmMain.GenHP_SchedulerStructure.F1OffHour = cbOFFhour.Text
            frmMain.GenHP_SchedulerStructure.F1OffMinute = cbOFFminute.Text
            frmMain.GenHP_SchedulerStructure.F1Week(0) = chkLunedi.Checked
            frmMain.GenHP_SchedulerStructure.F1Week(1) = chkMartedi.Checked
            frmMain.GenHP_SchedulerStructure.F1Week(2) = chkMercoledi.Checked
            frmMain.GenHP_SchedulerStructure.F1Week(3) = chkGiovedi.Checked
            frmMain.GenHP_SchedulerStructure.F1Week(4) = chkVenerdi.Checked
            frmMain.GenHP_SchedulerStructure.F1Week(5) = chkSabato.Checked
            frmMain.GenHP_SchedulerStructure.F1Week(6) = chkDomenica.Checked
        ElseIf frmConfScheduler.callingButton = 8 Then
            frmMain.GenHP_SchedulerStructure.F2OnHour = cbONhour.Text
            frmMain.GenHP_SchedulerStructure.F2OnMinute = cbONminute.Text
            frmMain.GenHP_SchedulerStructure.F2OffHour = cbOFFhour.Text
            frmMain.GenHP_SchedulerStructure.F2OffMinute = cbOFFminute.Text
            frmMain.GenHP_SchedulerStructure.F2Week(0) = chkLunedi.Checked
            frmMain.GenHP_SchedulerStructure.F2Week(1) = chkMartedi.Checked
            frmMain.GenHP_SchedulerStructure.F2Week(2) = chkMercoledi.Checked
            frmMain.GenHP_SchedulerStructure.F2Week(3) = chkGiovedi.Checked
            frmMain.GenHP_SchedulerStructure.F2Week(4) = chkVenerdi.Checked
            frmMain.GenHP_SchedulerStructure.F2Week(5) = chkSabato.Checked
            frmMain.GenHP_SchedulerStructure.F2Week(6) = chkDomenica.Checked
        ElseIf frmConfScheduler.callingButton = 9 Then
            frmMain.GenHP_SchedulerStructure.F3OnHour = cbONhour.Text
            frmMain.GenHP_SchedulerStructure.F3OnMinute = cbONminute.Text
            frmMain.GenHP_SchedulerStructure.F3OffHour = cbOFFhour.Text
            frmMain.GenHP_SchedulerStructure.F3OffMinute = cbOFFminute.Text
            frmMain.GenHP_SchedulerStructure.F3Week(0) = chkLunedi.Checked
            frmMain.GenHP_SchedulerStructure.F3Week(1) = chkMartedi.Checked
            frmMain.GenHP_SchedulerStructure.F3Week(2) = chkMercoledi.Checked
            frmMain.GenHP_SchedulerStructure.F3Week(3) = chkGiovedi.Checked
            frmMain.GenHP_SchedulerStructure.F3Week(4) = chkVenerdi.Checked
            frmMain.GenHP_SchedulerStructure.F3Week(5) = chkSabato.Checked
            frmMain.GenHP_SchedulerStructure.F3Week(6) = chkDomenica.Checked
        Else
            MsgBox("Situazione inaspettata.")
            Exit Sub
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class