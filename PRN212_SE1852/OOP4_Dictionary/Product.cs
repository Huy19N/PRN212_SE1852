﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Dictionary
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quality { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Id}\t {Name}\t {Quality}\t {Price}";
        }
    }
}
