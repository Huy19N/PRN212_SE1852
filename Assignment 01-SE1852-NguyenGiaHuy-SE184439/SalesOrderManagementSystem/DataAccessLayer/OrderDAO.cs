using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class OrderDAO
    {
        static List<Order> orders = new List<Order>();

        public void InitializeDataset()
        {
            orders.Add(new Order { OrderID = 1, CustomerID = 1, EmployeeID = 1, OrderDate = new DateTime(2025,6,26) });
            orders.Add(new Order { OrderID = 2, CustomerID = 2, EmployeeID = 2, OrderDate = new DateTime(2022,02,22) } );
            orders.Add(new Order { OrderID = 3, CustomerID = 3, EmployeeID = 3, OrderDate = new DateTime(2023,03,23) });
        }

        public List<Order> GetAllOrders() { return orders; }

        public bool SaveOrder(Order o)
        {
            Order oldorder = orders.FirstOrDefault(x => x.OrderID == o.OrderID);
            if (oldorder != null) return false;
            orders.Add(o);
            return true;
        }

        public bool UpdateOrder(Order o)
        {
            Order oldOrder = orders.FirstOrDefault(x => x.OrderID == o.OrderID);
            if (oldOrder == null) return false;
            oldOrder.OrderDate = o.OrderDate;
            return true;
        }

        public bool DeleteOrder(int id)
        {
            Order oldOrder = orders.FirstOrDefault(x => x.OrderID == id);
            if (oldOrder == null) return false;
            orders.Remove(oldOrder);
            return true;
        }
    }
}
