using CloudService.Model.Abstractions;

namespace CloudService.Model.Models;

/// <summary>
/// Модель IP адреса
/// </summary>
public class IpAddress : Entity
{
    public int Value { get; set; }

    public override object Clone() => new IpAddress
    {
        Id = this.Id,
        Value = this.Value
    };
}
