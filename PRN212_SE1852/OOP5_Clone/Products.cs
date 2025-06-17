using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Clone
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return $"{id}\t {name}\t {quality}\t {price}";
        }

        public Products clone()
        {
            return MemberwiseClone() as Products ;
        }
    }
}


