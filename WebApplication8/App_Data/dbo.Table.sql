CREATE TABLE [dbo].[Usuario]
(
	[idUsuario] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [contraseña] NCHAR(10) NOT NULL, 
    [nombres] NVARCHAR(50) NOT NULL, 
    [apellidos] NVARCHAR(50) NOT NULL, 
    [documentoTipo] NCHAR(10) NOT NULL, 
    [numeroDocumento] NVARCHAR(50) NOT NULL, 
    [nacionalidad] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(50) NOT NULL, 
    [idMoto] INT NULL, 
    [idViajeRealiza] INT NULL, 
    [idPagos] INT NULL , 
    [idViajePide] INT NULL, 
    [idDireccion] NCHAR(10) NULL 
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificacion Unica de Usuario',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'idUsuario'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Contraseña de Acceso',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'contraseña'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombres del Usuario',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'nombres'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Apellidos del Usuario',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'apellidos'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Documento del Usuario',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'documentoTipo'
GO

EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Pais de Origen',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'nacionalidad'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'E-mail de registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'email'
GO

EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Relacion con Moto',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'idMoto'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Relacion con Viajes',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'idViajePide'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Relacion con Pagos',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'idPagos'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Relacion con Viaje Pedido',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'idViajePide'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Relacion con Viaje Realizado',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = 'idViajePide'