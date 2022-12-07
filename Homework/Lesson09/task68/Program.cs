// Задача 68: Напиcать программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// start

Console.WriteLine("Ввести 2 неотрицательных целых числа ");
Console.Write("число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunA(int m, int n)
{
    if (m == 0) return n + 1;
    else

    if (m != 0 && n == 0) return FunA(m - 1, 1);
    else
    
    return FunA(m - 1, FunA(m, n - 1));

}

Console.Write("Результат: ");
Console.WriteLine(FunA(m, n));


// end