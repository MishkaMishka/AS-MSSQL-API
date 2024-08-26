CREATE PROCEDURE [dbo].[GetArticleById]
	@ArticleId INT
AS
BEGIN
	SELECT 
		a.Id,
		a.Name,
		a.Description,
		(SELECT Price, Date FROM Prices WHERE ArticleId = a.Id FOR JSON PATH) AS Prices
	FROM Articles a
	WHERE a.Id = @ArticleId
	FOR JSON PATH, WITHOUT_ARRAY_WRAPPER;
END
GO