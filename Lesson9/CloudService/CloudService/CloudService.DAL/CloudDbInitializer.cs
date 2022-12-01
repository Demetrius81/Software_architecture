using CloudService.DAL.Context;
using CloudService.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CloudService.DAL;
public class CloudDbInitializer
{
    private readonly CloudServiceDb _db;
    private readonly ILogger<CloudDbInitializer> _logger;

    public CloudDbInitializer(CloudServiceDb db, ILogger<CloudDbInitializer> logger)
    {
        _db = db;
        _logger = logger;
    }

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

    public async Task InitializeAsync(bool removeBefore = false, CancellationToken cancel = default)
    {
        if (removeBefore) await RemoveAsync(cancel).ConfigureAwait(false);

        await _db.Database.MigrateAsync(cancel).ConfigureAwait(false);
        _logger.LogInformation(">>> БД создана и находится в актуальном состоянии");

        var rnd = new Random();

        if (!await _db.Clients.AnyAsync(cancel))
        {
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

        if (!await _db.IpAddresses.AnyAsync(cancel))
        {
            var ipAddresses = Enumerable.Range(1, 254)
                .Select(x => new IpAddress
                {
                    Value = x
                });

            await _db.IpAddresses.AddRangeAsync(ipAddresses, cancel);
            _logger.LogInformation(">>> Таблица IP адресов добавлена");
            await _db.SaveChangesAsync(cancel);
        }
        if (!await _db.Servers.AnyAsync(cancel))
        {
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

        if (!await _db.ServerPools.AnyAsync(cancel))
        {
            var serverPools = Enumerable.Range(1, 20)
                .Select(x => new ServerPool
                {
                    ServerId = x
                });

            await _db.ServerPools.AddRangeAsync(serverPools, cancel);
            _logger.LogInformation(">>> Таблица пул серверов добавлена");
            await _db.SaveChangesAsync(cancel);
        }

        if (!await _db.Clouds.AnyAsync(cancel))
        {
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
    }
}
