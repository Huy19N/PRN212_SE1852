using System.Text;
using OOP3_Extendsionmethod;

Console.OutputEncoding  = Encoding.UTF8;

int n1 = 8;
int n2 = 13;

Console.WriteLine("Sum n1 = " + n1.Sum());
Console.WriteLine("Sum n2 = "+n2.Sum());

int[] M = new int[n1];
M.Random();
Console.WriteLine("Mang truoc khi sap xep");
M.Array();
M.Sortincrease();
Console.WriteLine("Mang sau khi sap xep");
M.Array();