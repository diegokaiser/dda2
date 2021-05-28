create database SistemaServicios
GO
use SistemaServicios
GO
--TABLA DISTRITO------
----------------------

CREATE TABLE tb_Distrito(
idDistrito Tinyint IDENTITY(1,1) NOT NULL,
nombreDistrito varchar(30) NOT NULL,
create_at datetime  NULL,
create_by varchar (40) NULL,
update_at datetime  NULL,
update_by varchar (40) NULL,
)
GO
ALTER TABLE tb_Distrito
ADD CONSTRAINT pk_idDistrito PRIMARY KEY (idDistrito)
GO
ALTER TABLE tb_Distrito
ADD CONSTRAINT df_create_at_Distrito DEFAULT GETDATE() FOR create_at
GO
ALTER TABLE tb_Distrito
ADD CONSTRAINT df_create_by_Distrito DEFAULT SYSTEM_USER FOR create_by
GO

--TABLA TIPOCUENTA------
----------------------
CREATE TABLE tb_TipoCuenta(
idTipoCuenta  int IDENTITY(1,1) NOT NULL,
nombre varchar (30) NOT NULL,
precio money  NULL,
create_at datetime  NULL ,
create_by varchar (40)  NULL,
update_at datetime  NULL,
update_by varchar (40) NULL,
)
GO
ALTER TABLE tb_TipoCuenta
ADD CONSTRAINT idTipoCuenta PRIMARY KEY (idTipoCuenta)
GO
ALTER TABLE tb_TipoCuenta
ADD CONSTRAINT df_create_at_TipoCuenta DEFAULT GETDATE() FOR create_at
GO
ALTER TABLE tb_TipoCuenta
ADD CONSTRAINT df_create_by_TipoCuenta DEFAULT SYSTEM_USER FOR create_by
GO


--TABLA USUARIO------
----------------------

CREATE TABLE tb_Usuario(
idUsuario int IDENTITY(1,1) NOT NULL,
tipoUsuario Tinyint  NULL,
estadoUsuario bit  NULL,
nombreUsuario varchar(30) NOT NULL,
apellidoUsuario varchar(30) NOT NULL,
contrasenaUsuario Varchar(30) NOT NULL,
idDistrito Tinyint  NULL,
emailUsuario varchar(90) NOT NULL,
cellUsuario varchar(20)  NULL,
rankUsuario int  NULL,
wspUsuario varchar(20)  NULL,
ocupacionUsuario varchar(80)  NULL,
idTipoCuenta int NULL,
tiempoCuenta date NUll,
create_at datetime  NULL ,
create_by varchar (40)  NULL,
update_at datetime  NULL,
update_by varchar (40) NULL,
)
GO
ALTER TABLE tb_Usuario
ADD CONSTRAINT pk_idUsuario PRIMARY KEY (idUsuario)
GO
ALTER TABLE tb_Usuario
ADD CONSTRAINT fk_tb_Usuario_tb_Distrito FOREIGN KEY (idDistrito)
REFERENCES tb_Distrito  (idDistrito)
GO
ALTER TABLE tb_Usuario
ADD CONSTRAINT fk_tb_Usuario_tb_TipoCuenta FOREIGN KEY (idTipoCuenta)
REFERENCES tb_TipoCuenta  (idTipoCuenta)
GO
ALTER TABLE tb_Usuario
ADD CONSTRAINT df_create_at_Usuario DEFAULT GETDATE() FOR create_at
GO
ALTER TABLE tb_Usuario
ADD CONSTRAINT df_create_by_Usuario  DEFAULT SYSTEM_USER FOR create_by
GO
ALTER TABLE tb_Usuario
ADD CONSTRAINT uq_emailUsuario UNIQUE (emailUsuario)
GO
ALTER TABLE tb_Usuario
ADD CONSTRAINT df_estadoUsuario DEFAULT 1 FOR estadoUsuario
GO
ALTER TABLE tb_Usuario
ADD CONSTRAINT df_tipoUsuario DEFAULT 1 FOR tipoUsuario
GO



