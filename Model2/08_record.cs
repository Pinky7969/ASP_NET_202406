List<Category> categories = [
    new(1, "Category1"),
    new(2, "Category2"),
    new(3, "Category3")
];
List<Product> products = [
    new(1, "Product 1", 12, categories[0]),
    new(2, "Product 2", 21, categories[0]),
    new(3, "Product 3", 17, categories[0]),
    new(4, "Product 4", 23, categories[0]),
    new(5, "Product 5", 42, categories[1]),
    new(6, "Product 6", 21, categories[1]),
    new(7, "Product 7", 28, categories[1]),
    new(8, "Product 8", 16, categories[2]),
 ];

var query = from p in products
            group p by p.Category.CategoryName;

foreach (var group in query)
{
    Console.WriteLine(group.Key);
    foreach (var name in group)
    {
        //Console.WriteLine("\t" + name);
        Console.WriteLine("\t" + name.ProductName);
    }
}

record Category(int CategoryId, string CategoryName);
record Product(int ProductId, string ProductName, decimal UnitPrice, Category Category);