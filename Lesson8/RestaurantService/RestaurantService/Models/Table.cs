using RestaurantService.Models.Base;

namespace RestaurantService.Models;

/// <summary>Класс модель столика</summary>
public class Table : Entity
{
    public int CountPlaces { get; set; }
    public bool Vip { get; set; }
}
