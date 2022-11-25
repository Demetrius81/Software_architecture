using RestaurantService.Models.Base;

namespace RestaurantService.Models;

public class Table : Entity
{
    public int CountPlaces { get; set; }
    public bool Vip { get; set; }
}
