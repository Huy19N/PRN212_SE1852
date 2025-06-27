using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepositories employeeRepositories;

        public EmployeeServices()
        {
            employeeRepositories = new EmployeeRepositories();
        }
        public bool DeleteEmployees(int id)
        {
            return employeeRepositories.DeleteEmployees(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeRepositories.GetAllEmployees();
        }

        public void InitializeDataset()
        {
            employeeRepositories.InitializeDataset();
        }

        public bool SaveEmployees(Employee e)
        {
            return employeeRepositories.SaveEmployees(e);
        }

        public bool UpdateEmpoyees(Employee e)
        {
            return employeeRepositories.UpdateEmpoyees(e);
        }
    }
}
