using ShipRequestApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRequestApp.Data.Interfaces
{
    /// <summary>
    /// Defines methods for interacting with the users backend.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Returns all users
        /// </summary>
        Task<IEnumerable<User>> GetAsync();

        /// <summary>
        /// Returns all users with a data field matching the start of the given string.
        /// </summary>
        Task<IEnumerable<User>> GetAsync(string search);

        /// <summary>
        /// Returns the user with the given id. 
        /// </summary>
        Task<User> GetAsync(Guid id);

        /// <summary>
        /// Adds a new user if the user does not exist, updates the 
        /// existing user otherwise.
        /// </summary>
        Task<User> UpsertAsync(User user);

        /// <summary>
        /// Deletes a user.
        /// </summary>
        Task DeleteAsync(Guid userId);
    }
}
