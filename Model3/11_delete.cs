using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

int id = 5;
var region = context.Find<Region>(id);
if (region != null)
{
    context.Remove(region);
    context.SaveChanges();
}
foreach (var item in context.Regions.AsNoTracking())
{
    Console.WriteLine((item.RegionId, item.RegionDescription.Trim()));
}