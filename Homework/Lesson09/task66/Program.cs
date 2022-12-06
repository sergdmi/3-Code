// Задача 66: Задать значения M и N. Напиcать программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 

// 1. Ввести значения M и N;
// 2. Определить сумму натуральных элементов в промежутке от M до N (метод);
// 3. Вывести результат.

// start

Console.Clear();
Console.Write("Задать промежуток из 2-х натуральных чисел");
Console.WriteLine();

Console.Write("Ввести начальное число : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввести конечное число : ");
int N = Convert.ToInt32(Console.ReadLine());

SumNumSegment(M);

int SumNumSegment(int n)
{
    
        if (n == M) return M;        
        else return SumNumSegment(n - 1) + n;  
        n++;
        
}
Console.Write("Сумма элементов: ");
Console.WriteLine(SumNumSegment(N));

// end