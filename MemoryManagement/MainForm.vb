Public Class MainForm

    Private Sub btnFija_Click(sender As Object, e As EventArgs) Handles btnFija.Click

        Dim frmPartFijaCfg As ParticionFijaCfg = New ParticionFijaCfg()
        frmPartFijaCfg.ShowDialog()

    End Sub

    Private Sub btnDinamica_Click(sender As Object, e As EventArgs) Handles btnDinamica.Click

        Dim frmPartDinamicaCfg As ParticionDinamicaCfg = New ParticionDinamicaCfg()
        frmPartDinamicaCfg.ShowDialog()

    End Sub
End Class