CREATE PROCEDURE [dbo].[GetArticles]
AS
BEGIN
	SELECT 
		a.Id,
		a.Name,
		a.Description,
		(SELECT Price, Date FROM Prices WHERE ArticleId = a.Id FOR JSON PATH) AS Prices
	FROM Articles a
	FOR JSON PATH;
END