CREATE TABLE [dbo].[Funcionario] (
    [Nfunc]    INT           NOT NULL,
    [Nome ]    NVARCHAR (50) NOT NULL,
    [Email]    NVARCHAR (50) NOT NULL,
    [Telefone] INT           NOT NULL,
	[CC]      INT           NOT NULL,
    [NIF]      INT           NOT NULL,
    [NIB]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Nfunc] ASC)
);

