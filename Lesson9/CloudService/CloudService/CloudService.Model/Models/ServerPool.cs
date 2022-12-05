using CloudService.Model.Abstractions;

namespace CloudService.Model.Models;

/// <summary>
/// Модель пула серверов
/// </summary>
public class ServerPool : Entity
{
    public int ServerId { get; set; }

    public override object Clone() => new ServerPool
    {
        Id = this.Id,
        ServerId = this.ServerId,
    };
}
