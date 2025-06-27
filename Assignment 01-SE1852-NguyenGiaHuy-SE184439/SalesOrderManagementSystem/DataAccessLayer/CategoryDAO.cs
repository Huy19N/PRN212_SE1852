using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        static List<Category> categories = new List<Category>();

        public void InitializeDataset()
        {
            categories.Add(new Category { CategoryID = 1, CategoryName = "Laptop", Description="USA"});
            categories.Add(new Category { CategoryID = 2, CategoryName = "SmartPhone", Description = "South Korea" } );
            categories.Add(new Category { CategoryID = 3, CategoryName = "TV", Description = "China" });
        }


        public List<Category> GetAllCategory()
        {
            return categories;
        }

        public bool SaveCategory(Category ca)
        {
            Category oldCate = categories.FirstOrDefault(x => x.CategoryID == ca.CategoryID);
            if (oldCate != null) return false;
            categories.Add (ca);
            return true;
        }

        public bool UpdateCategory(Category ca)
        {
            Category oldCate = categories.FirstOrDefault(x => x.CategoryID == ca.CategoryID);
            if(oldCate == null) return false;
            oldCate.CategoryName = ca.CategoryName;
            oldCate.Description = ca.Description;
            return true;
        }

        public bool DeleteCategory(int id)
        {
            Category oldCate = categories.FirstOrDefault(x => x.CategoryID == id);
            if( oldCate == null ) return false;
            categories.Remove (oldCate);
            return true;
        }
    }
}
