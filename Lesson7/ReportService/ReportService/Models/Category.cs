using ReportService.Models.Base;

namespace ReportService.Models;

/// <summary>Класс модель категории товара</summary>
public class Category : NamedEntity
{
    public Report? ReportCategory { get; set; }
}