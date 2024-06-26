using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

/*
前面的查詢一定要加 .AsNoTracking()，不然會發生 Exception:
The instance of entity type 'Region' cannot be tracked because another instance with the same key value for {'RegionId'} is already being tracked.
 */
foreach (var item in context.Regions.AsNoTracking())
{
    Console.WriteLine((item.RegionId, item.RegionDescription.Trim()));
}

context.Update(new Region { RegionId = 5, RegionDescription = "efg" });
context.SaveChanges();

foreach (var item in context.Regions.AsNoTracking())
{
    Console.WriteLine((item.RegionId, item.RegionDescription.Trim()));
}