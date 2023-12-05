Public Interface ticketsInterfaces
    Function ObtenerReclamos() As DataTable

    Function InsertarTicket(ByVal categoriaId As Integer, ByVal descripcion As String, ByVal prioridadId As Integer, ByVal rutaImagen As String) As Integer

    Function ObtenerCategorias() As DataTable

    Function ObtenerDetalleTicket(ByVal idTicket As Integer) As String
End Interface