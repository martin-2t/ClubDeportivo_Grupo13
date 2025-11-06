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
-- --> TABLA DE TIPOS_DOCUMENTO
-- *************************************

CREATE TABLE tipos_documento(
	id_tipo_documento INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(30) NOT NULL
);


-- Registra los tipos de documentos posibles.
INSERT INTO tipos_documento(nombre) VALUES
('DNI'),
('Pasaporte');


-- *************************************
-- --> TABLA DE CLIENTES
-- *************************************

CREATE TABLE clientes(
	id_cliente INT UNSIGNED AUTO_INCREMENT,
    fecha_alta TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30) NOT NULL,
	tipo_documento INT UNSIGNED NOT NULL,
    numero_documento VARCHAR(20) NOT NULL,
    email VARCHAR(40),
    telefono VARCHAR(20),
    es_socio BOOLEAN NOT NULL,
    apto_fisico BOOLEAN NOT NULL,
	estado VARCHAR(15) DEFAULT 'activo',
    CONSTRAINT pk_cliente PRIMARY KEY (id_cliente),
    CONSTRAINT fk_tipo_documento FOREIGN KEY (tipo_documento) REFERENCES tipos_documento(id_tipo_documento),
    CONSTRAINT uq_numero_documento UNIQUE (tipo_documento, numero_documento) 
);

-- Registra socios (activos y morosos) y no socios.
INSERT INTO clientes(nombre, apellido, tipo_documento, numero_documento, email, telefono, es_socio, apto_fisico, estado)
VALUES 
('Lucas', 'Gomez', 1, '1234567890', 'lucas.gomez@mail.com', '111-1234', TRUE, TRUE, 'activo'),
('Mariana', 'Lopez', 1, '2234567890', 'mariana.lopez@mail.com', '111-5678', TRUE, TRUE, 'activo'),
('Javier', 'Fernandez', 1, '3234567890', 'javier.fernandez@mail.com', '111-9012', TRUE, TRUE, 'moroso'),
('Valentina', 'Sanchez', 1, '4234567890', 'valentina.sanchez@mail.com', '111-3456', TRUE, TRUE, 'moroso'),
('Sofia', 'Martinez', 1, '5234567890', 'sofia.martinez@mail.com', '111-7890', FALSE, TRUE, NULL),
('Mateo', 'Diaz', 1, '6234567890', 'mateo.diaz@mail.com', '111-2345', FALSE, TRUE, NULL),
('Camila', 'Torres', 1, '7234567890', 'camila.torres@mail.com', '111-6789', FALSE, TRUE, NULL),
('Nicolas', 'Ruiz', 1, '8234567890','nicolas.ruiz@mail.com', '111-0123', TRUE, TRUE, 'activo'),
('Laura', 'Castro', 1, '9234567890', 'laura.castro@mail.com', '111-4567', FALSE, TRUE, NULL),
('Federico', 'Vega', 1, '0234567890', 'federico.vega@mail.com', '111-8901', TRUE, TRUE, 'activo');

-- Inicializo variables para las fechas.

SET @un_mes_antes = DATE_SUB(CURDATE(), INTERVAL 1 MONTH);
SET @dos_mes_antes = DATE_SUB(CURDATE(), INTERVAL 2 MONTH);
SET @tres_mes_antes = DATE_SUB(CURDATE(), INTERVAL 3 MONTH);
SET @cuatro_mes_antes = DATE_SUB(CURDATE(), INTERVAL 4 MONTH);


-- Actualiza fecha_alta para que tengan sentido los registros de pago.
UPDATE clientes 
SET fecha_alta = DATE_SUB(@dos_mes_antes, INTERVAL 1 DAY) 
WHERE id_cliente = 1;

UPDATE clientes 
SET fecha_alta = DATE_SUB(@tres_mes_antes, INTERVAL 8 DAY) 
WHERE id_cliente = 2;

UPDATE clientes 
SET fecha_alta = DATE_SUB(@cuatro_mes_antes, INTERVAL 3 DAY) 
WHERE id_cliente = 3;

UPDATE clientes SET fecha_alta = '2025-07-25' WHERE id_cliente = 4;
UPDATE clientes SET fecha_alta = '2025-08-25' WHERE id_cliente = 5;
UPDATE clientes SET fecha_alta = '2025-08-25' WHERE id_cliente = 6;
UPDATE clientes SET fecha_alta = '2025-05-10' WHERE id_cliente = 7;

