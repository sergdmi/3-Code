// Задача 56: Задать прямоугольный двумерный массив. Написать программу, которая будет находить строку с наименьшей суммой элементов.

// 1. Задать исходный прямоугольный двумерный массив (метод);
// 2. Заполнить массив случайными числами (метод);
// 3. Вывести исходный массив в консоль(метод);
// 4. Найти сумму элементов в каждой строке матрицы и задать массив из сумм строк (метод);
// 5. Определить наименьший элемент массива сумм (метод);
// 6. Определить индекс наименьшего элемента массива сумм (метод);
// 7. Вывести массив сумм и номер строки матрицы с наименьшей суммой. 

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

int [] SumArray (int[,] matrix)
{
    int[] sumarray = new int [matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumrow = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow = sumrow + matrix[i,j];
        }
        sumarray[i] = sumrow;
    }
    return sumarray;
}

int SumMin(int[] sumarray)
{
    int summin = sumarray[0];

         
        for (int n = 0; n < sumarray.Length; n++)
        {
            if (sumarray[n] < summin) { summin = sumarray[n]; }
        }

    return summin;      
}

int SumMinIndex(int[] sumarray, int summin)
{
    for (int index = 0; index < sumarray.Length; index++)
        {
            if (sumarray[index]  == summin) {return index;}
        }
        return -1;
        
}


string Print(int[] numbers)
{
  int size = numbers.Length;
  int index = 0;
  string result = "[ ";

  while (index < size)
  {
    result += ($"{numbers[index]} ");
    index++;
  }
  return result + "]";
}


int[,] newmatrix = CreateMatrix(5, 5);
FillMatrix(newmatrix, 1, 10);
PrintMatrix(newmatrix);
int[] summinarray = SumArray(newmatrix);
int summin = SumMin(summinarray);
int result = SumMinIndex (summinarray, summin) + 1;
Console.WriteLine();
Console.WriteLine(Print(summinarray));
Console.WriteLine();
Console.Write($"Минимальная сумма в строке {result}");
