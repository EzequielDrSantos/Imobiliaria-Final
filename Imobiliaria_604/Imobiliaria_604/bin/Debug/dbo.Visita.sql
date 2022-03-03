CREATE TABLE [dbo].[Visita] (
    [IdVisita] INT           IDENTITY (1, 1) NOT NULL,
    [NumeroC]  INT           NOT NULL,
    [NomeC]    NVARCHAR (50) NOT NULL,
    [NomeCt]   NVARCHAR (50) NOT NULL,
    [Telefone] INT           NOT NULL,
    [NumeroI]  INT           NOT NULL,
    [Hora]     NVARCHAR (5)  NOT NULL,
    [Data]     DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([IdVisita] ASC)
);

