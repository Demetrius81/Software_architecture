using CloudService.Model.Abstractions;
using CloudService.Model.Models;

namespace CloudService.Model.ModelsDTO;
public class CloudDto : Entity
{
    public Client? CurrentClient { get; set; }
    public IpAddress? CurrentIpAddress { get; set; }
    public ServerPool? CurrentServerPool { get; set; }
    public int Ram { get; set; }
    public int Rom { get; set; }
    public int Cpu { get; set; }
    public OperationSystem Os { get; set; }

    public override object Clone() => this.MemberwiseClone();
}
