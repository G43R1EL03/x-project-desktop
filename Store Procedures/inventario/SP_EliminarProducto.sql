-- Creación del procedimiento para
--DELIMITER $$

CREATE PROCEDURE SP_EliminarProductos(IN id INT)
BEGIN
    DELETE FROM producto WHERE id_producto = id;
END;

$$
DELIMITER ;