using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface IOrderRepositories
    {
        public List<Order> GetAllOrders();

        public void InitializeDataset();
        public bool SaveOrder(Order o);
        public bool UpdateOrder(Order o);
        public bool DeleteOrder(int id);
    }
}
