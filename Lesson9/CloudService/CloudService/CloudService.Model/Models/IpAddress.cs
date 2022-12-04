using CloudService.Model.Abstractions;

namespace CloudService.Model.Models;

public class IpAddress : Entity, ICloneable
{
    public int Value { get; set; }

    public override object Clone() => new IpAddress
    {
        Id = this.Id,
        Value = this.Value
    };
}
