using DeliveryFilter.Models;

namespace DeliveryFilter.Repositories
{
    public interface IOrderRepository
    {
        Task AddOrderAsync(Order order);
        Task<List<Order>> GetFilteredOrders(string district, DateTime deliveryTime);
        Task<List<Order>> GetAllOrders();
    }
}
