using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class EmployeeRepositories : IEmployeeRepositories
    {
        EmployeeDAO employeedao = new EmployeeDAO();
        public bool DeleteEmployees(int id)
        {
            return employeedao.DeleteEmployees(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeedao.GetAllEmployees();
        }

        public void InitializeDataset()
        {
            employeedao.InitializeDataset();
        }
        public bool SaveEmployees(Employee e)
        {
            return employeedao.SaveEmployees(e);
        }

        public bool UpdateEmpoyees(Employee e)
        {
            return employeedao.UpdateEmpoyees(e);
        }
    }
}
