--TRIGGERS	

USE SistemaServicios
GO
--- FOR UPDATES-----

CREATE TRIGGER TR_UpdateCategoria
ON tb_Categoria
FOR UPDATE 
AS
SET NOCOUNT ON 
DECLARE @idCategoria INT 
select @idCategoria= idCategoria FROM inserted
UPDATE tb_Categoria SET update_at  = GETDATE() WHERE  idCategoria=@idCategoria
UPDATE tb_Categoria SET update_by= SYSTEM_USER WHERE  idCategoria=@idCategoria
GO


CREATE TRIGGER TR_UpdateDistrito
ON tb_Distrito
FOR UPDATE 
AS
SET NOCOUNT ON 
DECLARE @idDistrito INT 
select @idDistrito= idDistrito FROM inserted
UPDATE tb_Distrito SET update_at  = GETDATE() WHERE  idDistrito=@idDistrito
UPDATE tb_Distrito SET update_by= SYSTEM_USER WHERE  idDistrito=@idDistrito
GO


CREATE TRIGGER TR_UpdatePost
ON tb_Post
FOR UPDATE 
AS
SET NOCOUNT ON 
DECLARE @idPost INT 
select @idPost= idPost FROM inserted
UPDATE tb_Post SET update_at  = GETDATE() WHERE  idPost=@idPost
UPDATE tb_Post SET update_by= SYSTEM_USER WHERE  idPost=@idPost
GO



CREATE TRIGGER TR_UpdateReplica
ON tb_Replica
FOR UPDATE 
AS
SET NOCOUNT ON 
DECLARE @idReplica INT 
select @idReplica= idReplica FROM inserted
UPDATE tb_Replica SET update_at  = GETDATE() WHERE  idReplica=@idReplica
UPDATE tb_Replica SET update_by= SYSTEM_USER WHERE  idReplica=@idReplica
GO


CREATE TRIGGER TR_UpdateServicio
ON tb_Servicio
FOR UPDATE 
AS
SET NOCOUNT ON 
DECLARE @idServicio INT 
select @idServicio= idServicio FROM inserted
UPDATE tb_Servicio SET update_at  = GETDATE() WHERE  idServicio=@idServicio
UPDATE tb_Servicio SET update_by= SYSTEM_USER WHERE  idServicio=@idServicio
GO



CREATE TRIGGER TR_UpdateSubCategoria
ON tb_SubCategoria
FOR UPDATE 
AS
SET NOCOUNT ON 
DECLARE @idSubCategoria INT 
select @idSubCategoria= idSubCategoria FROM inserted
UPDATE tb_SubCategoria SET update_at  = GETDATE() WHERE  idSubCategoria=@idSubCategoria
UPDATE tb_SubCategoria SET update_by= SYSTEM_USER WHERE  idSubCategoria=@idSubCategoria
GO


CREATE TRIGGER TR_UpdateTestimonio
ON tb_Testimonio
FOR UPDATE 
AS
SET NOCOUNT ON 
DECLARE @idTestimonio INT 
select @idTestimonio= idTestimonio FROM inserted
UPDATE tb_Testimonio SET update_at  = GETDATE() WHERE  idTestimonio=@idTestimonio
UPDATE tb_Testimonio SET update_by= SYSTEM_USER WHERE  idTestimonio=@idTestimonio
GO



CREATE TRIGGER TR_UpdateTipoCuenta
ON tb_TipoCuenta
FOR UPDATE 
AS
SET NOCOUNT ON 
DECLARE @idTipoCuenta INT 
select @idTipoCuenta= idTipoCuenta FROM inserted
UPDATE tb_TipoCuenta SET update_at  = GETDATE() WHERE  idTipoCuenta=@idTipoCuenta
UPDATE tb_TipoCuenta SET update_by= SYSTEM_USER WHERE  idTipoCuenta=@idTipoCuenta
GO

CREATE TRIGGER TR_UpdateUsuario
ON tb_Usuario
FOR UPDATE 
AS
SET NOCOUNT ON 
DECLARE @idUsuario INT 
select @idUsuario= idUsuario FROM inserted
UPDATE tb_Usuario SET update_at  = GETDATE() WHERE  idUsuario=@idUsuario
UPDATE tb_Usuario SET update_by= SYSTEM_USER WHERE  idUsuario=@idUsuario
GO


