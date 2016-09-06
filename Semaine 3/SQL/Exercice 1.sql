CREATE DATABASE client_serveur
go
USE client_serveur
go

CREATE TABLE personne (
per_num int IDENTITY,
per_nom varchar (30) NOT NULL,
pre_prenom varchar (30) NOT NULL,
pre_adresse varchar (300) NOT NULL,
per_ville varchar (30) NOT NULL,
PRIMARY KEY (per_num)
)
go

CREATE TABLE groupe (
gro_num int IDENTITY NOT NULL,
gro_libelle varchar (50),
PRIMARY KEY (gro_num)
)
go

CREATE TABLE appartient (
per_num int REFERENCES personne(per_num),
gro_num int REFERENCES groupe(gro_num),
PRIMARY KEY (gro_num,per_num)
)
go

