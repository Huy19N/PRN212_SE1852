using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface IEmployeeRepositories
    {
        public List<Employee> GetAllEmployees();
        public void InitializeDataset();
        public bool SaveEmployees(Employee e);
        public bool UpdateEmpoyees(Employee e);
        public bool DeleteEmployees(int id);
    }
}
