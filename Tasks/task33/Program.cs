// Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
// Найти сумму положительных/отрицательных элементов массива

// 1. Создать массив заданного размера (метод)
// 2. Заполнить массив случайными числами (метод)
// 3. Вывести массив в консоль (метод)
// 4. Определить количество четных чисел (метод)
// 5. Найти сумму положительных элементов массива (метод)
// 6. Найти сумму отрицательных элементов массива (метод)

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
        randomNumber[i] = new Random().Next(-9, 10);
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

int SumPlusNum(int[] numbers)
{
    int sumplus = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sumplus = sumplus + numbers[i];
        }

    }
    return sumplus;
       
}

int SumMinusNum(int[] numbers)
{
    int summinus = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            summinus = summinus + numbers[i];
        }

    }
    return summinus;
}


int[] array12 = CreateArray(12);
FillArrayRandom(array12);
Console.WriteLine(Print(array12));
Console.WriteLine($"Сумма положительных чисел: {SumPlusNum(array12)}");
Console.WriteLine($"Сумма отрицательных чисел: {SumMinusNum(array12)}");


// end