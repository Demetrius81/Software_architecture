using ReportService.Infrastructure;
using ReportService.Services;

namespace ReportService;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        _ = builder
            .ConfigureDbContext()
            .ConfigureServices();

        var app = builder.Build();

        using(var scope = app.Services.CreateScope())
        {
            var initilizer = scope.ServiceProvider.GetRequiredService<DbInitilizer>();
            await initilizer.InitializeAsync();
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