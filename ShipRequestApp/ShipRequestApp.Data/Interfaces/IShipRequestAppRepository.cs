using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRequestApp.Data.Interfaces
{
    /// <summary>
    /// Defines methods for interacting with the app backend.
    /// </summary>
    public interface IShipRequestAppRepository
    {
        IUserRepository Users { get; }
    }
}
