CREATE TABLE [dbo].[Moto]
(
	[idMoto] INT NOT NULL PRIMARY KEY, 
    [modelo] NCHAR(10) NOT NULL, 
    [registro] NCHAR(10) NOT NULL, 
    [patente] NCHAR(10) NOT NULL, 
    [seguro] NCHAR(10) NOT NULL, 
    [fotoMoto] NCHAR(10) NOT NULL
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificador Unica de Moto',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'idMoto'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Modelo de la moto',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'modelo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificador Unico de Moto',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'idMoto'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificador Unico',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'idMoto'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'u',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'idMoto'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificacion Unica de Moto',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'idMoto'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificador',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'idMoto'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Numero de Registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'registro'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Numero de Patente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'patente'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Seguro al Dia',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'seguro'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'2 fotos del Vehiculo',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = N'COLUMN',
    @level2name = N'fotoMoto'