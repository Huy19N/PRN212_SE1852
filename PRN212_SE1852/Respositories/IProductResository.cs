using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Respositories
{
    public interface IProductResository
    {
        public List<Product> GetAllProducts();
        public void InitializeDataset();

        public bool SaveProduct(Product p);
    }
}
