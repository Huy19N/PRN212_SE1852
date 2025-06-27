using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepositories categoryRepositories;

        public CategoryServices()
        {
            categoryRepositories = new CategoryRepositories();
        }
        public bool DeleteCategory(int id)
        {
            return categoryRepositories.DeleteCategory(id);
        }

        public List<Category> GetAllCategory()
        {
            return categoryRepositories.GetAllCategory();
        }

        public void InitializeDataset()
        {
            categoryRepositories.InitializeDataset();
        }

        public bool SaveCategory(Category ca)
        {
            return categoryRepositories.SaveCategory(ca);
        }

        public bool UpdateCategory(Category ca)
        {
            return categoryRepositories.UpdateCategory(ca);
        }
    }
}
