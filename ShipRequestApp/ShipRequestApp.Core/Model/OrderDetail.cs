using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipRequestApp.Core.Model
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public string ProductName { get; set; }
    }
}
