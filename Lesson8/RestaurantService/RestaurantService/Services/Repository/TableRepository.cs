using Microsoft.EntityFrameworkCore;
using RestaurantService.Models;
using RestaurantService.Services.Db;

namespace RestaurantService.Services.Repository;

/// <summary>
/// Репозиторий столиков
/// </summary>
public class TableRepository : IRepositoryAsync<Table>
{
    private readonly BaseContext _context;
    private readonly ILogger<TableRepository> _logger;

    public TableRepository(BaseContext context, ILogger<TableRepository> logger)
    {
        this._context = context;
        this._logger = logger;
    }

    public Task<int> AddAsync(Table item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Table item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Table>> GetAllAsync(CancellationToken cancel = default)
    {
        _logger.LogInformation(">>>Получаем список столиков");
        return await _context.Tables.ToArrayAsync(cancel).ConfigureAwait(false);
    }

    public async Task<Table?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        _logger.LogInformation(">>>Получаем столик");
        return await _context.Tables.FirstOrDefaultAsync(x => x.Id == id, cancel).ConfigureAwait(false);
    }

    public Task<int> GetCountAsync(CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Table item, CancellationToken cancel = default)
    {
        throw new NotImplementedException();
    }
}
