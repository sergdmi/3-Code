// Определить, присутствует ли в заданном массиве, некоторое число 

// start

Console.Clear();

int[] CreateArray(int count)
{
    return new int[count];
}

void FillArrayRandom(int[] randomNumber, int min, int max)
{
    for (int i = 0; i < randomNumber.Length; i++)
    {
        randomNumber[i] = new Random().Next(min, max);
    }
}

string Print(int[] numbers)
{
    Console.WriteLine(); 
    
    string text = "[ ";

    for (int i=0; i < numbers.Length; i++)
    {
        text += ($"{numbers[i]} ");
    }
    return(text + "]");
}

// bool FindNumber(int[] array)
// {
//     Console.Write("find: ");
    
//     int number = Convert.ToInt32(Console.ReadLine());

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == number) return true;
//     }
//     return false;
// }

int FindNumber(int[] array)
{
    Console.WriteLine();
    Console.Write("findnumber: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number) {count++;}
    }
    
    return count;
    
}

int[] FindIndex(int[] array, int findcount)
{
    Console.WriteLine();
    Console.Write("reenter findnumber: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] indexarray = new int[findcount];
    int length = array.Length;
    int i = 0;
    int j = 0;
    
    while (i < length)
    {
        if(array[i] == number) 
        {
            indexarray[j] = i;
            j++;
        }
        i++;
    }
    return indexarray;
}


int[] array35 = CreateArray(50);
FillArrayRandom(array35, 0, 100);
Console.WriteLine(Print(array35));
int count35 = FindNumber(array35);
int[] indexarray35 = FindIndex(array35, count35);
Console.WriteLine($"number found {count35} times at index {Print(indexarray35)}");


//bool flag = FindNumber(array35);
//Console.WriteLine($"number found - {flag}");


// end