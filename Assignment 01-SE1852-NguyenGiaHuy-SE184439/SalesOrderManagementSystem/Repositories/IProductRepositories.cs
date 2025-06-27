using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface IProductRepositories
    {
        public List<Product> GetALlProducts();

        public void InitializeDataset();
        public bool SaveAllProduct(Product p);
        public bool UpdateProduct(Product p);
        public bool DeleteProducts(int id);
    }
}
