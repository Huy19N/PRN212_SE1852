using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int[] arr = { 21, 232, 43, 43, 243, 243, 24, 32, 432, 4, 134, 325, 46, 547, 65, 753, 64, 643, 64, 8653, 45, 246, 6436, 44, 65463, 86526, 46, 467, 4, 626, 75, 65247, 5327, 26, 437, 637, 437 };
var even_list = arr.Where(x => x %  2 == 0);

Console.WriteLine("Danh sách các số chẵn : ");
foreach (var x in even_list) Console.WriteLine(x);
var even_list2 = from x in arr 
                 where x % 2 == 0
                 select x;
Console.WriteLine("\n Danh sách các số chắn thei Query Sysntax ");
foreach (var y in even_list2) Console.WriteLine(y);

// Sort array increase and not increase use method and Query Syntax

var list_asc = arr.OrderBy(x => x);

var list_asc2 = from x in arr
                orderby x
                select x;

var list_desc = from x in arr
                orderby x descending
                select x;

var list_desc2 = arr.OrderDescending;
                