using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class OrderDetailServices : IOrderDetailServices
    {
        private readonly IOderDetailRepositories oderDetailRepositories;

        public OrderDetailServices()
        {
            oderDetailRepositories = new OrderDetailRepositories();
        }
        public bool DeleteOrderDetail(int id)
        {
            return oderDetailRepositories.DeleteOrderDetail(id);
        }

        public List<OrderDetail> GetAllOrderDetail()
        {
            return oderDetailRepositories.GetAllOrderDetail();
        }

        public void InitializeDataset()
        {
            oderDetailRepositories.InitializeDataset();
        }

        public bool SaveOrderDetail(OrderDetail od)
        {
            return oderDetailRepositories.SaveOrderDetail(od);
        }

        public bool UpdateOrderDetail(OrderDetail od)
        {
            return oderDetailRepositories.UpdateOrderDetail(od);
        }

        public int GetNextOrderID()
        {
            var orders = GetAllOrderDetail();
            return orders.Count == 0 ? 1 : orders.Max(o => o.OrderID) + 1;
        }
    }
}
