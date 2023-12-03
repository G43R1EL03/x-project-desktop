Public Class frmMenuReportes
    Private Sub InventarioGlobalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioGlobalToolStripMenuItem.Click
        SetPanel(frmReporteInventario, panelTablaReportes)
    End Sub

    Private Sub ReporteDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeClientesToolStripMenuItem.Click
        SetPanel(frmReporteClientes, panelTablaReportes)
    End Sub

End Class