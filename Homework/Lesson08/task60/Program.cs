// Задача 60. Сформировать трёхмерный массив из неповторяющихся двузначных чисел. 
// Написать программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
// Массив размером 2 x 2 x 2

// 1. Задать массив и заполнить случайными целыми числами(метод);
// 2. Вывести массив с индексами (метод).

// start

int[,,] CreateMatrixRandom3(int row, int col, int lay, int min, int max)
{
  int[,,] matrix = new int [row, col, lay];
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int l = 0; l < lay; l++)
            {
                matrix[i, j, l] = new Random().Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintMatrix3(int[,,] matrix)
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
        {
            Console.Write($"{matrix[i, j, l]} ({i},{j},{l}) ");
        }
        Console.WriteLine();
        }
    }
}

int[,,] matrix60 = CreateMatrixRandom3(2, 2, 2, 10, 100);
PrintMatrix3(matrix60);

// end