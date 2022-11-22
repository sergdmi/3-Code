// Напиcать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter number a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) 
{
    max = b;
}

if (c > max) 
{
    max = c;
}

Console.Write("max = ");
Console.WriteLine(max);

// end