using DemoLNQToObject2;
using System.Text;
ListProduct lp = new ListProduct();
lp.gen_sample_products();
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Danh sách sản phẩm: ");
lp.print();
Console.WriteLine("\nDanh sách sản phẩm có giá từ 500 đến 1000: ");
lp.FilterProductByPrice(500, 1000);
Console.WriteLine("\nDanh sách sản phẩm có giá từ 500 đến 1000 theo Query Syntax: ");
lp.FilterProductByPriceAsc(500, 1000);

