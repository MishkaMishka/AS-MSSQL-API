using System.Collections.Generic;
using System.Threading.Tasks;
using AS_MSSQL_API.Models;

public interface IArticleRepository
{
	Task<IEnumerable<ArticleModel>> GetAllArticlesAsync();
	Task<ArticleModel> GetArticleByIdAsync(int id);
	Task<IEnumerable<PriceModel>> GetPricesForArticleAsync(int articleId);
	Task<PriceModel> AddPriceToArticleAsync(int articleId, PriceModel price);
	Task<ArticleModel> AddArticleAsync(ArticleModel article);
	Task<bool> SaveChangesAsync();
}
	