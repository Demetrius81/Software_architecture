using RestaurantService.Models.Base;

namespace RestaurantService.Services.Repository;

public interface IRepositoryAsync<T> where T : Entity
{
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancel = default);
    Task<T?> GetByIdAsync(int id, CancellationToken cancel = default);
    Task<int> GetCountAsync(CancellationToken cancel = default);
    Task<int> AddAsync(T item, CancellationToken cancel = default);
    Task<bool> UpdateAsync(T item, CancellationToken cancel = default);
    Task<bool> DeleteAsync(T item, CancellationToken cancel = default);
}
