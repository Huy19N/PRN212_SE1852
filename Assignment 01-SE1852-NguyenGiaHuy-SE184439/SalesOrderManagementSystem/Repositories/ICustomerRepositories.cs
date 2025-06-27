using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface ICustomerRepositories
    {
        public List<Customer> GetCustomerList();

        public void InitializeDataset();
        public bool SaveCustomer(Customer cus);
        public bool UpdateCustomer(Customer cus);
        public bool DeleteCustomer(int id);
    }
}
