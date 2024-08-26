using AS_MSSQL_API.Models;
using Microsoft.EntityFrameworkCore;

public interface IApplicationDbContext
{
    DbSet<ArticleModel> Articles { get; set; }
    DbSet<PriceModel> Prices { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}