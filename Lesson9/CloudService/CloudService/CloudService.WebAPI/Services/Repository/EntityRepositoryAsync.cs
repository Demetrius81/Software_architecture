using CloudService.DAL.Context;
using CloudService.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloudService.WebAPI.Services.Repository;

internal class EntityRepositoryAsync<T> : IRepositoryAsync<T> where T : class, IEntity
{
    private readonly CloudServiceDb _db;
    private readonly ILogger<EntityRepositoryAsync<T>> _logger;

    public EntityRepositoryAsync(CloudServiceDb db, ILogger<EntityRepositoryAsync<T>> logger)
    {
        this._db = db;
        this._logger = logger;
    }

    public async Task<int> AddAsync(T item, CancellationToken cancel = default)
    {
        var result = await _db.Set<T>().AddAsync(item, cancel).ConfigureAwait(false);
        await _db.SaveChangesAsync(cancel);
        return result.Entity.Id;
    }

    public async Task<int> CountAsync(CancellationToken cancel = default)
    {
        var rresult = await _db.Set<T>().CountAsync(cancel).ConfigureAwait(false);
        _logger.LogInformation($">>>Получили количество всех элементов {typeof(T)}");
        return rresult;
    }

    public async Task<bool> DeleteAsync(T item, CancellationToken cancel = default)
    {
        if (!await _db.Set<T>().AnyAsync(i => i.Id == item.Id, cancel).ConfigureAwait(false)) 
            return false;
        var result = _db.Set<T>().Remove(item);
        _logger.LogInformation($">>>Удалили элемент {typeof(T)}");
        await _db.SaveChangesAsync(cancel).ConfigureAwait(false);
        return result.Entity is not null;
    }

    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancel = default)
    {
        var items = await _db.Set<T>().ToArrayAsync(cancel).ConfigureAwait(false);
        _logger.LogInformation($">>>Получили массив всех элементов {typeof(T)}");
        return items;
    }

    public async Task<T?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        var item = await _db.Set<T>().FirstOrDefaultAsync(i => i.Id == id).ConfigureAwait(false);
        _logger.LogInformation($">>>Получили элемент по идентификатору {typeof(T)}");
        return item;
    }

    public async Task<bool> UpdateAsync(T item, CancellationToken cancel = default)
    {
        var result = _db.Set<T>().Update(item);
        _logger.LogInformation($">>>Изменили элемент {typeof(T)}");
        await _db.SaveChangesAsync(cancel).ConfigureAwait(false);
        return result.Entity is not null;
    }
}
