CREATE TABLE [dbo].[MOTO]
(
	[Codigo_id] INT NOT NULL PRIMARY KEY,
	modelo varchar(15) NOT NULL,
	Registro varchar(15) NOT NULL,
	Patente varchar(15) NOT NULL ,
	Seguro varchar(15) NOT NULL,
	Foto image NULL,
)
GO