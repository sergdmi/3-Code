// Напиcать программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter number a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (a < b)
{
  max = b; 
  min = a;
}

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min); 