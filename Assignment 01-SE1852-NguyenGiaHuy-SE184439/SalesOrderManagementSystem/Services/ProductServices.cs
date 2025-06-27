using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepositories productRepositories;

        public ProductServices()
        {
            productRepositories = new ProductRepositories();
        }
        public bool DeleteProducts(int id)
        {
            return productRepositories.DeleteProducts(id);
        }

        public List<Product> GetALlProducts()
        {
            return productRepositories.GetALlProducts();
        }

        public void InitializeDataset()
        {
            productRepositories.InitializeDataset();
        }

        public bool SaveAllProduct(Product p)
        {
            return productRepositories.SaveAllProduct(p);
        }

        public bool UpdateProduct(Product p)
        {
            return productRepositories.UpdateProduct(p);
        }
    }
}
