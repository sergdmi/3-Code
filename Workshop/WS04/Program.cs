using static Library;
// Задачи на сегодня
Console.Clear();

// Задача 1: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// int[] col = CreateArray(12);
// Console.WriteLine(PrintGood(col));
// Fill(col, -9, 9);
// Console.WriteLine(PrintGood(col));
// int pos = SumPositive(col);
// Console.WriteLine($">0 {pos}");
// int neg = SumNegative(col);
// Console.WriteLine($"<0 {neg}");

// Задача 2: Напишите программу замена элементов
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// =====
// int[] col2 = CreateArray(10);
// Console.WriteLine(PrintGood(col2));
// Fill(col2, -20, 20);
// Console.WriteLine(PrintGood(col2));

// int[] res = Inverse1(col2);
// Inverse2(col2);
// Console.WriteLine(PrintGood(res));
// Console.WriteLine(PrintGood(col2));
// =====
// Задача 3: Задайте массив.
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// =====
int[] col3 = CreateArray(10);
int upperBound = 50;
int searchElement = Random.Shared.Next(0, upperBound);

Fill(col3, 0, upperBound);
Console.WriteLine(PrintGood(col3));

bool flag1 = FindElement1(col3, searchElement);
Console.WriteLine($"{searchElement} найден - {flag1}");

bool flag2 = FindElement2(col3, searchElement);
Console.WriteLine($"{searchElement} найден - {flag2}");
// =====
// Задача 4: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке[10, 99]. 

// Задача 5: Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний и т.д.Результат запишите в новом массиве.
// * Для нечетного количество центральный элемент возводится в квадрат