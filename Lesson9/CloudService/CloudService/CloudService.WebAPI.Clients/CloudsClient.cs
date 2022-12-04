using CloudService.Interfaces;
using CloudService.Model;
using CloudService.Model.ModelsDTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CloudService.WebAPI.Clients;
public class CloudsClient : IRepositoryAsync<CloudDto>
{
    private readonly HttpClient _client;
    private readonly ILogger<CloudsClient> _logger;

    public CloudsClient(HttpClient client, ILogger<CloudsClient> logger)
	{
        this._client = client;
        this._logger = logger;
    }

    public async Task<int> AddAsync(CloudDto item, CancellationToken cancel = default)
    {
        var result = await _client.PostAsJsonAsync("uri", item, cancel).ConfigureAwait(false);
        return result.Content.ReadFromJsonAsync<int>(options: null, cancel).Result;
    }

    public async Task<int> CountAsync(CancellationToken cancel = default)
    {
        var result = await _client
            .GetFromJsonAsync<int>("")
            .ConfigureAwait(false);
        return result;
    }

    public Task<bool> DeleteAsync(CloudDto item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CloudDto>?> GetAllAsync(CancellationToken cancel = default)
    {
        var clouds = await _client
            .GetFromJsonAsync<IEnumerable<CloudDto>>(""/*адрес*/, cancel)
            .ConfigureAwait(false);

        if (clouds is null)
            throw new InvalidOperationException("Не удалось получить данные от сервера");

        return clouds;
    }

    public async Task<CloudDto?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        var cloud = await _client
            .GetFromJsonAsync<CloudDto>("")
            .ConfigureAwait(false);

        if (cloud is null)
            throw new InvalidOperationException("Не удалось получить данные от сервера");

        return cloud;
    }

    public Task<bool> UpdateAsync(CloudDto item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }
}
