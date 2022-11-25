using Microsoft.EntityFrameworkCore;
using RestaurantService.Models;

namespace RestaurantService.Services.Db;

public class DbInitializer
{
    private readonly BaseContext _context;
    private readonly ILogger<DbInitializer> _logger;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public DbInitializer(BaseContext context, ILogger<DbInitializer> logger)
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
        if (!await _context.Clients.AnyAsync(cancel).ConfigureAwait(false))
        {
            var clients = Enumerable.Range(1, 10)
                .Select(i => new Client
                {
                    FirstName = $"FirstName-{i}",
                    LastName = $"LastName-{i}",
                    Patronymic = $"Patronymic-{i}",
                    Email = $"FirstName-{i}@mail.ru",
                    PhoneNumber = $"{i}{i + 1}{i + 2}{i + 3}{i + 4}"
                });

            _context.Clients.AddRange(clients);
            await _context.SaveChangesAsync();
        }

        if (!await _context.Tables.AnyAsync(cancel).ConfigureAwait(false))
        {
            var rnd = new Random();

            var tables = Enumerable.Range(1, 10)
                .Select(i => new Table
                {
                    CountPlaces = rnd.Next(2, 10),
                    Vip = i % 2 == 0
                });

            _context.Tables.AddRange(tables);
            await _context.SaveChangesAsync();
        }

        if (!await _context.Orders.AnyAsync(cancel).ConfigureAwait(false))
        {
            var rnd = new Random();

            var clients = _context.Clients.ToArray();
            var tables = _context.Tables.ToArray();

            var orders = Enumerable.Range(1, 5)
                .Select(i => new Order
                {
                    CurrentClient = clients[rnd.Next(0, clients.Length)],
                    CurrentTable= tables[rnd.Next(0, tables.Length)]
                });

            _context.Orders.AddRange(orders);
            _logger.LogInformation(">>> В БД добавлены заказы");
            await _context.SaveChangesAsync();
            _logger.LogInformation(">>> Сохранены изменения в БД");
        }

    }
}
