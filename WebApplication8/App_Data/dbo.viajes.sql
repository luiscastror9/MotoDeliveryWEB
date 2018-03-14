CREATE TABLE [dbo].[viajes]
(
	[Codigo_id] INT NOT NULL PRIMARY KEY,
	id_moteromodelo varchar(15) NOT NULL,
	codigo_viaje varchar(15) NOT NULL,
	tarifa varchar(15) NOT NULL,
	calle_in varchar(15) NOT NULL,
	altura_in varchar(15) NOT NULL,
	piso_in varchar(15) NOT NULL,
	dep_in varchar(15) NOT NULL,
	calle_fn varchar(15) NOT NULL,
	altura_fn varchar(15) NOT NULL,
	piso_fn varchar(15) NOT NULL,
	dep_fn varchar(15) NOT NULL,
)
