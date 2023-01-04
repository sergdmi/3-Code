// Показать кубы чисел, заканчивающихся на четную цифру

// start

Console.Clear();

Console.WriteLine("Ввести целое число");

int N = Convert.ToInt32(Console.ReadLine());

int n = 1;

while (n <= N)
{
    if (n % 2 == 0) {Console.WriteLine($"{n}^3 = {n*n*n}");}
    n = n + 1;
}

// end