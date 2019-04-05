CREATE DATABASE Hola 
GO

USE Test;

CREATE TABLE Hola.compañia (
    id_compañia int PRIMARY KEY,
    nombre_compañia varchar(20) NOT NULL,
    descripcion varchar(200),
	estado bit,
);

CREATE TABLE Hola.rol_seg(
	id_rol int PRIMARY KEY,
	nombre_rol varchar(50) NOT NULL,
	descripcion varchar(200),
	estado bit,
);

CREATE TABLE Hola.producto(
	id_producto int PRIMARY KEY,
	nombre_producto varchar(50) NOT NULL,
	descripcion varchar(200),
	estado bit,
	nombre_compañia varchar(20) NOT NULL,
	nombre_rol varchar(50) NOT NULL,
	FOREIGN KEY (nombre_compañia) REFERENCES Prueba.compañia (nombre_compañia),
	FOREIGN KEY (nombre_rol) REFERENCES Prueba.rol_seg (nombre_rol),
);

CREATE TABLE Hola.tipo_document(
	id_tipo_document int PRIMARY KEY,
	nombre_document varchar(20) NOT NULL,
	estado bit,
);

CREATE TABLE Hola.departamento(
	id_departamento int PRIMARY KEY,
	nombre_departamento varchar(20) NOT NULL,
	estado bit,
);

CREATE TABLE Hola.ciudad(
	id_ciudad int PRIMARY KEY,
	nombre_ciudad varchar(20) NOT NULL,
	estado bit,
);

CREATE TABLE Hola.venta(
	id_venta int PRIMARY KEY,
	nombre_producto varchar(50) NOT NULL,
	primer_nombre varchar(20) NOT NULL,
	segundo_nombre varchar(20),
	primer_apellido varchar(20) NOT NULL,
	segundo_apellido  varchar(20),
	tipo_document varchar(20) NOT NULL,
	numero_document int,
	correo_electronico varchar(100) NOT NULL,
	telefono int NOT NULL,
	nombre_departamento varchar(20) NOT NULL,
	nombre_ciudad varchar(20) NOT NULL,
	observacion varchar(500),
	FOREIGN KEY (nombre_producto) REFERENCES Prueba.producto (nombre_producto),
	FOREIGN KEY (tipo_document) REFERENCES Prueba.tipo_document (nombre_document),
	FOREIGN KEY (nombre_departamento) REFERENCES Prueba.departamento (nombre_departamento),
	FOREIGN KEY (nombre_ciudad) REFERENCES Prueba.ciudad (nombre_ciudad),
);
GO

drop table Hola;