using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using CloudService.Model.ModelsDTO;
using CloudService.Interfaces;

namespace CloudService.WebAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class CloudController : ControllerBase
{
    private readonly IRepositoryAsync<CloudDto> _manager;
    private readonly ILogger<CloudController> _logger;

    public CloudController(IRepositoryAsync<CloudDto> manager, ILogger<CloudController> logger)
    {
        this._manager = manager;
        this._logger = logger;
    }
    /// <summary>
    /// Метод отмены заказа на облако по ID
    /// </summary>
    /// <param name="cloudId">Идентификатор заказа облака</param>
    /// <response code="200">Успешный ответ заказом облака по ID</response>
    /// <response code="400">Ошибка ввода данных</response>
    /// <response code="500">Ошибка сервера</response>
    /// <response code="0">Все остальное</response>
    [HttpDelete]
    [Route("api/v1/delete")]
    [SwaggerOperation("CencelCloudById")]
    [SwaggerResponse(statusCode: 200, description: "Заказ на облако отменен")]
    [SwaggerResponse(statusCode: 400, description: "Ошибка ввода данных")]
    [SwaggerResponse(statusCode: 500, description: "Ошибка сервера")]
    [SwaggerResponse(statusCode: 0, description: "Все остальное")]
    public async Task<IActionResult> DeleteCloudById([FromBody][Required] CloudDto cloud, CancellationToken cancel = default)
    {
        if (cloud is null ||
            cloud.Id == default ||
            cloud.Cpu == default ||
            cloud.Os == default ||
            cloud.Ram == default ||
            cloud.Rom == default ||
            cloud.CurrentIpAddress is null ||
            cloud.CurrentClient is null ||
            cloud.CurrentServerPool is null)
            return BadRequest();
        var result = await _manager.DeleteAsync(cloud, cancel).ConfigureAwait(true);
        if (!result) return NotFound();
        return Ok(result);
    }

    /// <summary>
    /// Метод создания заказа на облако
    /// </summary>
    /// <param name="body"></param>
    /// <response code="200">Успешный ответ создания заказ на облако</response>
    /// <response code="400">Ошибка ввода данных</response>
    /// <response code="500">Ошибка сервера</response>
    /// <response code="0">Все остальное</response>
    [HttpPost]
    [Route("api/v1/add")]
    [SwaggerOperation("CreateCloud")]
    [SwaggerResponse(statusCode: 200, description: "Успешный ответ создания заказ на облако")]
    [SwaggerResponse(statusCode: 400, description: "Ошибка ввода данных")]
    [SwaggerResponse(statusCode: 500, description: "Ошибка сервера")]
    [SwaggerResponse(statusCode: 0, description: "Все остальное")]
    public async Task<IActionResult> CreateCloud([FromBody] CloudDto cloud, CancellationToken cancel = default)
    {
        if (cloud is null ||
            cloud.Id == default ||
            cloud.Cpu == default ||
            cloud.Os == default ||
            cloud.Ram == default ||
        cloud.Rom == default ||
            cloud.CurrentIpAddress is null ||
        cloud.CurrentClient is null ||
            cloud.CurrentServerPool is null)
            return BadRequest();
        var result = await _manager.AddAsync(cloud, cancel).ConfigureAwait(true);
        if (result < 0) return NotFound();
        return Ok(result);
    }

    /// <summary>
    /// Метод получения списка заказов на облако
    /// </summary>
    /// <response code="200">Успешный ответ со списком заказов в облаке</response>
    /// <response code="400">Ошибка ввода данных</response>
    /// <response code="500">Ошибка сервера</response>
    /// <response code="0">Все остальное</response>
    [HttpGet]
    [Route("api/v1/getall")]
    [SwaggerOperation("GetAllClouds")]
    [SwaggerResponse(statusCode: 200, description: "Успешный ответ со списком заказов в облаке")]
    [SwaggerResponse(statusCode: 500, description: "Ошибка сервера")]
    [SwaggerResponse(statusCode: 0, description: "Все остальное")]
    public async Task<IActionResult> GetAllClouds(CancellationToken cancel = default)
    {
        var result = await _manager.GetAllAsync(cancel).ConfigureAwait(true);
        if (result is null)
            return NotFound();
        return Ok(result);
    }

