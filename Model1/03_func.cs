Func<DateTime> func1 = GetDateTimes;
Func<string, string> func2 = SayHi;

Console.WriteLine(func1());
Console.WriteLine(func2("Mary"));

DateTime GetDateTimes() => DateTime.Now;
string SayHi(string name) => $"Hi {name}";