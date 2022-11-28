// Напиcать методы, которые задают массив из 8 элементов и выводят их на экран.

// 1. определить метод создания массива 
// 2. определить метод ввода элементов массива
// 3. определить метод вывода массива в консоль

// start


int[] CreateArray(int count)
{
  return new int[count];
}


void FillArrayConsole(int[] numbers)
{
     
    for (int i=0; i < numbers.Length; i++)
    {
        Console.Write($" Введите элемент массива с индексом {i}: ");
        numbers[i] = int.Parse(Console.ReadLine());
    }
   
}

string Print(int[] numbers)
{
    Console.WriteLine(); 
    Console.WriteLine("Вывод массива:");

    string text = "[";

    for (int i=0; i < numbers.Length; i++)
    {
        text += ($"{numbers[i]} ");
    }
    return(text + "]");
}

int[] array = CreateArray(8);
FillArrayConsole(array);
Console.WriteLine(Print(array));

// end


























































































