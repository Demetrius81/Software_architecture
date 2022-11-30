using CloudService.Model.Abstractions;

namespace CloudService.Model;

public class Server : Entity
{
    public int Ram { get; set; }
    public int Rom { get; set; }
    public int Cpu { get; set; }
    public OperationSystem Os { get; set; }
}
