using Microsoft.EntityFrameworkCore;
using ShipRequestApp.Core.Model;

namespace ShipRequestApp.Data
{
    public class ShipRequestAppContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderByUser> OrderByUsers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderResponse> OrderResponses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<User> Users { get; set; }

    }
}