int[] numbers = [1, 2, 3, 4, 5];
Console.WriteLine(numbers.Average());
Console.WriteLine(numbers.Sum());
Console.WriteLine(numbers.Count());
Console.WriteLine(numbers.Max());
Console.WriteLine(numbers.Min());
Console.WriteLine(numbers.Aggregate((i, j) => i * j));