UPDATE clientes 
SET fecha_alta = DATE_SUB(@dos_mes_antes, INTERVAL 1 DAY) 
WHERE id_cliente = 8;

UPDATE clientes SET fecha_alta = '2025-08-25' WHERE id_cliente = 9;

UPDATE clientes 
SET fecha_alta = DATE_SUB(@tres_mes_antes, INTERVAL 8 DAY) 
WHERE id_cliente = 10;


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
    monto DECIMAL(10,2) NOT NULL,
    fecha_emision DATE NOT NULL,
    fecha_vencimiento DATE NOT NULL,
    fecha_pago DATE DEFAULT NULL,
    modo_pago VARCHAR(20),
    promocion VARCHAR(30),
    estado VARCHAR(20) DEFAULT 'pendiente',
    CONSTRAINT pk_cuota PRIMARY KEY (id_cuota),
    CONSTRAINT fk_socio_cuota FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente)
);

-- Socio ID 1: Activo, todo pagado menos la cuota del mes actual, ¡que se le vence hoy!
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(	1, 
	10000, 
	DATE_SUB(@dos_mes_antes, INTERVAL 1 DAY), 
    DATE_SUB(@un_mes_antes, INTERVAL 1 DAY), 
    DATE_SUB(@dos_mes_antes, INTERVAL 1 DAY), 
    'efectivo', 'pagada'
),
(	1, 
	20000, 
    @un_mes_antes, 
    CURDATE(), 
    NULL, 
    NULL, 
    'pendiente'
);

-- Socio ID 2: Activo, varias cuotas pagadas, cuota pendiente actual pero no se le vence hoy.
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(	2, 
	10000, 
    DATE_ADD(@tres_mes_antes, INTERVAL 8 DAY), 
    DATE_ADD(@dos_mes_antes, INTERVAL 8 DAY), 
    DATE_ADD(@tres_mes_antes, INTERVAL 8 DAY), 
    'efectivo', 
    'pagada'),
(	2, 
	10000,
    DATE_ADD(@dos_mes_antes, INTERVAL 9 DAY), 
    DATE_ADD(@un_mes_antes, INTERVAL 9 DAY), 
    DATE_ADD(@un_mes_antes, INTERVAL 2 DAY), 
    'efectivo', 
    'pagada'),
(	2, 
	20000, 
    DATE_ADD(@un_mes_antes, INTERVAL 10 DAY), 
	DATE_ADD(CURDATE(), INTERVAL 10 DAY), 
    NULL, 
    NULL, 
    'pendiente'
);

-- Socio ID 3: Moroso, tiene cuotas vencidas + cuota pendiente que se le vence hoy.
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(	3, 10000, 
	DATE_SUB(@cuatro_mes_antes, INTERVAL 3 DAY), 
    DATE_SUB(@tres_mes_antes, INTERVAL 3 DAY), 
    DATE_SUB(@cuatro_mes_antes, INTERVAL 3 DAY), 
    'efectivo', 'pagada'),
(	3, 10000, 
	DATE_SUB(@tres_mes_antes, INTERVAL 2 DAY), 
    DATE_SUB(@dos_mes_antes, INTERVAL 2 DAY), 
    NULL, 
    NULL, 'vencida'),
(	3, 10000, 
	DATE_SUB(@dos_mes_antes, INTERVAL 1 DAY), 
    DATE_SUB(@un_mes_antes, INTERVAL 1 DAY), 
    NULL, 
	NULL,'vencida'),
(	3, 20000, 
	@un_mes_antes, 
    CURDATE(), 
    NULL, NULL, 'pendiente');

-- Socio ID 4: Moroso, 1 vencida + cuota pendiente que no se le vence hoy
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(	4, 10000, 
	DATE_ADD(@tres_mes_antes, INTERVAL 20 DAY), 
    DATE_ADD(@dos_mes_antes, INTERVAL 20 DAY), 
    DATE_ADD(@tres_mes_antes, INTERVAL 20 DAY), 
    'tarjeta', 'pagada'),
(	4, 10000, 
	DATE_ADD(@dos_mes_antes, INTERVAL 21 DAY), 
    DATE_ADD(@un_mes_antes, INTERVAL 21 DAY), 
    NULL, NULL, 'vencida'),
