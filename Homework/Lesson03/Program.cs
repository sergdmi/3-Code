

// Описать 
// 0. Метод, считывающий число от пользователя из консоли
// 1. метод, создающий массив с указанным количеством эл.
// 2. метод, заполняющий массив поэлементно *от пользователя
// 3. метод, подсчёта четных элементов
// 4. метод, формирующий новый массив на основе имеющегося
// 5. метод, печатающий массив

// 0. Метод, считывающий число от пользователя из консоли
int GetNumber(string text)
{
  Console.Write(text);
  int value = int.Parse(Console.ReadLine());
  return value;
}

// 1. метод, создающий массив с указанным количеством эл.
int[] CreateArray(int count)
{
  return new int[count];
}

// 2. метод, заполняющий массив поэлементно *от пользователя
void Fill(int[] array)
{
  int size = array.Length;

  int index = 0;
  while (index < size)
  {
    array[index] = GetNumber($"array[{index}]: ");
    index++;
  }
}

// 3. метод, подсчёта четных элементов
int CountIsEven(int[] elements)
{
  int result = 0;

  int size = elements.Length;
  int i = 0;
  while (i < size)
  {
    if (elements[i] % 2 == 0) result++;
    i++;
  }

  return result;
}

// 4. метод, формирующий новый массив на основе имеющегося
//! ДЗ ОПИСАТЬ БЛОК-СХЕМУ РЕШЕНИЯ ЗАДАЧИ
int[] Solution(int[] collectionElements, int evenCounts)
{

  //       v
  // 1 2 3 4 5 6 7 8 9 0 collectionElements
  // 2 0 0 0 0 items
  //   ^ 

  int[] items = new int[evenCounts];
  int length = collectionElements.Length;
  int position = 0;
  int indexInItems = 0;
  while (position < length)
  {
    if (collectionElements[position] % 2 == 0)
    {
      items[indexInItems] = collectionElements[position];
      indexInItems++;
    }
    position++;
  }

  return items;
}

// 5.1 метод, печатающий массив 
void PrintBad(int[] numbers)
{
  int size = numbers.Length;
  int i = 0;

  while (i < size)
  {
    Console.Write($"{numbers[i]} ");
    i++;
  }
  Console.WriteLine();
}

// 5.2 метод, печатающий массив 
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


// Клиентский код

int countElements = GetNumber("Введите количество эл массива: ");
int[] arr = CreateArray(countElements);
Fill(arr);
PrintBad(arr);
int even = CountIsEven(arr);
int[] newArr = Solution(arr, even);
Console.WriteLine(PrintGood(newArr));

