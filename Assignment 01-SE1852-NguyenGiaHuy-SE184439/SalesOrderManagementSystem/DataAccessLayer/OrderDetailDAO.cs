using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class OrderDetailDAO
    {
        static List<OrderDetail> orders = new List<OrderDetail>();

        public void InitializeDataset()
        {
            orders.Add(new OrderDetail { OrderID = 1, ProductID = 1, Quantity = 10, UnitPrice = 1000, Discount = 20 });
            orders.Add(new OrderDetail { OrderID = 2, ProductID = 2, Quantity = 18, UnitPrice = 999, Discount = 10 });
            orders.Add(new OrderDetail { OrderID = 3, ProductID = 3, Quantity = 20, UnitPrice = 888, Discount = 50 });
        }

        public List<OrderDetail> GetAllOrderDetail() { return orders; }

        public bool SaveOrderDetail(OrderDetail od)
        {
            OrderDetail oldorder = orders.FirstOrDefault(x => x.OrderID == od.OrderID);
            if (oldorder != null) return false;
            orders.Add(od);
            return true;
        }

        public bool UpdateOrderDetail(OrderDetail od)
        {
            OrderDetail oldOrder = orders.FirstOrDefault(x => x.OrderID == od.OrderID);
            if (oldOrder == null) return false;
            oldOrder.Quantity = od.Quantity;
            oldOrder.UnitPrice = od.UnitPrice;
            oldOrder.Discount = od.Discount;
            return true;
        }

        public bool DeleteOrderDetail(int id)
        {
            OrderDetail oldOrder = orders.FirstOrDefault(x => x.OrderID == id);
            if (oldOrder == null) return false;
            orders.Remove(oldOrder);
            return true;
        }
    }
}
