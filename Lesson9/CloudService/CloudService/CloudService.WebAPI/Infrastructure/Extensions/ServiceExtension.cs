using CloudService.DAL;
using CloudService.DAL.Context;
using CloudService.Interfaces;
using CloudService.Model.ModelsDTO;
using CloudService.WebAPI.Services.Managers;
using CloudService.WebAPI.Services.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudService.WebAPI.Infrastructure.Extensions;

internal static class ServiceExtension
{
    internal static WebApplicationBuilder DbRegister(this WebApplicationBuilder builder)
    {
        string connectionType = builder.Configuration["DataBase"] ?? throw new ArgumentException("Не выбрана база данных для работы");
        string connectionString = builder.Configuration.GetConnectionString(connectionType) ?? throw new ArgumentException("Не задана строка подключения базы данных");

        switch (connectionType)
        {
            case "SqLite":
                builder.Services.AddDbContext<CloudServiceDb>(opt => opt.UseSqlite(connectionString, o => o.MigrationsAssembly("CloudService.DAL.SqLite")));
                break;
            case "SqlServer":
                //Здесь можно добавлять разные базы данных в разных сборках по аналогии с SqLite.
                break;
            default:
                break;
        }

        return builder;
    }

    internal static WebApplicationBuilder ServiceRegister(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<CloudDbInitializer>();
        builder.Services.AddScoped(typeof(IRepositoryAsync<>), typeof(EntityRepositoryAsync<>));
        builder.Services.AddTransient<IRepositoryAsync<CloudDto>, CloudManager>();
        builder.Services.AddTransient<IRepositoryAsync<ServerPoolDto>, ServerPoolManager>();
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder;
    }
    
}
