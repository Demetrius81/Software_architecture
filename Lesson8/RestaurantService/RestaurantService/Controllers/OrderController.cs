using Microsoft.AspNetCore.Mvc;
using RestaurantService.Models;
using RestaurantService.Services.Managers;
using Swashbuckle.AspNetCore.Annotations;

namespace RestaurantService.Controllers;

/// <summary>
/// Контроллер заказов
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderManager _orderManager;
    private readonly ILogger<OrderController> _logger;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="orderManager"></param>
    /// <param name="logger"></param>
    public OrderController(IOrderManager orderManager, ILogger<OrderController> logger)
    {
        this._orderManager = orderManager;
        this._logger = logger;
    }

    /// <summary>
    /// Получение списка всех заказов
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("/api/GetAllOrders")]
    [SwaggerOperation("GetAll")]
    [SwaggerResponse(statusCode: 200, type: typeof(IEnumerable<Order>), description: "Successful operation")]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await _orderManager.GetAllOrdersAsync());
    }

    /// <summary>
    /// Получение заказа по номеру
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("/api/GetOrderById/id={id}")]
    [SwaggerOperation("GetById")]
    [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "Successful operation")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        return Ok(await _orderManager.GetOrderByIdAsync(id));
    }

    /// <summary>
    /// Получение количества заказов
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("/api/GetCountOrders")]
    [SwaggerOperation("GetCount")]
    [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Successful operation")]
    public async Task<IActionResult> GetCountAsync()
    {
        return Ok(await _orderManager.GetCountOrdersAsync());
    }

    /// <summary>
    /// Изменение заказа
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    [HttpPut]
    [Route("/api/Update")]
    [SwaggerOperation("Update")]
    [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Successful operation")]
    public async Task<IActionResult> UpdateAsync([FromBody] OrderDTO order)
    {
        return Ok(await _orderManager.UpdateOrderAsync(order));
    }

    /// <summary>
    /// Удаление заказа
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    [HttpDelete]
    [Route("/api/Remove")]
    [SwaggerOperation("Delete")]
    [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Successful operation")]
    public async Task<IActionResult> DeleteAsync([FromBody] OrderDTO order)
    {
        return Ok(await _orderManager.DeleteOrderAsync(order));
    }

    /// <summary>
    /// Добавление нового заказа
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("/api/Add")]
    [SwaggerOperation("Add")]
    [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Successful operation")]
    public async Task<IActionResult> AddAsync([FromBody] OrderDTO order)
    {
        return Ok(await _orderManager.AddOrderAsync(order));
    }
}
