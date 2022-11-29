// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным значением элементов массива.

// 1. Создать массив вещественнных чисел заданного размера (метод)
// 2. Заполнить массив из консоли (метод)
// 3. Вывести массив в консоль (метод)
// 4. Определить разницу между значениями максимального и минимального элементов массива

// start

double[] CreateArray(int count)
{
  return new double[count];
}

void FillArrayConsole(double[] numbers)
{
     
    for (int i=0; i < numbers.Length; i++)
    {
        Console.Write($" Введите элемент массива с индексом {i}: ");
        numbers[i] = double.Parse(Console.ReadLine());
    }
   
}

string Print(double[] numbers)
{
    Console.WriteLine(); 
    Console.WriteLine("Вывод массива:");

    string text = "[";

    for (int i=0; i < numbers.Length; i++)
    {
        text += ($"{numbers[i]} ");
    }
    return(text +"]");
}

double MaxMinNumDiff (double[] numbers)
{
    double minNumber = numbers[0];
    double maxNumber = numbers[1]; 

    if (numbers[1] < numbers[0])
    {
        minNumber = numbers[1];
        maxNumber = numbers[0];      
    }
     

    for(int i = 2; i < numbers.Length; i++)
    {
        if (numbers[i] < minNumber)
        {
            minNumber = numbers[i];
        }

        if (numbers[i] > maxNumber)
        {
            maxNumber = numbers[i];
        }
    }

    double result =  maxNumber - minNumber;

    return result;

}

double[] array = CreateArray(5);
FillArrayConsole(array);
Console.WriteLine(Print(array));
Console.WriteLine(); 
Console.WriteLine($"Разница между максимальным и минимальным значениями: {MaxMinNumDiff(array)}");

// end