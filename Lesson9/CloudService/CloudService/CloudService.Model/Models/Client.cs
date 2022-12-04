using CloudService.Model.Abstractions;

namespace CloudService.Model.Models;
public class Client : Entity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Patronymic { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }

    public override object Clone() => new Client
    {
        Id = this.Id,
        FirstName = this.FirstName,
        LastName = this.LastName,
        Patronymic = this.Patronymic,
        Email = this.Email,
        PasswordHash = this.PasswordHash
    };
}
