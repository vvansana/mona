CREATE TABLE [dbo].[ProductImage] (
    [ImageId]    INT            IDENTITY (1, 1) NOT NULL,
    [ProductId]  INT            NOT NULL,
    [ImageUrl]   NVARCHAR (MAX) NULL,
    [CreatedUtc] DATETIME       DEFAULT (getutcdate()) NOT NULL,
    [Deleted] BIT NULL DEFAULT 0, 
    CONSTRAINT [PK_ProductImage] PRIMARY KEY CLUSTERED ([ImageId] ASC),
    CONSTRAINT [FK_ProductImage_Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId])
);

