Public Interface inventaryInterfaces

    'Select - Insert - Update - Delete -> Productos
    Function VerProductos() As DataTable
    Function InsertarProducto(nombre As String, precioUnitario As Decimal, cantidadPorCajas As Integer?, puntoReorden As Integer?, cantidadCajas As Integer?, marcaId As Integer, categoriaId As Integer, imagen As Image) As Boolean
    Function ActualizarProducto() As Integer
    Function EliminarProducto() As Integer

    'Select - Insert - Update - Delete -> Marcas
    Function VerMarcas() As DataTable
    Function InsertarMarca(ByVal nombre As String, ByVal descripcion As String, ByVal logo As String) As Integer
    Function ActualizarMarca() As Integer
    Function EliminarMarca() As Integer

    'Select - Insert - Update - Delete -> Categorias
    Function VerCategorias() As DataTable
    Function InsertaCategorias() As Integer
    Function ActualizarCategorias() As Integer
    Function EliminarCategorias() As Integer

End Interface