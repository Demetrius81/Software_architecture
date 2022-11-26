using Microsoft.Extensions.Logging;
using RestaurantService.Models;
using RestaurantService.Services.Repository;

namespace RestaurantService.Services.Managers;

/// <summary>
/// Менеджер заказов
/// </summary>
public class OrderManager : IOrderManager
{
    private readonly IRepositoryAsync<Order> _orderRepository;
    private readonly IRepositoryAsync<Table> _tableRepository;
    private readonly IRepositoryAsync<Client> _clientRepository;
    private readonly ILogger<OrderManager> _logger;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="orderRepository"></param>
    /// <param name="tableRepository"></param>
    /// <param name="clientRepository"></param>
    /// <param name="logger"></param>
    public OrderManager(
        IRepositoryAsync<Order> orderRepository,
        IRepositoryAsync<Table> tableRepository,
        IRepositoryAsync<Client> clientRepository,
        ILogger<OrderManager> logger)
    {
        _orderRepository = orderRepository;
        _tableRepository = tableRepository;
        _clientRepository = clientRepository;
        _logger = logger;
        logger.LogInformation($">>>Создан объект класса {nameof(OrderManager)}");
    }

    /// <summary>
    /// Метод добавления заказа
    /// </summary>
    /// <param name="item"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    public async Task<int> AddOrderAsync(OrderDTO item, CancellationToken cancel = default)
    {
        var order = new Order
        {
            ClientId = item.CurrentClient is not null ? item.CurrentClient.Id : default,
            TableId = item.CurrentTable is not null ? item.CurrentTable.Id : default
        };

        _logger.LogInformation($">>>Создан объект класса {nameof(Order)}");
        var result = await _orderRepository.AddAsync(order, cancel);
        _logger.LogInformation($">>>Oбъект класса {nameof(Order)} добавлен в БД");

        return result;
    }

    /// <summary>
    /// Метод удаления заказа
    /// </summary>
    /// <param name="item"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>    
    public async Task<bool> DeleteOrderAsync(OrderDTO item, CancellationToken cancel = default)
    {
        var order = new Order
        {
            Id = item.Id,
            ClientId = item.CurrentClient is not null ? item.CurrentClient.Id : default,
            TableId = item.CurrentTable is not null ? item.CurrentTable.Id : default,
            DateTime = item.DateTime
        };

        return await _orderRepository.DeleteAsync(order, cancel);
    }

    /// <summary>
    /// Метод получения списка заказов
    /// </summary>
    /// <param name="cancel"></param>
    /// <returns></returns>
    public async Task<IEnumerable<OrderDTO>?> GetAllOrdersAsync(CancellationToken cancel = default)
    {
        var orders = await _orderRepository.GetAllAsync(cancel).ConfigureAwait(false);
        var result = new List<OrderDTO>();
        var clients = await _clientRepository.GetAllAsync(cancel);
        var tables = await _tableRepository.GetAllAsync(cancel);
        foreach (var order in orders)
        {
            var orderDTO = new OrderDTO
            {
                Id = order.Id,
                CurrentClient = clients.FirstOrDefault(x => x.Id == order.ClientId)!,
                CurrentTable = tables.FirstOrDefault(x => x.Id == order.TableId)!,
                DateTime = order.DateTime
            };
            result.Add(orderDTO);
        }
        return result;
    }

    /// <summary>
    /// Метод получения количества заказов
    /// </summary>
    /// <param name="cancel"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<int> GetCountOrdersAsync(CancellationToken cancel = default)
    {
        return await _orderRepository.GetCountAsync(cancel).ConfigureAwait(false);
    }

    /// <summary>
    /// Метод получения заказа по номеру
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    public async Task<OrderDTO?> GetOrderByIdAsync(int id, CancellationToken cancel = default)
    {
        var order = await _orderRepository.GetByIdAsync(id, cancel).ConfigureAwait(false);
        if (order is null) return null;
        var orderDTO = new OrderDTO
        {
            Id = order.Id,
            CurrentClient = await _clientRepository.GetByIdAsync(order.ClientId, cancel),
            CurrentTable = await _tableRepository.GetByIdAsync(order.ClientId, cancel),
            DateTime = order.DateTime
        };

        return orderDTO;
    }

    /// <summary>
    /// Метод изменения заказа
    /// </summary>
    /// <param name="item"></param>
    /// <param name="cancel"></param>
    /// <returns></returns>
    public async Task<bool> UpdateOrderAsync(OrderDTO item, CancellationToken cancel = default)
    {
        var order = new Order
        {
            Id = item.Id,
            ClientId = item.CurrentClient is not null ? item.CurrentClient.Id : default,
            TableId = item.CurrentTable is not null ? item.CurrentTable.Id : default,
            DateTime = item.DateTime
        };

        return await _orderRepository.UpdateAsync(order, cancel);
    }
}
