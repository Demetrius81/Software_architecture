using Microsoft.EntityFrameworkCore;
using RestaurantService.Models;
using RestaurantService.Services.Db;

namespace RestaurantService.Services.Repository;

/// <summary>
/// Репозиторий заказов
/// </summary>
public class OrderRepository : IRepositoryAsync<Order>
{
    private readonly BaseContext _context;
    private readonly ILogger<OrderRepository> _logger;

    public OrderRepository(BaseContext context, ILogger<OrderRepository> logger)
    {
        this._context = context;
        this._logger = logger;
        _logger.LogInformation($"Создан объект класса {nameof(OrderRepository)}");
    }

    public async Task<int> AddAsync(Order item, CancellationToken cancel = default)
    {
        var result = await _context.AddAsync(item, cancel).ConfigureAwait(false);
        await _context.SaveChangesAsync();
        _logger.LogInformation($">>>Added {result}");
        return result.Entity.Id;
    }

    public async Task<bool> DeleteAsync(Order item, CancellationToken cancel = default)
    {
        if(!(await _context.FindAsync<Order>(item, cancel).ConfigureAwait(false) is Order order && Equals(order, item)))
            return false;
        _context.Remove(item);
        await _context.SaveChangesAsync();
        _logger.LogInformation($">>>Deleted {item}");
        return true;
    }

    public async Task<IEnumerable<Order>> GetAllAsync(CancellationToken cancel = default)
    {
        return await _context.Orders.ToArrayAsync(cancel).ConfigureAwait(false);
    }

    public async Task<Order?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        return await _context.Orders.FirstOrDefaultAsync(x => x.Id == id, cancel).ConfigureAwait(false);
    }

    public async Task<int> GetCountAsync(CancellationToken cancel = default)
    {
        return await _context.Orders.CountAsync(cancel).ConfigureAwait(false);
    }

    public async Task<bool> UpdateAsync(Order item, CancellationToken cancel = default)
    {
        if (!(await _context.Orders.FirstOrDefaultAsync<Order>(i => i.Id == item.Id, cancel).ConfigureAwait(false) is Order order && Equals(order, item)))
            return false;
        _context.Update(item);
        await _context.SaveChangesAsync();
        _logger.LogInformation($">>>Updated {item}");
        return true;
    }
}
