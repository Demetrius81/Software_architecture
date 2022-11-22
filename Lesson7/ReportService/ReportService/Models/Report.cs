using ReportService.Models.Base;

namespace ReportService.Models;

public class Report : Entity
{
    public DateTimeOffset Time { get; set; } = DateTimeOffset.Now;
    //public ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    //public ICollection<Provider> Providers { get; set; } = new HashSet<Provider>();
}