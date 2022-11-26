using RestaurantService.Models.Base;

namespace RestaurantService.Models;

public class OrderDTO : Entity
{
    public Client? CurrentClient { get; set; } = null!;
    public Table? CurrentTable { get; set; } = null!;
    public DateTimeOffset DateTime { get; set; } = DateTimeOffset.UtcNow;
}