(	4, 20000, 
    DATE_ADD(@un_mes_antes, INTERVAL 22 DAY), 
    DATE_ADD(CURDATE(), INTERVAL 22 DAY), 
    NULL, NULL, 'pendiente');

-- Socio ID 8: Activo, se le venceria hoy pero ya la pago.
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(	8, 
	20000, 
	DATE_SUB(@dos_mes_antes, INTERVAL 1 DAY), 
    DATE_SUB(@un_mes_antes, INTERVAL 1 DAY), 
    DATE_SUB(@dos_mes_antes, INTERVAL 1 DAY), 
    'efectivo', 
    'pagada'
),
(	8, 
	20000, 
    @un_mes_antes, 
    CURDATE(), 
    DATE_SUB(CURDATE(), INTERVAL 2 DAY), 
    'efectivo', 
    'pagada'
);

-- Socio ID 10: Activo, todo pagado
INSERT INTO cuotas_mensuales (id_cliente, monto, fecha_emision, fecha_vencimiento, fecha_pago, modo_pago, estado)
VALUES
(	10, 
	1000, 
    DATE_SUB(@tres_mes_antes, INTERVAL 8 DAY), 
    DATE_SUB(@dos_mes_antes, INTERVAL 8 DAY), 
    DATE_SUB(@tres_mes_antes, INTERVAL 8 DAY), 
    'efectivo', 
    'pagada'),
(	10, 
	1000,
    DATE_ADD(@dos_mes_antes, INTERVAL 9 DAY), 
    DATE_ADD(@un_mes_antes, INTERVAL 9 DAY), 
    DATE_ADD(@un_mes_antes, INTERVAL 2 DAY), 
    'efectivo', 
    'pagada'),
(	10, 
	1000, 
    DATE_ADD(@un_mes_antes, INTERVAL 10 DAY), 
	DATE_ADD(CURDATE(), INTERVAL 10 DAY), 
    DATE_SUB(CURDATE(), INTERVAL 12 DAY), 
    'efectivo', 
    'pagada'
);

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

DELIMITER //

CREATE PROCEDURE IngresoLogin(IN usuario VARCHAR(30), IN clave VARCHAR(60))
BEGIN
	SELECT R.nombre
    FROM usuarios U INNER JOIN roles R on R.id_rol = U.id_rol
    WHERE U.nombre_usuario = usuario and U.password_usuario = clave and U.activo = 1;

END //

DELIMITER ;


-- *************************************
-- --> PROCEDIMIENTO NuevoSocio
-- *************************************


DROP PROCEDURE IF EXISTS NuevoSocio;

DELIMITER //

CREATE PROCEDURE NuevoSocio( 
								IN nombre VARCHAR(30), 
                                IN apellido VARCHAR(30), 
                                IN tipo_documento INT, 
                                IN numero_documento VARCHAR(20), 
                                IN email VARCHAR(40),
                                IN telefono VARCHAR(20),
                                IN apto_fisico BOOLEAN,
                                IN modo_pago VARCHAR(20),
                                IN promocion VARCHAR(30),
                                IN monto DECIMAL(10,2),
                                OUT respuesta INT,
                                OUT fecha_alta TIMESTAMP
                                )
BEGIN

	DECLARE existe INT DEFAULT 0;
    DECLARE paga INT DEFAULT 0;
    
    SELECT COUNT(*) INTO existe
    FROM clientes C
    WHERE C.tipo_documento = tipo_documento AND C.numero_documento = numero_documento;
    
    IF existe = 0 THEN
    
		START TRANSACTION;
        
		INSERT INTO clientes(nombre, apellido, tipo_documento, numero_documento, email, telefono, es_socio, apto_fisico)
        VALUES
        (nombre, apellido, tipo_documento, numero_documento, email, telefono, true, apto_fisico);
        
        SET respuesta = last_insert_id();
        
        CALL NuevoSocioCuota(respuesta, monto, modo_pago, promocion, paga);
        
        IF paga = -1 THEN
			ROLLBACK;
            SET respuesta = -2;
            SET fecha_alta = NULL;
		ELSE
			SELECT C.fecha_alta INTO fecha_alta
			FROM clientes C
			WHERE C.id_cliente = respuesta;
            COMMIT;
		END IF;
	ELSE
		SET respuesta = -1;
        SET fecha_alta = NULL;
        
	END IF;
        
