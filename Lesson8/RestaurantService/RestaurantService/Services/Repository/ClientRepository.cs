using Microsoft.EntityFrameworkCore;
using RestaurantService.Models;
using RestaurantService.Services.Db;

namespace RestaurantService.Services.Repository;

public class ClientRepository : IRepositoryAsync<Client>
{
    private readonly BaseContext _context;
    private readonly ILogger<ClientRepository> _logger;

    public ClientRepository(BaseContext context, ILogger<ClientRepository> logger)
    {
        this._context = context;
        this._logger = logger;
    }
    public Task<int> AddAsync(Client item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Client item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Client>> GetAllAsync(CancellationToken cancel = default)
    {
        _logger.LogInformation(">>>Получаем список клиентов");
        return await _context.Clients.ToArrayAsync(cancel).ConfigureAwait(false);
    }

    public async Task<Client?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        _logger.LogInformation(">>>Получаем клиента");
        return await _context.Clients.FirstOrDefaultAsync(x => x.Id == id, cancel).ConfigureAwait(false);
    }

    public Task<int> GetCountAsync(CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Client item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }
}
