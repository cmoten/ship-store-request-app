using Microsoft.EntityFrameworkCore;
using ShipRequestApp.Core.Model;
using ShipRequestApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRequestApp.Data.Sqlite
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly ShipRequestAppContext _db;

        public SqlUserRepository(ShipRequestAppContext db)
        {
            _db = db;
        }

        public Task DeleteAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAsync()
        {
            return await _db.Users
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<User>> GetAsync(string search)
        {
            string[] parameters = search.Split(' ');
            return await _db.Users
                .Where(user =>
                    parameters.Any(parameter =>
                    user.FirstName.StartsWith(parameter) ||
                    user.LastName.StartsWith(parameter) ||
                    user.Email.StartsWith(parameter)))
                .OrderByDescending(user =>
                    parameters.Count(parameter =>
                        user.FirstName.StartsWith(parameter) ||
                        user.LastName.StartsWith(parameter) ||
                        user.Email.StartsWith(parameter)))
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await _db.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(user => user.Id == id);
        }

        public async Task<User> UpsertAsync(User user)
        {
            var current = await _db.Users.FirstOrDefaultAsync(_user => _user.Id == user.Id);
            if (null == current)
            {
                _db.Users.Add(user);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(user);
            }
            await _db.SaveChangesAsync();
            return user;
        }
    }
}
