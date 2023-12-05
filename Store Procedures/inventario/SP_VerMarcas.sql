-- Creación del procedimiento para ver todas las marcas
DELIMITER $$
CREATE PROCEDURE SP_VerMarcas()

BEGIN

    SELECT * FROM marca;

END $$
DELIMITER ;