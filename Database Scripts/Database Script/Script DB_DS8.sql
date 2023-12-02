-- Creación de DB_DS8
CREATE DATABASE DB_DS8;

-- Usar la BD recién creada
USE DB_DS8;

-- Creación de tabla Marca
CREATE TABLE Marca (
    id_marca INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) UNIQUE,
    descripcion VARCHAR(255),
    logo VARCHAR(255)
);

-- Creación de tabla Categoria
CREATE TABLE Categoria (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) UNIQUE
);

-- Creación de tabla Producto
CREATE TABLE Producto (
    id_producto INT AUTO_INCREMENT PRIMARY KEY,
    marca_id INT,
    FOREIGN KEY (marca_id) REFERENCES Marca(id_marca),
    categoria_id INT,
    FOREIGN KEY (categoria_id) REFERENCES Categoria(id_categoria),
    nombre VARCHAR(255),
    precio_unit DECIMAL(10,2),
    cantidad_por_cajas INT,
    foto VARCHAR(255),
    punto_reorden INT,
    cantidad_cajas INT
);

-- Creación de tabla Provincia
CREATE TABLE Provincia (
    id_provincia INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) UNIQUE
);

-- Creación de tabla Direccion
CREATE TABLE Direccion (
    id_direccion INT AUTO_INCREMENT PRIMARY KEY,
    provincia_id INT,
    FOREIGN KEY (provincia_id) REFERENCES Provincia(id_provincia),
    codigo_postal VARCHAR(255),
    telefono VARCHAR(255),
    detalles VARCHAR(255)
);

-- Creación de tabla Permisos
CREATE TABLE Permisos (
    id_permisos INT AUTO_INCREMENT PRIMARY KEY,
    gestiona_inventario VARCHAR(255),
    gestiona_clientes VARCHAR(255),
    gestiona_ventas VARCHAR(255),
    gestiona_soporte VARCHAR(255),
    gestiona_analitica VARCHAR(255),
    gestiona_permisos VARCHAR(255)
);

-- Creación de tabla Usuario
CREATE TABLE Usuario (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255),
    correo VARCHAR(255) UNIQUE,
    pass VARCHAR(255),
    rol enum("Admin", "Cliente", "Proveedor"),
    foto VARCHAR(255),
    telefono VARCHAR(255),
    detalles VARCHAR(255)
);



-- Creación de tabla Admin
CREATE TABLE Admin (
    id_admin INT AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT,
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario),
    apellido VARCHAR(255),
    genero VARCHAR(255),
    cedula VARCHAR(255) UNIQUE,
    permisos_id INT,
    FOREIGN KEY (permisos_id) REFERENCES Permisos(id_permisos)
);

-- Creación de tabla Empresa
CREATE TABLE Empresa (
    id_empresa INT AUTO_INCREMENT PRIMARY KEY,
    ruc VARCHAR(255) UNIQUE,
    razon_social VARCHAR(255) UNIQUE,
    documento VARCHAR(255),
    estado VARCHAR(255)
);

-- Creación de tabla Compra
CREATE TABLE Compra (
    id_compra INT AUTO_INCREMENT PRIMARY KEY,
    admin_id INT,
    FOREIGN KEY (admin_id) REFERENCES Admin(id_admin),
    fecha DATETIME,
    producto_id INT,
    FOREIGN KEY (producto_id) REFERENCES Producto(id_producto),
    cantidad INT
);

-- Creación de tabla Cliente
CREATE TABLE Cliente (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    apellido VARCHAR(255),
    cedula VARCHAR(255) UNIQUE,
    empresa_id INT,
    FOREIGN KEY (empresa_id) REFERENCES Empresa(id_empresa),
    genero VARCHAR(255),
    estado VARCHAR(255),
    tipo enum("minorisra", "distribuidor")
);

-- Creación de tabla Sugerencia
CREATE TABLE Sugerencia (
    id_sugerencia INT AUTO_INCREMENT PRIMARY KEY,
    contenido VARCHAR(255),
    fecha DATETIME,
    valoracion INT,
    cliente_id INT,
    FOREIGN KEY (cliente_id) REFERENCES Cliente(id_cliente)
);

-- Creación de tabla Notificacion
CREATE TABLE Notificacion (
    id_notificacion INT AUTO_INCREMENT PRIMARY KEY,
    contenido VARCHAR(255),
    titulo VARCHAR(255),
    icono VARCHAR(255),
    usuario_id INT,
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id_usuario),
    ruta VARCHAR(255)
);

-- Creación de tabla Pedido_estado
CREATE TABLE Pedido_estado (
    id_pedido_estado INT AUTO_INCREMENT PRIMARY KEY,
    estado VARCHAR(255) UNIQUE
);

-- Creación de tabla Forma_pago
CREATE TABLE Forma_pago (
    id_forma_pago INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) UNIQUE
);

-- Creación de tabla Pedido
CREATE TABLE Pedido (
    id_pedido INT AUTO_INCREMENT PRIMARY KEY,
    cliente_id INT,
    FOREIGN KEY (cliente_id) REFERENCES Cliente(id_cliente),
    fecha DATETIME,
    estado_id INT,
    FOREIGN KEY (estado_id) REFERENCES Pedido_estado(id_pedido_estado),
    fecha_cambio_estado DATETIME,
    detalles VARCHAR(255),
    direccion_id INT,
    FOREIGN KEY (direccion_id) REFERENCES Direccion(id_direccion)
);

-- Creación de tabla Pedido_producto
CREATE TABLE Pedido_producto (
    id_pedido_producto INT AUTO_INCREMENT PRIMARY KEY,
    pedido_id INT,
    FOREIGN KEY (pedido_id) REFERENCES Pedido(id_pedido),
    producto_id INT,
    FOREIGN KEY (producto_id) REFERENCES Producto(id_producto),
    cantidad INT
);

-- Creación de tabla Pago
CREATE TABLE Pago (
    id_pago INT AUTO_INCREMENT PRIMARY KEY,
    pedido_id INT,
    FOREIGN KEY (pedido_id) REFERENCES Pedido(id_pedido),
    monto DOUBLE,
    fecha DATETIME,
    forma_pago_id INT,
    FOREIGN KEY (forma_pago_id) REFERENCES Forma_pago(id_forma_pago)
);

-- Creación de tabla Empresa_direcciones
CREATE TABLE Empresa_direcciones (
    empresa_id INT,
    FOREIGN KEY (empresa_id) REFERENCES Empresa(id_empresa),
    direccion_id INT,
    FOREIGN KEY (direccion_id) REFERENCES Direccion(id_direccion),
    PRIMARY KEY (empresa_id, direccion_id)
);

-- Creación de tabla Cliente_direcciones
CREATE TABLE Cliente_direcciones (
    cliente_id INT,
    FOREIGN KEY (cliente_id) REFERENCES Cliente(id_cliente),
    direccion_id INT,
    FOREIGN KEY (direccion_id) REFERENCES Direccion(id_direccion),
    PRIMARY KEY (cliente_id, direccion_id)
);