END //

DELIMITER ;


-- *************************************
-- --> PROCEDIMIENTO NuevoSocioCuota
-- *************************************


DROP PROCEDURE IF EXISTS NuevoSocioCuota;

DELIMITER //

CREATE PROCEDURE NuevoSocioCuota( 
								IN id_cliente INT, 
                                IN monto DECIMAL(10,2), 
                                IN modo_pago VARCHAR(20),
                                IN promocion VARCHAR(30),
                                OUT resultado INT
                                )
BEGIN

	DECLARE id_cuota INT;
    
    INSERT INTO cuotas_mensuales(id_cliente, monto, fecha_emision, fecha_vencimiento, estado, modo_pago, promocion) 
    VALUES (id_cliente, monto, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 30 DAY), 'pendiente', modo_pago, promocion );
    
    SET id_cuota = LAST_INSERT_ID();
    
    -- Llama a PagarCuotaMensual
    CALL PagarCuotaMensual(id_cuota, modo_pago, promocion, resultado);
    
    IF resultado = 0 THEN
        SET resultado = -1;
	ELSE
		SET resultado = 1;
	END IF;
        
END //

DELIMITER ;

-- *************************************
-- --> PROCEDIMIENTO PagarCuotaMensual
-- *************************************


DROP PROCEDURE IF EXISTS PagarCuotaMensual;

DELIMITER //

CREATE PROCEDURE PagarCuotaMensual( 
								IN id_cuota INT, 
                                IN modo_pago VARCHAR(20),
                                IN promocion VARCHAR(30),
                                OUT resultado INT
                                )
BEGIN

	DECLARE existe INT;
    
    SELECT COUNT(*) INTO existe
    FROM cuotas_mensuales CM
    WHERE CM.id_cuota = id_cuota;
    
    IF existe = 0 THEN
		SET resultado = 0;
	ELSE
		UPDATE cuotas_mensuales CM
        SET CM.fecha_pago = CURDATE(),
        CM.modo_pago = modo_pago,
        CM.promocion = promocion,
        CM.estado = 'pagada'
        WHERE CM.id_cuota = id_cuota;
		
        SET resultado = 1;
	END IF;
    
END //

DELIMITER ;


-- *************************************
-- --> PROCEDIMIENTO NuevoNoSocio
-- *************************************


DROP PROCEDURE IF EXISTS NuevoNoSocio;

DELIMITER //

CREATE PROCEDURE NuevoNoSocio( 
								IN nombre VARCHAR(30), 
                                IN apellido VARCHAR(30), 
                                IN tipo_documento INT, 
                                IN numero_documento VARCHAR(20), 
                                IN email VARCHAR(40),
                                IN telefono VARCHAR(20),
                                IN apto_fisico BOOLEAN,
                                OUT respuesta INT
                                )
BEGIN

	DECLARE existe INT DEFAULT 0;
    
    SELECT COUNT(*) INTO existe
    FROM clientes C
    WHERE C.tipo_documento = tipo_documento AND C.numero_documento = numero_documento;
    
    IF existe = 0 THEN
        
		INSERT INTO clientes(nombre, apellido, tipo_documento, numero_documento, email, telefono, es_socio, apto_fisico)
        VALUES
        (nombre, apellido, tipo_documento, numero_documento, email, telefono, false, apto_fisico);
        
        SET respuesta = last_insert_id();
        
	ELSE
		SET respuesta = -1;
        
	END IF;
        
END //

DELIMITER ;

-- *************************************
-- --> PROCEDIMIENTO TieneCuotasPendientes
-- *************************************

DROP PROCEDURE IF EXISTS TieneCuotasPendientes;

DELIMITER //

CREATE PROCEDURE TieneCuotasPendientes(
    IN id_cliente INT,
    OUT tiene BOOLEAN
)
BEGIN

SELECT COUNT(*) > 0 INTO tiene
FROM cuotas_mensuales CM
WHERE CM.id_cliente = id_cliente
	AND CM.estado IN ('pendiente', 'vencida');
    
END //

DELIMITER ;

-- *************************************
-- --> PROCEDIMIENTO ObtenerCuotas
-- *************************************

