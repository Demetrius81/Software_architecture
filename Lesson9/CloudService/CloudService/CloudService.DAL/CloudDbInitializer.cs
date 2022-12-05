using CloudService.DAL.Context;
using CloudService.Model;
using CloudService.Model.Models;
using CloudService.Model.ModelsDTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CloudService.DAL;

/// <summary>
/// Класс инициализатор базы данных
/// </summary>
public class CloudDbInitializer
{
    private readonly CloudServiceDb _db;
    private readonly ILogger<CloudDbInitializer> _logger;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="db">забилаем из контейнера сервисов контекст базы данных</param>
    /// <param name="logger">забилаем из контейнера сервисов логер</param>
    public CloudDbInitializer(CloudServiceDb db, ILogger<CloudDbInitializer> logger)
    {
        _db = db;
        _logger = logger;
    }

    /// <summary>
    /// Метод удаления базы данных в отладочных целях
    /// </summary>
    /// <param name="cancel"></param>
    /// <returns></returns>
    public async Task<bool> RemoveAsync(CancellationToken cancel = default)
    {
        if (!await _db.Database.EnsureDeletedAsync(cancel).ConfigureAwait(false))
        {
            _logger.LogInformation(">>> БД удалена");
            return true;
        }

        _logger.LogInformation(">>> БД отсутствует");
        return false;
    }

    /// <summary>
    /// Метод инициализации базы данных
    /// </summary>
    /// <param name="removeBefore">передаем значение true, если базу данных нужно удалить. По умолчанию - false</param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    public async Task InitializeAsync(bool removeBefore = false, CancellationToken cancel = default)
    {
        if (removeBefore) await RemoveAsync(cancel).ConfigureAwait(false);

        await _db.Database.MigrateAsync(cancel).ConfigureAwait(false);
        _logger.LogInformation(">>> БД создана и находится в актуальном состоянии");

        var rnd = new Random();

        if (!await _db.Clients.AnyAsync(cancel))
        {
            _logger.LogInformation(">>> Таблица клиентов отсутствует, добавляю...");
            var clients = Enumerable.Range(1, 10)
                .Select(x => new Client
                {
                    FirstName = $"FirstName-{x}",
                    LastName = $"LastName-{x}",
                    Patronymic = $"Patronymic-{x}",
                    Email = $"Email-{x}",
                    PasswordHash = $"PasswordHash{x}"
                });

            await _db.Clients.AddRangeAsync(clients, cancel);
            _logger.LogInformation(">>> Таблица клиентов добавлена");
            await _db.SaveChangesAsync(cancel);
        }
        else
        {
            _logger.LogInformation(">>> Таблица клиентов уже находится в БД");
        }

        if (!await _db.IpAddresses.AnyAsync(cancel))
        {
            _logger.LogInformation(">>> Таблица IP адресов отсутствует, добавляю...");
            var ipAddresses = Enumerable.Range(1, 254)
                .Select(x => new IpAddress
                {
                    Value = x
                });

            await _db.IpAddresses.AddRangeAsync(ipAddresses, cancel);
            _logger.LogInformation(">>> Таблица IP адресов добавлена");
            await _db.SaveChangesAsync(cancel);
        }
        else
        {
            _logger.LogInformation(">>> Таблица IP адресов уже находится в БД");
        }

        if (!await _db.Servers.AnyAsync(cancel))
        {
            _logger.LogInformation(">>> Таблица серверов отсутствует, добавляю...");
            var servers = Enumerable.Range(1, 20)
                .Select(x => new Server
                {
                    Ram = rnd.Next(16, 128),
                    Rom = rnd.Next(1, 10),
                    Cpu = rnd.Next(4, 28),
                    Os = OperationSystem.Debian
                });

            await _db.Servers.AddRangeAsync(servers, cancel);
            _logger.LogInformation(">>> Таблица серверов добавлена");
            await _db.SaveChangesAsync(cancel);
        }
        else
        {
            _logger.LogInformation(">>> Таблица серверов уже находится в БД");
        }

        if (!await _db.ServerPools.AnyAsync(cancel))
        {
            _logger.LogInformation(">>> Таблица пул серверов отсутствует, добавляю...");
            var serverPools = Enumerable.Range(1, 20)
                .Select(x => new ServerPool
                {
                    ServerId = x
                });

            await _db.ServerPools.AddRangeAsync(serverPools, cancel);
            _logger.LogInformation(">>> Таблица пул серверов добавлена");
            await _db.SaveChangesAsync(cancel);
        }
        else
        {
            _logger.LogInformation(">>> Таблица пул серверов уже находится в БД");
        }

        if (!await _db.Clouds.AnyAsync(cancel))
        {
            _logger.LogInformation(">>> Таблица облако отсутствует, добавляю...");
            var clouds = Enumerable.Range(1, 5)
                .Select(x => new Cloud
                {
                    ClientId = rnd.Next(1, 10),
                    IpAddressId = rnd.Next(1, 254),
                    ServerPoolId = rnd.Next(1, 20),
                    Ram = rnd.Next(16, 128),
                    Rom = rnd.Next(1, 10),
                    Cpu = rnd.Next(4, 28),
                    Os = OperationSystem.Debian
                });

            await _db.Clouds.AddRangeAsync(clouds, cancel);
            _logger.LogInformation(">>> Таблица облако добавлена");
            await _db.SaveChangesAsync(cancel);
        }
        else
        {
            _logger.LogInformation(">>> Таблица облако уже находится в БД");
        }
    }
}
