using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        static List<Customer> customers = new List<Customer>();

        public void InitializeDataset()
        {
            customers.Add(new Customer { CustomerID = 1, CompanyName = "Apple", ContactName = "Alice Nguyen", ContactTitle = "Manager", Address = "123 PhamVanDong st, HCM city", Phone = "12345678"});
            customers.Add(new Customer { CustomerID = 2, CompanyName = "Samsung", ContactName = "Timcook Nguyen", ContactTitle = "CEO", Address = "123 NguyenTrai st, HCM city", Phone = "888888888" });
            customers.Add(new Customer { CustomerID = 3, CompanyName = "VinFast", ContactName = "PhanNhatVuong", ContactTitle = "Owner", Address = "Erling Skakkes gate 78", Phone = "07989235" } );
        }

        public List<Customer> GetCustomerList()
        {
            return customers;
        }

        public bool SaveCustomer(Customer cus)
        {
            Customer oldCust = customers.FirstOrDefault(x => x.CustomerID == cus.CustomerID);
            if (oldCust != null) return false;
            customers.Add(cus);
            return true;
        }

        public bool UpdateCustomer(Customer cus)
        {
            Customer oldCust = customers.FirstOrDefault(x => x.CustomerID == cus.CustomerID);
            if (oldCust == null) return false;
            oldCust.ContactName = cus.ContactName;
            oldCust.ContactTitle = cus.ContactTitle;
            oldCust.CompanyName = cus.CompanyName;
            oldCust.Address = cus.Address;
            oldCust.Phone = cus.Phone;
            return true;
        }

        public bool DeleteCustomer(int id)
        {
            Customer oldCust = customers.FirstOrDefault(x => x.CustomerID == id);
            if (oldCust == null) return false;
            customers.Remove(oldCust);
            return true;
        }
    }
}
