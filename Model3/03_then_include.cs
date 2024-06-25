using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

var query = from c in context.Customers
            .Include(c => c.Orders)
            .ThenInclude(o => o.OrderDetails)
            .AsSplitQuery()
            where c.CustomerId == "ALFKI"
            select c;

foreach (var item in query)
{
    Console.WriteLine((item.CustomerId, item.CompanyName));

    foreach (var order in item.Orders)
    {
        Console.WriteLine($"\t{order.OrderId} {order.OrderDate:d}");
        foreach (var detail in order.OrderDetails)
        {
            Console.WriteLine($"\t\t {detail.ProductId} {detail.UnitPrice} {detail.Quantity}");
        }
    }

}