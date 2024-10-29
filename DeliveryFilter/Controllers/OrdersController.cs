using DeliveryFilter.Models;
using DeliveryFilter.Services;
using DeliveryFilter.Validators;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryFilter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IOrderService orderService, ILogger<OrderController> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(Order order)
        {
            _logger.LogInformation("Received request to create order.");


            if (order == null)
            {
                _logger.LogWarning("Order is null.");
                return BadRequest("Order cannot be null.");
            }


            var validationResult = await new OrderValidator().ValidateAsync(order);
            if (!validationResult.IsValid)
            {
                _logger.LogWarning("Order validation failed: {Errors}", validationResult.Errors);
                return BadRequest(validationResult.Errors);
            }

            await _orderService.AddOrderAsync(order);
            return Ok("Order added successfully");
        }

        [HttpGet]
        public async Task<IActionResult> GetFilteredOrders(string district, DateTime deliveryTime)
        {
            _logger.LogInformation("Received request to retrieve filtered orders.");
            var orders = await _orderService.GetFilteredOrdersAsync(district, deliveryTime);
            return Ok(orders);
        }
    }
}
