using ReportService.Models.Base;

namespace ReportService.Models;

/// <summary>����� ������ ��������� ������</summary>
public class Category : NamedEntity
{
    public Report? ReportCategory { get; set; }
}