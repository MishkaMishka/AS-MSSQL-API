CREATE TABLE [dbo].[Prices]
(
	[Id] INT NOT NULL IDENTITY, 
	[ArticleId] INT NULL, 
	[Price] DECIMAL(18, 2) NULL, 
	[Date] DATETIME NULL, 
	PRIMARY KEY ([Id]), 
	CONSTRAINT [FK_Prices_Articles] FOREIGN KEY ([ArticleId]) REFERENCES [Articles]([Id])
)
