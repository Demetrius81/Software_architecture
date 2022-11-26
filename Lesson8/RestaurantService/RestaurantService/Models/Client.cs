using RestaurantService.Models.Base;

namespace RestaurantService.Models;

/// <summary>Класс модель клиента</summary>
public class Client : Entity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Patronymic { get; set; } = null!;
    public string  Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
}
