int GetNumber(string text)
{
  Console.Write(text);
  int value = int.Parse(Console.ReadLine());
  return value;
}

int[] CreateArray(int count)
{
  return new int[count];
}



void Fill(int[] array, int min, int max)
{
  int size = array.Length;

  int index = 0;
  while (index < size)
  {
    array[index] = Random.Shared.Next(min, max);
    index++;
  }
}


string PrintGood(int[] numbers)
{
  int size = numbers.Length;
  int i = 0;
  string result = "[ ";

  while (i < size)
  {
    result += ($"{numbers[i]} ");
    i++;
  }
  return result + "]";
}

int[] items = CreateArray(10);
Console.WriteLine(PrintGood(items));
Fill(items, -10, 10);
Console.WriteLine(PrintGood(items));

int[] negitems = Library.Inverse1(items);
Console.WriteLine(PrintGood(negitems));