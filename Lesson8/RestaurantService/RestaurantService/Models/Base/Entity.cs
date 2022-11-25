namespace RestaurantService.Models.Base;

public abstract class Entity
{
    public int Id { get; set; }

    public override int GetHashCode()
    {
        return Id;
    }
}
