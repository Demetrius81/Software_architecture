using Microsoft.AspNetCore.Mvc;
using RestaurantService.Models;
using RestaurantService.Services.Managers;
using Swashbuckle.AspNetCore.Annotations;

namespace RestaurantService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderManager _orderManager;
    private readonly ILogger<OrderController> _logger;

    public OrderController(IOrderManager orderManager, ILogger<OrderController> logger)
    {
        this._orderManager = orderManager;
        this._logger = logger;
    }

    [HttpGet]
    [Route("/api/GetAllOrders")]
    [SwaggerOperation("GetAll")]
    [SwaggerResponse(statusCode: 200, type: typeof(IEnumerable<Order>), description: "Successful operation")]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await _orderManager.GetAllOrdersAsync());
    }

    [HttpGet]
    [Route("/api/GetOrderById/id={id}")]
    [SwaggerOperation("GetById")]
    [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "Successful operation")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        return Ok(await _orderManager.GetOrderByIdAsync(id));
    }

    [HttpGet]
    [Route("/api/GetCountOrders")]
    [SwaggerOperation("GetCount")]
    [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Successful operation")]
    public async Task<IActionResult> GetCountAsync()
    {
        return Ok(await _orderManager.GetCountOrdersAsync());
    }

    [HttpPut]
    [Route("/api/Update")]
    [SwaggerOperation("Update")]
    [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Successful operation")]
    public async Task<IActionResult> UpdateAsync([FromBody] Order order)
    {
        return Ok(await _orderManager.UpdateOrderAsync(order));
    }

    [HttpDelete]
    [Route("/api/Remove")]
    [SwaggerOperation("Delete")]
    [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Successful operation")]
    public async Task<IActionResult> DeleteAsync([FromBody] Order order)
    {
        return Ok(await _orderManager.DeleteOrderAsync(order));
    }

    [HttpPost]
    [Route("/api/Add")]
    [SwaggerOperation("Add")]
    [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Successful operation")]
    public async Task<IActionResult> AddAsync([FromBody] Order order)
    {
        return Ok(await _orderManager.AddOrderAsync(order));
    }
}
