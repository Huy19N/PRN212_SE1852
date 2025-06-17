using System.Text;
using LucyDemoLNQ2SQL;

Console.OutputEncoding = Encoding.UTF8;

string connectionString = "server=JAHWI;database=Lucy_SalesData;uid=sa;pwd=12345";
lucysaledata123DataContext context = new lucysaledata123DataContext(connectionString);


var ds = (from c in context.Customers
          join o in context.Orders on c.CustomerID equals o.CustomerID
          join od in context.Order_Details on o.OrderID equals od.OrderID)

