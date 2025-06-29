using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductRepository;

        public ProductService()
        {
            iProductRepository = new ProductRepository();
        }

        public void DeleteProduct(Product p)
        {
            iProductRepository.DeleteProduct(p);
        }

        public List<Product> GetAllProducts()
        {
            return iProductRepository.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return iProductRepository.GetProductById(id);
        }

        public void SaveProduct(Product p)
        {
            iProductRepository.UpdateProduct(p);
        }

        public void UpdateProduct(Product p)
        {
            iProductRepository.UpdateProduct(p);
        }
    }
}
