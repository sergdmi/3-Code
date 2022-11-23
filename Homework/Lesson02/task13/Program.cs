// Задача 13: Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 1. Ввести с консоли положительное целое число
// 2. Преобразовать строку в массив
// 3. Определить длину массива
// 4. Если длина массива меньше 3 символов вывести сообщение
// 5. Вывести 2-й элемент массива на экран 

// start

Console.Clear();

Console.WriteLine("Введите любое положительное целое число: ");
string value = Console.ReadLine();

char[] array = new char[value.Length];
for(int i = 0; i < value.Length; i++)
{
    array[i] = value[i];
}

if (value.Length < 3)
{
    Console.WriteLine(" 3-я цифра отсутствует");
}
else

Console.WriteLine(array[2]);

// end

