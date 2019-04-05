CREATE DATABASE Prueba

USE Prueba;

CREATE TABLE compañia (
    id_compañia int IDENTITY(1,1) PRIMARY KEY,
    nombre_compañia varchar(20) NOT NULL,
    descripcion varchar(200),
	estado bit,
);

CREATE TABLE rol_seg(
	id_rol int IDENTITY(1,1) PRIMARY KEY,
	nombre_rol varchar(50) NOT NULL,
	descripcion varchar(200),
	estado bit,
);

CREATE TABLE producto(
	id_producto int IDENTITY(1,1) PRIMARY KEY,
	nombre_producto varchar(50) NOT NULL,
	descripcion varchar(200),
	estado bit,
	id_compañia int NOT NULL,
	id_rol int NOT NULL,
	FOREIGN KEY (id_compañia) REFERENCES compañia (id_compañia),
	FOREIGN KEY (id_rol) REFERENCES rol_seg (id_rol),
);

CREATE TABLE tipo_document(
	id_tipo_document int IDENTITY(1,1) PRIMARY KEY,
	nombre_document varchar(20) NOT NULL,
	estado bit,
);

CREATE TABLE departamento(
	id_departamento int IDENTITY(1,1) PRIMARY KEY,
	nombre_departamento varchar(20) NOT NULL,
	estado bit,
);

CREATE TABLE ciudad(
	id_ciudad int IDENTITY(1,1) PRIMARY KEY,
	nombre_ciudad varchar(20) NOT NULL,
	estado bit,
);

CREATE TABLE venta(
	id_venta int IDENTITY(1,1),
	id_producto int NOT NULL,
	primer_nombre varchar(20) NOT NULL,
	segundo_nombre varchar(20),
	primer_apellido varchar(20) NOT NULL,
	segundo_apellido  varchar(20),
	id_tipo_document int NOT NULL,
	numero_document int,
	correo_electronico varchar(100) NOT NULL,
	telefono int NOT NULL,
	id_departamento int NOT NULL,
	id_ciudad int NOT NULL,
	observacion varchar(500),
	FOREIGN KEY (id_producto) REFERENCES producto (id_producto),
	FOREIGN KEY (id_tipo_document) REFERENCES tipo_document (id_tipo_document),
	FOREIGN KEY (id_departamento) REFERENCES departamento (id_departamento),
	FOREIGN KEY (id_ciudad) REFERENCES ciudad (id_ciudad),
	PRIMARY KEY (id_venta, id_producto, id_tipo_document, id_departamento, id_ciudad),
);


drop table Prueba;