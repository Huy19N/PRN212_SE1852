using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Services
{
    public interface IOrderServices
    {
        public List<Order> GetAllOrders();

        public void InitializeDataset();
        public bool SaveOrder(Order o);
        public bool UpdateOrder(Order o);
        public bool DeleteOrder(int id);
    }
}
