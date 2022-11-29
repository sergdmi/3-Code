Console.Clear();
int[,] pascal = new int[11, 11];

for (int n = 0; n < 11; n++)
{
    pascal[n, 0] = 1;
    pascal[n, n] = 1;
    
}

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 11; j++)
    {
        Console.Write($"{pascal[i,j],4}");
    }
    Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine();


for (int i = 2; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {
        pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
    }
}

for (int i = 0; i < 11; i++)
{
    for (int j = 0; j < 11; j++)
    {
       if(pascal[i,j]!=0) Console.Write($"{pascal[i,j],4}");
    }
    Console.WriteLine();
}

// pascal [i, j] = pascal [i-1, j-1] +  pascal [i-1, j];