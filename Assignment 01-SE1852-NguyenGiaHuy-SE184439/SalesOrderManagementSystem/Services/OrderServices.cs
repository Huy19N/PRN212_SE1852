using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderRepositories orderRepositories;

        public OrderServices()
        {
            orderRepositories = new OrderRepositories();
        }
        public bool DeleteOrder(int id)
        {
            return orderRepositories.DeleteOrder(id);
        }

        public List<Order> GetAllOrders()
        {
            return orderRepositories.GetAllOrders();
        }

        public void InitializeDataset()
        {
            orderRepositories.InitializeDataset();
        }

        public bool SaveOrder(Order o)
        {
            return orderRepositories.SaveOrder(o);
        }

        public bool UpdateOrder(Order o)
        {
            return orderRepositories.UpdateOrder(o);
        }

        public int GetNextOrderID()
        {
            var orders = GetAllOrders();
            return orders.Count == 0 ? 1 : orders.Max(o => o.OrderID) + 1;
        }
    }
}
