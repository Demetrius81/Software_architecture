using ReportService.Models.Base;

namespace ReportService.Models;

/// <summary>����� ������ �����</summary>
public class Report : Entity
{
    public DateTimeOffset Time { get; set; } = DateTimeOffset.Now;
}