CREATE TABLE [dbo].[login] (
    [Nfunc]    INT           NULL,
    [Password] NVARCHAR (15) NOT NULL,
    [Cargo]    NVARCHAR (15) NOT NULL, 
    CONSTRAINT [FK_login_ToTable] FOREIGN KEY ([Nfunc]) REFERENCES [Funcionario]([Nfunc])
);

