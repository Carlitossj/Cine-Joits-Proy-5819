create database CineJoits5819;

USE CineJoits5819;

SET FOREIGN_KEY_CHECKS=0;



DROP TABLE IF EXISTS Entrada
;
DROP TABLE IF EXISTS Genero
;
DROP TABLE IF EXISTS Pelicula
;
DROP TABLE IF EXISTS Proyeccion
;
DROP TABLE IF EXISTS Sala
;

CREATE TABLE Entrada
(
	idEntrada INTEGER NOT NULL,
	idProyeccion SMALLINT,
	valor FLOAT(0) NOT NULL,
	PRIMARY KEY (idEntrada),
	KEY (idProyeccion)
) 
;


CREATE TABLE Genero
(
	idGenero SMALLINT NOT NULL,
	genero VARCHAR(30) NOT NULL,
	PRIMARY KEY (idGenero)
) 
;


CREATE TABLE Pelicula
(
	idPelicula SMALLINT NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	fecha_lanzamiento DATE NOT NULL,
	idGenero SMALLINT,
	PRIMARY KEY (idPelicula),
	KEY (idGenero)
) 
;


CREATE TABLE Proyeccion
(
	idProyeccion SMALLINT NOT NULL,
	fecha_y_hora DATETIME NOT NULL,
	idPelicula SMALLINT NOT NULL,
	idSala SMALLINT,
	PRIMARY KEY (idProyeccion),
	KEY (idPelicula)
) 
;


CREATE TABLE Sala
(
	idSala TINYINT NOT NULL,
	piso TINYINT NOT NULL,
	capacidad SMALLINT NOT NULL,
	PRIMARY KEY (idSala)
) 
;



SET FOREIGN_KEY_CHECKS=1;


ALTER TABLE Entrada ADD CONSTRAINT FK_Entrada_Proyeccion 
	FOREIGN KEY (idProyeccion) REFERENCES Proyeccion (idProyeccion)
;

ALTER TABLE Pelicula ADD CONSTRAINT FK_Pelicula_Genero 
	FOREIGN KEY (idGenero) REFERENCES Genero (idGenero)
;

ALTER TABLE Proyeccion ADD CONSTRAINT FK_Proyeccion_Pelicula 
	FOREIGN KEY (idPelicula) REFERENCES Pelicula (idPelicula)
;
