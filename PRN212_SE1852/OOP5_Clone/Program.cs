using System.Net.NetworkInformation;
using OOP5_Clone;

Customer c1 = new Customer();

Products p1 = new Products() { id = 1, name="Protein", quality= 19, price = 90 };
Products p2 = new Products() { id = 2, name = "Cacbon", quality = 1, price = 100 };

p1 = p2;

p2.name = "H2SO4";
p2.price = 200;

Console.WriteLine(p1);


Products p3 = new Products() { id = 3, name = "Hidro", quality = 43, price = 940 };
Products p4 = new Products() { id = 4, name = "Natri", quality = 11, price = 490 };
Products p5 = new Products() { id = 5, name = "Crom", quality = 40, price = 290 };


p5 = p3;
p3 = p4;

Products p6 = new Products() { id = 6, name = "Canxi", quality = 129, price = 590 };
Products p7 = p6.clone();

Console.WriteLine("----p6----\n"+p6);
Console.WriteLine("----p7-----\n"+p7);

p7.name = "Cacbonnat";
Console.WriteLine("-----p6------\n"+p6);


