namespace ReportService.Models.Base;

/// <summary>Базовый абстрактный класс именованной сущности</summary>
public class NamedEntity : Entity
{
    public string Name { get; set; } = null!;
}
