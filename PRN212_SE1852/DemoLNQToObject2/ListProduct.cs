using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLNQToObject2
{
    public class ListProduct
    {
        List<Products> products;
        public ListProduct()
        {
            products = new List<Products>();
        }

        public void gen_sample_products()
        {
            products.Add(new Products { id = 1, name = "Iphone 14 Pro Max", quality = 10, price = 3000 });
            products.Add(new Products { id = 2, name = "Iphone 14 Pro", quality = 20, price = 2000 });
            products.Add(new Products { id = 3, name = "Iphone 14", quality = 30, price = 1000 });
            products.Add(new Products { id = 4, name = "Iphone 13 Pro Max", quality = 40, price = 800 });
            products.Add(new Products { id = 5, name = "Iphone 13 Pro", quality = 50, price = 600 });
            products.Add(new Products { id = 6, name = "Iphone 13", quality = 60, price = 500 });
        }

        public void print()
        {
            products.ForEach(p => Console.WriteLine(p));
        }

        public void FilterProductByPrice(double price1, double price2)
        {
            var results = products.Where(p => p.price >= price1 && p.price <= price2).ToList();
            results.ToList().ForEach(p => Console.WriteLine(p));
        }

        public void FilterProductByPriceAsc(double price1, double price2)
        {
            var results = from p in products
                          where p.price >= price1 && p.price <= price2
                          orderby p.price ascending
                          select p;
            results.ToList().ForEach(p => Console.WriteLine(p));
        }

        public void FillterProductByPriceDesc(double price1, double price2)
        {
            var results = from p in products
                          where p.price >= price1 && p.price <= price2
                          orderby p.price descending
                          select p;
            results.ToList().ForEach(p => Console.WriteLine(p));
        }

        public void FillerProductByQuality(int quality1, int quality2)
        {
            var results = from p in products
                          where p.quality >= quality1 && p.quality <= quality2
                          select new { p.id, p.name };
            foreach (var item in results) Console.WriteLine($"{item.id}\t {item.name}");
        }
    }
}
