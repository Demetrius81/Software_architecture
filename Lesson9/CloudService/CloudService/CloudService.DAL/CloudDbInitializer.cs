using CloudService.DAL.Context;
using CloudService.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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

        var clients = Enumerable.Range(1, 10)
            .Select(x => new Client
            { 
                FirstName = $"FirstName-{x}",
                LastName = $"LastName-{x}",
                Patronymic = $"Patronymic-{x}",
                Email = $"Email-{x}",
                PasswordHash = $"PasswordHash{x}"
            });

        var ipAddresses = Enumerable.Range(1, 254)
            .Select(x => new IpAddress
            {
                Value = x
            });

        var servers = Enumerable.Range(1, 20)
            .Select(x => new Server
            {

            })
    }
}
