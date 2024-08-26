using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AS_MSSQL_API.Models;

public class ArticleRepository : IArticleRepository
{
	private readonly ApplicationDbContext _context;

	public ArticleRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<IEnumerable<ArticleModel>> GetAllArticlesAsync()
	{
		return await _context.Articles.Include(a => a.Prices).ToListAsync();
	}

	public async Task<ArticleModel> GetArticleByIdAsync(int id)
	{
		return await _context.Articles.Include(a => a.Prices)
									  .FirstOrDefaultAsync(a => a.Id == id);
	}

	public async Task<IEnumerable<PriceModel>> GetPricesForArticleAsync(int articleId)
	{
		var article = await _context.Articles.Include(a => a.Prices)
											 .FirstOrDefaultAsync(a => a.Id == articleId);
		return article?.Prices ?? new List<PriceModel>();
	}

	public async Task<PriceModel> AddPriceToArticleAsync(int articleId, PriceModel price)
	{
		var article = await _context.Articles.FirstOrDefaultAsync(a => a.Id == articleId);
		if (article == null)
		{
			return null;
		}

		price.ArticleId = articleId;
		_context.Prices.Add(price);
		await SaveChangesAsync();

		return price;
	}

	public async Task<ArticleModel> AddArticleAsync(ArticleModel article)
	{
		_context.Articles.Add(article);
		await SaveChangesAsync();

		return article;
	}

	public async Task<bool> SaveChangesAsync()
	{
		return await _context.SaveChangesAsync() > 0;
	}
}