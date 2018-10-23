Imports Syncfusion.Windows.Forms

Public Class frmConfDispPot
    Inherits MetroForm

    Private Sub MetroForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim verificaPriority As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

        verificaPriority.Add("nupCFFSpriority", nupCFFSpriority.Value)
        verificaPriority.Add("nupCFERpriority", nupCFERpriority.Value)
        verificaPriority.Add("nupASHPpriority", nupASHPpriority.Value)
        verificaPriority.Add("nupGSHPpriority", nupGSHPpriority.Value)

        If Not verificaPriority.ContainsValue(1) Or
            Not verificaPriority.ContainsValue(2) Or
            Not verificaPriority.ContainsValue(3) Or
            Not verificaPriority.ContainsValue(4) Then
            MsgBox("La sequenza delle priorità non è corretta. Verificare che non ci siano doppioni.")
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