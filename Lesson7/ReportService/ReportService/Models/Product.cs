using ReportService.Models.Base;

namespace ReportService.Models;

/// <summary>Класс модель продукт</summary>
public class Product : NamedEntity
{
    public decimal Price { get; set; }
    public int Count { get; set; }

    public Category? CategoryProduct { get; set; }
}