--TABLA CATEGORIA------
----------------------

CREATE TABLE tb_Categoria(
idCategoria int IDENTITY(1,1) NOT NULL,
nombreCategoria varchar(100) NOT NULL,
create_at datetime  NULL ,
create_by varchar (40)  NULL,
update_at datetime  NULL,
update_by varchar (40) NULL,
)

GO
ALTER TABLE tb_Categoria
ADD CONSTRAINT pk_idCategoria PRIMARY KEY (idCategoria)
GO
ALTER TABLE tb_Categoria
ADD CONSTRAINT df_create_at_Categoria DEFAULT GETDATE() FOR create_at
GO
ALTER TABLE tb_Categoria
ADD CONSTRAINT df_create_by_Categoria DEFAULT SYSTEM_USER FOR create_by
GO


--TABLA SUBCATEGORIA------
----------------------

CREATE TABLE tb_SubCategoria(
idSubCategoria int IDENTITY(1,1) NOT NULL,
idCategoria int NOT NULL,
nombreSubCategoria varchar(100) NOT NULL,
create_at datetime  NULL ,
create_by varchar (40)  NULL,
update_at datetime  NULL,
update_by varchar (40) NULL,
)
GO

ALTER TABLE tb_SubCategoria
ADD CONSTRAINT pk_idSubCategoria PRIMARY KEY (idSubCategoria)
GO
ALTER TABLE tb_SubCategoria
ADD CONSTRAINT fk_tb_SubCategoria_tb_Categoria FOREIGN KEY (idCategoria)
REFERENCES tb_Categoria (idCategoria)
GO
ALTER TABLE tb_SubCategoria
ADD CONSTRAINT df_create_at_SubCategoria DEFAULT GETDATE() FOR create_at
GO
ALTER TABLE tb_SubCategoria
ADD CONSTRAINT df_create_by_SubCategoria DEFAULT SYSTEM_USER FOR create_by
GO

--TABLA POST------
----------------------

CREATE TABLE tb_Post(
idPost  int IDENTITY(1,1) NOT NULL,
idUsuario int NOT NULL,
idSubcategoria int NOT NULL,
idDistrito Tinyint  NULL,
tituloPost varchar (100) NOT NULL,
descripcionPost varchar(200) NULL,
precioPost int NULL,
imagenPost varchar(200) NULL,
valoracionPost int NULL,
estadoPost bit  NULL,
create_at datetime  NULL ,
create_by varchar (40)  NULL,
update_at datetime  NULL,
update_by varchar (40) NULL,
)
GO

ALTER TABLE tb_Post
ADD CONSTRAINT pk_idPost PRIMARY KEY (idPost)
GO
ALTER TABLE tb_Post
ADD CONSTRAINT fk_tb_Post_tb_Usuario FOREIGN KEY (idUsuario)
REFERENCES tb_Usuario (idUsuario)
GO
ALTER TABLE tb_Post
ADD CONSTRAINT fk_tb_Post_tb_SubCategoria FOREIGN KEY (idSubCategoria)
REFERENCES tb_SubCategoria (idSubCategoria)
GO
ALTER TABLE tb_Post
ADD CONSTRAINT fk_tb_Post_tb_Distrito FOREIGN KEY (idDistrito)
REFERENCES tb_Distrito (idDistrito)
GO
ALTER TABLE tb_Post
ADD CONSTRAINT df_create_at_Post DEFAULT GETDATE() FOR create_at
GO
ALTER TABLE tb_Post
ADD CONSTRAINT df_create_by_Post DEFAULT SYSTEM_USER FOR create_by
GO
ALTER TABLE tb_Post
ADD CONSTRAINT df_estadoPost DEFAULT 1 FOR estadoPost
GO


--TABLA SERVICIO------
----------------------

CREATE TABLE tb_Servicio(
idServicio int IDENTITY(1,1) NOT NULL,
idPost  int  NOT NULL,
idUsuario int  NOT NULL,
estadoServicio bit  NULL,
create_at datetime  NULL ,
create_by varchar (40)  NULL,
update_at datetime  NULL,
update_by varchar (40) NULL,
)

