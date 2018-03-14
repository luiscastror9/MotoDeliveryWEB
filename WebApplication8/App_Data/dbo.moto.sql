CREATE TABLE [dbo].[MOTO]
(
	[Codigo_id] INT NOT NULL PRIMARY KEY,
	modelo varchar(15) NOT NULL,
	registro varchar(15) NOT NULL,
	patente varchar(15) NOT NULL ,
	seguro varchar(15) NOT NULL,
	foto image NULL,
)
GO