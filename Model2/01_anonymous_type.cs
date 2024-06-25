int i = 10;
var j = 20;
//j = "3"; // Error: Cannot implicitly convert type 'string' to 'int'

// Dynamic Type
dynamic k = 30;
k = "3"; // No error
Console.WriteLine(k + 10);

// Anonymous Type
var book = new { Title = "C#", Author = "Unknown" };
//book.Title="Title2"; // Error: Property or indexer 'AnonymousType#1.Title' cannot be assigned to -- it is read only
Console.WriteLine((book.Title, book.Author)); //(value1, value2) tuple