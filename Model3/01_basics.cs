using Model3.Models;

using var context = new NorthwindContext();

var query = from e in context.Employees
            where e.City == "London"
            select new { e.FirstName, e.City };
//select e;

foreach (var item in query)
{
    Console.WriteLine((item.FirstName, item.City));
}