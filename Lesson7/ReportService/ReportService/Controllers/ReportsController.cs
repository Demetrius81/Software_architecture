using Microsoft.AspNetCore.Mvc;
using ReportService.Models;
using ReportService.Services.Repository;

namespace ReportService.Controllers;
[ApiController]
[Route($$"""api/reports""")]
public class ReportsController : ControllerBase
{    
    private readonly IRepositoryAsync<Report> _repository;
    private readonly ILogger<ReportsController> _logger;

    public ReportsController(IRepositoryAsync<Report> repository, ILogger<ReportsController> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await _repository.GetAllAsync().ConfigureAwait(true);
        _logger.LogInformation(">>> Получили список отчетов");
        return Ok(response);
    }
}
