// Задать массив заполненный случайными положительными трёхзначными числами. Написать программу, которая покажет количество чётных чисел в массиве.

// 1. Создать массив заданного размера (метод)
// 2. Заполнить массив случайными натуральными 3-х значными числами (метод)
// 3. Вывести массив в консоль (метод)
// 4. Определить количество четных чисел (метод)

// start

int[] CreateArray(int count)
{
    return new int[count];
}

void FillArrayRandom100to999(int[] randomNumber)
{
    for (int i = 0; i < randomNumber.Length; i++)
    {
        randomNumber[i] = new Random().Next(100, 1000);
    }
}

string Print(int[] numbers)
{
    Console.WriteLine(); 
    
    string text = "[";

    for (int i=0; i < numbers.Length; i++)
    {
        text += ($"{numbers[i]} ");
    }
    return(text + "]");
}

int CountEvenNumbers (int[] numbers)
{
    int count = 0;
    for (int i=0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] randomarray = CreateArray(4);
FillArrayRandom100to999(randomarray);
Console.WriteLine(Print(randomarray));
Console.WriteLine($"Количество четных элементов массива:  {CountEvenNumbers(randomarray)}");

