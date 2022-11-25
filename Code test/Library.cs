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
}