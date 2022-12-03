using CloudService.Model.Abstractions;

namespace CloudService.Model.ModelsDTO;
public class ServerPoolDto : Entity
{
    public Server? CurrentServer { get; set; }
}
