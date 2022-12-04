using CloudService.Interfaces;
using CloudService.Model.ModelsDTO;
using CloudService.Model.Models;

namespace CloudService.WebAPI.Services.Managers;

internal class CloudManager : IRepositoryAsync<CloudDto>
{
    private readonly IRepositoryAsync<Cloud> _cloudRepository;
    private readonly IRepositoryAsync<Client> _clientRepository;
    private readonly IRepositoryAsync<ServerPool> _serverPoolRepository;
    private readonly IRepositoryAsync<IpAddress> _ipAddressRepository;
    private readonly ILogger<CloudManager> _logger;

    public CloudManager(IRepositoryAsync<Cloud> cloudRepository,
                        IRepositoryAsync<Client> clientRepository,
                        IRepositoryAsync<ServerPool> serverPoolRepository,
                        IRepositoryAsync<IpAddress> ipAddressRepository,
                        ILogger<CloudManager> logger)
    {
        this._cloudRepository = cloudRepository;
        this._clientRepository = clientRepository;
        this._serverPoolRepository = serverPoolRepository;
        this._ipAddressRepository = ipAddressRepository;
        this._logger = logger;
    }

    public async Task<int> AddAsync(CloudDto item, CancellationToken cancel = default)
    {
        if (item is null ||
            item.CurrentIpAddress is null ||
            item.CurrentClient is null ||
            item.CurrentServerPool is null)
            return -1;
        Cloud cloud = new()
        {
            ClientId = item.CurrentClient.Id,
            ServerPoolId = item.CurrentServerPool.Id,
            IpAddressId = item.CurrentIpAddress.Id,
            Ram = item.Ram,
            Rom = item.Rom,
            Cpu = item.Cpu,
            Os = item.Os
        };

        var result = await _cloudRepository.AddAsync(cloud, cancel).ConfigureAwait(false);
        _logger.LogInformation(">>> Облако добавлено");
        return result;
    }

    public async Task<int> CountAsync(CancellationToken cancel = default)
    {
        return await _cloudRepository.CountAsync(cancel).ConfigureAwait(false);
    }

    public async Task<bool> DeleteAsync(CloudDto item, CancellationToken cancel = default)
    {
        if (item is null ||
            item.CurrentIpAddress is null ||
            item.CurrentClient is null ||
            item.CurrentServerPool is null) 
            return false;
        Cloud cloud = new()
        {
            Id = item.Id,
            ClientId = item.CurrentClient.Id,
            ServerPoolId = item.CurrentServerPool.Id,
            IpAddressId = item.CurrentIpAddress.Id,
            Ram = item.Ram,
            Rom = item.Rom,
            Cpu = item.Cpu,
            Os = item.Os
        };

        var result = await _cloudRepository.DeleteAsync(cloud, cancel).ConfigureAwait(false);
        _logger.LogInformation(">>> Облако удалено");
        return result;
    }

    public async Task<IEnumerable<CloudDto>?> GetAllAsync(CancellationToken cancel = default)
    {
        var clouds = await _cloudRepository.GetAllAsync(cancel).ConfigureAwait(false);
        if (clouds is null) 
            return null;
        var cloudsDto = new List<CloudDto>();
        foreach (var cloud in clouds)
        {
            cloudsDto.Add(new CloudDto
            {
                Id = cloud.Id,
                CurrentClient = await _clientRepository.GetByIdAsync(cloud.ClientId, cancel),
                CurrentServerPool = await _serverPoolRepository.GetByIdAsync(cloud.ServerPoolId, cancel),
                CurrentIpAddress = await _ipAddressRepository.GetByIdAsync(cloud.IpAddressId, cancel),
                Ram = cloud.Ram,
                Rom = cloud.Rom,
                Cpu = cloud.Cpu,
                Os = cloud.Os
            });

        }

        _logger.LogInformation(">>>Получена коллекция облаков");
        return cloudsDto;
    }

    public async Task<CloudDto?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        var cloud = await _cloudRepository.GetByIdAsync(id, cancel).ConfigureAwait(false);
        if (cloud is null) 
            return null;
        var cloudDto = new CloudDto
        {
            Id = cloud.Id,
            CurrentClient = await _clientRepository.GetByIdAsync(cloud.ClientId, cancel),
            CurrentServerPool = await _serverPoolRepository.GetByIdAsync(cloud.ServerPoolId, cancel),
            CurrentIpAddress = await _ipAddressRepository.GetByIdAsync(cloud.IpAddressId, cancel),
            Ram = cloud.Ram,
            Rom = cloud.Rom,
            Cpu = cloud.Cpu,
            Os = cloud.Os
        };

        _logger.LogInformation(">>>Получено облако");
        return cloudDto;
    }

    public async Task<bool> UpdateAsync(CloudDto item, CancellationToken cancel = default)
    {
        if (item is null ||
            item.CurrentIpAddress is null ||
            item.CurrentClient is null ||
            item.CurrentServerPool is null) 
                return false;
        Cloud cloud = new()
        {
            Id = item.Id,
            ClientId = item.CurrentClient.Id,
            ServerPoolId = item.CurrentServerPool.Id,
            IpAddressId = item.CurrentIpAddress.Id,
            Ram = item.Ram,
            Rom = item.Rom,
            Cpu = item.Cpu,
            Os = item.Os
        };

        var result = await _cloudRepository.UpdateAsync(cloud, cancel).ConfigureAwait(false);
        _logger.LogInformation(">>> Облако обновлено");
        return result;
    }
}
