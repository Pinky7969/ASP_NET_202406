//Func<DateTime> GetDateTimes = () => DateTime.Now;
//Func<string, string> SayHi = (string name) => $"Hi {name}";

var GetDateTimes = () => DateTime.Now;
var SayHi = (string name) => $"hi {name}";

Console.WriteLine(GetDateTimes());
Console.WriteLine(SayHi("Mary"));