using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepositories customerRepositories;

        public CustomerServices()
        {
            customerRepositories = new CustomerRepositories();
        }
        public bool DeleteCustomer(int id)
        {
            return customerRepositories.DeleteCustomer(id);
        }

        public List<Customer> GetCustomerList()
        {
            return customerRepositories.GetCustomerList();
        }

        public void InitializeDataset()
        {
            customerRepositories.InitializeDataset();
        }

        public bool SaveCustomer(Customer cus)
        {
            return customerRepositories.SaveCustomer(cus);
        }

        public bool UpdateCustomer(Customer cus)
        {
            return customerRepositories.UpdateCustomer(cus);
        }
    }
}
