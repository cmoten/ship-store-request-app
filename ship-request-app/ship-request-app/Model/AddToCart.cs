using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship_request_app.Model
{
    public class AddToCart
    {
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
