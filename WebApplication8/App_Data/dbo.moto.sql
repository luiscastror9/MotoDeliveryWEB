CREATE TABLE [dbo].[moto] (
    [patente]    INT          IDENTITY (1, 1) NOT NULL,
    [id_usuario] INT          NOT NULL,
    [modelo]     VARCHAR (15) NOT NULL,
    [Registro]   VARCHAR (15) NOT NULL,
    [Seguro]     VARCHAR (15) NOT NULL,
    [Foto]       IMAGE        NULL,
    CONSTRAINT [PK_moto] PRIMARY KEY CLUSTERED ([patente] ASC),
    CONSTRAINT [FK_moto_usuario] FOREIGN KEY ([id_usuario]) REFERENCES [dbo].[usuario] ([id_usuario])
);

