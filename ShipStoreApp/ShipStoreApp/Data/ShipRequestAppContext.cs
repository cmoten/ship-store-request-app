using Microsoft.EntityFrameworkCore;
using ShipStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipStoreApp.Data
{
    public class ShipRequestAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<AddToCart> AddToCart { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany<Order>()
                .WithOne();

            modelBuilder.Entity<User>()
                .HasMany<AddToCart>()
                .WithOne();

            modelBuilder.Entity<Product>()
                .HasMany<AddToCart>()
                .WithOne();

            modelBuilder.Entity<Product>()
                .HasMany<ShoppingCartItem>()
                .WithOne();

            modelBuilder.Entity<Product>()
                .HasMany<OrderDetail>()
                .WithOne();

            modelBuilder.Entity<Order>()
                .HasMany<OrderDetail>()
                .WithOne();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = AppData.db");
            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
