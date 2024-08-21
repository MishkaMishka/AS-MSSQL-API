CREATE TABLE [dbo].[Prices]
(
	[Id] INT NOT NULL , 
	[ArticleID] INT NULL, 
	[Price] DECIMAL NULL, 
	[Date] DATE NULL, 
	PRIMARY KEY ([Id]), 
	CONSTRAINT [FK_Prices_Articles] FOREIGN KEY ([ArticleID]) REFERENCES [Articles]([Id])
)
