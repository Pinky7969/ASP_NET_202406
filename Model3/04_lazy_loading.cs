using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

var query = from c in context.Customers
            where c.CustomerId == "ALFKI"
            select c;


//var query = from c in context.Customers
//            where c.CustomerId == "ALFKI"
//            select new { c.CustomerId, c.CompanyName, c.Orders };


foreach (var item in query)
{
    Console.WriteLine((item.CustomerId, item.CompanyName));

    foreach (var order in item.Orders)
    {
        Console.WriteLine($"\t{order.OrderId} {order.OrderDate:d}");
    }

}