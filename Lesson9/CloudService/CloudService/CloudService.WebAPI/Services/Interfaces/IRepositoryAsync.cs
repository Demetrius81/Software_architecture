using CloudService.Model.Abstractions;

namespace CloudService.WebAPI.Services.Interfaces;

public interface IRepositoryAsync<T> where T : class, IEntity
{
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancel = default);
    Task<T?> GetByIdAsync(int id, CancellationToken cancel = default);
    Task<int> CountAsync(CancellationToken cancel = default);
    Task<int> AddAsync(T item, CancellationToken cancel = default);
    Task<bool> UpdateAsync(T item, CancellationToken cancel = default);
    Task<bool> DeleteAsync(T item, CancellationToken cancel = default);
}
