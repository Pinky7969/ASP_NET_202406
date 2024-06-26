using Microsoft.EntityFrameworkCore;
using Model3.Models;

using var context = new NorthwindContext();

int id = 7;
string desciption = "Region 7";
var cnt = context.Database.ExecuteSqlInterpolated($"exec AddRegion @regionid={id}, @regiondescription={desciption}");
Console.WriteLine("cnt: " + cnt);

foreach (var item in context.Regions.AsNoTracking())
{
    Console.WriteLine((item.RegionId, item.RegionDescription.Trim()));
}
