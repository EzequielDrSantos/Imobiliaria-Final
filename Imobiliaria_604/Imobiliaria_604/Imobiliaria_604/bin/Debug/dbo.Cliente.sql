CREATE TABLE [dbo].[Cliente] (
    [IdCliente]    INT            NOT NULL,
    [Nome]         NVARCHAR (MAX) NOT NULL,
    [DataNasc]     DATE           NOT NULL,
    [Email]        NVARCHAR (50)  NOT NULL,
    [Telefone]     INT            NOT NULL,
    [NIF]          INT            NOT NULL,
    [CC]           INT            NOT NULL,
    [Morada]       NVARCHAR (50)  NOT NULL,
    [Numero]       INT            NOT NULL,
    [Andar]        NVARCHAR (10)  NOT NULL,
    [CodigoPostal] NVARCHAR (50)  NOT NULL,
    [Distrito]     NVARCHAR (50)  NOT NULL,
    [Cidade]       NVARCHAR (50)  NOT NULL,
    [Nfunc]        NVARCHAR (10)  NOT NULL,
    PRIMARY KEY CLUSTERED ([IdCliente] ASC),
    CONSTRAINT [FK_Cliente_ToTable] FOREIGN KEY ([Nfunc]) REFERENCES [dbo].[Login] ([Nfunc])
);

