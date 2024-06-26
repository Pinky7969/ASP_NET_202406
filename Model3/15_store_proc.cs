using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

string id = "ALFKI";

var query = context.Database.SqlQuery<CustOrderHistResult>($"exec CustOrderHist {id}");

foreach (var item in query)
{
    Console.WriteLine((item.ProductName, item.Total));
}
public record CustOrderHistResult(string ProductName, int Total);