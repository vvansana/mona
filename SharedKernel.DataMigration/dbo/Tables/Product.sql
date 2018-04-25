CREATE TABLE [dbo].[Product] (
    [ProductId]          INT            IDENTITY (1, 1) NOT NULL,
    [ProductName]        NVARCHAR (MAX) NULL,
    [ProductDescription] NVARCHAR (MAX) NULL,
    [ProductPrice]       DECIMAL (2)    NULL,
    [CreatedUtc]         DATETIME       DEFAULT (getutcdate()) NOT NULL,
    [Created]            DATETIME       DEFAULT (getdate()) NOT NULL,
    [CategoryId]         INT            NULL,
    CONSTRAINT [PK_dbo.Product] PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

