int[] numbers = [0, 1, 2, 3, 4, 5, 5, 6];
Console.WriteLine(numbers.ElementAt(3)); //3
Console.WriteLine(numbers.ElementAtOrDefault(3)); //3
//Console.WriteLine(numbers.ElementAt(10)); //exception
Console.WriteLine(numbers.ElementAtOrDefault(10)); //0
Console.WriteLine(numbers.First(i => i == 5)); //5
Console.WriteLine(numbers.FirstOrDefault(i => i == 100)); //0
Console.WriteLine(numbers.Last(i => i == 5)); //5
Console.WriteLine(numbers.LastOrDefault(i => i == 100)); //0

Console.WriteLine(numbers.Single(i => i == 4)); //4
Console.WriteLine(numbers.SingleOrDefault(i => i == 100)); //0
//Console.WriteLine(numbers.Single(i => i == 5)); //exception