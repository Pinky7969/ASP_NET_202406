Action<int, int> compute1 = Add;
compute1 += Subtract;
compute1 += Multiply;
compute1 += Divide;
compute1(10, 5);

Action<int, int>? compute2 = Add;
compute2 += Subtract;
compute2 += Multiply;
compute2 += Divide;
compute2 -= Divide;
compute2?.Invoke(10, 5);

if (compute2 != null)
    compute2(10, 5);

//local function
void Add(int a, int b) => Console.WriteLine(a + b);
void Subtract(int a, int b) => Console.WriteLine(a - b);
void Multiply(int a, int b) => Console.WriteLine(a * b);
void Divide(int a, int b) => Console.WriteLine(a / b);