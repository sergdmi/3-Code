// Задать массив заполненный случайными положительными трёхзначными числами. Написать программу, которая покажет количество чётных чисел в массиве.

// Создать массив заданного размера (метод)
// Заполнить массив случайными натуральными 3-х значными числами (метод)
// Вывести массив в консоль (метод)
// Определить количество четных чисел (метод)

// start

int[] CreateArray(int count)
{
    return new int[count];
}

void FillArrayRandom100to999(int[] randomnumber)
{
    for (int i = 0; i < randomnumber.Length; i++)
    {
        randomnumber[i] = new Random().Next(100, 1000);
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

