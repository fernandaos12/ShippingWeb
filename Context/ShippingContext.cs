using Microsoft.EntityFrameworkCore;
using ShippingSystem.Models;


namespace ShippingWebSystem.Context
{
    public class ShippingContext : DbContext
    {
        public ShippingContext(DbContextOptions<ShippingContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }

  
}
