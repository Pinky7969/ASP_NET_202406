int[] numbers = [0, 5, 1, 2, 3, 4, 5, 3, 2, 1];

//var query = numbers.Skip(4); // 3, 4, 5, 3, 2, 1
//var query=numbers.SkipWhile(i=>i<4); // 5, 1, 2, 3, 4, 5, 3, 2, 1
//var query=numbers.Take(4); // 0, 5, 1, 2
//var query = numbers.TakeWhile(i => i < 4); // 0
var query = numbers.Where(i => i < 4); // 0, 1, 2, 3, 3, 2, 1

foreach (var item in query)
{
    Console.Write(item + " ");
}