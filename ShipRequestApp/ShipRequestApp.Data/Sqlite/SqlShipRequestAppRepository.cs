using Microsoft.EntityFrameworkCore;
using ShipRequestApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRequestApp.Data.Sqlite
{
    public class SqlShipRequestAppRepository : IShipRequestAppRepository
    {
        private readonly DbContextOptions<ShipRequestAppContext> _dbOptions;

        public SqlShipRequestAppRepository(DbContextOptionsBuilder<ShipRequestAppContext> dbOptionsBuilder)
        {
            _dbOptions = dbOptionsBuilder.Options;
            using(var db = new ShipRequestAppContext(_dbOptions))
            {
                db.Database.EnsureCreated();
            }
        }

        public IUserRepository Users => throw new NotImplementedException();
    }
}
