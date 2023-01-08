using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship_request_app.Model
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public int CustomerID { get; set; }
        public int OrderTotal { get; set; }
    }
}
