public static class Library
{
  // печать массив
  public static string PrintGood(int[] numbers)
  {
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
      result += ($"{numbers[i],3} ");
      i++;
    }
    return result + "]";
  }

  // метод, который создаёт массив
  public static int[] CreateArray(int count)
  {
    return new int[count];
  }

  // заполняет массив
  public static void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.Next(min, max + 1);
      //array[i] = new Random().Next(min, max);
    }
  }

  public static int SumPositive(int[] numbers)
  {
    int result = 0;
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
      if (numbers[i] > 0) result += numbers[i];
    }
    return result;
  }

  public static int SumNegative(int[] numbers)
  {
    int result = 0;
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
      if (numbers[i] < 0) result += numbers[i];
    }
    return result;
  }


  public static int[] Inverse1(int[] input)
  {
    int size = input.Length;
    int[] output = new int[size];
    for (int i = 0; i < size; i++)
    {
      output[i] = -input[i];
    }
    return output;
  }

  public static void Inverse2(int[] input)
  {
    int size = input.Length;
    for (int i = 0; i < size; i++)
    {
      input[i] = -input[i];
    }
  }

  public static bool FindElement1(int[] col, int find)
  {
    int size = col.Length;
    for (int i = 0; i < size; i++)
    {
      if (col[i] == find) return true;
    }
    return false;
  }

  public static bool FindElement2(int[] col, int find)
  {
    // 0 1 2 3 4 5
    // 1 5 1 2 3 9
    // 4 <- -1
    // 1 <- 0
    // 5 <- 1

    return Array.IndexOf(col, find) != -1;
  }

  // Методы из домашних заданий

  // метод возведения числа "а" в натуральную степень "в"

  public static double NaturalDegree(int a, int b)
  {  
        double degree = a;
        for (int i = 1; i < b; i++)
        {
              degree = degree * a;
        }

          return degree;
    
  }

  // Сумма цифр натурального числа (работает в рамках целого типа данных)

  public staticint SumValueNumbers(int value)
  {
    
      int sum = 0;
          
      while (value > 0)
      {
          int number = value % 10;
          sum = sum + number;
          value = value / 10;
      }

      return sum;
  }

    // Ввод элементов массива с консоли
  public static void FillArrayConsole(int[] numbers)
  {
      
      for (int i=0; i < numbers.Length; i++)
      {
          Console.Write($" Введите элемент массива с индексом {i}: ");
          numbers[i] = int.Parse(Console.ReadLine());
      }
    
  }
  
  // Сортировка элементов строк массива по убыванию
  public static int[,] SortMatrixMaxMin(int[,] matrix)
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

    // Сортировка элементов строк массива по возрастанию
  public static int[,] SortMatrixMinMax(int[,] matrix)
  {
      int temp;

      for (int i = 0; i < matrix.GetLength(0); i++)
      {
          for (int j = 0; j < matrix.GetLength(1) - 1; j++)
          {
              for (int n = j + 1; n < matrix.GetLength(1); n++)
              {
                  if (matrix[i, j] > matrix[i, n])
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

  // Вывести натуральные числа от 0 до N (рекурсия)
  public static void NumSegmentPlus(int n)
  {
      Console.WriteLine(n);
      {
          if (n >= N) return;
          n++;
          NumSegment(n);
      }
    
  }

  // Вывести натуральные числа от N до 0 (рекурсия)

  public static void NumSegmentMinus(int n)
  {
      Console.WriteLine(n);
      {
          if (n <= 1) return;
          n--;
          NumSegment(n);
      }
    
  }

  // Определить сумму натуральных элементов в промежутке от M до N

  //SumNumSegment(M);
  int SumNumSegment(int n)
  {
      
          if (n == M) return M;        
          else return SumNumSegment(n - 1) + n;  
          n++;
          
  }
  //Console.WriteLine(SumNumSegment(N));



}

