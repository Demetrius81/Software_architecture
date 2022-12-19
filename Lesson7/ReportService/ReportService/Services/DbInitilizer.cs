using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using ReportService.Models;

namespace ReportService.Services;

/// <summary>
/// Класс инициализатор базы данных
/// </summary>
public class DbInitilizer
{
    private readonly BaseContext _context;
    private readonly ILogger<DbInitilizer> _logger;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public DbInitilizer(BaseContext context, ILogger<DbInitilizer> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <summary>
    /// Метод удаляет базу данных
    /// </summary>
    /// <param name="cancel"></param>
    /// <returns></returns>
    public async Task<bool> RemoveAsync(CancellationToken cancel = default)
    {
        if (!await _context.Database.EnsureDeletedAsync(cancel).ConfigureAwait(false))
        {
            _logger.LogInformation(">>> База данных отсутствует");
            return false;
        }

        _logger.LogInformation(">>> База данных удалена");
        return true;
    }

    /// <summary>
    /// Метод инициализирует базу данных
    /// </summary>
    /// <param name="removeBefore"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    public async Task InitializeAsync(bool removeBefore = false, CancellationToken cancel = default)
    {
        if (removeBefore)
            await RemoveAsync(cancel).ConfigureAwait(false);

        await _context.Database.MigrateAsync(cancel).ConfigureAwait(false);
        _logger.LogInformation(">>> База данных создана и находится в актуальном состоянии");

        await AddTestDataAsync(cancel);
    }

    /// <summary>
    /// Метод заполняет базу данных тестовым контентом
    /// </summary>
    /// <param name="cancel"></param>
    /// <returns></returns>
    private async Task AddTestDataAsync(CancellationToken cancel = default)
    {
        if (!await _context.Products.AnyAsync(cancel).ConfigureAwait(false))
        {
            var rnd = new Random();

            var reports = Enumerable.Range(1, 5)
                .Select(i => new Report())
                .ToArray();

            var categories = Enumerable.Range(1, 10)
                .Select(i => new Category
                {
                    Name = $"Category-{i}",
                    ReportCategory = reports[rnd.Next(0, reports.Length)]

                }).ToArray();

            var products = Enumerable.Range(1, 100)
                .Select(i => new Product
                {
                    Name = $"Product-[{i}]",
                    Price = rnd.Next(10000, 50000),
                    Count = rnd.Next(20, 60),
                    CategoryProduct = categories[rnd.Next(0, categories.Length)]
                }).ToHashSet();

            var providers = Enumerable.Range(1, 7)
                .Select(i => new Provider
                {
                    Name = $"Provider-{i}",
                    Rent = rnd.Next(0, 50),
                    ReportProvider = reports[rnd.Next(0, reports.Length)]
                });

            _context.Products.AddRange(products);
            _logger.LogInformation(">>> В БД добавлены продукты");
            _context.Providers.AddRange(providers);
            _logger.LogInformation(">>> В БД добавлены провайдеры");
            _context.Categories.AddRange(categories);
            _logger.LogInformation(">>> В БД добавлены категории");
            _context.Reports.AddRange(reports);
            _logger.LogInformation(">>> В БД добавлены отчеты");
            _context.SaveChanges();
            _logger.LogInformation(">>> Сохранены изменения в БД");
        }

    }
}
