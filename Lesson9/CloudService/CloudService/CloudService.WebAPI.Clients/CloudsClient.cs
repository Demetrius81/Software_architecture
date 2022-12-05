using CloudService.Interfaces;
using CloudService.Model.ModelsDTO;
using System.Net.Http.Json;

namespace CloudService.WebAPI.Clients;
public class CloudsClient : IRepositoryAsync<CloudDto>
{
    private readonly HttpClient _client;

    public CloudsClient(HttpClient client)
	{
        this._client = client;
    }

    public async Task<int> AddAsync(CloudDto item, CancellationToken cancel = default)
    {
        var result = await _client.PostAsJsonAsync("/Cloud/api/v1/add", item, cancel).ConfigureAwait(false);
        return result.Content.ReadFromJsonAsync<int>(options: null, cancel).Result;
    }

    public async Task<int> CountAsync(CancellationToken cancel = default)
    {
        var result = await _client
            .GetFromJsonAsync<int>("/Cloud/api/v1/getcount")
            .ConfigureAwait(false);
        return result;
    }

    public async Task<bool> DeleteAsync(CloudDto item, CancellationToken cancel = default)
    {
        var result = await _client.PostAsJsonAsync("/Cloud/api/v1/delete", item, cancel).ConfigureAwait(false);
        return await result.Content.ReadFromJsonAsync<bool>(options: null, cancel);
    }
    
    public async Task<bool> DeleteByIdAsync(int id, CancellationToken cancel = default)
    {
        var result = await _client.DeleteAsync($"/Cloud/api/v1/delete/id={id}", cancel).ConfigureAwait(false);
        return await result.Content.ReadFromJsonAsync<bool>(options: null, cancel);
    }

    public async Task<IEnumerable<CloudDto>?> GetAllAsync(CancellationToken cancel = default)
    {
        var clouds = await _client
            .GetFromJsonAsync<IEnumerable<CloudDto>>("/Cloud/api/v1/getall", cancel)
            .ConfigureAwait(false);

        if (clouds is null)
            throw new InvalidOperationException("Не удалось получить данные от сервера");

        return clouds;
    }

    public async Task<CloudDto?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        var cloud = await _client
            .GetFromJsonAsync<CloudDto>($"/Cloud/api/v1/getbyid/id={id}")
            .ConfigureAwait(false);

        if (cloud is null)
            throw new InvalidOperationException("Не удалось получить данные от сервера");

        return cloud;
    }

    public async Task<bool> UpdateAsync(CloudDto item, CancellationToken cancel = default)
    {
        var result = await _client.PostAsJsonAsync("/Cloud/api/v1/update", item, cancel).ConfigureAwait(false);
        return await result.Content.ReadFromJsonAsync<bool>(options: null, cancel);
    }
}
