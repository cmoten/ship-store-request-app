﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship_request_app_core.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public int OrderDetailId { get; set; }
        public DateTime Date { get; set; }
    }
}
