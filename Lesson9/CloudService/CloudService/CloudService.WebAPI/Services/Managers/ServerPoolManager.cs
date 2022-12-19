using CloudService.Interfaces;
using CloudService.Model.Models;
using CloudService.Model.ModelsDTO;

namespace CloudService.WebAPI.Services.Managers;

/// <summary>
/// Класс менеджера пула серверов
/// </summary>
public class ServerPoolManager : IRepositoryAsync<ServerPoolDto>
{
    private readonly IRepositoryAsync<ServerPool> _serverPoolRepository;
    private readonly IRepositoryAsync<Server> _serverRepository;
    private readonly ILogger<ServerPoolManager> _logger;

    public ServerPoolManager(IRepositoryAsync<ServerPool> serverPoolRepository, IRepositoryAsync<Server> serverRepository, ILogger<ServerPoolManager> logger)
    {
        this._serverPoolRepository = serverPoolRepository;
        this._serverRepository = serverRepository;
        this._logger = logger;
    }

    public async Task<int> AddAsync(ServerPoolDto item, CancellationToken cancel = default)
    {
        if (item is null || item.CurrentServer is null)
            return -1;
        ServerPool serverPool = new()
        {
            ServerId = item.CurrentServer.Id
        };

        var result = await _serverPoolRepository.AddAsync(serverPool, cancel).ConfigureAwait(false);
        _logger.LogInformation(">>>Пул серверов добавлен");
        return result;
    }

    public async Task<int> CountAsync(CancellationToken cancel = default)
    {
        return await _serverPoolRepository.CountAsync(cancel).ConfigureAwait(false);
    }

    public async Task<bool> DeleteAsync(ServerPoolDto item, CancellationToken cancel = default)
    {
        if (item is null || item.CurrentServer is null)
            return false;
        ServerPool serverPool = new()
        {
            Id = item.Id,
            ServerId = item.CurrentServer.Id
        };

        var result = await _serverPoolRepository.DeleteAsync(serverPool, cancel).ConfigureAwait(false);
        _logger.LogInformation(">>>Пул серверов удален");
        return result;
    }

    public async Task<IEnumerable<ServerPoolDto>?> GetAllAsync(CancellationToken cancel = default)
    {
        var serverPool = await _serverPoolRepository.GetAllAsync(cancel).ConfigureAwait(false);
        if (serverPool is null)
            return null;
        var serverPoolDto = new List<ServerPoolDto>();
        foreach (var item in serverPool)
        {
            serverPoolDto.Add(new ServerPoolDto
            {
                Id = item.Id,
                CurrentServer = await _serverRepository.GetByIdAsync(item.ServerId, cancel)
            });
        }

        _logger.LogInformation(">>>Пул серверов получен");
        return serverPoolDto;
    }

    public async Task<ServerPoolDto?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        var serverPool = await _serverPoolRepository.GetByIdAsync(id, cancel).ConfigureAwait(false);
        if (serverPool is null)
            return null;
        var serverPoolDto = new ServerPoolDto
        {
            Id = id,
            CurrentServer = await _serverRepository.GetByIdAsync(serverPool.ServerId, cancel)
        };

        _logger.LogInformation(">>>Пул серверов получен");
        return serverPoolDto;
    }

    public async Task<bool> UpdateAsync(ServerPoolDto item, CancellationToken cancel = default)
    {
        if (item is null || item.CurrentServer is null)
            return false;
        ServerPool serverPool = new()
        {
            Id = item.Id,
            ServerId = item.CurrentServer.Id
        };

        var result = await _serverPoolRepository.UpdateAsync(serverPool, cancel).ConfigureAwait(false);
        _logger.LogInformation(">>>Пул серверов изменен");
        return result;
    }
}
