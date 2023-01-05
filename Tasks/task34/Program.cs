// Написать программу замены элементов массива на противоположные 

// start

Console.Clear();

int[] CreateArray(int count)
{
    return new int[count];
}

void FillArrayRandom(int[] randomNumber)
{
    for (int i = 0; i < randomNumber.Length; i++)
    {
        randomNumber[i] = new Random().Next(-100, 100);
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

void RevertArray(int[] initarray)
{
    int size = initarray.Length;

    for (int i = 0; i < size; i++)
    {
        initarray[i] = - initarray[i];
    }
}

int[] array1 = CreateArray(10);
FillArrayRandom(array1);
Console.WriteLine(Print(array1));
RevertArray(array1);
Console.WriteLine(Print(array1));

// end
