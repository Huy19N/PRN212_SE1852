﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public int Total { get; set; }
    }
}
