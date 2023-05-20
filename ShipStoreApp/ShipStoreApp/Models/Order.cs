﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipStoreApp.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
