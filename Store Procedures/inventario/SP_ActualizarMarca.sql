--Creacion del SP para actualizar una marca
DELIMITER $$
CREATE PROCEDURE SP_ActualizarMarca()

BEGIN

 
   UPDATE marca 
   SET nombre = @nombre, descripcion = @descripcion, logo = @logo WHERE id_marca = @id_marca;
   SELECT * FROM marca WHERE id_marca = @id_marca;

END $$
DELIMITER ;
