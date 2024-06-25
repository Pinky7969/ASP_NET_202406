MyDelegate compute1 = new MyDelegate(Add);
MyDelegate compute2 = Subtract;

compute1.Invoke(10, 5);
compute2(20,4);

//local function
void Add(int a, int b) => Console.WriteLine(a + b);
void Subtract(int a, int b) => Console.WriteLine(a - b);
void Multiply(int a, int b) => Console.WriteLine(a * b);
void Divide(int a, int b) => Console.WriteLine(a / b);

delegate void MyDelegate(int a, int b);