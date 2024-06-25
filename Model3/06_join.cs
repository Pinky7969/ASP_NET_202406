using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

var query = from o in context.Orders
            join c in context.Customers on o.CustomerId equals c.CustomerId
            where o.CustomerId == "ALFKI"
            select new { o.OrderId, c.CompanyName, o.OrderDate };

foreach (var item in query)
{
    Console.WriteLine((item.OrderId, item.CompanyName, item.OrderDate?.ToShortDateString()));
}
