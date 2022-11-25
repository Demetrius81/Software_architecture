using RestaurantService.Models;

namespace RestaurantService.Services;

public interface IOrderManager
{
    Task<IEnumerable<Order>> GetAllOrdersAsync(CancellationToken cancel = default);
    Task<Order?> GetOrderByIdAsync(int id, CancellationToken cancel = default);
    Task<int> GetCountOrdersAsync(CancellationToken cancel = default);
    Task<int> AddOrderAsync(Order item, CancellationToken cancel = default);
    Task<bool> UpdateOrderAsync(Order item, CancellationToken cancel = default);
    Task<bool> DeleteOrderAsync(Order item, CancellationToken cancel = default);
}
