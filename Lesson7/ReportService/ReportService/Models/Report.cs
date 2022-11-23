using ReportService.Models.Base;

namespace ReportService.Models;

/// <summary>Класс модель отчет</summary>
public class Report : Entity
{
    public DateTimeOffset Time { get; set; } = DateTimeOffset.Now;
}