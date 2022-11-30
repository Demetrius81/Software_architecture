using CloudService.Model.Abstractions;

namespace CloudService.Model;
public class Client : Entity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Patronymic { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
}
