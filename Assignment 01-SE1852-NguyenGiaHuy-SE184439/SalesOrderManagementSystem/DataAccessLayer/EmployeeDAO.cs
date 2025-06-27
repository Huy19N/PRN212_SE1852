using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class EmployeeDAO
    {
        static List<Employee> employees = new List<Employee>();

        public void InitializeDataset()
        {
            employees.Add(new Employee { EmployeeID = 1, Name = "Davolio", UserName = "Admin", Password = "123", JobTitle = "Sales Representative" });
            employees.Add(new Employee { EmployeeID = 2, Name = "Fuller", UserName = "Andrew", Password = "456", JobTitle = "Vice President, Sales" });
            employees.Add(new Employee { EmployeeID = 3, Name = "Leverling", UserName = "Janet", Password = "789", JobTitle = "Sales Representative" });
        }

        public List<Employee> GetAllEmployees() { return employees; }

        public bool SaveEmployees(Employee e)
        {
            Employee oldEmp = employees.FirstOrDefault(x => x.EmployeeID == e.EmployeeID);
            if (oldEmp != null) return false;
            employees.Add(e);
            return true;
        }

        public bool UpdateEmpoyees(Employee e)
        {
            Employee oldEmp = employees.FirstOrDefault(x => x.EmployeeID == e.EmployeeID);
            if (oldEmp == null) return false;
            oldEmp.Name = e.Name;
            oldEmp.UserName = e.UserName;
            oldEmp.Password = e.Password;
            oldEmp.JobTitle = e.JobTitle;
            return true;
        }

        public bool DeleteEmployees(int id)
        {
            Employee oldEmp = employees.FirstOrDefault(x => x.EmployeeID == id);
            if (oldEmp == null) return false;
            employees.Remove(oldEmp);
            return true;
        }
    }
}
