using ReportService.Models.Base;

namespace ReportService.Models;

/// <summary>Класс модель провайдер</summary>
public class Provider : NamedEntity
{
    public int Rent { get; set; }

    public Report? ReportProvider { get; set; }
}