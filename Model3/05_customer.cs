using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

var query = from o in context.Orders
            where o.CustomerId == "ALFKI"
            select o;

foreach (var order in query)
{
    Console.WriteLine((order.OrderId, order.Customer.CompanyName, order.OrderDate));
}
