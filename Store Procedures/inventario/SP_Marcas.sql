-- Procedimiento para Ver Marcas
DELIMITER $$
CREATE PROCEDURE SP_VerMarcas()
BEGIN

    SELECT * FROM marca;

END $$
DELIMITER ;


-- Procedimiento para Insertar Marcas
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


-- Procedimiento para Eliminar Marcas
DELIMITER $$
CREATE PROCEDURE SP_EliminarMarcas()
BEGIN

END $$
DELIMITER ;



-- Procedimiento para Actualizar Marcas
DELIMITER $$
CREATE PROCEDURE SP_ActualizarMarcas()
BEGIN

END $$
DELIMITER ;