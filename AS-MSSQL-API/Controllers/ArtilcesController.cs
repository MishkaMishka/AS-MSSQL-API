using AS_MSSQL_API.Models;
using AS_MSSQL_API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ArticlesController : ControllerBase
{
	private readonly IApplicationDbContext _context;

	public ArticlesController(ApplicationDbContext context)
	{
		_context = context;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<ArticleModel>>> GetArticles()
	{
		return await _context.Articles.Include(a => a.Prices).ToListAsync();
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<ArticleModel>> GetArticleById(int id)
	{
		var article = await _context.Articles
			.Include(a => a.Prices)  // Automatically load prices
			.FirstOrDefaultAsync(a => a.Id == id);

		if (article == null)
		{
			return NotFound();
		}

		return Ok(article);
	}


	[HttpPost]
	public async Task<ActionResult<ArticleModel>> CreateArticle(CreateArticleDto createArticleDto)
	{
		// DTO map
		var article = new ArticleModel
		{
			Name = createArticleDto.Name,
			Description = createArticleDto.Description,
			Prices = createArticleDto.Prices?.Select(p => new PriceModel
			{
				Price = p.Price,
				Date = p.Date
			}).ToList()
		};

		// Add article to the context
		_context.Articles.Add(article);
		await _context.SaveChangesAsync();

		return CreatedAtAction(nameof(GetArticleById), new { id = article.Id }, article);
	}
}
