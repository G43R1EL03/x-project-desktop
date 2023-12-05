-- Creación del procedimiento para llenar el DataGridView de Inventario
DELIMITER $$
CREATE PROCEDURE SP_VerInventario()

BEGIN

    SELECT
        pr.nombre AS 'Producto', ca.nombre AS 'Categoria', ma.nombre AS 'Marca',
        pr.precio_unit AS 'Precio Unit', pr.cantidad_por_cajas AS 'Stock', pr.foto AS 'foto',
        CASE pr.punto_reorden
            WHEN 0 THEN 'No aplica'
            WHEN 1 THEN 'Aplica'
        END AS 'P.reorden'

    FROM
        producto AS pr
    JOIN categoria AS ca ON pr.categoria_id = ca.id_categoria
    JOIN marca AS ma ON pr.marca_id = ma.id_marca;

END $$
DELIMITER ;