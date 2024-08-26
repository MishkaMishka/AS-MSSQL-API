using AS_MSSQL_API.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
	public DbSet<ArticleModel> Articles { get; set; }
	public DbSet<PriceModel> Prices { get; set; }
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}