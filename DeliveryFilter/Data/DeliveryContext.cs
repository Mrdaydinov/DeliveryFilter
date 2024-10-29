using DeliveryFilter.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryFilter.Data
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext(DbContextOptions<DeliveryContext> options)
        : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

    }
}
