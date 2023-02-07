using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipStoreApp.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        [ForeignKey("Order")]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        [ForeignKey("Product")]
        [Column(Order = 2)]
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
