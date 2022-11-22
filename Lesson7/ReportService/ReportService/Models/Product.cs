using ReportService.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportService.Models;

public class Product : NamedEntity
{
    //[Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public int Count { get; set; }

    public Category CategoryProduct { get; set; }
}
