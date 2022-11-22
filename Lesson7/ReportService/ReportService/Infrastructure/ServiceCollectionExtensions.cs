using Microsoft.EntityFrameworkCore;
using ReportService.Models;
using ReportService.Services;
using ReportService.Services.Repository;

namespace ReportService.Infrastructure;

internal static class ServiceCollectionExtensions
{
    public static WebApplicationBuilder ConfigureDbContext(this WebApplicationBuilder builder)
    {
        var connString = builder.Configuration.GetConnectionString("SqLite");

        builder.Services.AddDbContext<BaseContext>(opt => opt.UseSqlite(connString));
        return builder;
    }

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
