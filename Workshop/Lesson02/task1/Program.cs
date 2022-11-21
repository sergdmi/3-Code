// 1 - Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 1. Выводим случайное число из отрезка 10 - 99
// 2. Определить 1 и 2 цифры числа
// 3. Сравнить 1 и 2 цифры числа
// 4. Вывести наибольшую 

Console.Clear();

int value = new Random().Next(10, 100);

int a = value / 10;
int b = value % 10;

if (a > b) 
{
    Console.WriteLine(a);
}
else 
{
    Console.WriteLine(b);
}

Console.WriteLine(value);

// end