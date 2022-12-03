using CloudService.Interfaces;
using CloudService.Model;
using CloudService.Model.ModelsDTO;

namespace CloudService.WebAPI.Services.Managers;

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
        ServerPool serverPool = new()
        {
            Id = item.Id,
            ServerId = item.CurrentServer.Id
        };
        var result = await _serverPoolRepository.DeleteAsync(serverPool, cancel).ConfigureAwait(false);
        _logger.LogInformation(">>>Пул серверов удален");
        return result;
    }

    public async Task<IEnumerable<ServerPoolDto>> GetAllAsync(CancellationToken cancel = default)
    {
        var serverPool = await _serverPoolRepository.GetAllAsync(cancel).ConfigureAwait(false);
        var serverPoolDto = new List<ServerPoolDto>();
        foreach ( var item in serverPool)
        {
            serverPoolDto.Add(new ServerPoolDto
            {
                Id = item.Id,
                CurrentServer
            });
        }
    }

    public Task<ServerPoolDto?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(ServerPoolDto item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }
}
