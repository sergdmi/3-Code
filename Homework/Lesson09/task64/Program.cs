// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// 1. Ввести значение N с консоли;
// 2. Вывести натуральные числа в интервале от от N до 1 (метод);


// start

Console.Clear();
Console.Write("Ввести натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

NumSegment(N);

void NumSegment(int n)
{
     Console.Write($"{n} ");
    {
        if (n <= 1) return;
        n--;
        NumSegment(n);
    }
   
}


// end