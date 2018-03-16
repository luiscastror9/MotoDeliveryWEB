CREATE TABLE [dbo].[pago]
(
	[Codigo_viaje] INT NOT NULL PRIMARY KEY,
	codigo_id varchar(25) NOT NULL,
	id_motero varchar(25) NOT NULL,
	met_Pago varchar(25) NOT NULL,
	estado_pago varchar(25) NOT NULL,
	importe varchar(25) NOT NULL,
)
GO