using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class OrderDetailRepositories : IOderDetailRepositories
    {
        OrderDetailDAO orderdetaildao = new OrderDetailDAO();
        public bool DeleteOrderDetail(int id)
        {
            return orderdetaildao.DeleteOrderDetail(id);
        }

        public List<OrderDetail> GetAllOrderDetail()
        {
            return orderdetaildao.GetAllOrderDetail();
        }

        public void InitializeDataset()
        {
            orderdetaildao.InitializeDataset();
        }
        public bool SaveOrderDetail(OrderDetail od)
        {
            return orderdetaildao.SaveOrderDetail(od);
        }

        public bool UpdateOrderDetail(OrderDetail od)
        {
            return orderdetaildao.UpdateOrderDetail(od);
        }
    }
}
