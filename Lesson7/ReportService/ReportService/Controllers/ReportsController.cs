using Microsoft.AspNetCore.Mvc;
using ReportService.Models;
using ReportService.Services.Repository;

namespace ReportService.Controllers;

/// <summary>
/// Контроллер отчетов
/// </summary>
[ApiController]
[Route($$"""api/reports""")]
public class ReportsController : ControllerBase
{    
    private readonly IRepositoryAsync<Report> _repository;
    private readonly ILogger<ReportsController> _logger;

    /// <summary>
    /// Конструктор контроллера
    /// </summary>
    /// <param name="repository"></param>
    /// <param name="logger"></param>
    public ReportsController(IRepositoryAsync<Report> repository, ILogger<ReportsController> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    /// <summary>
    /// Метод получения коллекции отчетов и отправки его по GET запросу
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await _repository.GetAllAsync().ConfigureAwait(true);
        _logger.LogInformation(">>> Получили список отчетов и подготовили его к отправке");
        return Ok(response);
    }
}
