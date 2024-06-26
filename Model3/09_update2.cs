using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

context.Update(new Region { RegionId = 5, RegionDescription = "abc" });
context.SaveChanges();

foreach (var item in context.Regions.AsNoTracking())
{
    Console.WriteLine((item.RegionId, item.RegionDescription.Trim()));
}