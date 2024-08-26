using AS_MSSQL_API.Models;
using AS_MSSQL_API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ArticlesController : ControllerBase
{
	private readonly IArticleRepository _articleRepository;

	public ArticlesController(IArticleRepository articleRepository)
	{
		_articleRepository = articleRepository;
	}

	[HttpGet]
	public async Task<IActionResult> GetAllArticles()
	{
		var articles = await _articleRepository.GetAllArticlesAsync();
		return Ok(articles);
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetArticleById(int id)
	{
		var article = await _articleRepository.GetArticleByIdAsync(id);
		if (article == null)
		{
			return NotFound();
		}

		return Ok(article);
	}

	[HttpGet("{articleId}/prices")]
	public async Task<IActionResult> GetPricesForArticle(int articleId)
	{
		var prices = await _articleRepository.GetPricesForArticleAsync(articleId);
		return Ok(prices);
	}

	[HttpPost("{articleId}/prices")]
	public async Task<IActionResult> AddPriceToArticle(int articleId, [FromBody] CreatePriceDto createPriceDto)
	{
		var newPrice = new PriceModel
		{
			Price = createPriceDto.Price,
			Date = createPriceDto.Date
		};

		var addedPrice = await _articleRepository.AddPriceToArticleAsync(articleId, newPrice);
		if (addedPrice == null)
		{
			return NotFound();
		}

		return CreatedAtAction(nameof(GetPricesForArticle), new { articleId = articleId }, addedPrice);
	}

	[HttpPost]
	public async Task<IActionResult> AddArticle([FromBody] CreateArticleDto createArticleDto)
	{
		var newArticle = new ArticleModel
		{
			Name = createArticleDto.Name,
			Description = createArticleDto.Description,
			Prices = new List<PriceModel>() // You can populate this with createArticleDto.Prices if required
		};

		var addedArticle = await _articleRepository.AddArticleAsync(newArticle);

		return CreatedAtAction(nameof(GetArticleById), new { id = addedArticle.Id }, addedArticle);
	}
}
