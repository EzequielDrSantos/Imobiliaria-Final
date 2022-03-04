CREATE TABLE [dbo].[Cliente] (
    [IdCliente] INT            NOT NULL,
    [Nome]      NVARCHAR (MAX) NOT NULL,
    [Email]     NVARCHAR (50)  NOT NULL,
    [Telefone]  INT            NOT NULL,
    [CC]        INT            NOT NULL,
    [Distrito]  NVARCHAR (50)  NOT NULL,
    [Cidade]    NVARCHAR (50)  NOT NULL,
    

    PRIMARY KEY CLUSTERED ([IdCliente] ASC)
);

