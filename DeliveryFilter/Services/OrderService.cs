using DeliveryFilter.Models;
using DeliveryFilter.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DeliveryFilter.Services
{

    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ILogger<OrderService> _logger;

        public OrderService(IOrderRepository orderRepository, ILogger<OrderService> logger)
        {
            _orderRepository = orderRepository;
            _logger = logger;
        }

        public async Task AddOrderAsync(Order order)
        {
            try
            {
                _logger.LogInformation("Adding order with weight {Weight} for district {District}", order.Weight, order.District);
                await _orderRepository.AddOrderAsync(order);
                _logger.LogInformation("Order with ID {OrderId} added successfully.", order.OrderId);
            }
            catch (DbUpdateException dbEx)
            {
                _logger.LogError(dbEx, "Database update error occurred while adding order.");
                throw new Exception("An error occurred while saving the order. Please try again later.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding order.");
                throw new Exception("An unexpected error occurred. Please try again later.");
            }
        }

        public async Task<List<Order>> GetFilteredOrdersAsync(string district, DateTime deliveryTime)
        {
            _logger.LogInformation("Retrieving filtered orders for district {District} and delivery time {DeliveryTime}.", district, deliveryTime);

            var filteredOrders = await _orderRepository.GetFilteredOrders(district, deliveryTime);

            var resultFilePath = Path.Combine(Directory.GetCurrentDirectory(), "results.txt");
            await File.AppendAllLinesAsync(resultFilePath, filteredOrders.Select(o => $"Order ID: {o.OrderId}, District: {o.District}, Weight: {o.Weight}, Delivery Time: {o.DeliveryTime}"));
            
            return filteredOrders;
        }
    }
}
