using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRequestApp.Core.Model
{
    public class OrderByUser : DbObject 
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
