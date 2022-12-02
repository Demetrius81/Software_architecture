using CloudService.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace CloudService.WebAPI.Infrastructure.Extensions;

internal static class ServiceExtension
{
    internal static WebApplicationBuilder DbRegister(this WebApplicationBuilder builder)
    {
        var connectionType = builder.Configuration["DataBase"];
        var connectionString = builder.Configuration.GetConnectionString(connectionType);

        switch (connectionType)
        {
            case "SqLite":
                builder.Services.AddDbContext<CloudServiceDb>(opt => opt.UseSqlite(connectionString, o => o.MigrationsAssembly("CloudService.DAL.SqLite")));
                break;
            case "SqlServer":
                //Здесь можно добавлять разные базы данных в разных сборках по аналогии с SqLite.
                break;
        }
        return builder;
    }

    internal static WebApplicationBuilder ServiceRegister(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder;
    }
    
}
