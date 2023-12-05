-- Creación de Procedimiento Almacenado SP_InsertarTicket
DELIMITER $$

CREATE PROCEDURE SP_InsertarTicket (
        IN p_usuario_id INT,
        IN p_categoria_id INT, 
        IN p_prioridad_id INT,
        IN p_estado_id INT,
    	IN p_descripcion VARCHAR(255),
        IN p_evidencia VARCHAR(255),
        OUT p_resultado INT
)

BEGIN
	DECLARE EXIT HANDLER FOR SQLEXCEPTION
        BEGIN
            ROLLBACK;
            SET p_resultado = 0;
        END;

        START TRANSACTION;
        
        INSERT INTO tickets (usuario_id, categoria_id, prioridad_id, estado_id, descripcion, evidencia) 
        VALUES (p_usuario_id, p_categoria_id, p_prioridad_id, p_estado_id, p_descripcion, p_evidencia);
        
        SELECT ROW_COUNT() INTO p_resultado;
    	COMMIT;
END $$
 
DELIMITER ;


-- Procedimiento almacenado para obtener todas las categorias de los tickets
DELIMITER $$

CREATE PROCEDURE SP_ObtenerCategoriasTickets()
READS SQL DATA
BEGIN
    SELECT id_tickets_categoria, categoria FROM tickets_categoria;
END $$

DELIMITER ;
