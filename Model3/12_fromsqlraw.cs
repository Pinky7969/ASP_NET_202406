using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

var query = context.Employees.FromSqlRaw("select * from employees");
foreach (var item in query)
{
    Console.WriteLine(item.FirstName);
}