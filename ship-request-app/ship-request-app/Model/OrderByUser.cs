using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship_request_app.Model
{
    public class OrderByUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public DateTime OrderPlaced
        {
            get; set;
        }
    }
}
