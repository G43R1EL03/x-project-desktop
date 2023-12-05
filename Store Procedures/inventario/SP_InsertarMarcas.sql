-- Creación del procedimiento para insertar marca
DELIMITER $$
CREATE PROCEDURE SP_InsertarMarcas(
    IN nombre VARCHAR(255),
    IN descripcion VARCHAR(255),
    IN logo VARCHAR(255)
)
BEGIN

    INSERT INTO marca (nombre, descripcion, logo)
    VALUES (nombre, descripcion, logo);

END $$
DELIMITER ;