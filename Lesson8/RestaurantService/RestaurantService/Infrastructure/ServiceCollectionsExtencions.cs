using Microsoft.EntityFrameworkCore;
using RestaurantService.Models;
using RestaurantService.Services.Db;
using RestaurantService.Services.Managers;
using RestaurantService.Services.Repository;

namespace RestaurantService.Infrastructure;

/// <summary>Класс расширения для регистрации сервисов</summary>
public static class ServiceCollectionsExtensions
{
    /// <summary>
    /// Метод конфигурации и подключения сервиса работы с базой данных
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static WebApplicationBuilder ConfigureDbContext(this WebApplicationBuilder builder)
    {
        var connString = builder.Configuration.GetConnectionString("SqLite");

        builder.Services.AddDbContext<BaseContext>(opt => opt.UseSqlite(connString));
        return builder;
    }

    /// <summary>
    /// Метод конфигурации и подключения сервисов
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IRepositoryAsync<Order>, OrderRepository>();
        builder.Services.AddTransient<IRepositoryAsync<Client>, ClientRepository>();
        builder.Services.AddTransient<IRepositoryAsync<Table>, TableRepository>();
        builder.Services.AddTransient<IOrderManager, OrderManager>();
        builder.Services.AddScoped<DbInitializer>();
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        return builder;
    }
}
