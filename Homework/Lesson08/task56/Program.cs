// Задача 56: Задать прямоугольный двумерный массив. Написать программу, которая будет находить строку с наименьшей суммой элементов.

// 1. Задать исходный прямоугольный двумерный массив (метод);
// 2. Заполнить массив случайными числами (метод);
// 3. Вывести исходный массив в консоль(метод);
// 4. Найти сумму элементов в каждой строке матрицы и задать массив из сумм строк (метод);
// 5. Определить наименьший элемент массива сумм (метод);
// 6. Определить индекс наименьшего элемента массива сумм (метод);
// 7. Вывести массив сумм и номер строки матрицы с наименьшей суммой. 

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

int[] SumArray(int[,] matrix)
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

int[] SumMinRowNumber(int[] sumarray, int summin)
{
    int[] minindex = new int[sumarray.Length];
       
    for (int i = 0; i < sumarray.Length; i++)
    {
        if (sumarray[i] == summin) {minindex[i] = i+1;}
        else minindex[i] = 0;
    }
    
    return minindex;
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

string PrintIndex(int[] numbers)
{
  int size = numbers.Length;
  int index = 0;
  string result = "[ ";

  while (index < size)
  {
    if(numbers[index] !=0) {result += ($"{numbers[index]}, ");}
    index++;
  }
  return result + "]";
}



int[,] newmatrix = CreateMatrix(5, 4);
FillMatrix(newmatrix, 0, 10);
PrintMatrix(newmatrix);
int[] task56array = SumArray(newmatrix);
int summin56 = SumMin(task56array);
int[] minsumrow = SumMinRowNumber(task56array, summin56);
Console.WriteLine();
Console.WriteLine(Print(task56array));
Console.WriteLine();
Console.Write($"Минимальная сумма в строке: {(PrintIndex(minsumrow))}");

// end

// end