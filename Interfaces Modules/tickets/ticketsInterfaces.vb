Public Interface ticketsInterfaces
    Function ObtenerTickets() As DataTable

    Function InsertarTicket(ByVal categoriaId As Integer, ByVal descripcion As String, ByVal prioridadId As Integer, ByVal rutaImagen As String) As Integer

    Function ObtenerCategorias() As DataTable

    Function ObtenerTicketPorUsuario(ByVal idUsuario As Integer, ByVal idTicket As Integer) As String
End Interface