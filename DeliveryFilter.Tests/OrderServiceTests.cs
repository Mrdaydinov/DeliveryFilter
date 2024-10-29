using DeliveryFilter.Models;
using DeliveryFilter.Repositories;
using DeliveryFilter.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace DeliveryFilter.Tests
{
    public class OrderServiceTests
    {
        private readonly Mock<IOrderRepository> _mockOrderRepository;
        private readonly Mock<ILogger<OrderService>> _mockLogger;
        private readonly OrderService _orderService;

        public OrderServiceTests()
        {
            _mockOrderRepository = new Mock<IOrderRepository>();
            _mockLogger = new Mock<ILogger<OrderService>>();
            _orderService = new OrderService(_mockOrderRepository.Object, _mockLogger.Object, "results.txt");
        }

        [Fact]
        public async Task AddOrderAsync_ShouldAddOrderSuccessfully()
        {
            var order = new Order { Weight = 5.0, District = "District A", DeliveryTime = DateTime.Now };

            await _orderService.AddOrderAsync(order);

            _mockOrderRepository.Verify(repo => repo.AddOrderAsync(It.IsAny<Order>()), Times.Once);
        }

        [Fact]
        public async Task GetFilteredOrdersAsync_ShouldReturnFilteredOrders()
        {
            var district = "District A";
            var deliveryTime = DateTime.Now;
            var orders = new List<Order>
            {
                new Order { OrderId = Guid.NewGuid(), Weight = 10, District = district, DeliveryTime = deliveryTime },
                new Order { OrderId = Guid.NewGuid(), Weight = 15, District = district, DeliveryTime = deliveryTime.AddMinutes(15) }
            };

            _mockOrderRepository.Setup(repo => repo.GetFilteredOrders(district, deliveryTime))
                .ReturnsAsync(orders);

            var result = await _orderService.GetFilteredOrdersAsync(district, deliveryTime);

            Assert.Equal(2, result.Count);
            Assert.All(result, o => Assert.Equal(district, o.District));
        }
    }
}
