﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public string CategoryName { get; set; }
    }
}
