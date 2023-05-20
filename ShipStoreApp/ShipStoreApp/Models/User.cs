using ShipStoreApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipStoreApp.Models
{
    public class User
    {
        public User()
        {
            Orders = new List<Order>();
        }
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Enter a grade.")]
        public Grade Grade { get; set; }

        [Required(ErrorMessage ="Enter your first name.")]
        [StringLength(50, ErrorMessage ="First name cant be longer than 50 characterrs.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your last name.")]
        [StringLength(50, ErrorMessage = "Last name cant be longer than 50 characterrs.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your email address.")]
        [StringLength(100, ErrorMessage = "Email address cant be longer than 100 characterrs.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Enter your building number.")]
        public int BuildingNumber { get; set; }


        [Required(ErrorMessage ="Enter your apartment number.")]
        [StringLength(5, ErrorMessage ="Number can't be longer than 5 characters.")]
        public string ApartmentNumber { get; set; }
        public List<Order> Orders { get; set; }
    }
}
