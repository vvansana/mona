CREATE TABLE [dbo].[Product] (
    [ProductId]          INT            IDENTITY (1, 1) NOT NULL,
    [ProductName]        NVARCHAR (50) NULL,
    [ProductDescription] NVARCHAR (MAX) NULL,
    [ProductPrice]       DECIMAL (2)    NULL,
    [CreatedUtc]         DATETIME       DEFAULT (getutcdate()) NOT NULL,
    [Created]            DATETIME       DEFAULT (getdate()) NOT NULL,
    [CategoryId]         INT            NOT NULL,
    [Deleted] BIT NULL DEFAULT 0, 
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ProductId] ASC), 
    CONSTRAINT [FK_Product_Category] FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)
);

