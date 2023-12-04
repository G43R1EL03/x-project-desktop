--Creacion del SP para insertar una marca nueva
DELIMITER $$
CREATE PROCEDURE SP_InsertarMarca()


BEGIN

   INSERT INTO marca (nombre, descripcion, logo) VALUES (@nombre, @descripcion, @logo);
   SELECT * FROM marca WHERE id_marca = LAST_INSERT_ID();

END $$
DELIMITER ;
