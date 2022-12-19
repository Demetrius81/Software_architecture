namespace CloudService.Interfaces;

/// <summary>
/// Интерфейс сущности. Устанавливает понятие, что такое сущность.
/// </summary>
public interface IEntity : ICloneable
{
    public int Id { get; set; }
}
