using CloudService.Model.Abstractions;

namespace CloudService.Model.Models;

public class ServerPool : Entity, ICloneable
{
    public int ServerId { get; set; }

    public override object Clone() => new ServerPool
    {
        Id = this.Id,
        ServerId = this.ServerId,
    };
}
