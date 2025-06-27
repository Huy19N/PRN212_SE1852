using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();

        public void InitializeDataset()
        {
            products.Add(new Product { Id = 1, Name = "Laptop", Quantity = 10, Price = 999.99 });
            products.Add(new Product { Id = 2, Name = "Smartphone", Quantity = 20, Price = 499.99 });
            products.Add(new Product { Id = 3, Name = "Tablet", Quantity = 15, Price = 299.99 });
            products.Add(new Product { Id = 4, Name = "Smartwatch", Quantity = 30, Price = 199.99 });
            products.Add(new Product { Id = 5, Name = "Headphones", Quantity = 25, Price = 89.99 });
            products.Add(new Product { Id = 6, Name = "Bluetooth Speaker", Quantity = 18, Price = 59.99 });
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public bool SaveProduct(Product p)
        {
            Product p2 = products.FirstOrDefault(x => x.Id == p.Id);
            if (p2 != null) return false;

            products.Add(p2);
            return true;

        }


        public bool UpdateProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old == null) return false;
            old.Name = p.Name;
            old.Quantity = p.Quantity;
            old.Price = p.Price;
            return true;
        }

        public bool DeleteProduct(int id)
        {
            Product old = products.FirstOrDefault(x => x.Id == id);
            if (old == null) return false;

            products.Remove(old);
            return true;  
        }

    }
}
