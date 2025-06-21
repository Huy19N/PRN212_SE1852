using System.Collections.Generic;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts() => ProductDAO.GetProducts();
        public void DeleteProduct(Product p) => ProductDAO.DeleteProduct(p);
        public void SaveProduct(Product p) => ProductDAO.SaveProduct(p);
        public void UpdateProduct(Product p) => ProductDAO.UpdateProduct(p);
        public Product GetProductById(int id) => ProductDAO.GetProductById(id);

    }
}
