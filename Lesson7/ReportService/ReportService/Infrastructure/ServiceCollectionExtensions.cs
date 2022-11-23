using Microsoft.EntityFrameworkCore;
using ReportService.Models;
using ReportService.Services;
using ReportService.Services.Repository;

namespace ReportService.Infrastructure;

/// <summary>
/// Класс расширения для подключения сервисов. Создан для того, чтобы освободить метод Main и вынести из него регистрацию сервисов.
/// </summary>
internal static class ServiceCollectionExtensions
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
        builder.Services.AddScoped<IRepositoryAsync<Report>, ReportRepositoryAsync>();
        builder.Services.AddTransient<DbInitilizer>();
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        return builder;
    }
}
