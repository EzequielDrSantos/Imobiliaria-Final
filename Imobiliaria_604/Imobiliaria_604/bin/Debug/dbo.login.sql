CREATE TABLE [dbo].[login] (
    [Nfunc]    NVARCHAR (10) NOT NULL,
    [Password] NVARCHAR (15) NOT NULL,
    [Cargo]    NVARCHAR (15) NOT NULL,
    CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED ([Nfunc] ASC)
);

