USE `PrototipoEF-09011976`;

select *from tbl_usuarios;

INSERT INTO `tbl_usuarios` VALUES 
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('5', 'Nominas', 'Nominas', 'nominas', 'X9yc1/l1b2A==', 'nominas@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM='),
('9', 'Seguridad', 'Seguridad', 'seguridad', 'X9yc1/l1b2A==', 'seguridad@gmail.com', '2022-07-02 21:00:48', '1','COLOR FAVORITO','TdX9j/kyyKM=');

INSERT INTO `tbl_modulos` VALUES
('1000', 'SEGURIDAD', 'Seguridad', 1),
('2000', 'LOGISTICA', 'Logistica', 1),
('3000', 'COMPRAS Y VENTAS', 'Compras y Ventas', 1),
('5000', 'PRODUCCIÓN', 'Produccion', 1),
('6000', 'NOMINAS', 'Nominas', 1),
('7000', 'BANCOS', 'Bancos', 1),
('8000', 'CONTABILIDAD', 'Contabilidad', 1);

-- -----APLICACIONES
INSERT INTO `tbl_aplicaciones` VALUES
('1', 'Login', 'Login', '1');
INSERT INTO `tbl_aplicaciones` VALUES
('999', 'cerrar', 'Login', '1');
INSERT INTO `tbl_aplicaciones` VALUES
('1000', 'MDI SEGURIDAD', 'PARA SEGURIDAD', '1'),
('1001', 'Mant. Usuario', 'PARA SEGURIDAD', '1'),
('1002', 'Mant. Aplicación', 'PARA SEGURIDAD', '1'),
('1003', 'Mant. Modulo', 'PARA SEGURIDAD', '1'),
('1004', 'Mant. Perfil', 'PARA SEGURIDAD', '1'),
('1101', 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', '1'),
('1102', 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', '1'),
('1103', 'Asign. Perfil Usuario', 'PARA SEGURIDAD', '1'),
('1201', 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', '1'),
('1301', 'Pcs. BITACORA', 'PARA SEGURIDAD', '1'),
('2000', 'MDI LOGISTICA', 'PARA LOGISTICA', '1'),
('3000', 'MDI COMPRAS Y VENTAS', 'PARA COMPRAS Y VENTAS', '1'),
('5000', 'MDI PRODUCCIÓN', 'PARA PRODUCCIÓN', '1'),
('6000', 'MDI NOMINAS', 'PARA NOMINAS', '1'),
('6001', 'Mant. Trabajadores', 'PARA NOMINAS', '1'),
('6002', 'Mant. Puestos de Trabajo', 'PARA NOMINAS', '1'),
('6003', 'Mant. Departamentos', 'PARA NOMINAS', '1'),
('6004', 'Mant. Contratos', 'PARA NOMINAS', '1'),
('6005', 'Mant. Percepciones', 'PARA NOMINAS', '1'),
('6006', 'Mant. Horas Extras', 'PARA NOMINAS', '1'),
('6007', 'Mant. Faltas', 'PARA NOMINAS', '1'),
('6101', 'Asgn. Puesto - Depto.', 'PARA NOMINAS', '1'),
('6102', 'Asgn. Puesto - Trabajador', 'PARA NOMINAS', '1'),
('6103', 'Asgn. Contrato Trabajador', 'PARA NOMINAS', '1'),
('6104', 'Asgn. Prestaciones Contrato', 'PARA NOMINAS', '1'),
('6105', 'Asgn. Prestaciones Individual', 'PARA NOMINAS', '1'),
('6106', 'Prcs. Nomina', 'PARA NOMINAS', '1'),
('6201', 'Rpt. Planillas', 'PARA NOMINAS', '1'),
('6202', 'Rpt. Contratos', 'PARA NOMINAS', '1'),
('6203', 'Rpt. Trabajadores', 'PARA NOMINAS', '1'),
('6301', 'ACCESO SEGURIDAD', 'PARA NOMINAS', '1'),
('7000', 'MDI BANCOS', 'PARA BANCOS', '1'),
('8000', 'MDI CONTRABILIDAD', 'PARA CONTRABILIDAD', '1');


-- -----PERFILES
INSERT INTO `tbl_perfiles` VALUES
('1', 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
('2', 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
('3', 'LOGISTICA', 'contiene todos los permisos de logistica', 1),
('4', 'COMPRAS Y VENTAS', 'contiene todos los permisos de compras y ventas', 1),
('5', 'PRODUCCIÓN', 'contiene todos los permisos de producción', 1),
('6', 'NOMINAS', 'contiene todos los permisos de nominas', 1),
('7', 'BANCOS', 'contiene todos los permisos de bancos', 1),
('8', 'CONTABILIDAD', 'contiene todos los permisos de contabilidad', 1);

-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES
('1000', '1000'),
('1000', '1001'),
('1000', '1002'),
('1000', '1003'),
('1000', '1004'),
('1000', '1102'),
('1000', '1103'),
('1000', '1201'),
('1000', '1301'),
('2000', '2000'),
('3000', '3000'),
('5000', '5000'),
('6000', '6000'),
('6000', '6001'),
('6000', '6002'),
('6000', '6003'),
('6000', '6004'),
('6000', '6005'),
('6000', '6006'),
('6000', '6007'),
('6000', '6101'),
('6000', '6102'),
('6000', '6103'),
('6000', '6104'),
('6000', '6105'),
('6000', '6106'),
('6000', '6201'),
('6000', '6202'),
('6000', '6203'),
('6000', '6301'),
('7000', '7000'),
('8000', '8000');

-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO `tbl_permisosAplicacionPerfil` VALUES
('1', '1000', '1', '1', '1', '1', '1'),
('1', '1001', '1', '1', '1', '1', '1'),
('1', '1002', '1', '1', '1', '1', '1'),
('1', '1003', '1', '1', '1', '1', '1'),
('1', '1004', '1', '1', '1', '1', '1'),
('1', '1101', '1', '1', '1', '1', '1'),
('1', '1102', '1', '1', '1', '1', '1'),
('1', '1103', '1', '1', '1', '1', '1'),
('1', '1201', '1', '1', '1', '1', '1'),
('1', '1301', '1', '1', '1', '1', '1'),
('1', '2000', '1', '1', '1', '1', '1'),
('1', '3000', '1', '1', '1', '1', '1'),
('1', '5000', '1', '1', '1', '1', '1'),
('1', '6000', '1', '1', '1', '1', '1'),
('1', '6001', '1', '1', '1', '1', '1'),
('1', '6002', '1', '1', '1', '1', '1'),
('1', '6003', '1', '1', '1', '1', '1'),
('1', '6004', '1', '1', '1', '1', '1'),
('1', '6005', '1', '1', '1', '1', '1'),
('1', '6006', '1', '1', '1', '1', '1'),
('1', '6007', '1', '1', '1', '1', '1'),
('1', '6101', '1', '1', '1', '1', '1'),
('1', '6102', '1', '1', '1', '1', '1'),
('1', '6103', '1', '1', '1', '1', '1'),
('1', '6104', '1', '1', '1', '1', '1'),
('1', '6105', '1', '1', '1', '1', '1'),
('1', '6106', '1', '1', '1', '1', '1'),
('1', '6201', '1', '1', '1', '1', '1'),
('1', '6202', '1', '1', '1', '1', '1'),
('1', '6203', '1', '1', '1', '1', '1'),
('1', '6301', '1', '1', '1', '1', '1'),
('1', '7000', '1', '1', '1', '1', '1'),
('1', '8000', '1', '1', '1', '1', '1'),
('2', '1000', '1', '1', '1', '1', '1'),
('3', '2000', '1', '1', '1', '1', '1'),
('4', '3000', '1', '1', '1', '1', '1'),
('5', '5000', '1', '1', '1', '1', '1'),
('6', '6000', '1', '1', '1', '1', '1'),
('6', '6001', '1', '1', '1', '1', '1'),
('6', '6002', '1', '1', '1', '1', '1'),
('6', '6003', '1', '1', '1', '1', '1'),
('6', '6004', '1', '1', '1', '1', '1'),
('6', '6005', '1', '1', '1', '1', '1'),
('6', '6006', '1', '1', '1', '1', '1'),
('6', '6007', '1', '1', '1', '1', '1'),
('6', '6101', '1', '1', '1', '1', '1'),
('6', '6102', '1', '1', '1', '1', '1'),
('6', '6103', '1', '1', '1', '1', '1'),
('6', '6104', '1', '1', '1', '1', '1'),
('6', '6105', '1', '1', '1', '1', '1'),
('6', '6106', '1', '1', '1', '1', '1'),
('6', '6201', '1', '1', '1', '1', '1'),
('6', '6202', '1', '1', '1', '1', '1'),
('6', '6203', '1', '1', '1', '1', '1'),
('6', '6301', '1', '1', '1', '1', '1'),
('7', '7000', '1', '1', '1', '1', '1'),
('8', '8000', '1', '1', '1', '1', '1');

-- -----ASIGNACIÓN DE PERFIL A USUARIO
INSERT INTO `tbl_asignacionesPerfilsUsuario` VALUES
('1', '1'); 



INSERT INTO `prototipoef-09011976`.`tbl_asignacionesPerfilsUsuario` (`fk_id_usuario`, `fk_id_perfil`) VALUES ('5', '6');