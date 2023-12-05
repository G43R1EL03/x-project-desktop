Public Interface ticketsInterfaces
    Function ObtenerTickets() As DataTable

    Function InsertarTicket(ByVal categoriaId As Integer, ByVal descripcion As String, ByVal prioridadId As Integer, ByVal rutaImagen As String) As Integer

    Function ObtenerCategorias() As DataTable

    Function ObtenerTicketPorId(ByVal idTicket As Integer) As String

    Function ObtenerEvidenciaPorId(ByVal idTicket As Integer) As String
    Function EliminarTicket(ByVal ticketID As Integer) As Integer

    Function ObtenerEstado() As DataTable

    Function ActualizarEstadoTicket(ByVal ticketId As Integer, ByVal estadoId As Integer) As Integer
End Interface