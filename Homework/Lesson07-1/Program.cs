// Cделать вывод только нечетных коэффициентов у треугольника, распечатать хотя бы 120 строк

double[,] CreateTriangle(int row)
{
    double[,] triangle = new double[row, row];
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] =
            triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}

void PrintTriangle(double[,] triangle)
{
    int row = triangle.GetLength(0);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] % 2 != 0)        
                if (triangle[i, j] < 1000 )
                {
                    Console.Write($"{triangle[i, j],4}");
                }
                else
                Console.Write($"{triangle[i, j].ToString("0.#E+0"),7}");
        }
        Console.WriteLine();
    }
}


double[,] tr = CreateTriangle(120);
PrintTriangle(tr);
