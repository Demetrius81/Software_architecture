namespace CloudService.Interfaces;

/// <summary>
/// Интерфейс расширения репозитория. Говорит нам, что такое репозиторий.
/// </summary>
/// <typeparam name="T">универсальный тип, должен быть классом и сущностью</typeparam>
public interface IRepositoryAsync<T> where T : class, IEntity
{
    /// <summary>
    /// Метод получает коллекцию всех объектов
    /// </summary>
    /// <param name="cancel"></param>
    /// <returns></returns>
    Task<IEnumerable<T>?> GetAllAsync(CancellationToken cancel = default);

    /// <summary>
    /// Метод получает объект по идентификатору
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    Task<T?> GetByIdAsync(int id, CancellationToken cancel = default);

    /// <summary>
    /// Метод получает количество элементов
    /// </summary>
    /// <param name="cancel"></param>
    /// <returns></returns>
    Task<int> CountAsync(CancellationToken cancel = default);

    /// <summary>
    /// Метод добавляет элемент
    /// </summary>
    /// <param name="item"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    Task<int> AddAsync(T item, CancellationToken cancel = default);

    /// <summary>
    /// Метод обновляет элемент
    /// </summary>
    /// <param name="item"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    Task<bool> UpdateAsync(T item, CancellationToken cancel = default);

    /// <summary>
    /// Метод удаляет элемент
    /// </summary>
    /// <param name="item"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(T item, CancellationToken cancel = default);
}
