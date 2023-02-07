using ShipStoreApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipStoreApp.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public Category Category { get; set; } 
        public string ImageUrl { get; set; }
    }
}
