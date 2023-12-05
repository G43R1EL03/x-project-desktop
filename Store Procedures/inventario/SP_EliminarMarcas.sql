-- Creación del procedimiento para
DELIMITER $$

CREATE PROCEDURE SP_EliminarMarca(IN id INT)
BEGIN
    DELETE FROM Marca WHERE id_marca = id;
END;

$$
DELIMITER ;