DROP DATABASE IF EXISTS Proyecto;

CREATE DATABASE Proyecto;

USE Proyecto;

-- *************************************
-- --> TABLA DE ROLES
-- *************************************

CREATE TABLE roles (
    id_rol INT UNSIGNED AUTO_INCREMENT,
    nombre VARCHAR(30) NOT NULL UNIQUE,
    CONSTRAINT pk_rol PRIMARY KEY (id_rol)
);

INSERT INTO roles (nombre) 
VALUES
('Administrador'),
('Empleado');

-- *************************************
-- --> TABLA DE USUARIOS
-- *************************************

CREATE TABLE usuarios (
	id_usuario INT UNSIGNED AUTO_INCREMENT,
    nombre_usuario VARCHAR(30) NOT NULL UNIQUE,
    password_usuario VARCHAR(60) NOT NULL,
    id_rol INT UNSIGNED NOT NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,
    CONSTRAINT pk_usuario PRIMARY KEY (id_usuario),
    CONSTRAINT fk_usuario_rol FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
);

INSERT INTO usuarios (nombre_usuario, password_usuario, id_rol)
VALUES ('Administrador', '123456', 1);

-- *************************************
-- --> TABLA DE CLIENTES
-- *************************************

CREATE TABLE clientes(
	id_cliente INT UNSIGNED AUTO_INCREMENT,
    fecha_alta TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30) NOT NULL,
    email VARCHAR(40) NOT NULL,
    telefono VARCHAR(20),
    es_socio BOOLEAN NOT NULL,
    apto_fisico BOOLEAN NOT NULL,
	estado VARCHAR(15) DEFAULT 'activo',
    CONSTRAINT pk_cliente PRIMARY KEY (id_cliente)
);

-- Registra socios (activos y morosos) y no socios.
INSERT INTO clientes(nombre, apellido, email, telefono, es_socio, apto_fisico, estado)
VALUES 
('Lucas', 'Gomez', 'lucas.gomez@mail.com', '111-1234', TRUE, TRUE, 'activo'),
('Mariana', 'Lopez', 'mariana.lopez@mail.com', '111-5678', TRUE, TRUE, 'activo'),
('Javier', 'Fernandez', 'javier.fernandez@mail.com', '111-9012', TRUE, TRUE, 'moroso'),
('Valentina', 'Sanchez', 'valentina.sanchez@mail.com', '111-3456', TRUE, TRUE, 'moroso'),
('Sofia', 'Martinez', 'sofia.martinez@mail.com', '111-7890', FALSE, TRUE, NULL),
('Mateo', 'Diaz', 'mateo.diaz@mail.com', '111-2345', FALSE, TRUE, NULL),
('Camila', 'Torres', 'camila.torres@mail.com', '111-6789', TRUE, TRUE, 'moroso'),
('Nicolas', 'Ruiz', 'nicolas.ruiz@mail.com', '111-0123', TRUE, TRUE, 'activo'),
('Laura', 'Castro', 'laura.castro@mail.com', '111-4567', FALSE, TRUE, NULL),
('Federico', 'Vega', 'federico.vega@mail.com', '111-8901', TRUE, TRUE, 'activo');


-- Actualiza fecha_alta para que tengan sentido los registros de pago.
UPDATE clientes SET fecha_alta = '2025-08-25' WHERE id_cliente = 1;
UPDATE clientes SET fecha_alta = '2025-07-25' WHERE id_cliente = 2;
UPDATE clientes SET fecha_alta = '2025-07-28' WHERE id_cliente = 3;
UPDATE clientes SET fecha_alta = '2025-07-25' WHERE id_cliente = 4;
UPDATE clientes SET fecha_alta = '2025-08-25' WHERE id_cliente = 5;
UPDATE clientes SET fecha_alta = '2025-08-25' WHERE id_cliente = 6;
UPDATE clientes SET fecha_alta = '2025-06-10' WHERE id_cliente = 7;
UPDATE clientes SET fecha_alta = '2025-06-28' WHERE id_cliente = 8;
UPDATE clientes SET fecha_alta = '2025-08-25' WHERE id_cliente = 9;
UPDATE clientes SET fecha_alta = '2025-06-28' WHERE id_cliente = 10;


-- *************************************
-- --> TABLA DE ACTIVIDADES
-- *************************************

CREATE TABLE actividades(
	id_actividad INT UNSIGNED AUTO_INCREMENT,
    nombre VARCHAR(30) NOT NULL,
    monto FLOAT NOT NULL,
    CONSTRAINT pk_actividad PRIMARY KEY (id_actividad)
);

-- Registra actividades.
INSERT INTO actividades(nombre, monto)
VALUES
('Natación', 1500.00),
('Musculación', 1200.00),
('Fútbol', 1000.00),
('Yoga', 800.00),
('Pilates', 900.00);

-- *************************************
-- --> TABLA DE CUOTAS MENSUALES
-- *************************************

CREATE TABLE cuotas_mensuales(
	id_cuota INT UNSIGNED AUTO_INCREMENT,
    id_cliente INT UNSIGNED NOT NULL,
    monto FLOAT NOT NULL,
    fecha_emision DATE NOT NULL,
    fecha_vencimiento DATE NOT NULL,
    fecha_pago DATE DEFAULT NULL,
    modo_pago VARCHAR(20),
    promocion VARCHAR(30),
    estado VARCHAR(20) DEFAULT 'pendiente',
    CONSTRAINT pk_cuota PRIMARY KEY (id_cuota),
    CONSTRAINT fk_socio_cuota FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente)
);