ALTER TABLE tb_Servicio
ADD CONSTRAINT idServicio PRIMARY KEY (idServicio)
GO
ALTER TABLE tb_Servicio
ADD CONSTRAINT fk_tb_Servicio_tb_Post FOREIGN KEY (idPost)
REFERENCES tb_Post (idPost)
GO
ALTER TABLE tb_Servicio
ADD CONSTRAINT fk_tb_Servicio_tb_Usuario FOREIGN KEY (idUsuario)
REFERENCES tb_Usuario (idUsuario)
GO
ALTER TABLE tb_Servicio
ADD CONSTRAINT df_create_at_servicio DEFAULT GETDATE() FOR create_at
GO
ALTER TABLE tb_Servicio
ADD CONSTRAINT df_create_by_servicio DEFAULT SYSTEM_USER FOR create_by
GO
ALTER TABLE tb_Servicio
ADD CONSTRAINT df_estadoServicio DEFAULT 1 FOR estadoServicio
GO


--TABLA Testimonio------
----------------------

CREATE TABLE tb_Testimonio(
idTestimonio  int IDENTITY(1,1) NOT NULL,
idUsuario int NOT NULL,
idPost int NOT NULL,
tituloTestimonio varchar(50)NOT NULL,
descripcionTestimonio varchar (200) NULL,
estadoTestimonio bit  NULL,
create_at datetime  NULL ,
create_by varchar (40)  NULL,
update_at datetime  NULL,
update_by varchar (40) NULL,
)
GO

ALTER TABLE tb_Testimonio
ADD CONSTRAINT idTestimonio PRIMARY KEY (idTestimonio)
GO
ALTER TABLE tb_Testimonio
ADD CONSTRAINT fk_tb_Testimonio_tb_Usuario FOREIGN KEY (idUsuario)
REFERENCES tb_Usuario (idUsuario)
GO
ALTER TABLE tb_Testimonio
ADD CONSTRAINT fk_tb_Testimonio_tb_Post FOREIGN KEY (idPost)
REFERENCES tb_Post (idPost)
GO
ALTER TABLE tb_Testimonio
ADD CONSTRAINT df_create_at_testimonio DEFAULT GETDATE() FOR create_at
GO
ALTER TABLE tb_Testimonio
ADD CONSTRAINT df_create_by_testimonio DEFAULT SYSTEM_USER FOR create_by
GO
ALTER TABLE tb_Testimonio
ADD CONSTRAINT df_estadoTestimonio DEFAULT 1 FOR estadoTestimonio
GO

--TABLA REPLICA------
----------------------


CREATE TABLE tb_Replica(
idReplica  int IDENTITY(1,1) NOT NULL,
idUsuario int NOT NULL,
idTestimonio int NOT NULL,
tituloReplica varchar(50)NOT NULL,
descripcionReplica varchar (200) NULL,
estadoReplica bit  NULL,
create_at datetime  NULL ,
create_by varchar (40)  NULL,
update_at datetime  NULL,
update_by varchar (40) NULL,
)
GO

ALTER TABLE tb_Replica
ADD CONSTRAINT idReplica PRIMARY KEY (idReplica)
GO
ALTER TABLE tb_Replica
ADD CONSTRAINT fk_tb_Replica_tb_Usuario FOREIGN KEY (idUsuario)
REFERENCES tb_Usuario (idUsuario)
GO
ALTER TABLE tb_Replica
ADD CONSTRAINT fk_tb_Replica_tb_Testimonio FOREIGN KEY (idTestimonio)
REFERENCES tb_Testimonio (idTestimonio)
GO
ALTER TABLE tb_Replica
ADD CONSTRAINT df_create_at_replica DEFAULT GETDATE() FOR create_at
GO
ALTER TABLE tb_Replica
ADD CONSTRAINT df_create_by_replica DEFAULT SYSTEM_USER FOR create_by
GO
ALTER TABLE tb_Replica
ADD CONSTRAINT df_estadoReplica DEFAULT 1 FOR estadoReplica
GO

