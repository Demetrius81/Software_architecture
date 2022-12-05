using CloudService.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudService.DAL.Context;

/// <summary>
/// Класс контекст базы данных
/// </summary>
public class CloudServiceDb : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Cloud> Clouds { get; set; }
    public DbSet<IpAddress> IpAddresses { get; set; }
    public DbSet<Server> Servers { get; set; }
    public DbSet<ServerPool> ServerPools { get; set; }

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="options">опции для использования контекста, передаем в базовый конструктор</param>
    public CloudServiceDb(DbContextOptions<CloudServiceDb> options) : base(options)
    {

    }
}
