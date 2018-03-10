CREATE TABLE [dbo].[pago]
(
	[Codigo_viaje] INT NOT NULL PRIMARY KEY,
	Codigo_id varchar(25) NOT NULL,
	Id_motero varchar(25) NOT NULL,
	Met_Pago varchar(25) NOT NULL,
	Estado_pago varchar(25) NOT NULL,
	importe varchar(25) NOT NULL,
)
GO