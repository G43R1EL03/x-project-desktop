DELIMITER //

CREATE PROCEDURE SP_InsertarProducto(
    IN p_nombre VARCHAR(255),
    IN p_precio_unit DECIMAL(10, 2),
    IN p_cantidad_por_cajas INT,
    IN p_punto_reorden INT,
    IN p_cantidad_cajas INT,
    IN p_marca_id INT,
    IN p_categoria_id INT
)
BEGIN
   
    INSERT INTO Producto (nombre, precio_unit, cantidad_por_cajas, punto_reorden, cantidad_cajas, marca_id, categoria_id)
    VALUES (p_nombre, p_precio_unit, p_cantidad_por_cajas, p_punto_reorden, p_cantidad_cajas, p_marca_id, p_categoria_id);
    
END //

DELIMITER ;