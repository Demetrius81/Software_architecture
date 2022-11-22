using Microsoft.EntityFrameworkCore;
using ReportService.Models;

namespace ReportService.Services;

public class BaseContext : DbContext
{
	public DbSet<Report> Reports { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<Provider> Providers { get; set; }
	public DbSet<Product> Products { get; set; }

	public BaseContext(DbContextOptions<BaseContext> options) : base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 2);
    }
}
