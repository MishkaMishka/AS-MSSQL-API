CREATE PROCEDURE [AddArticle]
@Name nvarchar(100),
@Description nvarchar(500),
@Prices nvarchar(max)
AS
BEGIN
	DECLARE @ArticleId int;
	INSERT INTO Articles (Name, Description) VALUES (@Name, @Description);
	SET @ArticleId = SCOPE_IDENTITY();
	
	INSERT INTO Prices (ArticleId, Price, Date)
	SELECT @ArticleId, Price, Date FROM OPENJSON(@Prices)
	WITH (Price decimal(18, 2), Date datetime);
END
