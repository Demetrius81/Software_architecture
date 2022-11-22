using ReportService.Models.Base;

namespace ReportService.Models;

public class Provider : NamedEntity
{
    public int Rent { get; set; }

    public Report ReportProvider { get; set; }
}