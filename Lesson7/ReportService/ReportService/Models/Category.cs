using ReportService.Models.Base;

namespace ReportService.Models;

public class Category : NamedEntity
{
    //public ICollection<Product> Products { get; set; } = new HashSet<Product>();

    public Report ReportCategory { get; set; }
}