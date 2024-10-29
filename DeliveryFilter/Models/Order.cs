namespace DeliveryFilter.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public string District { get; set; }
        public double Weight { get; set; }
        public DateTime DeliveryTime { get; set; }
    }
}