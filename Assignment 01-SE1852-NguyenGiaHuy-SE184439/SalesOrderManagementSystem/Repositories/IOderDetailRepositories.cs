using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface IOderDetailRepositories
    {
        public List<OrderDetail> GetAllOrderDetail();

        public void InitializeDataset();
        public bool SaveOrderDetail(OrderDetail od);
        public bool UpdateOrderDetail(OrderDetail od);
        public bool DeleteOrderDetail(int id);
    }
}
