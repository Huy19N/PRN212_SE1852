/*
 * Ung dung Generic Collection de quan ly Employee
 * Cac thao tac CRud
 * C-Create: Them moi Employee
 * R-Read: Doc danh sach Employee
 * U-Update: Cap nhat thong tin Employee
 * D-Delete: Xoa Employee
 */

using System.Text;
using OOP2;

List<Employee> employees = new List<Employee>();
FulltimeEmployee huy = new FulltimeEmployee() { Id = 8, Name = "Huy", Birthday = new DateTime(2004, 01, 19) };
employees.Add(huy);
FulltimeEmployee phuc = new FulltimeEmployee() { Id = 9, Name = "Phuc", Birthday = new DateTime(2005, 05, 10) };
employees.Add(phuc);
FulltimeEmployee thang = new FulltimeEmployee() { Id = 10, Name = "Thang", Birthday = new DateTime(2002, 12, 20) };
employees.Add(thang);
ParttimeEmployee Thuan = new ParttimeEmployee() { Id = 11, Name = "Thuan", Birthday = new DateTime(2000, 08, 19) };
employees.Add(Thuan);

//Q2: Xuat toan bo thong tin nhan su
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Danh sach nhan su:");
employees.ForEach(e => Console.WriteLine(e));
Console.WriteLine("=========================================");
foreach (var employee in employees)
{
    Console.WriteLine(employee);
}
//Q3 : Sap xep nha su theo nam sinh
// Cung la R-read
for (int i = 0; i < employees.Count; i++)
{
    for(int j = i + 1; j < employees.Count; j++)
    {
        Employee e1 = employees[i];
        Employee e2 = employees[j];
        if(e1.Birthday < e2.Birthday)
        {
            // Hoan vi
            employees[i] = e2;
            employees[j] = e1;
        }
    }
}