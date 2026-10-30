-- MySQL 8.0.16 o posterior. Seleccionar la base de Clever Cloud antes de ejecutar.
-- Esquema inicial para una base vacía; los cambios posteriores se aplican por separado.
-- DATETIME representa instantes en UTC. DATE y TIME laborales usan la hora de Guatemala.
-- Los campos *_cifrado reciben datos cifrados por la aplicación.

SET NAMES utf8mb4 COLLATE utf8mb4_unicode_ci;
SET SESSION time_zone = '+00:00';

CREATE TABLE departamentos (
    id_departamento INT UNSIGNED NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(500) NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,
    fecha_creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fecha_actualizacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    PRIMARY KEY (id_departamento),
    CONSTRAINT uq_departamentos_nombre UNIQUE (nombre),
    CONSTRAINT chk_departamentos_nombre CHECK (CHAR_LENGTH(TRIM(nombre)) > 0),
    CONSTRAINT chk_departamentos_activo CHECK (activo IN (0, 1))
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE puestos (
    id_puesto INT UNSIGNED NOT NULL AUTO_INCREMENT,
    id_departamento INT UNSIGNED NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(500) NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,
    fecha_creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fecha_actualizacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    PRIMARY KEY (id_puesto),
    CONSTRAINT uq_puestos_departamento_nombre UNIQUE (id_departamento, nombre),
    CONSTRAINT uq_puestos_id_departamento UNIQUE (id_puesto, id_departamento),
    CONSTRAINT fk_puestos_departamentos FOREIGN KEY (id_departamento)
        REFERENCES departamentos (id_departamento),
    CONSTRAINT chk_puestos_nombre CHECK (CHAR_LENGTH(TRIM(nombre)) > 0),
    CONSTRAINT chk_puestos_activo CHECK (activo IN (0, 1))
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE tipos_contrato (
    id_tipo_contrato INT UNSIGNED NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(80) NOT NULL,
    descripcion VARCHAR(500) NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,

    PRIMARY KEY (id_tipo_contrato),
    CONSTRAINT uq_tipos_contrato_nombre UNIQUE (nombre),
    CONSTRAINT chk_tipos_contrato_nombre CHECK (CHAR_LENGTH(TRIM(nombre)) > 0),
    CONSTRAINT chk_tipos_contrato_activo CHECK (activo IN (0, 1))
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE horarios (
    id_horario INT UNSIGNED NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(500) NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,

    PRIMARY KEY (id_horario),
    CONSTRAINT uq_horarios_nombre UNIQUE (nombre),
    CONSTRAINT chk_horarios_nombre CHECK (CHAR_LENGTH(TRIM(nombre)) > 0),
    CONSTRAINT chk_horarios_activo CHECK (activo IN (0, 1))
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE horario_dias (
    id_horario_dia INT UNSIGNED NOT NULL AUTO_INCREMENT,
    id_horario INT UNSIGNED NOT NULL,
    dia_semana TINYINT UNSIGNED NOT NULL COMMENT '1 = lunes, 7 = domingo',
    hora_entrada TIME NOT NULL,
    hora_salida TIME NOT NULL,
    salida_dia_siguiente BOOLEAN NOT NULL DEFAULT FALSE,
    tolerancia_minutos SMALLINT UNSIGNED NOT NULL DEFAULT 0,

    PRIMARY KEY (id_horario_dia),
    CONSTRAINT uq_horario_dias_horario_dia UNIQUE (id_horario, dia_semana),
    CONSTRAINT fk_horario_dias_horarios FOREIGN KEY (id_horario)
        REFERENCES horarios (id_horario),
    CONSTRAINT chk_horario_dias_semana CHECK (dia_semana BETWEEN 1 AND 7),
    CONSTRAINT chk_horario_dias_horas CHECK (
        hora_entrada >= '00:00:00' AND hora_entrada < '24:00:00'
        AND hora_salida >= '00:00:00' AND hora_salida < '24:00:00'
    ),
    CONSTRAINT chk_horario_dias_salida CHECK (
        (salida_dia_siguiente = 0 AND hora_salida > hora_entrada)
        OR (salida_dia_siguiente = 1 AND hora_salida < hora_entrada)
    )
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE empleados (
    id_empleado INT UNSIGNED NOT NULL AUTO_INCREMENT,
    codigo VARCHAR(20) NOT NULL,
    dpi CHAR(13) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    fecha_nacimiento DATE NULL,
    telefono VARCHAR(25) NULL,
    correo VARCHAR(254) NULL,
    direccion VARCHAR(250) NULL,
    fotografia BLOB NULL COMMENT 'Imagen reducida, hasta 65535 bytes',
    fotografia_tipo ENUM('image/jpeg', 'image/png') NULL,
    fecha_contratacion DATE NOT NULL,
    fecha_baja DATE NULL,
    estado ENUM('Activo', 'Suspendido', 'Inactivo') NOT NULL DEFAULT 'Activo',
    banco VARCHAR(100) NULL,
    cuenta_bancaria_cifrada VARBINARY(512) NULL,
    fecha_creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fecha_actualizacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    PRIMARY KEY (id_empleado),
    CONSTRAINT uq_empleados_codigo UNIQUE (codigo),
    CONSTRAINT uq_empleados_dpi UNIQUE (dpi),
    KEY idx_empleados_apellidos_nombres (apellidos, nombres),
    KEY idx_empleados_nombres_apellidos (nombres, apellidos),
    KEY idx_empleados_estado (estado),
    CONSTRAINT chk_empleados_codigo CHECK (CHAR_LENGTH(TRIM(codigo)) > 0),
    CONSTRAINT chk_empleados_dpi CHECK (dpi REGEXP '^[0-9]{13}$'),
    CONSTRAINT chk_empleados_nombres CHECK (CHAR_LENGTH(TRIM(nombres)) > 0),
    CONSTRAINT chk_empleados_apellidos CHECK (CHAR_LENGTH(TRIM(apellidos)) > 0),
    CONSTRAINT chk_empleados_nacimiento CHECK (
        fecha_nacimiento IS NULL OR fecha_nacimiento <= fecha_contratacion
    ),
    CONSTRAINT chk_empleados_baja CHECK (
        fecha_baja IS NULL OR (fecha_baja >= fecha_contratacion AND estado = 'Inactivo')
    ),
    CONSTRAINT chk_empleados_fotografia CHECK (
        (fotografia IS NULL AND fotografia_tipo IS NULL)
        OR (fotografia IS NOT NULL AND fotografia_tipo IS NOT NULL AND OCTET_LENGTH(fotografia) > 0)
    ),
    CONSTRAINT chk_empleados_cuenta CHECK (
        cuenta_bancaria_cifrada IS NULL OR OCTET_LENGTH(cuenta_bancaria_cifrada) > 0
    )
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE roles (
    id_rol INT UNSIGNED NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(250) NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,

    PRIMARY KEY (id_rol),
    CONSTRAINT uq_roles_nombre UNIQUE (nombre),
    CONSTRAINT chk_roles_nombre CHECK (CHAR_LENGTH(TRIM(nombre)) > 0),
    CONSTRAINT chk_roles_activo CHECK (activo IN (0, 1))
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE permisos_sistema (
    id_permiso_sistema INT UNSIGNED NOT NULL AUTO_INCREMENT,
    codigo VARCHAR(80) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(250) NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,

    PRIMARY KEY (id_permiso_sistema),
    CONSTRAINT uq_permisos_sistema_codigo UNIQUE (codigo),
    CONSTRAINT chk_permisos_sistema_codigo CHECK (CHAR_LENGTH(TRIM(codigo)) > 0),
    CONSTRAINT chk_permisos_sistema_nombre CHECK (CHAR_LENGTH(TRIM(nombre)) > 0),
    CONSTRAINT chk_permisos_sistema_activo CHECK (activo IN (0, 1))
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE rol_permisos (
    id_rol INT UNSIGNED NOT NULL,
    id_permiso_sistema INT UNSIGNED NOT NULL,

    PRIMARY KEY (id_rol, id_permiso_sistema),
    KEY idx_rol_permisos_permiso (id_permiso_sistema),
    CONSTRAINT fk_rol_permisos_roles FOREIGN KEY (id_rol)
        REFERENCES roles (id_rol),
    CONSTRAINT fk_rol_permisos_permisos FOREIGN KEY (id_permiso_sistema)
        REFERENCES permisos_sistema (id_permiso_sistema)
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE usuarios (
    id_usuario INT UNSIGNED NOT NULL AUTO_INCREMENT,
    id_rol INT UNSIGNED NOT NULL,
    id_empleado INT UNSIGNED NULL,
    nombre_usuario VARCHAR(50) NOT NULL,
    contrasena_hash VARCHAR(255) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,
    ultimo_acceso DATETIME NULL,
    fecha_creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fecha_actualizacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    PRIMARY KEY (id_usuario),
    CONSTRAINT uq_usuarios_nombre UNIQUE (nombre_usuario),
    CONSTRAINT uq_usuarios_empleado UNIQUE (id_empleado),
    KEY idx_usuarios_rol (id_rol),
    CONSTRAINT fk_usuarios_roles FOREIGN KEY (id_rol)
        REFERENCES roles (id_rol),
    CONSTRAINT fk_usuarios_empleados FOREIGN KEY (id_empleado)
        REFERENCES empleados (id_empleado),
    CONSTRAINT chk_usuarios_nombre CHECK (CHAR_LENGTH(TRIM(nombre_usuario)) > 0),
    CONSTRAINT chk_usuarios_hash CHECK (CHAR_LENGTH(TRIM(contrasena_hash)) > 0),
    CONSTRAINT chk_usuarios_activo CHECK (activo IN (0, 1))
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

-- La fecha final de una condición laboral es excluyente: la siguiente puede iniciar ese mismo día.
-- Los solapamientos entre intervalos deben validarse desde la aplicación dentro de una transacción.
CREATE TABLE historial_laboral (
    id_historial_laboral INT UNSIGNED NOT NULL AUTO_INCREMENT,
    id_empleado INT UNSIGNED NOT NULL,
    id_puesto INT UNSIGNED NOT NULL,
    id_tipo_contrato INT UNSIGNED NOT NULL,
    id_horario INT UNSIGNED NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NULL,
    salario_cifrado VARBINARY(256) NOT NULL,
    motivo VARCHAR(500) NOT NULL,
    id_usuario_autoriza INT UNSIGNED NOT NULL,
    fecha_autorizacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    vigencia_abierta TINYINT GENERATED ALWAYS AS (
        CASE WHEN fecha_fin IS NULL THEN 1 ELSE NULL END
    ) STORED,

    PRIMARY KEY (id_historial_laboral),
    CONSTRAINT uq_historial_laboral_inicio UNIQUE (id_empleado, fecha_inicio),
    CONSTRAINT uq_historial_laboral_abierto UNIQUE (id_empleado, vigencia_abierta),
    KEY idx_historial_laboral_empleado_fechas (id_empleado, fecha_inicio, fecha_fin),
    KEY idx_historial_laboral_puesto (id_puesto),
    KEY idx_historial_laboral_contrato (id_tipo_contrato),
    KEY idx_historial_laboral_horario (id_horario),
    KEY idx_historial_laboral_autoriza (id_usuario_autoriza),
    CONSTRAINT fk_historial_laboral_empleados FOREIGN KEY (id_empleado)
        REFERENCES empleados (id_empleado),
    CONSTRAINT fk_historial_laboral_puestos FOREIGN KEY (id_puesto)
        REFERENCES puestos (id_puesto),
    CONSTRAINT fk_historial_laboral_contratos FOREIGN KEY (id_tipo_contrato)
        REFERENCES tipos_contrato (id_tipo_contrato),
    CONSTRAINT fk_historial_laboral_horarios FOREIGN KEY (id_horario)
        REFERENCES horarios (id_horario),
    CONSTRAINT fk_historial_laboral_usuarios FOREIGN KEY (id_usuario_autoriza)
        REFERENCES usuarios (id_usuario),
    CONSTRAINT chk_historial_laboral_fechas CHECK (fecha_fin IS NULL OR fecha_fin > fecha_inicio),
    CONSTRAINT chk_historial_laboral_salario CHECK (OCTET_LENGTH(salario_cifrado) > 0),
    CONSTRAINT chk_historial_laboral_motivo CHECK (CHAR_LENGTH(TRIM(motivo)) > 0)
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE permisos_laborales (
    id_permiso_laboral INT UNSIGNED NOT NULL AUTO_INCREMENT,
    id_empleado INT UNSIGNED NOT NULL,
    fecha_inicio DATETIME NOT NULL,
    fecha_fin DATETIME NOT NULL,
    motivo VARCHAR(500) NOT NULL,
    con_goce BOOLEAN NOT NULL,
    estado ENUM('Pendiente', 'Aprobado', 'Rechazado', 'Cancelado') NOT NULL DEFAULT 'Pendiente',
    id_usuario_registra INT UNSIGNED NOT NULL,
    id_usuario_resuelve INT UNSIGNED NULL,
    fecha_resolucion DATETIME NULL,
    observaciones VARCHAR(500) NULL,
    fecha_creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fecha_actualizacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    PRIMARY KEY (id_permiso_laboral),
    KEY idx_permisos_laborales_empleado_fechas (id_empleado, fecha_inicio, fecha_fin),
    KEY idx_permisos_laborales_estado_inicio (estado, fecha_inicio),
    KEY idx_permisos_laborales_registra (id_usuario_registra),
    KEY idx_permisos_laborales_resuelve (id_usuario_resuelve),
    CONSTRAINT fk_permisos_laborales_empleados FOREIGN KEY (id_empleado)
        REFERENCES empleados (id_empleado),
    CONSTRAINT fk_permisos_laborales_registra FOREIGN KEY (id_usuario_registra)
        REFERENCES usuarios (id_usuario),
    CONSTRAINT fk_permisos_laborales_resuelve FOREIGN KEY (id_usuario_resuelve)
        REFERENCES usuarios (id_usuario),
    CONSTRAINT chk_permisos_laborales_fechas CHECK (fecha_fin > fecha_inicio),
    CONSTRAINT chk_permisos_laborales_motivo CHECK (CHAR_LENGTH(TRIM(motivo)) > 0),
    CONSTRAINT chk_permisos_laborales_goce CHECK (con_goce IN (0, 1)),
    CONSTRAINT chk_permisos_laborales_resolucion CHECK (
        (estado NOT IN ('Aprobado', 'Rechazado') OR fecha_resolucion IS NOT NULL)
        AND (fecha_resolucion IS NULL OR fecha_resolucion >= fecha_creacion)
    )
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

-- Se registra la jornada prevista aunque no existan marcas; una fila ausente no implica una falta.
CREATE TABLE asistencias (
    id_asistencia INT UNSIGNED NOT NULL AUTO_INCREMENT,
    id_empleado INT UNSIGNED NOT NULL,
    fecha DATE NOT NULL,
    es_laborable BOOLEAN NOT NULL DEFAULT TRUE,
    entrada_prevista DATETIME NULL,
    salida_prevista DATETIME NULL,
    tolerancia_minutos SMALLINT UNSIGNED NOT NULL DEFAULT 0,
    entrada DATETIME NULL,
    salida DATETIME NULL,
    estado ENUM('Pendiente', 'Presente', 'Falta', 'Justificada', 'NoLaborable') NOT NULL DEFAULT 'Pendiente',
    observaciones VARCHAR(500) NULL,
    id_usuario_registra INT UNSIGNED NOT NULL,
    fecha_creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fecha_actualizacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    PRIMARY KEY (id_asistencia),
    CONSTRAINT uq_asistencias_empleado_fecha UNIQUE (id_empleado, fecha),
    KEY idx_asistencias_fecha_estado (fecha, estado),
    KEY idx_asistencias_registra (id_usuario_registra),
    CONSTRAINT fk_asistencias_empleados FOREIGN KEY (id_empleado)
        REFERENCES empleados (id_empleado),
    CONSTRAINT fk_asistencias_usuarios FOREIGN KEY (id_usuario_registra)
        REFERENCES usuarios (id_usuario),
    CONSTRAINT chk_asistencias_jornada CHECK (
        (es_laborable = 1 AND estado <> 'NoLaborable'
            AND entrada_prevista IS NOT NULL AND salida_prevista IS NOT NULL
            AND salida_prevista > entrada_prevista)
        OR (es_laborable = 0 AND estado = 'NoLaborable'
            AND entrada_prevista IS NULL AND salida_prevista IS NULL
            AND entrada IS NULL AND salida IS NULL)
    ),
    CONSTRAINT chk_asistencias_marcas CHECK (
        salida IS NULL OR (entrada IS NOT NULL AND salida >= entrada)
    ),
    CONSTRAINT chk_asistencias_presente CHECK (estado <> 'Presente' OR entrada IS NOT NULL),
    CONSTRAINT chk_asistencias_falta CHECK (estado <> 'Falta' OR (entrada IS NULL AND salida IS NULL))
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE periodos_nomina (
    id_periodo_nomina INT UNSIGNED NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(100) NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL,
    estado ENUM('Borrador', 'Cerrado', 'Anulado') NOT NULL DEFAULT 'Borrador',
    id_usuario_genera INT UNSIGNED NOT NULL,
    fecha_generacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    id_usuario_cierra INT UNSIGNED NULL,
    fecha_cierre DATETIME NULL,
    observaciones VARCHAR(500) NULL,

    PRIMARY KEY (id_periodo_nomina),
    CONSTRAINT uq_periodos_nomina_fechas UNIQUE (fecha_inicio, fecha_fin),
    KEY idx_periodos_nomina_estado_inicio (estado, fecha_inicio),
    KEY idx_periodos_nomina_genera (id_usuario_genera),
    KEY idx_periodos_nomina_cierra (id_usuario_cierra),
    CONSTRAINT fk_periodos_nomina_genera FOREIGN KEY (id_usuario_genera)
        REFERENCES usuarios (id_usuario),
    CONSTRAINT fk_periodos_nomina_cierra FOREIGN KEY (id_usuario_cierra)
        REFERENCES usuarios (id_usuario),
    CONSTRAINT chk_periodos_nomina_nombre CHECK (CHAR_LENGTH(TRIM(nombre)) > 0),
    CONSTRAINT chk_periodos_nomina_fechas CHECK (fecha_fin >= fecha_inicio),
    CONSTRAINT chk_periodos_nomina_cierre CHECK (
        (estado <> 'Cerrado' OR fecha_cierre IS NOT NULL)
        AND (fecha_cierre IS NULL OR fecha_cierre >= fecha_generacion)
    )
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

-- Los nombres y montos de cada detalle conservan los datos usados al emitir la boleta.
-- La aplicación debe impedir editar períodos cerrados y sus detalles o movimientos.
CREATE TABLE detalle_nomina (
    id_detalle_nomina INT UNSIGNED NOT NULL AUTO_INCREMENT,
    id_periodo_nomina INT UNSIGNED NOT NULL,
    id_empleado INT UNSIGNED NOT NULL,
    id_departamento INT UNSIGNED NOT NULL,
    id_puesto INT UNSIGNED NOT NULL,
    codigo_empleado VARCHAR(20) NOT NULL,
    nombre_empleado VARCHAR(201) NOT NULL,
    nombre_departamento VARCHAR(100) NOT NULL,
    nombre_puesto VARCHAR(100) NOT NULL,
    tipo_contrato VARCHAR(80) NOT NULL,
    dias_pagados DECIMAL(6, 2) NOT NULL,
    moneda CHAR(3) CHARACTER SET ascii COLLATE ascii_bin NOT NULL DEFAULT 'GTQ',
    salario_base_cifrado VARBINARY(256) NOT NULL,
    total_ingresos_cifrado VARBINARY(256) NOT NULL,
    total_deducciones_cifrado VARBINARY(256) NOT NULL,
    neto_cifrado VARBINARY(256) NOT NULL,
    fecha_calculo DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    PRIMARY KEY (id_detalle_nomina),
    CONSTRAINT uq_detalle_nomina_periodo_empleado UNIQUE (id_periodo_nomina, id_empleado),
    KEY idx_detalle_nomina_empleado_periodo (id_empleado, id_periodo_nomina),
    KEY idx_detalle_nomina_periodo_departamento (id_periodo_nomina, id_departamento),
    KEY idx_detalle_nomina_departamento (id_departamento),
    KEY idx_detalle_nomina_puesto_departamento (id_puesto, id_departamento),
    CONSTRAINT fk_detalle_nomina_periodos FOREIGN KEY (id_periodo_nomina)
        REFERENCES periodos_nomina (id_periodo_nomina),
    CONSTRAINT fk_detalle_nomina_empleados FOREIGN KEY (id_empleado)
        REFERENCES empleados (id_empleado),
    CONSTRAINT fk_detalle_nomina_departamentos FOREIGN KEY (id_departamento)
        REFERENCES departamentos (id_departamento),
    CONSTRAINT fk_detalle_nomina_puestos FOREIGN KEY (id_puesto, id_departamento)
        REFERENCES puestos (id_puesto, id_departamento),
    CONSTRAINT chk_detalle_nomina_dias CHECK (dias_pagados >= 0),
    CONSTRAINT chk_detalle_nomina_codigo CHECK (CHAR_LENGTH(TRIM(codigo_empleado)) > 0),
    CONSTRAINT chk_detalle_nomina_empleado CHECK (CHAR_LENGTH(TRIM(nombre_empleado)) > 0),
    CONSTRAINT chk_detalle_nomina_departamento CHECK (CHAR_LENGTH(TRIM(nombre_departamento)) > 0),
    CONSTRAINT chk_detalle_nomina_puesto CHECK (CHAR_LENGTH(TRIM(nombre_puesto)) > 0),
    CONSTRAINT chk_detalle_nomina_contrato CHECK (CHAR_LENGTH(TRIM(tipo_contrato)) > 0),
    CONSTRAINT chk_detalle_nomina_moneda CHECK (moneda REGEXP '^[A-Z]{3}$'),
    CONSTRAINT chk_detalle_nomina_importes CHECK (
        OCTET_LENGTH(salario_base_cifrado) > 0 AND OCTET_LENGTH(total_ingresos_cifrado) > 0
        AND OCTET_LENGTH(total_deducciones_cifrado) > 0 AND OCTET_LENGTH(neto_cifrado) > 0
    )
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE movimientos_nomina (
    id_movimiento_nomina INT UNSIGNED NOT NULL AUTO_INCREMENT,
    id_detalle_nomina INT UNSIGNED NOT NULL,
    orden SMALLINT UNSIGNED NOT NULL,
    tipo ENUM('Ingreso', 'Deduccion') NOT NULL,
    concepto VARCHAR(150) NOT NULL,
    cantidad DECIMAL(10, 2) NOT NULL DEFAULT 1,
    importe_cifrado VARBINARY(256) NOT NULL,

    PRIMARY KEY (id_movimiento_nomina),
    CONSTRAINT uq_movimientos_nomina_orden UNIQUE (id_detalle_nomina, orden),
    CONSTRAINT fk_movimientos_nomina_detalles FOREIGN KEY (id_detalle_nomina)
        REFERENCES detalle_nomina (id_detalle_nomina),
    CONSTRAINT chk_movimientos_nomina_orden CHECK (orden > 0),
    CONSTRAINT chk_movimientos_nomina_concepto CHECK (CHAR_LENGTH(TRIM(concepto)) > 0),
    CONSTRAINT chk_movimientos_nomina_cantidad CHECK (cantidad > 0),
    CONSTRAINT chk_movimientos_nomina_importe CHECK (OCTET_LENGTH(importe_cifrado) > 0)
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE bitacora (
    id_bitacora BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
    id_usuario INT UNSIGNED NULL,
    nombre_usuario VARCHAR(50) NULL,
    fecha_operacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    operacion ENUM('INSERT', 'UPDATE', 'DELETE', 'LOGIN', 'LOGOUT', 'AUTORIZACION', 'CIERRE', 'ANULACION') NOT NULL,
    entidad VARCHAR(64) NOT NULL,
    registro_afectado VARCHAR(150) NULL,
    descripcion VARCHAR(1000) NOT NULL,

    PRIMARY KEY (id_bitacora),
    KEY idx_bitacora_fecha (fecha_operacion),
    KEY idx_bitacora_usuario_fecha (id_usuario, fecha_operacion),
    KEY idx_bitacora_registro_fecha (entidad, registro_afectado, fecha_operacion),
    CONSTRAINT fk_bitacora_usuarios FOREIGN KEY (id_usuario)
        REFERENCES usuarios (id_usuario),
    CONSTRAINT chk_bitacora_entidad CHECK (CHAR_LENGTH(TRIM(entidad)) > 0),
    CONSTRAINT chk_bitacora_descripcion CHECK (CHAR_LENGTH(TRIM(descripcion)) > 0)
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;

CREATE TABLE configuracion_sistema (
    id_configuracion TINYINT UNSIGNED NOT NULL DEFAULT 1,
    nombre_empresa VARCHAR(150) NOT NULL,
    nit VARCHAR(25) NULL,
    direccion VARCHAR(250) NULL,
    telefono VARCHAR(25) NULL,
    correo VARCHAR(254) NULL,
    moneda CHAR(3) CHARACTER SET ascii COLLATE ascii_bin NOT NULL DEFAULT 'GTQ',
    zona_horaria VARCHAR(64) NOT NULL DEFAULT 'America/Guatemala',
    fecha_actualizacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    PRIMARY KEY (id_configuracion),
    CONSTRAINT chk_configuracion_sistema_unica CHECK (id_configuracion = 1),
    CONSTRAINT chk_configuracion_sistema_nombre CHECK (CHAR_LENGTH(TRIM(nombre_empresa)) > 0),
    CONSTRAINT chk_configuracion_sistema_moneda CHECK (moneda REGEXP '^[A-Z]{3}$'),
    CONSTRAINT chk_configuracion_sistema_zona CHECK (CHAR_LENGTH(TRIM(zona_horaria)) > 0)
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_unicode_ci;
