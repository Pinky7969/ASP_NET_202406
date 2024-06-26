using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

int id = 5;
var query = context.Database.SqlQuery<EmployeeView>($"select EmployeeId, FirstName from Employees where employeeId = {id}");
foreach (var item in query)
{
    Console.WriteLine((item.EmployeeId, item.FirstName));
}

public record EmployeeView(int EmployeeId, string FirstName);