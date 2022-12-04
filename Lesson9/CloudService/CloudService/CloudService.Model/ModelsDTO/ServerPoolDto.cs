using CloudService.Model.Abstractions;
using CloudService.Model.Models;

namespace CloudService.Model.ModelsDTO;
public class ServerPoolDto : Entity
{
    public Server? CurrentServer { get; set; }
}
