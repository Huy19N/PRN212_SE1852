using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee huy = new FulltimeEmployee() { Id = 1, Name = "huy" };
Console.WriteLine(huy.calSalary());

ParttimeEmployee huy2 = new ParttimeEmployee() { Id = 2, Name = "Huy2", WorkingHour = 8 };
Console.WriteLine(huy2.calSalary());

FulltimeEmployee DonalTrump = new FulltimeEmployee() { Id = 47, Name = "DonalTrump", IdCard = "86", Birthday = new DateTime(1978,01,19) };
Console.WriteLine($"Information DonalTrump: {DonalTrump}");
