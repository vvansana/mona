CREATE TABLE [dbo].[ProductImage] (
    [ImageId]    INT            IDENTITY (1, 1) NOT NULL,
    [ProductId]  INT            NOT NULL,
    [ImageUrl]   NVARCHAR (MAX) NULL,
    [CreatedUtc] DATETIME       DEFAULT (getutcdate()) NOT NULL,
    CONSTRAINT [PK_dbo.ProductImage] PRIMARY KEY CLUSTERED ([ImageId] ASC),
    CONSTRAINT [FK_dbo.ProductImage_dbo.Product_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId])
);

