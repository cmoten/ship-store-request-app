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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = AppData.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
