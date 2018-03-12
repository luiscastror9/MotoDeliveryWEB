CREATE TABLE [dbo].[Direccion]
(
	[idDireccion] INT NOT NULL PRIMARY KEY, 
    [idDireccionInicio] INT NULL, 
    [idDireccionFinal] INT NULL, 
    [Calle] NCHAR(10) NOT NULL, 
    [Altura] NCHAR(10) NOT NULL, 
    [Piso] NCHAR(10) NULL, 
    [Departamento] NCHAR(10) NULL, 
    [Codigo Postal] NCHAR(10) NULL, 
    [Localidad] NCHAR(10) NOT NULL, 
    [Partido] NCHAR(10) NOT NULL, 
    [Provincia] NCHAR(10) NOT NULL
)
