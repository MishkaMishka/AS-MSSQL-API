using AS_MSSQL_API.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
	public DbSet<ArticleModel> Articles { get; set; }
	public DbSet<PriceModel> Prices { get; set; }
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
	public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		return base.SaveChangesAsync(cancellationToken);
	}
}