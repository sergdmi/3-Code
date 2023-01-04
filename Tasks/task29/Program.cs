// Написать программу вычисления произведения чисел от 1 до N

// start

// Console.Clear();
// Console.WriteLine("Ввести натуральное число N");

// int N = Convert.ToInt32(Console.ReadLine());

// int n = 1;
// double mult = 1;

// while (n <= N)
// {
//     mult = mult * n;
//     n = n + 1;
// }

// Console.WriteLine($"произведение чисел от 1 до N: {mult}");

// end

// Решение через рекурсию

// start

Console.Clear();
Console.WriteLine("Ввести натуральное число N");

int N = Convert.ToInt32(Console.ReadLine());

double FactorialNum(int num)
{
    if (num == 1) return 1;

    else return FactorialNum(num - 1) * num;

}

Console.Write($"произведение чисел от 1 до N: {FactorialNum(N)}");

// end