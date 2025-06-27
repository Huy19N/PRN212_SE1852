using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class CustomerRepositories : ICustomerRepositories
    {
        CustomerDAO customerdao = new CustomerDAO();
        public bool DeleteCustomer(int id)
        {
            return customerdao.DeleteCustomer(id);
        }

        public List<Customer> GetCustomerList()
        {
            return customerdao.GetCustomerList();
        }

        public void InitializeDataset()
        {
            customerdao.InitializeDataset();
        }

        public bool SaveCustomer(Customer cus)
        {
            return customerdao.SaveCustomer(cus);
        }

        public bool UpdateCustomer(Customer cus)
        {
            return customerdao.UpdateCustomer(cus);
        }
    }
}
