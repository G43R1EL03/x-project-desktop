-- Procedimiento para ver Marcas
DELIMITER $$
CREATE PROCEDURE SP_VerMarcas()
BEGIN

    SELECT * FROM marca;

END $$
DELIMITER ;


-- Procedimiento para insetar Marcas
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


-- Procedimiento para eliminar Marcas
DELIMITER $$
CREATE PROCEDURE SP_EliminarMarcas()
BEGIN

END $$
DELIMITER ;


-- Procedimiento para actualizar Marcas
DELIMITER $$
CREATE PROCEDURE SP_ActualizarMarcas()
BEGIN

END $$
DELIMITER ;