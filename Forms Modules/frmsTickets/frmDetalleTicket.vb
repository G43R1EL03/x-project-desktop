Imports MySql.Data.MySqlClient
Public Class frmDetalleTicket
    Private _idTicket As Integer
    Private _idUsuario As Integer

    Public Sub New(idUsuario As Integer, idTicket As Integer)
        InitializeComponent()
        _idUsuario = idUsuario
        _idTicket = idTicket
    End Sub

    Public Function ObtenerConexion() As MySqlConnection
        Return DB_Conecction.myConnectionDB
    End Function


    Private Sub CargarDetalleTicket()
        Try

            Dim dao As New ticketsDAO(ObtenerConexion())


            Dim detalle As String = dao.ObtenerTicketPorUsuario(_idUsuario, _idTicket)


            lblDetalle.Text = detalle
        Catch ex As Exception

            MessageBox.Show("Error al cargar el detalle del ticket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub frmDetalleTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDetalleTicket()
    End Sub
End Class