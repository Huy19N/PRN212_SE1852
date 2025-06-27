using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class CategoryRepositories : ICategoryRepositories
    {
        CategoryDAO categorydao = new CategoryDAO();
        public bool DeleteCategory(int id)
        {
            return categorydao.DeleteCategory(id);
        }

        public List<Category> GetAllCategory()
        {
            return categorydao.GetAllCategory();
        }

        public void InitializeDataset()
        {
            categorydao.InitializeDataset();
        }

        public bool SaveCategory(Category ca)
        {
            return categorydao.SaveCategory(ca);
        }

        public bool UpdateCategory(Category ca)
        {
            return categorydao.UpdateCategory(ca);
        }
    }
}
