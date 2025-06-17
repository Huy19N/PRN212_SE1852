using OOP2;
using OOP2_Rreuse_as_Library;

FulltimeEmployee huy = new FulltimeEmployee() { Id = 8, Name = "Huy", Birthday = new DateTime(2004, 01, 19) };
Console.WriteLine(huy.calSalary());
Console.WriteLine($"Huy's age: {huy.TinhTuoi()}");