using Microsoft.EntityFrameworkCore;
using RestaurantService.Models;

namespace RestaurantService.Services.Db;

/// <summary>
/// Контекст базы данных
/// </summary>
public class BaseContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Table> Tables { get; set; }
    public DbSet<Client> Clients { get; set; }

    public BaseContext(DbContextOptions<BaseContext> contextOptions) : base(contextOptions) { }
}
