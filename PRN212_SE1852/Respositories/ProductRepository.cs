using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Respositories
{
    public class ProductRepository : IProductResository
    {
        ProductDAO productDAO = new ProductDAO();
        public List<Product> GetAllProducts()
        {
            return productDAO.GetAllProducts();
        }

        public void InitializeDataset()
        {
            productDAO.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return productDAO.SaveProduct(p);
            
        }

        public bool UpdateProduct(Product p)
        {
            return productDAO.UpdateProduct(p);
        }

        public bool DeleteProduct(int id)
        {
            return productDAO.DeleteProduct(id);
        }
    }
}
