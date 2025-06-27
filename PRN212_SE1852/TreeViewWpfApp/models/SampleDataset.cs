using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input.Manipulations;

namespace TreeViewWpfApp.models
{
    public class SampleDataset
    {
        public static Dictionary<int, Category> GenerateDataset()
        {
            Dictionary<int, Category> categories = new Dictionary<int, Category>();
            Category c1 = new Category();
            c1.Id = 2;
            c1.Name = "Laptop";

            Category c2 = new Category();
            c2.Id = 3;
            c2.Name = "Laptop2";

            Category c3 = new Category();
            c3.Id = 4;
            c3.Name = "Laptop3";


            categories.Add(c1.Id, c1);
            categories.Add(c2.Id, c2);
            categories.Add(c3.Id, c3);

            return categories;

            Dictionary<int,Product> products = new Dictionary<int,Product>();
            Product p1 = new Product();
            

        }
    }
}
