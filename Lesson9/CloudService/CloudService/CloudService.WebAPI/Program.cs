using CloudService.WebAPI.Infrastructure.Extensions;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder
            .DbRegister()
            .ServiceRegister()
            .Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();

        app.UseRouting();//

        app.MapControllers();

        app.Run();
    }
}