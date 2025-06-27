using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        ProductDAO productdao = new ProductDAO();
        public bool DeleteProducts(int id)
        {
            return productdao.DeleteProducts(id);
        }

        public List<Product> GetALlProducts()
        {
            return productdao.GetALlProducts();
        }

        public void InitializeDataset()
        {
            productdao.InitializeDataset();
        }
        public bool SaveAllProduct(Product p)
        {
            return productdao.SaveAllProduct(p);
        }

        public bool UpdateProduct(Product p)
        {
            return productdao.UpdateProduct(p);
        }
    }
}
