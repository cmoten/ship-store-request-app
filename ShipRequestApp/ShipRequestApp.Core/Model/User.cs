using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRequestApp.Core.Model
{
    public class User : DbObject, IEquatable<User>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Building { get; set; }
        public string ApartmentNumber { get; set; }

        /// <summary>
        /// Returns the user's name.
        /// </summary>
        public override string ToString() => $"{FirstName} {LastName}";

        public bool Equals(User? other) =>

            FirstName == other.FirstName &&
            LastName == other.LastName &&
            Email == other.Email &&
            Password == other.Password &&
            Building == other.Building &&
            ApartmentNumber == other.ApartmentNumber;

        
    }
}
