using DemoMyStoreLINQ25QL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = "server=JAHWI;database=MyStore;uid=sa;pwd=12345";
MystoreDataContext context = new MystoreDataContext(connectionString);

var categorires = context.Categories;
//foreach(var c in categorires)
//{
//    Console.WriteLine(c.CategoryID + "\t" + c.CategoryName);
//} 

//Q2
//int categoryId = 8;
//Category category = context.Categories.FirstOrDefault(c => c.CategoryID == categoryId);
//if(category == null)
//{
//    Console.WriteLine("Not found category with id category: " + categoryId);
//}
//else
//{
//    Console.WriteLine("found category with id category: "+ categoryId);
//    Console.WriteLine(category.CategoryID + "\t" + category.CategoryName);
//}

//Q3
//Category cnew = new Category();
//cnew.CategoryName = "Ung Thu";
//context.Categories.InsertOnSubmit(cnew);
//context.SubmitChanges();

//Q4

//List<Category> list_new = new List<Category>();
//list_new.Add(new Category() { CategoryName = "Laptop" });
//list_new.Add(new Category() { CategoryName = "TV" });
//list_new.Add(new Category() { CategoryName = "Broad" });
//list_new.Add(new Category() { CategoryName = "Table" });
//context.Categories.InsertAllOnSubmit(list_new);
//context.SubmitChanges();

//Q5
//Category c = (from x in context.Categories
//              where x.CategoryID == 8
//              select x).FirstOrDefault();

//Category c2 = context.Categories.FirstOrDefault(x => x.CategoryID == 8);
//if (c2 != null)
//{
//    c2.CategoryName = "HealthFood";
//    context.SubmitChanges();
//}

//Q6

//Category c3 = context.Categories.FirstOrDefault(x => x.CategoryID == 10);
//if (c3 != null)
//{
//    context.Categories.DeleteOnSubmit(c3);
//    context.SubmitChanges();
//}

//Q7

var products = context.Products;

var p = from x in products
        join y in categorires on x.CategoryID equals y.CategoryID
        where x.CategoryID == null
        select x;
if(p != null)
{

    context.Categories.DeleteOnSubmit(p);
    context.SubmitChanges();
}
        
Console.WriteLine(p);