using CloudService.DAL.Context;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

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


        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}