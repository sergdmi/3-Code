// Задать одномерный массив, заполненный случайными числами. Найти сумму элементов, стоящих на нечётных позициях.

// Создать массив случайных целых чисел заданного размера (метод)
// Заполнить массив случайными натуральными числами (метод)
// Вывести массив в консоль (метод)
// Определить сумму чисел на нечетных позициях (метод)

// start

int[] CreateArray(int count)
{
    return new int[count];
}

void FillArrayRandomInt(int[] randomNumber, int minNumber, int maxNumber)
{
    for (int i = 0; i < randomNumber.Length; i++)
    {
        randomNumber[i] = new Random().Next(minNumber, maxNumber);
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

int SumOddNumbers (int[] numbers)
{
    int sumOddIndex = 0;
    for (int i=0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumOddIndex = sumOddIndex + numbers[i];
        }
    }
    return sumOddIndex;
}

int[] randomarray = CreateArray(4);
FillArrayRandomInt(randomarray, -100, 100);
Console.WriteLine(Print(randomarray));
Console.WriteLine($"Сумма элементов массива с нечетным индексом:  {SumOddNumbers(randomarray)}");

