using DeliveryFilter.Data;
using DeliveryFilter.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryFilter.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DeliveryContext _context;

        public OrderRepository(DeliveryContext context)
        {
            _context = context;
        }

        public async Task AddOrderAsync(Order order)
        {
            order.OrderId = Guid.NewGuid();
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            return orders;
        }

        public async Task<List<Order>> GetFilteredOrders(string district, DateTime deliveryTime)
        {
            var filteredOrders = await _context.Orders
                .Where(o => o.District == district && o.DeliveryTime >= deliveryTime && o.DeliveryTime <= deliveryTime.AddMinutes(30))
                .ToListAsync();

            return filteredOrders;
        }
    }
}
