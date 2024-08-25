using AS_MSSQL_API.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ArticleModel> Articles { get; set; }
    public DbSet<PriceModel> Prices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Opcjonalna konfiguracja modelu
    }
}
