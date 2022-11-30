using CloudService.Model.Abstractions;

namespace CloudService.Model;

public class Cloud : Entity
{
    public int ClientId { get; set; }
    public int IpAddressId { get; set; }
    public int ServerPoolId { get; set; }
    public int Ram { get; set; }
    public int Rom { get; set; }
    public int Cpu { get; set; }
    public OperationSystem Os { get; set; }

}
