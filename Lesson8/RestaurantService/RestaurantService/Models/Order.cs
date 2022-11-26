using RestaurantService.Models.Base;

namespace RestaurantService.Models;

public class Order : Entity
{
    public int ClientId { get; set; }
    public int TableId { get; set; }
    public DateTimeOffset DateTime { get; set; } = DateTimeOffset.UtcNow;

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;
        
        Order? order = obj as Order;

        return order is not null && order.Id == this.Id && order.DateTime == this.DateTime;
    }
}
