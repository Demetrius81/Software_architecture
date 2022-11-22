using System.ComponentModel.DataAnnotations;

namespace ReportService.Models.Base;

public class NamedEntity : Entity
{
    //[Required]
    public string Name { get; set; } = null!;
}
