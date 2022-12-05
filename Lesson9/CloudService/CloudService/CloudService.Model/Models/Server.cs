using CloudService.Model.Abstractions;

namespace CloudService.Model.Models;

/// <summary>
/// Модель сервера
/// </summary>
public class Server : Entity
{
    public int Ram { get; set; }
    public int Rom { get; set; }
    public int Cpu { get; set; }
    public OperationSystem Os { get; set; }

    public override object Clone() => new Server
    {
        Id = this.Id,
        Ram = this.Ram,
        Rom = this.Rom,
        Cpu = this.Cpu,
        Os = this.Os,
    };
}
