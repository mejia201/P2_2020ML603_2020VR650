CREATE DATABASE db_covid;

USE db_covid;


CREATE TABLE Departamentos(
id_departamento int identity primary key,
nombre_departamento varchar(100)
);

CREATE TABLE Genero(
id_genero int identity primary key,
nombre varchar(100)
);

CREATE TABLE Casos(
id_caso int identity primary key,
id_departamento int,
id_genero int,
casos_confirmados int,
casos_recuperados int,
fallecidos int
CONSTRAINT fk_departamento FOREIGN KEY (id_departamento) REFERENCES Departamentos (id_departamento),
CONSTRAINT fk_genero FOREIGN KEY (id_genero) REFERENCES Genero (id_genero)
);