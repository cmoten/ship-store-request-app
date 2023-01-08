using Microsoft.EntityFrameworkCore;
using ship_request_app.Model;

namespace AppData
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

    }
}