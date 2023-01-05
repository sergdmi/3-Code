// Задать массив из 8 элементов и вывести их на экран 

// start

Console.Clear();

int[] numbers = new int[8];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($" Введите элемент массива с индексом {i}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Вывод массива:");

Console.Write("[ ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}, ");
}
Console.Write("]");

// end