// Удалить вторую цифру трёхзначного числа.

// start

Console.Clear();

Console.WriteLine("start");

int value = new Random().Next(100, 1000);  // [100; 999]

int a = value / 100;
int b = (value / 10) % 10;
int c = value % 10;

int result = a*10 + c;

Console.WriteLine(value);
Console.WriteLine(result);
Console.WriteLine("end");

// end