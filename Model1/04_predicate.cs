using System.Text.RegularExpressions;

Predicate<string> IsFourNumber = Check;
Func<string, bool> IsFourNumber2 = Check;

Console.WriteLine(IsFourNumber("1234")); // True
Console.WriteLine(IsFourNumber("12345")); // False
Console.WriteLine(IsFourNumber("abcd1234d"));// False
Console.WriteLine("---------------");
Console.WriteLine(IsFourNumber2("1234")); // True
Console.WriteLine(IsFourNumber2("12345")); // False
Console.WriteLine(IsFourNumber2("abcd1234d"));// False

//檢查輸入是否為四個數字
bool Check(string input) => new Regex(@"^\d{4}$").IsMatch(input);