DROP PROCEDURE IF EXISTS ObtenerCuotas;

DELIMITER //

CREATE PROCEDURE ObtenerCuotas(
    IN id_cliente INT
)
BEGIN

    WITH ultima_pagada AS (
        SELECT CM.id_cuota
        FROM cuotas_mensuales CM
        WHERE CM.id_cliente = id_cliente
          AND CM.estado = 'pagada'
        ORDER BY CM.fecha_pago DESC
        LIMIT 1
    )
    SELECT 
        CM.id_cuota,
        CM.monto,
        CM.fecha_vencimiento,
        CM.fecha_pago,
        CM.estado
    FROM cuotas_mensuales CM
    LEFT JOIN ultima_pagada UP ON CM.id_cuota = UP.id_cuota
    WHERE CM.id_cliente = id_cliente
      AND (CM.estado IN ('pendiente', 'vencida') OR UP.id_cuota IS NOT NULL)
    ORDER BY CM.fecha_vencimiento DESC;
    
END //

DELIMITER ;

-- *************************************
-- --> PROCEDIMIENTO ObtenerCliente
-- *************************************

DROP PROCEDURE IF EXISTS ObtenerCliente;

DELIMITER //

CREATE PROCEDURE ObtenerCliente(
    IN id_cliente INT
)
BEGIN
    -- Si no existe, no devuelve filas
    SELECT 
        C.id_cliente,
        C.nombre,
        C.apellido,
        C.es_socio,
        C.estado
	FROM clientes C
    WHERE C.id_cliente = id_cliente;
END //

DELIMITER ;

-- *************************************
-- --> PROCEDIMIENTO ActualizarEstadoCliente
-- *************************************

DROP PROCEDURE IF EXISTS ActualizarEstadoCliente;

DELIMITER //

CREATE PROCEDURE ActualizarEstadoCliente(
    IN id_cliente INT
)
BEGIN
	DECLARE cuotas_vencidas INT DEFAULT 0;
    -- Cuenta cuantas cuotas vencidas tiene el cliente
    SELECT COUNT(*) INTO cuotas_vencidas
    FROM cuotas_mensuales CM
    WHERE CM.id_cliente = id_cliente
      AND estado = 'vencida';

	    -- Si no tiene cuotas vencidas, actualizamos el estado a activo
    IF cuotas_vencidas = 0 THEN
        UPDATE clientes C
        SET C.estado = 'activo'
        WHERE C.id_cliente = id_cliente;
    END IF;

END //

DELIMITER ;

-- *************************************
-- --> PROCEDIMIENTO ObtenerActividades
-- *************************************

DROP PROCEDURE IF EXISTS ObtenerActividades;

DELIMITER //

CREATE PROCEDURE ObtenerActividades(
)
BEGIN
    -- Si no existe, no devuelve filas
    SELECT 
        A.id_actividad,
        A.nombre,
        A.monto
	FROM actividades A;
    
END //

DELIMITER ;

-- *************************************
-- --> PROCEDIMIENTO PagarCuotaDiaria
-- *************************************

DROP PROCEDURE IF EXISTS PagarCuotaDiaria;

DELIMITER //

CREATE PROCEDURE PagarCuotaDiaria(
	IN id_cliente INT,
    IN id_actividad INT,
    IN modo_pago VARCHAR(20),
    IN promocion VARCHAR(30)
)
BEGIN

-- Registrar cuota diaria.
	INSERT INTO cuotas_diarias(id_cliente, id_actividad, fecha, modo_pago, promocion)
	VALUES(id_cliente, id_actividad, CURDATE(), modo_pago, promocion);
    
END //

DELIMITER ;

-- *************************************
-- --> PROCEDIMIENTO ObtenerSociosMorosos
-- *************************************

DROP PROCEDURE IF EXISTS ObtenerSociosMorosos;

DELIMITER //

CREATE PROCEDURE ObtenerSociosMorosos(
)
BEGIN
	SELECT 
			C.id_cliente,
			C.nombre,
			C.apellido
	FROM clientes C
	INNER JOIN cuotas_mensuales CM ON C.id_cliente = CM.id_cliente
	WHERE CM.fecha_vencimiento = CURDATE() AND CM.estado != 'pagada';
END //

DELIMITER ;



