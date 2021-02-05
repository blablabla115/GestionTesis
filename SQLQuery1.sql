--------------------------------------------------------------------------
---- CREACION DE LA BASE DE DATOS
--------------------------------------------------------------------------
use master
go
if exists (select * from sysdatabases where name = 'bdGestionTesis')
drop database bdGestionTesis
go
create database bdGestionTesis
go
--------------------------------------------------------------------------
-- CREACION DE LA TABLA TESISTA
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para tesista
create table TTesista
( -- lista de atributos
CodTesista varchar(6),
Nombre varchar(50) not null,
ApellidoPaterno varchar (50) not null,
ApellidoMaterno varchar (50) not null,
DNI varchar(8),
CarreraProfesional varchar (50) not null,
FechaNacimiento date,
-- definicion de la clave foranea
primary key (CodTesista)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA DOCENTES
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para docente
create table TDocentes
( -- lista de atributos
CodDocente varchar(10) not null,
Nombre varchar(50) not null,
ApellidoPaterno varchar (50) not null,
ApellidoMaterno varchar (50) not null,
DNI varchar (8) ,
telefono varchar (9),
Categoria varchar (20),
DepAcademico varchar (50),
Disponibilidad varchar (20),
-- definicion de la clave foranea
primary key (CodDocente)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA TESIS
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para tesis
create table TTesis
( -- lista de atributos
CodTesis varchar(10),
TituloTesis varchar(50) not null,
Autor1 varchar (6),
Autor2 varchar (6),
Autor3 varchar (6),
Asesor1 varchar (10) ,
Asesor2 varchar (10) ,
-- definicion de la clave foranea
primary key (CodTesis),
foreign key (Autor1) references TTesista(CodTesista),
foreign key (Autor2) references TTesista(CodTesista),
foreign key (Autor3) references TTesista(CodTesista),
foreign key (Asesor1) references TDocentes(CodDocente),
foreign key (Asesor2) references TDocentes(CodDocente),
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA PLAN DE TESIS
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para plan tesis
create table TPlanTesis
( -- lista de atributos
CodPlanTesis varchar(10),
TituloPlanTesis varchar(50) not null,
Asesor1 varchar(10) ,
Asesor2 varchar(10) ,
Autor1 varchar (6) ,
Autor2 varchar (6) ,
Autor3 varchar (6) ,
-- definicion de la clave foranea
primary key (CodPlanTesis),
foreign key (Asesor1) references TDocentes(CodDocente),
foreign key (Asesor2) references TDocentes(CodDocente),
foreign key (Autor1) references TTesista(CodTesista),
foreign key (Autor2) references TTesista(CodTesista),
foreign key (Autor3) references TTesista(CodTesista),
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA RESOLUCION
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para resolucion
create table TResolucion
( -- lista de atributos
nroResolucion int not null,
asunto varchar (50) not null, --asunto: AsignacionDictaminante,ActaSustentación,AsignacionJurado
implicado1 varchar (10),
implicado2 varchar (10),
implicado3 varchar (10),
implicado4 varchar (10),
implicado5 varchar (10),
-- definicion de la clave foranea
primary key (nroResolucion),
foreign key (implicado1) references TDocentes(CodDocente),
foreign key (implicado2) references TDocentes(CodDocente),
foreign key (implicado3) references TDocentes(CodDocente),
foreign key (implicado4) references TDocentes(CodDocente),
foreign key (implicado5) references TDocentes(CodDocente),
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA MEMORANDO (DESIGNACION DE LOS EVALUADORES)
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para memorando
create table TMemorando
( -- lista de atributos
nroMemorando int not null,
Evaluador1 varchar (10) not null,
Evaluador2 varchar (10) not null,
-- definicion de la clave foranea
primary key (nroMemorando),
foreign key (Evaluador1) references TDocentes(CodDocente),
foreign key (Evaluador2) references TDocentes(CodDocente)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA LIBRO DE INSCRIPCION DE TESIS
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para resolucion
create table TLibroInscripcion
( -- lista de atributos
nroLibroInscripcion int,
FechaInscripcion date,
CodTesisInscrita varchar (10) not null,
-- definicion de la clave foranea
primary key (nroLibroInscripcion),
foreign key (CodTesisInscrita) references TTesis(CodTesis),
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA TRAMITES
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para tramites
create table TTramites
( -- lista de atributos
CodTramite varchar (30) not null,
Nombre varchar (50),
-- definicion de la clave foranea
primary key (CodTramite),
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA SOLICITUD (TRAMITE)
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para resolucion
create table TSolicitud
( -- lista de atributos
nroSolicitud varchar (10) not null,
fechaSolicitud date not null,
tipo varchar (30) not null, --tipo: evaluacionTesis, evaluacionPlanTesis, Sustentacion
solicitante varchar (6) not null,
-- definicion de la clave foranea
primary key (nroSolicitud),
foreign key (solicitante) references TTesista(CodTesista),
foreign key (tipo) references TTramites(CodTramite)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA INFORME
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para informe
create table TInforme
( -- lista de atributos
nroInforme varchar (10) not null,
FechaEmision date,
observaciones varchar (50),
Evaluador varchar (10),
tipo varchar (50), --tipos: EvaluacionPlanTesis, EvaluacionTesis
-- definicion de la clave foranea
primary key (nroInforme),
foreign key (Evaluador) references TDocentes(CodDocente)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA PROVEIDO
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para proveido
create table TProveido
( -- lista de atributos
codProveido varchar (10) not null,
FechaEmision date,
Nominado1 varchar (10),
Nominado2 varchar (10),
Nominado3 varchar (10),
Nominado4 varchar (10),
Nominado5 varchar (10),
tipo varchar (50), --tipos: EvaluacionPlanTesis, EvaluacionTesis
-- definicion de la clave foranea
primary key (codProveido),
foreign key (Nominado1) references TDocentes(CodDocente),
foreign key (Nominado2) references TDocentes(CodDocente),
foreign key (Nominado3) references TDocentes(CodDocente),
foreign key (Nominado4) references TDocentes(CodDocente),
foreign key (Nominado5) references TDocentes(CodDocente)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA REQUISITOS
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para requisitos
create table TRequisitos
( -- lista de atributos
codRequisito varchar (10) not null,
descripcion varchar (20),
-- definicion de la clave foranea
primary key (codRequisito)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA REQUISITOS DE SOLICITUD (RELACIONA LA TABLA REQUISITOS Y LA TABLA TRAMITES)
--------------------------------------------------------------------------
use bdGestionTesis
go
-- Tabla para requisitos de solicitud
create table TRequisitosSolicitud
( -- lista de atributos
codTramite varchar (30) not null,
codRequisito varchar (10) not null,
-- definicion de la clave foranea
foreign key (codTramite) references TTramites(CodTramite),
foreign key (codRequisito) references TRequisitos(codRequisito),
primary key (codTramite,codRequisito)
)
Go


insert into TRequisitosSolicitud values('T001','blablabla')

select *
	from TRequisitos

select *
	from TRequisitosSolicitud

