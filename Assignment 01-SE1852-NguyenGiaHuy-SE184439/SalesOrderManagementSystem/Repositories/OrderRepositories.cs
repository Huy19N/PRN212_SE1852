using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class OrderRepositories : IOrderRepositories
    {
        OrderDAO orderdao = new OrderDAO();
        public bool DeleteOrder(int id)
        {
            return orderdao.DeleteOrder(id);
        }

        public List<Order> GetAllOrders()
        {
            return orderdao.GetAllOrders();
        }

        public void InitializeDataset()
        {
            orderdao.InitializeDataset();
        }
        public bool SaveOrder(Order o)
        {
            return orderdao.SaveOrder(o);
        }

        public bool UpdateOrder(Order o)
        {
            return orderdao.UpdateOrder(o);
        }
    }
}
