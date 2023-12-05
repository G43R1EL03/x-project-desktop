Public Interface inventaryInterfaces

    'Select que despliega todos los productos del inventario en el datagridview
    Function VerInventario() As DataTable

    'Select - Insert - Update - Delete -> Productos
    Function VerProductos() As DataTable
    Function InsertarProducto(nombre As String, precioUnitario As Decimal, cantidadPorCajas As Integer?, puntoReorden As Integer?, cantidadCajas As Integer?, marcaId As Integer, categoriaId As Integer, imagen As Image) As Boolean
    Function ActualizarProducto() As Integer
    Function EliminarProducto() As Integer

    'Select - Insert - Update - Delete -> Marcas
    Function VerMarcas() As DataTable
    Function InsertarMarca() As Integer
    Function ActualizarMarca() As Integer
    Function EliminarMarca() As Integer

    'Select - Insert - Update - Delete -> Categorias
    Function VerCategorias() As DataTable
    Function InsertaCategorias() As Integer
    Function ActualizarCategorias() As Integer
    Function EliminarCategorias() As Integer

End Interface