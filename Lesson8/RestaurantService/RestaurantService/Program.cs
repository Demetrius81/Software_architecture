using RestaurantService.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder
    .ConfigureDbContext()
    .ConfigureServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