    /// <summary>
    /// Метод получения заказа на облако по ID
    /// </summary>
    /// <param name="cloudId">Идентификатор заказа облака</param>
    /// <response code="200">Успешный ответ заказом облака по ID</response>
    /// <response code="400">Ошибка ввода данных</response>
    /// <response code="500">Ошибка сервера</response>
    /// <response code="0">Все остальное</response>
    [HttpGet]
    [Route("api/v1/getbyid/id={id}")]
    [SwaggerOperation("GetCloudById")]
    [SwaggerResponse(statusCode: 200, description: "Успешный ответ заказом облака по ID")]
    [SwaggerResponse(statusCode: 400, description: "Ошибка ввода данных")]
    [SwaggerResponse(statusCode: 500, description: "Ошибка сервера")]
    [SwaggerResponse(statusCode: 0, description: "Все остальное")]
    public async Task<IActionResult> GetCloudById([FromRoute][Required] int id, CancellationToken cancel = default)
    {
        if (id < 0)
            return BadRequest();
        var result = await _manager.GetByIdAsync(id, cancel).ConfigureAwait(true);
        if (result is null) 
            return NotFound();
        return Ok(result);
    }

    /// <summary>
    /// Метод создания заказа на облако
    /// </summary>
    /// <param name="body"></param>
    /// <response code="200">Успешный ответ создания заказ на облако</response>
    /// <response code="400">Ошибка ввода данных</response>
    /// <response code="500">Ошибка сервера</response>
    /// <response code="0">Все остальное</response>
    [HttpPost]
    [Route("api/v1/update")]
    [SwaggerOperation("UpdateCloud")]
    [SwaggerResponse(statusCode: 200, description: "Успешный ответ обновления заказ на облако")]
    [SwaggerResponse(statusCode: 400, description: "Ошибка ввода данных")]
    [SwaggerResponse(statusCode: 500, description: "Ошибка сервера")]
    [SwaggerResponse(statusCode: 0, description: "Все остальное")]
    public async Task<IActionResult> CreateUpdate([FromBody] CloudDto cloud, CancellationToken cancel = default)
    {
        if (cloud is null ||
            cloud.Id == default ||
            cloud.Cpu == default ||
            cloud.Os == default ||
            cloud.Ram == default ||
        cloud.Rom == default ||
            cloud.CurrentIpAddress is null ||
        cloud.CurrentClient is null ||
            cloud.CurrentServerPool is null)
            return BadRequest();
        var result = await _manager.UpdateAsync(cloud, cancel).ConfigureAwait(true);
        if (!result) return NotFound();
        return Ok(result);
    }

    /// <summary>
    /// Метод получения количества заказов на облако
    /// </summary>
    /// <response code="200">Успешный ответ со списком заказов в облаке</response>
    /// <response code="400">Ошибка ввода данных</response>
    /// <response code="500">Ошибка сервера</response>
    /// <response code="0">Все остальное</response>
    [HttpGet]
    [Route("api/v1/getcount")]
    [SwaggerOperation("GetCountClouds")]
    [SwaggerResponse(statusCode: 200, description: "Успешный ответ с количеством заказов в облаке")]
    [SwaggerResponse(statusCode: 500, description: "Ошибка сервера")]
    [SwaggerResponse(statusCode: 0, description: "Все остальное")]
    public async Task<IActionResult> GetCountClouds(CancellationToken cancel = default)
    {
        var result = await _manager.CountAsync(cancel).ConfigureAwait(true);
        if (result == default)
            return NotFound();
        return Ok(result);
    }

}
