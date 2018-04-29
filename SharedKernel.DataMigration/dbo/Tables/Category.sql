CREATE TABLE [dbo].[Category]
(
	[CategoryId] INT NOT NULL  IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [CreatedUtc] DATETIME NOT NULL DEFAULT (getutcdate()), 
    [Created] DATETIME NOT NULL DEFAULT (getdate()), 
    [Deleted] BIT NULL DEFAULT 0, 
    CONSTRAINT [PK_Category] PRIMARY KEY (CategoryId ASC) 
)
