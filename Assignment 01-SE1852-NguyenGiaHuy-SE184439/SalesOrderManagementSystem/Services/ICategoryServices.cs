using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Services
{
    public interface ICategoryServices
    {
        public List<Category> GetAllCategory();

        public void InitializeDataset();
        public bool SaveCategory(Category ca);
        public bool UpdateCategory(Category ca);
        public bool DeleteCategory(int id);
    }
}
