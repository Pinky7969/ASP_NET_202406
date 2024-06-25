string[] names = ["Mary", "Cindy", "Amy", "Janet", "Alice"];

var query = from name in names
            orderby name
            group name by name[0] into temp
            orderby temp.Key
            select temp;

foreach (var group in query)
{
    Console.WriteLine(group.Key);
    foreach (var name in group)
    {
        Console.WriteLine("\t"+name);
    }
}