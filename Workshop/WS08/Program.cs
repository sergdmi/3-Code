// 48. Показать двумерный массив размером m×n заполненный целыми числами

int[,] CreateArray(int row, int column)
{
    return new int[row, column];
}

void FillArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(0,20);
        }
    }
}

void PrintArray (int[,] array)

{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column], 3}");
        }
        Console.WriteLine();
    }    
    
}

int [,] matrix = CreateArray(3, 4);
FillArray(matrix);
PrintArray(matrix);