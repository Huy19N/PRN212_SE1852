using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            Products = new Dictionary<int, Product>();
        }
        //CRUD
        //New add product 
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id) == false)
            {
                Products.Add(p.Id, p);
            }
        }

        public void PrintAllProducts()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p.ToString());// auto call ToString() method
            }
        }
        // take content by object
        public Product GetProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
            {
                return null;
            }
            return Products[id];

        }

        public Dictionary<int, Product> SortProduct()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }

        public Dictionary<int, Product> ComplexSort()
        {
            return Products
                .OrderBy(item => item.Value.Quality)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();

        }

        public void EditProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
            {
                Console.WriteLine("Product not found!");
                return;
            }
            Products[p.Id] = p;
        }

        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
            {
                return false;
            }
            return Products.Remove(id);
        }

    }
}
