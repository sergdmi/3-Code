// Задача 10:Написать программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 1. Ввести с консоли 3-х значное число
// 2. Разбить число на цифры
// 3. Вывести 2 цифру на экран

// start

Console.Clear();

Console.WriteLine("Введите 3-хзначное число:");

int value = Convert.ToInt32(Console.ReadLine());


int a = value / 100;
int b = (value /  10) % 10;
int c = value % 10;

int result = b;

Console.WriteLine();
Console.WriteLine(result);


// end