-- Socio 1: Activo, todo pagado menos la cuota del mes actual
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(1, 1000, '2025-09-01', '2025-09-30', '2025-09-28', 'efectivo', 'pagada'),
(1, 1000, '2025-10-01', '2025-10-31', NULL, NULL, 'pendiente');

-- Socio 2: Activo, varias cuotas pagadas, cuota pendiente actual
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(2, 1000, '2025-08-01', '2025-08-31', '2025-08-28', 'efectivo', 'pagada'),
(2, 1000, '2025-09-01', '2025-09-30', '2025-09-28', 'efectivo', 'pagada'),
(2, 1000, '2025-10-01', '2025-10-31', NULL, NULL, 'pendiente');

-- Socio 3: Moroso, tiene cuotas vencidas + cuota pendiente
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(3, 1000, '2025-08-01', '2025-08-31', NULL, NULL, 'vencida'),
(3, 1000, '2025-09-01', '2025-09-30', NULL, NULL, 'vencida'),
(3, 1000, '2025-10-01', '2025-10-31', NULL, NULL, 'pendiente');

-- Socio 4: Moroso, 1 vencida + cuota pendiente
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(4, 1000, '2025-08-01', '2025-08-31', '2025-08-16', 'tarjeta', 'pagada'),
(4, 1000, '2025-09-01', '2025-09-30', NULL, NULL, 'vencida'),
(4, 1000, '2025-10-01', '2025-10-31', NULL, NULL, 'pendiente');

-- Socio 7: Moroso, varias cuotas vencidas + cuota pendiente
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(7, 1000, '2025-07-01', '2025-07-31', NULL, NULL, 'vencida'),
(7, 1000, '2025-08-01', '2025-08-31', NULL, NULL, 'vencida'),
(7, 1000, '2025-09-01', '2025-09-30', NULL, NULL, 'vencida'),
(7, 1000, '2025-10-01', '2025-10-31', NULL, NULL, 'pendiente');

-- Socio 8: Activo, todo pagado
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(8, 1000, '2025-07-01', '2025-07-31', '2025-07-28', 'efectivo', 'pagada'),
(8, 1000, '2025-08-01', '2025-08-31', '2025-08-28', 'efectivo', 'pagada'),
(8, 1000, '2025-09-01', '2025-09-30', '2025-09-28', 'efectivo', 'pagada'),
(8, 1000, '2025-10-01', '2025-10-31', '2025-10-03', 'efectivo', 'pagada');

-- Socio 10: Activo, todo pagado
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(10, 1000, '2025-07-01', '2025-07-31', '2025-07-28', 'efectivo', 'pagada'),
(10, 1000, '2025-08-01', '2025-08-31', '2025-08-28', 'efectivo', 'pagada'),
(10, 1000, '2025-09-01', '2025-09-30', '2025-09-28', 'efectivo', 'pagada'),
(10, 1000, '2025-10-01', '2025-10-31', '2025-10-03', 'efectivo', 'pagada');

-- *************************************
-- --> TABLA DE CUOTAS DIARIAS
-- *************************************

CREATE TABLE cuotas_diarias (
    id_cuota INT UNSIGNED AUTO_INCREMENT,
    id_cliente INT UNSIGNED NOT NULL,
    id_actividad INT UNSIGNED NOT NULL,
    fecha DATE NOT NULL,
    modo_pago VARCHAR(20),
    promocion VARCHAR(30),
    CONSTRAINT pk_cuota PRIMARY KEY (id_cuota),
    CONSTRAINT fk_nosocio_cuota FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente),
    CONSTRAINT fk_actividad FOREIGN KEY (id_actividad) REFERENCES actividades(id_actividad)
);


-- Registra pagos de no socios.
INSERT INTO cuotas_diarias (id_cliente, id_actividad, fecha, modo_pago, promocion)
VALUES 
(5, 1, '2025-10-03', 'efectivo', NULL),
(5, 2, '2025-10-04', 'efectivo', NULL),
(5, 3, '2025-10-04', 'efectivo', NULL),
(5, 5, '2025-10-05', 'tarjeta', '3 cuotas'),
(6, 1, '2025-10-05', 'efectivo', NULL),
(6, 4, '2025-10-05', 'efectivo', NULL),
(9, 5, '2025-10-05', 'efectivo', NULL),
(9, 3, '2025-10-02', 'tarjeta', NULL);


-- *************************************
-- --> PROCEDIMIENTO IngresoLogin
-- *************************************

DROP PROCEDURE IF EXISTS IngresoLogin;

DELIMITER //IngresoLogin

CREATE PROCEDURE IngresoLogin(IN usuario VARCHAR(30), IN clave VARCHAR(60))
BEGIN
	SELECT R.nombre
    FROM usuarios U INNER JOIN roles R on R.id_rol = U.id_usuario
    WHERE U.nombre_usuario = usuario and U.password_usuario = clave and U.activo = 1;

END //

DELIMITER ;