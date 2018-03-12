CREATE TABLE [dbo].[Viajes]
(
	[idViajePide] INT NOT NULL, 
    [idViajeRealiza] INT NOT NULL, 
    [tarifa] MONEY NOT NULL, 
    [idDireccionInicio] INT NOT NULL, 
    [idDireccionFinal] INT NOT NULL, 
    [fechaViaje] DATE NOT NULL, 
    [horaViaje] TIME NOT NULL, 
    [idCodigoViaje] INT NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([idCodigoViaje])
)
