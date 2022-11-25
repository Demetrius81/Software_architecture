using RestaurantService.Models;
using RestaurantService.Services.Repository;

namespace RestaurantService.Services;

public class OrderManager : IOrderManager
{
    private readonly IRepositoryAsync<Order> _repository;
    private readonly ILogger<OrderManager> _logger;

    public OrderManager(IRepositoryAsync<Order> repository, ILogger<OrderManager> logger)
    {
        this._repository = repository;
        this._logger = logger;
    }
    public async Task<int> AddOrderAsync(Order item, CancellationToken cancel = default)
    {
        return await _repository.AddAsync(item, cancel);
    }

    public async Task<bool> DeleteOrderAsync(Order item, CancellationToken cancel = default)
    {
        return await _repository.DeleteAsync(item, cancel);
    }

    public async Task<IEnumerable<Order>> GetAllOrdersAsync(CancellationToken cancel = default)
    {
        return await _repository.GetAllAsync(cancel);
    }

    public async Task<int> GetCountOrdersAsync(CancellationToken cancel = default)
    {
        return await _repository.GetCountAsync(cancel);
    }

    public async Task<Order?> GetOrderByIdAsync(int id, CancellationToken cancel = default)
    {
        return await _repository.GetByIdAsync(id, cancel);
    }

    public async Task<bool> UpdateOrderAsync(Order item, CancellationToken cancel = default)
    {
        return await _repository.UpdateAsync(item, cancel);
    }
}
