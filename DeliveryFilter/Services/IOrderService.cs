using DeliveryFilter.Models;

namespace DeliveryFilter.Services
{
    public interface IOrderService
    {
        Task AddOrderAsync(Order order);
        Task<List<Order>> GetFilteredOrdersAsync(string district, DateTime deliveryTime);
    }
}