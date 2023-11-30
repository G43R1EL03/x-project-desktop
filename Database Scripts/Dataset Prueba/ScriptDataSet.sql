-- Insert de marcas
INSERT INTO Marca (nombre, descripcion) VALUES
('Coca-Cola', 'Refresco carbonatado'),
('Pepsi', 'Refresco carbonatado'),
('Sprite', 'Refresco lima-limón'),
('Fanta', 'Refresco de naranja'),
('Red Bull', 'Bebida energética'),
('Mountain Dew', 'Refresco con sabor a citricos'),
('Gatorade', 'Bebida deportiva'),
('Snapple', 'Té y bebidas de frutas'),
('Dr. Pepper', 'Refresco de sabores'),
('7UP', 'Refresco lima-limón'),
('Monster Energy', 'Bebida energética'),
('Aquafina', 'Agua purificada'),
('Lipton', 'Té embotellado'),
('Tropicana', 'Jugo de naranja'),
('Powerade', 'Bebida deportiva'),
('Pocari Sweat', 'Bebida isotónica'),
('Honest Tea', 'Té orgánico'),
('Vitaminwater', 'Agua enriquecida con vitaminas'),
('San Pellegrino', 'Agua mineral con gas'),
('Ocean Spray', 'Jugo de arándano');


-- Inserts para la tabla Categoria
INSERT INTO Categoria (nombre) VALUES
('Refrescos'),
('Bebidas Energéticas'),
('Agua'),
('Té'),
('Jugos'),
('Bebidas Deportivas'),
('Bebidas Orgánicas'),
('Agua Mineral'),
('Té Embotellado'),
('Bebidas con Gas');

-- Inserts para la tabla Producto
INSERT INTO Producto (marca_id, categoria_id, nombre, precio_unit, cantidad_por_cajas, foto, punto_reorden, cantidad_cajas) VALUES
(1, 1, 'Coca-Cola Regular', 1.50, 24, 'coca_cola.jpg', 10, 100),
(2, 1, 'Pepsi Regular', 1.40, 24, 'pepsi.jpg', 12, 80),
(3, 6, 'Gatorade Fruit Punch', 2.00, 12, 'gatorade.jpg', 8, 50),
(4, 5, 'Tropicana Pure Premium', 2.50, 12, 'tropicana.jpg', 15, 75),
(5, 2, 'Red Bull Energy Drink', 3.00, 12, 'red_bull.jpg', 20, 60),
(6, 3, 'Aquafina Bottled Water', 1.00, 24, 'aquafina.jpg', 30, 120),
(7, 9, 'Lipton Green Tea', 1.75, 12, 'lipton.jpg', 18, 90),
(8, 4, 'Snapple Peach Tea', 2.25, 12, 'snapple.jpg', 15, 70),
(9, 8, 'San Pellegrino Sparkling Water', 2.50, 12, 'san_pellegrino.jpg', 25, 40),
(10, 7, 'Honest Tea Organic Lemon Tea', 2.00, 12, 'honest_tea.jpg', 12, 60),
(11, 5, 'Ocean Spray Cranberry Juice', 2.20, 12, 'ocean_spray.jpg', 15, 80),
(12, 2, 'Monster Energy Drink', 2.75, 12, 'monster.jpg', 22, 50),
(13, 10, '7UP', 1.25, 24, '7up.jpg', 15, 100),
(14, 4, 'Vitaminwater XXX', 2.25, 12, 'vitaminwater.jpg', 20, 60),
(15, 6, 'Powerade Berry Blast', 1.75, 12, 'powerade.jpg', 10, 70),
(16, 3, 'Dasani Bottled Water', 1.20, 24, 'dasani.jpg', 25, 150),
(17, 9, 'Perrier Sparkling Water', 2.75, 12, 'perrier.jpg', 20, 30),
(18, 8, 'Pocari Sweat', 2.00, 12, 'pocari_sweat.jpg', 15, 80),
(19, 1, 'Sprite', 1.30, 24, 'sprite.jpg', 12, 90),
(20, 10, 'Fanta Orange', 1.40, 24, 'fanta.jpg', 15, 80);


-- Inserts para la tabla Provincia (Panamá)
INSERT INTO Provincia (nombre) VALUES
('Bocas del Toro'),
('Coclé'),
('Colón'),
('Chiriquí'),
('Darién'),
('Herrera'),
('Los Santos'),
('Panamá'),
('Panamá Oeste'),
('Veraguas');

-- Inserts para la tabla Direccion
INSERT INTO Direccion (provincia_id, codigo_postal, telefono, detalles) VALUES
(1, '0101', '111-1111', 'Calle Principal #123'),
(2, '0202', '222-2222', 'Avenida Central #456'),
(3, '0303', '333-3333', 'Boulevard Norte #789'),
(4, '0404', '444-4444', 'Calle Este #234'),
(5, '0505', '555-5555', 'Avenida Oeste #567'),
(6, '0606', '666-6666', 'Calle 1ra #890'),
(7, '0707', '777-7777', 'Avenida 2da #123'),
(8, '0808', '888-8888', 'Boulevard 3ro #456'),
(9, '0909', '999-9999', 'Calle 4ta #789'),
(10, '1010', '000-0000', 'Avenida 5ta #234'),
(1, '0111', '123-4567', 'Urbanización Bella Vista #567'),
(2, '0222', '987-6543', 'Residencial Los Pinos #890'),
(3, '0333', '555-7890', 'Conjunto Residencial La Colina #123'),
(4, '0444', '111-2222', 'Barriada El Carmen #456'),
(5, '0555', '333-4444', 'Villa de las Flores #789'),
(6, '0666', '555-1111', 'Condominio Los Alamos #234'),
(7, '0777', '777-2222', 'Barriada San Francisco #567'),
(8, '0888', '888-3333', 'Residencial Altos de Panamá #890'),
(9, '0999', '999-4444', 'Vista Hermosa #123'),
(10, '1010', '000-5555', 'Costa del Este #456');

-- Inserts para la tabla Empresa (empresas de bebidas)
INSERT INTO Empresa (usuario_id, ruc, razon_social, documento, estado) VALUES
(1, '12345678901', 'Bebidas Refrescantes S.A.', 'ABC-123', 'Activa'),
(2, '98765432109', 'Energéticos Power Ltda.', 'DEF-456', 'Inactiva'),
(3, '45678901234', 'Agua Pura Panamá, S.A.', 'GHI-789', 'Activa'),
(4, '78901234567', 'Tés del Valle, Inc.', 'JKL-012', 'Inactiva'),
(5, '23456789012', 'Jugos Tropicales, S.A.', 'MNO-345', 'Activa'),
(6, '34567890123', 'Bebidas Deportivas Xtreme, Ltda.', 'PQR-678', 'Activa'),
(8, '56789012345', 'Aguas Minerales del Bosque, S.A.', 'VWX-234', 'Activa'),
(9, '67890123456', 'Tés Naturales, Ltda.', 'YZA-567', 'Inactiva')



