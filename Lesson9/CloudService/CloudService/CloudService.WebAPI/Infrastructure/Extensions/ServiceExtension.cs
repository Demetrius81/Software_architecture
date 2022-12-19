using CloudService.DAL;
using CloudService.DAL.Context;
using CloudService.Interfaces;
using CloudService.Model.ModelsDTO;
using CloudService.WebAPI.Services.Managers;
using CloudService.WebAPI.Services.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudService.WebAPI.Infrastructure.Extensions;

/// <summary>
/// Статический класс расширения. Служит для того, чтобы разгрузить метод Main
/// </summary>
internal static class ServiceExtension
{
    /// <summary>
    /// Метод регистрации контекста базы данных в DI контейнере. Реализован через fluent-interface
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    internal static WebApplicationBuilder DbRegister(this WebApplicationBuilder builder)
    {
        //Выбираем базу данных с которой будем работать. Выбор осуществляется корректировкой файла appsettings.json
        string connectionType = builder.Configuration["DataBase"] ?? throw new ArgumentException("Не выбрана база данных для работы");
        //Берем из appsettings.json строку подключения базы данных согласно ранее сделанного выбора
        string connectionString = builder.Configuration.GetConnectionString(connectionType) ?? throw new ArgumentException("Не задана строка подключения базы данных");
        //Здесь при помощи оператора switch мы регистрируем нужный сервис по работе с базой данных.
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

    /// <summary>
    /// Метод регистрации различных сервисов. Реализован через fluent-interface
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
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
