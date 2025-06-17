using OOP4_Dictionary;

Category c = new Category();
c.Id = 1;
c.Name = "Laptop";  

Product p1 = new Product() { Id = 1, Name = "Dell", Quality = 10, Price = 1000 };
Product p2 = new Product() { Id = 2, Name = "HP", Quality = 20, Price = 1200 };
Product p3 = new Product() { Id = 3, Name = "Lenovo", Quality = 30, Price = 1500 };
Product p4 = new Product() { Id = 4, Name = "Gigabyte", Quality = 20, Price = 1500 };

c.AddProduct(p1);
c.AddProduct(p2);
c.AddProduct(p3);
c.AddProduct(p4);

Console.WriteLine("List of products : ");
Console.WriteLine("Id\tName\tQuality\tPrice");
c.PrintAllProducts();
Console.WriteLine("=====================================");

Console.WriteLine("Please you enter ID product for search : ");
int pid = int.Parse(Console.ReadLine()!);
Product p = c.GetProduct(pid);
if(p == null)
{
  Console.WriteLine("Product not found!");
}
else
{
    Console.WriteLine("Product found : {0}",p.Id);
    Console.WriteLine(p.ToString());
}

Console.WriteLine("-List product before sort: ");
c.PrintAllProducts();
Dictionary<int, Product> sortedProduct = c.ComplexSort();
Console.WriteLine("- List product after sort: ");
foreach (KeyValuePair<int,Product> item in sortedProduct)
{
    Product product = item.Value;
    Console.WriteLine(product.ToString());
}

Product px = new Product() { Id = 5, Name = "Asus", Quality = 50, Price = 2000 };
c.AddProduct(px);
c.PrintAllProducts();


int pid_remove = 2;
c.RemoveProduct(pid_remove);
Console.WriteLine("List of products after removing: ");
c.PrintAllProducts();

Console.ReadKey();