-------FOR INSERT----------



GO
CREATE TRIGGER TR_InsertCategoria
ON tb_Categoria
AFTER INSERT 
AS
SET NOCOUNT ON 
DECLARE @idCategoria INT 
select @idCategoria= idCategoria FROM inserted
UPDATE tb_Categoria SET create_at  = GETDATE() WHERE  idCategoria=@idCategoria
UPDATE tb_Categoria SET create_by= SYSTEM_USER WHERE  idCategoria=@idCategoria
GO

CREATE TRIGGER TR_InsertDistrito
ON tb_Distrito
AFTER INSERT 
AS
SET NOCOUNT ON 
DECLARE @idDistrito INT 
select @idDistrito= idDistrito FROM inserted
UPDATE tb_Distrito SET create_at  = GETDATE() WHERE  idDistrito=@idDistrito
UPDATE tb_Distrito SET create_by= SYSTEM_USER WHERE  idDistrito=@idDistrito
GO

CREATE TRIGGER TR_InsertPost
ON tb_Post
AFTER INSERT 
AS
SET NOCOUNT ON 
DECLARE @idPost INT 
select @idPost= idPost FROM inserted
UPDATE tb_Post SET create_at  = GETDATE() WHERE  idPost=@idPost
UPDATE tb_Post SET create_by= SYSTEM_USER WHERE  idPost=@idPost
GO

CREATE TRIGGER TR_InsertReplica
ON tb_Replica
AFTER INSERT 
AS
SET NOCOUNT ON 
DECLARE @idReplica INT 
select @idReplica= idReplica FROM inserted
UPDATE tb_Replica SET create_at  = GETDATE() WHERE  idReplica=@idReplica
UPDATE tb_Replica SET create_by= SYSTEM_USER WHERE  idReplica=@idReplica
GO

CREATE TRIGGER TR_InsertServicio
ON tb_Servicio
AFTER INSERT 
AS
SET NOCOUNT ON 
DECLARE @idServicio INT 
select @idServicio= idServicio FROM inserted
UPDATE tb_Servicio SET create_at  = GETDATE() WHERE  idServicio=@idServicio
UPDATE tb_Servicio SET create_by= SYSTEM_USER WHERE  idServicio=@idServicio
GO

CREATE TRIGGER TR_InsertSubCategoria
ON tb_SubCategoria
AFTER INSERT 
AS
SET NOCOUNT ON 
DECLARE @idSubCategoria INT 
select @idSubCategoria= idSubCategoria FROM inserted
UPDATE tb_SubCategoria SET create_at  = GETDATE() WHERE  idSubCategoria=@idSubCategoria
UPDATE tb_SubCategoria SET create_by= SYSTEM_USER WHERE  idSubCategoria=@idSubCategoria
GO

CREATE TRIGGER TR_InsertTestimonio
ON tb_Testimonio
AFTER INSERT 
AS
SET NOCOUNT ON 
DECLARE @idTestimonio INT 
select @idTestimonio= idTestimonio FROM inserted
UPDATE tb_Testimonio SET create_at  = GETDATE() WHERE  idTestimonio=@idTestimonio
UPDATE tb_Testimonio SET create_by= SYSTEM_USER WHERE  idTestimonio=@idTestimonio
GO

CREATE TRIGGER TR_InsertTipoCuenta
ON tb_TipoCuenta
AFTER INSERT 
AS
SET NOCOUNT ON 
DECLARE @idTipoCuenta INT 
select @idTipoCuenta= idTipoCuenta FROM inserted
UPDATE tb_TipoCuenta SET create_at  = GETDATE() WHERE  idTipoCuenta=@idTipoCuenta
UPDATE tb_TipoCuenta SET create_by= SYSTEM_USER WHERE  idTipoCuenta=@idTipoCuenta
GO

CREATE TRIGGER TR_InsertUsuario
ON tb_Usuario
AFTER INSERT 
AS
SET NOCOUNT ON 
DECLARE @idUsuario INT 
select @idUsuario= idUsuario FROM inserted
UPDATE tb_Usuario SET create_at  = GETDATE() WHERE  idUsuario=@idUsuario
UPDATE tb_Usuario SET create_by= SYSTEM_USER WHERE  idUsuario=@idUsuario


