CREATE TABLE [dbo].[Pagos]
(
	[idCodigoViaje] INT NOT NULL PRIMARY KEY, 
    [metodoDePago] NCHAR(10) NULL, 
    [estadoDePago] NCHAR(10) NULL, 
    [importe] MONEY NULL, 
    [numeroFactura] NCHAR(10) NULL
)
