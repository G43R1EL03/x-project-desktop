Imports System.Windows.Documents
Imports MySql.Data.MySqlClient

Public Class frmInventario
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDGVInventario()
    End Sub

    Private Sub LlenarDGVInventario()
        Dim sqlDa As MySqlDataAdapter
        Dim dtResultado As New DataTable
        Try
            conexionDB()
            myConnection.Open()

            Dim cmd As New MySqlCommand("SP_LlenarDGVInventario", myConnection)
            cmd.CommandType = CommandType.StoredProcedure

            sqlDa = New MySqlDataAdapter(cmd)
            sqlDa.Fill(dtResultado)

            If dtResultado.Rows.Count <> 0 Then
                dgvInventario.DataSource = dtResultado
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConnection.State <> ConnectionState.Closed Then myConnection.Close()
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click

    End Sub
End Class