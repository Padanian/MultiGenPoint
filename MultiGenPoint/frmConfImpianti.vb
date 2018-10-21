Imports Syncfusion.Windows.Forms

Public Class frmConfImpianti
    Inherits MetroForm

    Private Sub MetroForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 6
            DirectCast(Controls.Find("nupConfImpianto" & i, True)(0), NumericUpDown).Enabled = False
        Next

        clbConfImpianto.SetItemChecked(0, My.Settings.cfgConfImpianto0)
        clbConfImpianto.SetItemChecked(1, My.Settings.cfgConfImpianto1)
        clbConfImpianto.SetItemChecked(2, My.Settings.cfgConfImpianto2)
        clbConfImpianto.SetItemChecked(3, My.Settings.cfgConfImpianto3)
        clbConfImpianto.SetItemChecked(4, My.Settings.cfgConfImpianto4)
        clbConfImpianto.SetItemChecked(5, My.Settings.cfgConfImpianto5)
        clbConfImpianto.SetItemChecked(6, My.Settings.cfgConfImpianto6)

        visualizzaGeneratoriAttivi()

        For Each checkedIndexes In clbConfImpianto.CheckedIndices
            DirectCast(Controls.Find("nupConfImpianto" & checkedIndexes, True)(0), NumericUpDown).Enabled = True
        Next
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim totGeneratori As Integer
        For i = 0 To 6
            totGeneratori = totGeneratori + DirectCast(Controls.Find("nupConfImpianto" & i, True)(0), NumericUpDown).Value
        Next
        If totGeneratori > 7 Then
            MsgBox("Numero di generatori superiore a 7. Ridurre il numero di generatori.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Se è stato premuto ok, salva le impostazioni
        My.Settings.cfgConfImpianto0 = nupConfImpianto0.Enabled
        My.Settings.cfgConfImpianto1 = nupConfImpianto1.Enabled
        My.Settings.cfgConfImpianto2 = nupConfImpianto2.Enabled
        My.Settings.cfgConfImpianto3 = nupConfImpianto3.Enabled
        My.Settings.cfgConfImpianto4 = nupConfImpianto4.Enabled
        My.Settings.cfgConfImpianto5 = nupConfImpianto5.Enabled
        My.Settings.cfgConfImpianto6 = nupConfImpianto6.Enabled
        My.Settings.Save()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        visualizzaGeneratoriAttivi()

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub visualizzaGeneratoriAttivi()
        'Ripristina tutto secondo quanto salvato nelle impostazioni

        If My.Settings.cfgConfImpianto0 Then
            frmMain.pbCFFSburner.Visible = True
        Else
            frmMain.pbCFFSburner.Visible = False
        End If

        If My.Settings.cfgConfImpianto1 Then
            frmMain.pbCFERburner.Visible = True
        Else
            frmMain.pbCFERburner.Visible = False
        End If

        If My.Settings.cfgConfImpianto2 Then
            frmMain.pbASHP.Visible = True
        Else
            frmMain.pbASHP.Visible = False
        End If

        If My.Settings.cfgConfImpianto3 Then
            frmMain.pbGSHP.Visible = True
            frmMain.pbGSHPField.Visible = True
        Else
            frmMain.pbGSHP.Visible = False
            frmMain.pbGSHPField.Visible = False
        End If

        If My.Settings.cfgConfImpianto4 Then
            frmMain.pbGSHPsolar.Visible = True
        Else
            frmMain.pbGSHPsolar.Visible = False
        End If

        If My.Settings.cfgConfImpianto5 Then
            frmMain.pbCTPI.Visible = True
        Else
            frmMain.pbCTPI.Visible = False
        End If

        If My.Settings.cfgConfImpianto6 Then
            frmMain.pbPSECsolar.Visible = True
        Else
            frmMain.pbPSECsolar.Visible = False
        End If
    End Sub

    Private Sub clbConfImpianto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbConfImpianto.SelectedIndexChanged

        'Resetta tutti i numericupdown
        For i = 0 To 6
            DirectCast(Controls.Find("nupConfImpianto" & i, True)(0), NumericUpDown).Enabled = False
        Next

        'Se è selezionata una sorgente, allora deve essere attiva anche la pompa di calore
        If clbConfImpianto.CheckedIndices.Contains(4) Or clbConfImpianto.CheckedIndices.Contains(5) Then
            clbConfImpianto.SetItemChecked(3, CheckState.Checked)
        End If

        'Attiva i numericupdown le cui spunte sono attive
        For Each checkedIndexes In clbConfImpianto.CheckedIndices
            DirectCast(Controls.Find("nupConfImpianto" & checkedIndexes, True)(0), NumericUpDown).Enabled = True
        Next

        'Se è attivo il fossile, visualizzalo
        If clbConfImpianto.CheckedIndices.Contains(0) Then
            frmMain.pbCFFSburner.Visible = True
        Else
            frmMain.pbCFFSburner.Visible = False
        End If

        'Se è attivo il biomassa, visualizzala
        If clbConfImpianto.CheckedIndices.Contains(1) Then
            frmMain.pbCFERburner.Visible = True
        Else
            frmMain.pbCFERburner.Visible = False
        End If

        'Se è attiva la pdc ad aria, visualizzala
        If clbConfImpianto.CheckedIndices.Contains(2) Then
            frmMain.pbASHP.Visible = True
        Else
            frmMain.pbASHP.Visible = False
        End If

        'Se è attiva la pdc ad acqua, visualizzala assieme al suo campo geotermico
        If clbConfImpianto.CheckedIndices.Contains(3) Then
            frmMain.pbGSHP.Visible = True
            frmMain.pbGSHPField.Visible = True
        Else
            frmMain.pbGSHP.Visible = False
            frmMain.pbGSHPField.Visible = False
        End If

        'Se è attivo il solare, visualizzalo
        If clbConfImpianto.CheckedIndices.Contains(4) Then
            frmMain.pbGSHPsolar.Visible = True
        Else
            frmMain.pbGSHPsolar.Visible = False
        End If

        'Se è attivo il cascame termico, visualizzalo
        If clbConfImpianto.CheckedIndices.Contains(5) Then
            frmMain.pbCTPI.Visible = True
        Else
            frmMain.pbCTPI.Visible = False
        End If

        'Se è attivo l'ACS PSEC, visualizzalo
        If clbConfImpianto.CheckedIndices.Contains(6) Then
            frmMain.pbPSECsolar.Visible = True
        Else
            frmMain.pbPSECsolar.Visible = False
        End If

    End Sub
End Class
