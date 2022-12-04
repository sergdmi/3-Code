// Задача 54: Задать двумерный массив. Написать программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// 1. Задать массив (метод);
// 2. Заполнить массив случайными числами (метод);
// 3. Вывести исходный массив в консоль(метод);
// 4. Задать алгоритм упорядочивания строк массива по убыванию (метод);
// 5. Вывести упорядоченный массив в консоль(метод);

// start

int[,] CreateMatrix(int row, int col)
{
    return new int [row, col];
}


void FillMatrix(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortMatrixMaxMin(int[,] matrix)
{
    int temp;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int n = j + 1; n < matrix.GetLength(1); n++)
            {
                if (matrix[i, j] < matrix[i, n])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, n];
                    matrix[i, n] = temp;
                }

            }
        }
    }
    return matrix;
}

int[,] matrix1 = CreateMatrix(5,5);
FillMatrix(matrix1, 1, 10);
PrintMatrix(matrix1);
int[,] matrix2 = SortMatrixMaxMin(matrix1);
Console.WriteLine("отсортированный массив:");
PrintMatrix(matrix2);
