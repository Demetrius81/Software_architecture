using CloudService.DAL;
using CloudService.WebAPI.Infrastructure.Extensions;


internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //Активация методов расширения. Красиво и лаконично.
        var app = builder
            .DbRegister()
            .ServiceRegister()
            .Build();

        //Инициализация базы данных
        using (var scope = app.Services.CreateScope())
        {
            var initializer = scope.ServiceProvider.GetRequiredService<CloudDbInitializer>();
            await initializer.InitializeAsync();
        }

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