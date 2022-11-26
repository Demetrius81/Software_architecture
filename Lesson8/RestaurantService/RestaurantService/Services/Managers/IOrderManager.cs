using RestaurantService.Models;

namespace RestaurantService.Services.Managers;

public interface IOrderManager
{
    Task<IEnumerable<OrderDTO>?> GetAllOrdersAsync(CancellationToken cancel = default);
    Task<OrderDTO?> GetOrderByIdAsync(int id, CancellationToken cancel = default);
    Task<int> GetCountOrdersAsync(CancellationToken cancel = default);
    Task<int> AddOrderAsync(OrderDTO item, CancellationToken cancel = default);
    Task<bool> UpdateOrderAsync(OrderDTO item, CancellationToken cancel = default);
    Task<bool> DeleteOrderAsync(OrderDTO item, CancellationToken cancel = default);
}
