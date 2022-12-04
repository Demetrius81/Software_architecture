using CloudService.Model.Abstractions;

namespace CloudService.Model.Models;

public class Cloud : Entity, ICloneable
{
    public int ClientId { get; set; }
    public int IpAddressId { get; set; }
    public int ServerPoolId { get; set; }
    public int Ram { get; set; }
    public int Rom { get; set; }
    public int Cpu { get; set; }
    public OperationSystem Os { get; set; }

    public override object Clone() => new Cloud
    {
        Id = this.Id,
        ClientId = this.ClientId,
        IpAddressId = this.IpAddressId,
        ServerPoolId = this.ServerPoolId,
        Ram = this.Ram,
        Rom = this.Ram,
        Cpu = this.Cpu,
        Os = this.Os,
    };
}
