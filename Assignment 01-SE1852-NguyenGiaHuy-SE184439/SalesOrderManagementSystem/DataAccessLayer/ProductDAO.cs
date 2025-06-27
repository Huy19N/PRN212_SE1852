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
            products.Add(new Product { ProductID = 1, ProductName = "Asus", CategoryID = 1, UnitsInStock = 8, UnitPrice = 2000 });
            products.Add(new Product { ProductID = 2, ProductName = "Iphone", CategoryID = 2, UnitsInStock = 10, UnitPrice = 1000 });
            products.Add(new Product { ProductID = 3, ProductName = "Sony", CategoryID = 3, UnitsInStock = 13, UnitPrice = 999 });
        }

        public List<Product> GetALlProducts() { return products; }

        public bool SaveAllProduct(Product p)
        {
            Product oldPro = products.FirstOrDefault(x => x.ProductID == p.ProductID);
            if (oldPro != null) return false;
            products.Add(p);
            return true;
        }

        public bool UpdateProduct(Product p)
        {
            Product oldPro = products.FirstOrDefault(x => x.ProductID == p.ProductID);
            if (oldPro == null) return false;
            oldPro.ProductName = p.ProductName;
            oldPro.UnitsInStock = p.UnitsInStock;
            oldPro.UnitPrice = p.UnitPrice;
            return true;
        }

        public bool DeleteProducts(int id)
        {
            Product oldPro = products.FirstOrDefault(x => x.ProductID == id);
            if (oldPro == null) return false;
            products.Remove(oldPro);
            return true;
        }
    }
}
