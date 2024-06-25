int[] numbers = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];

var result = numbers.Where(Check2);

foreach (var item in result)
{
    Console.Write(item + " ");
}

bool Check(int input) => input % 2 == 0;
bool Check2(int input) => input>3;