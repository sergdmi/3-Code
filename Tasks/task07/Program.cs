// Показать числа от -N до N

// start

Console.WriteLine("Ввести целое число: ");

int N = Convert.ToInt32(Console.ReadLine());

int number = - N;

while (number <= N)
{
    Console.WriteLine(number);
    number = number + 1;
}

// end
