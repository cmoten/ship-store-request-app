using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel.Resolution;
using ShipRequestApp.Core.Model;

namespace ShipRequestApp.Data.Sqlite
{
    /// <summary>
    /// Entity Framework Core DbContext.
    /// </summary>
    public class ShipRequestAppContext : DbContext
    {
        /// <summary>
        /// DbContext constructor
        /// </summary>
        public ShipRequestAppContext(DbContextOptions<ShipRequestAppContext> options) : base(options) { }

        /// <summary>
        /// Get the DbSets available in the database
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderByUser> OrderByUsers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderResponse> OrderResponses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=AppData.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
        }

    }




}