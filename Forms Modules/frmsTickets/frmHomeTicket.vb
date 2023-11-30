Public Class frmHomeTicket
    Private Sub TicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketsToolStripMenuItem.Click
        Dim frmTickets As New frmTickets(New ticketsDAO(myConnectionDB))
        frmTickets.Show()
    End Sub
End Class