// Показать четные числа от 1 до N


// start

Console.WriteLine("Ввести целое число: ");

int N = Convert.ToInt32(Console.ReadLine());

int number = 1;

while (number <= N)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    number = number + 1;
}

// end
