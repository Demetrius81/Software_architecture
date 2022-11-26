namespace RestaurantService.Models.Base;

/// <summary>Базовый абстрактный класс сущности</summary>
public abstract class Entity
{
    public int Id { get; set; }

    public override int GetHashCode()
    {
        return Id;
    }
}
