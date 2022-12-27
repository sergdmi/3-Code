//  Найти сумму чисел от 1 до А

// start

Console.Clear();

Console.WriteLine("Ввести целое число");

int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int n = 1;

while (n <= A)
{
    sum = sum + n;
    n = n + 1;
}

Console.Write("сумма:");
Console.WriteLine(sum);

// end
