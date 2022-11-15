CREATE DATABASE IF NOT EXISTS `PrototipoEF-09011976`;
USE `PrototipoEF-09011976`;

CREATE TABLE IF NOT EXISTS `tbl_modulos` (
	pk_id_modulos INT NOT NULL,
    nombre_modulo VARCHAR(50) NOT NULL,
    descripcion_modulo VARCHAR(150) NOT NULL,
    estado_modulo TINYINT DEFAULT 0,
    primary key (`pk_id_modulos`)
);

select *from tbl_aplicaciones; /*6000*/

CREATE TABLE IF NOT EXISTS `tbl_aplicaciones` (
	pk_id_aplicacion INT NOT NULL,
    nombre_aplicacion VARCHAR(50) NOT NULL,
    descripcion_aplicacion VARCHAR(150) NOT NULL,
    estado_aplicacion TINYINT DEFAULT 0,
    primary key (`pk_id_aplicacion`)
);

select *from tbl_AsignacionModuloAplicacion;

CREATE TABLE IF NOT EXISTS `tbl_AsignacionModuloAplicacion` (
  fk_id_modulos INT NOT NULL,
  fk_id_aplicacion INT NOT NULL, 
  PRIMARY KEY (`fk_id_modulos`,`fk_id_aplicacion` ),
  FOREIGN KEY (`fk_id_modulos`) REFERENCES `tbl_modulos` (`pk_id_modulos`),
  FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

select *from tbl_usuarios;

CREATE TABLE IF NOT EXISTS `tbl_usuarios` (
  pk_id_usuario INT AUTO_INCREMENT NOT NULL,
  nombre_usuario VARCHAR(50) NOT NULL,
  apellido_usuario VARCHAR(50) NOT NULL,
  username_usuario VARCHAR(20) NOT NULL,
  password_usuario VARCHAR(100) NOT NULL,
  email_usuario VARCHAR(50) NOT NULL,
  ultima_conexion_usuario DATETIME NULL DEFAULT NULL,
  estado_usuario TINYINT DEFAULT 0 NOT NULL,
  pregunta varchar(50) not null,
  respuesta varchar(50) not null,
  PRIMARY KEY (`pk_id_usuario`)
);

select *from tbl_perfiles; /* 6 */

CREATE TABLE IF NOT EXISTS `tbl_perfiles` (
	pk_id_perfil INT AUTO_INCREMENT NOT NULL,
    nombre_perfil VARCHAR(50) NOT NULL,
    descripcion_perfil VARCHAR(150) NOT NULL,
    estado_perfil TINYINT DEFAULT 0,
    primary key (pk_id_perfil)
);



CREATE TABLE IF NOT EXISTS `tbl_permisosAplicacionesUsuario` (
  fk_id_aplicacion INT NOT NULL, 
  fk_id_usuario INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (`fk_id_aplicacion`,`fk_id_usuario`),
  FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

select *from tbl_permisosAplicacionPerfil;

CREATE TABLE IF NOT EXISTS `tbl_permisosAplicacionPerfil` (
  fk_id_perfil INT NOT NULL, 
  fk_id_aplicacion INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (`fk_id_perfil`,`fk_id_aplicacion`),
  FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

select *from tbl_asignacionesPerfilsUsuario;

CREATE TABLE IF NOT EXISTS `tbl_asignacionesPerfilsUsuario` (
  fk_id_usuario INT NOT NULL, 
  fk_id_perfil INT NOT NULL,
  PRIMARY KEY (`fk_id_usuario`,`fk_id_perfil` ),
  FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;


CREATE TABLE IF NOT EXISTS `tbl_bitacoraDeEventos` (
  pk_id_bitacora INT AUTO_INCREMENT NOT NULL,
  fk_id_usuario INT NOT NULL,
  fk_id_aplicacion INT NOT NULL,
  fecha_bitacora DATE NOT NULL,
  hora_bitacora TIME NOT NULL,
  host_bitacora VARCHAR(100) NOT NULL,
  ip_bitacora VARCHAR(100) NOT NULL,
  accion_bitacora VARCHAR(100) NOT NULL,
  PRIMARY KEY (`pk_id_bitacora`),
  FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

/* Tablas nuevas */

CREATE TABLE IF NOT EXISTS `tbl_puestos` (
  pk_codigo_puesto INT AUTO_INCREMENT NOT NULL,
  nombre_puesto VARCHAR(100) NOT NULL,
  estatus_puesto TINYINT DEFAULT 0,
  PRIMARY KEY (`pk_codigo_puesto`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `tbl_departamento` (
  pk_codigo_departamento INT AUTO_INCREMENT NOT NULL,
  nombre_departamento VARCHAR(100) NOT NULL,
  estatus_departamento TINYINT DEFAULT 0,
  PRIMARY KEY (`pk_codigo_departamento`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

select  *from tbl_empleados;
CREATE TABLE IF NOT EXISTS `tbl_empleados` (
  pk_codigo_empleado INT AUTO_INCREMENT NOT NULL,
  nombre_empleado VARCHAR(100) NOT NULL,
  fk_codigo_puesto INT NOT NULL,
  fk_codigo_departamento INT NOT NULL,
  sueldo_empleado  float(10,2),
  estatus_empleado TINYINT DEFAULT 0,
  PRIMARY KEY (`pk_codigo_empleado`),
  FOREIGN KEY (`fk_codigo_puesto`) REFERENCES `tbl_puestos` (`pk_codigo_puesto`),
  FOREIGN KEY (`fk_codigo_departamento`) REFERENCES `tbl_departamento` (`pk_codigo_departamento`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

select *from tbl_concepto;

CREATE TABLE IF NOT EXISTS `tbl_concepto` (
  pk_codigo_concepto INT AUTO_INCREMENT NOT NULL,
  nombre_concepto VARCHAR(100) NOT NULL,
  efecto_concepto VARCHAR(100) NOT NULL,
  estatus_departamento TINYINT DEFAULT 0,
  PRIMARY KEY (`pk_codigo_concepto`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;


CREATE TABLE IF NOT EXISTS `tbl_nominad` (
  pk_codigo_nomina INT AUTO_INCREMENT NOT NULL,
  fk_codigo_empleado INT NOT NULL,
  fk_codigo_concepto INT NOT NULL,
  PRIMARY KEY (`pk_codigo_nomina`),
  FOREIGN KEY (`fk_codigo_empleado`) REFERENCES `tbl_empleados` (`pk_codigo_empleado`),
  FOREIGN KEY (`fk_codigo_concepto`) REFERENCES `tbl_concepto` (`pk_codigo_concepto`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `tbl_nominae` (
  pk_codigo_nominae INT AUTO_INCREMENT NOT NULL,
  fecha_inicial_nomina VARCHAR(100) NOT NULL,
  fecha_final_nomina VARCHAR(100) NOT NULL,
  fk_codigo_nomina INT NOT NULL,
  PRIMARY KEY (`pk_codigo_nominae`),
  FOREIGN KEY (`fk_codigo_nomina`) REFERENCES `tbl_nominad` (`pk_codigo_nomina`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;



-- vistas ------------------------------------------------------------------------
CREATE 
VIEW `PrototipoEF-09011976`.`vista_aplicacion_perfil` AS 
    SELECT 
        `b`.`fk_id_perfil` AS `ID`,
        `a`.`nombre_perfil` AS `Perfil`,
        `b`.`fk_id_aplicacion` AS `Aplicacion`,
        `b`.`guardar_permiso` AS `Insertar`,
        `b`.`modificar_permiso` AS `Modificar`,
        `b`.`eliminar_permiso` AS `Eliminar`,
        `b`.`buscar_permiso` AS `Buscar`,
        `b`.`imprimir_permiso` AS `Reporte`
    FROM
        (`PrototipoEF-09011976`.`tbl_permisosaplicacionperfil` `b`
        JOIN `PrototipoEF-09011976`.`tbl_perfiles` `a` ON ((`a`.`pk_id_perfil` = `b`.`fk_id_perfil`)));
        
CREATE 
VIEW `PrototipoEF-09011976`.`vista_aplicacionusuario` AS
    SELECT 
        `b`.`fk_id_aplicacion` AS `Aplicacion`,
        `b`.`fk_id_usuario` AS `ID`,
        `a`.`nombre_usuario` AS `Usuario`,
        `b`.`guardar_permiso` AS `Insertar`,
        `b`.`modificar_permiso` AS `Editar`,
        `b`.`eliminar_permiso` AS `Eliminar`,
        `b`.`buscar_permiso` AS `Buscar`,
        `b`.`imprimir_permiso` AS `Reporte`
    FROM
        (`PrototipoEF-09011976`.`tbl_permisosaplicacionesusuario` `b`
        JOIN `PrototipoEF-09011976`.`tbl_usuarios` `a` ON ((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`)));
        
CREATE 
VIEW `PrototipoEF-09011976`.`vista_modulo_aplicacion` AS
    SELECT 
        `b`.`fk_id_modulos` AS `ID`,
        `a`.`nombre_modulo` AS `Modulo`,
        `b`.`fk_id_aplicacion` AS `Aplicacion`,
        `c`.`nombre_aplicacion` AS `Nombre`,
        `c`.`descripcion_aplicacion` AS `Descripcion`
    FROM
        ((`PrototipoEF-09011976`.`tbl_asignacionmoduloaplicacion` `b`
        JOIN `PrototipoEF-09011976`.`tbl_modulos` `a` ON ((`a`.`pk_id_modulos` = `b`.`fk_id_modulos`)))
        JOIN `PrototipoEF-09011976`.`tbl_aplicaciones` `c` ON ((`c`.`pk_id_aplicacion` = `b`.`fk_id_aplicacion`)));
        
CREATE 
VIEW `PrototipoEF-09011976`.`vista_perfil_usuario` AS
    SELECT 
        `b`.`fk_id_usuario` AS `ID`,
        `a`.`nombre_usuario` AS `Usuario`,
        `a`.`username_usuario` AS `nickName`,
        `b`.`fk_id_perfil` AS `perfil`,
        `c`.`nombre_perfil` AS `Nombre`
    FROM
        ((`PrototipoEF-09011976`.`tbl_asignacionesperfilsusuario` `b`
        JOIN `PrototipoEF-09011976`.`tbl_usuarios` `a` ON ((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`)))
        JOIN `PrototipoEF-09011976`.`tbl_perfiles` `c` ON ((`c`.`pk_id_perfil` = `b`.`fk_id_perfil`)));
        