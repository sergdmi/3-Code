// Написать программу вычитания двух многочленов

//          0  1  2   3  4   5
int[] f = { 1, 2, 0, -4, 5, -6 };
int[] g = { 0, 1, 2, 5, 0, -1, -7, 3 };
// int[] g = { 0, 1, 2, 5 };

// f(x) = 1*x^0 + 2*x^1 + 0*x^2 - 4*x^3 + 5*x^4 - 6*x^5              
// g(x) = 0*x^0 + 1*x^1 + 2*x^2 + 5*x^3 + 0 x^4 - 1*x^5 - 7*x^6 + 3*x^7
// g(x) = 0*x^0 + 1*x^1 + 2*x^2 + 5*x^3 

int[] Substr(int[] f, int[] g)
{
    int powF = f.Length;
    int powG = g.Length;

    int resultMax = powF;
    int resultMin = powG;
    if (powG > resultMax) 
    {
        resultMax = powG;
        resultMin = powF;
    }

        int[] result = new int[resultMax];

        for (int i = 0; i < resultMin; i++)
        {
            result[i] = f[i] - g[i];
        }

        for (int i = resultMin; i < resultMax; i++)
        {
            if (resultMax == powG) result[i] = - g[i];
            else result[i] = f[i];
        }

        return result;
}

int[] s = Substr(f, g);

Console.WriteLine(Print(f));
Console.WriteLine(Print(g));
Console.WriteLine(Print(s));

string Print(int[] f)
{
    string output = String.Empty;
    for (int i = 0; i < f.Length; i++)
    {
        output += $"{f[i]}*x^{i} + ";
    }

    return output;
}