using Microsoft.EntityFrameworkCore;
using ReportService.Models;

namespace ReportService.Services;

/// <summary>
/// Контекст базы данных
/// </summary>
public class BaseContext : DbContext
{
	public DbSet<Report> Reports { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<Provider> Providers { get; set; }
	public DbSet<Product> Products { get; set; }

	public BaseContext(DbContextOptions<BaseContext> options) : base(options)
	{

	}

    /// <summary>
    /// Переопределенный метод OnModelCreating для указания особенностей преобразования типа decimal в БД
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //Здесь указываем особенности преобразования типа. При использовании модели мы будем иметь протечку абстракции и будем зависеть от модели.
		modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 2);
    }
}
