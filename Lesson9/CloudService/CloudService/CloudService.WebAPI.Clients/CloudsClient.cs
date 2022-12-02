using CloudService.Interfaces;
using CloudService.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CloudService.WebAPI.Clients;
public class CloudsClient : IRepositoryAsync<Cloud>
{
    private readonly HttpClient _client;
    private readonly ILogger<CloudsClient> _logger;

    public CloudsClient(HttpClient client, ILogger<CloudsClient> logger)
	{
        this._client = client;
        this._logger = logger;
    }

    public Task<int> AddAsync(Cloud item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public async Task<int> CountAsync(CancellationToken cancel = default)
    {
        var result = await _client
            .GetFromJsonAsync<int>("")
            .ConfigureAwait(false);
        return result;
    }

    public Task<bool> DeleteAsync(Cloud item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Cloud>> GetAllAsync(CancellationToken cancel = default)
    {
        var clouds = await _client
            .GetFromJsonAsync<IEnumerable<Cloud>>(""/*адрес*/, cancel)
            .ConfigureAwait(false);

        if (clouds is null)
            throw new InvalidOperationException("Не удалось получить данные от сервера");

        return clouds;
    }

    public async Task<Cloud?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        var cloud = await _client
            .GetFromJsonAsync<Cloud>("")
            .ConfigureAwait(false);

        if (cloud is null)
            throw new InvalidOperationException("Не удалось получить данные от сервера");

        return cloud;
    }

    public Task<bool> UpdateAsync(Cloud item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }
}
