﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 1. Ввести число дня недели
// 2. Задать массив - числа дней недели
// 3. Проверить число на соотвествие 6 и 7 дню недели
// 4. Вывести сообщение выходной или рабочий день

// start

Console.WriteLine("Введите № дня недели:");
int WeekDayNumber = Convert.ToInt32(Console.ReadLine());

int[] week = {1, 2, 3, 4, 5, 6, 7};

if (WeekDayNumber == week[5] || WeekDayNumber == week[6])
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}


// end