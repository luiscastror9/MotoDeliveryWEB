CREATE TABLE [dbo].[Usuario]
(
	[Codigo_id] INT NOT NULL PRIMARY KEY,
	Nombre varchar(25) NOT NULL,
	Apellido varchar(25) NOT NULL,
	doc_type varchar(25) NOT NULL,
	num_doc varchar(10) NOT NULL,
	pais text NULL,
	f_nacimiento date NOT NULL,
	calle varchar(10) NOT NULL,
	altura varchar(10) NOT NULL,
	piso varchar(10) NOT NULL, 
	departamento varchar(10) NOT NULL,
	cp varchar(10) NOT NULL,
	moto bit NOT NULL,
)
GO
