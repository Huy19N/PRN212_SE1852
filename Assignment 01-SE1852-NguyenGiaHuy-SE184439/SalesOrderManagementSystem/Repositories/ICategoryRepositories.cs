using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface ICategoryRepositories
    {
        public List<Category> GetAllCategory();
        public bool SaveCategory(Category ca);
        public bool UpdateCategory(Category ca);

        public void InitializeDataset();
        public bool DeleteCategory(int id);
    }
}
