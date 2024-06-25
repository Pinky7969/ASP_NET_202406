int[] numbers = [1, 2, 3, 4, 5];

//var query = from number in numbers
//            where number % 2 == 0
//            select number;

var query = numbers.Where(number => number % 2 == 0);

foreach (var item in query)
{
    Console.WriteLine(item);
}