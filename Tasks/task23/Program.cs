// Показать таблицу квадратов чисел от 1 до N 

// start

Console.Clear();

Console.WriteLine("Ввести целое число");

int N = Convert.ToInt32(Console.ReadLine());

int n = 1;

while (n <= N)
{
    Console.WriteLine($"{n}^2 = {n*n}");
    n = n + 1;
}

// end
