// Написать программу сложения и вычитания двух многочленов

// f(x) = 4*x^3 + 3*x^2 + x + 11
// g(x) = 10*x^3 + x + 10 

// f(x) + g (x) = 14*x^3 + 3*x^2 + 2*x^1 + 21
// f(x) - g (x) = -6*x^3 + 3*x^2 + 1

//          0  1  2  3  4  5  6   7 .....  N
int[] f = { 1, 2, 0, -4, 5, -6 };
int[] g = { 0, 1, 2, 5, 0, 0, -7, 3 };

// f(x) = a0*x^0 + a1*x^1 + a2*x^2 + a3*x^3 + a4*x^4 + ... + aN*x^N  (общий вид многочлена)

// f(x) = 1*x^0 + 2*x^1 + 0*x^2 + 4*x^3 +5*x^4 + 6*x^5              степень результирующего многочлена определяется степенью большего по степени многочлена
// g(x) = 0*x^0 + 1*x^1 + 2*x^2 + 5*x^3 +0*x^4 + 0*x^5 + 7*x^6 + 3*x^7


int[] Sum(int[] f, int[] g)
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
            result[i] = f[i] +g[i];
        }

        for (int i = resultMin; i < resultMax; i++)
        {
            if (resultMax == powG) result[i] = g[i];
            else result[i] = f[i];
        }

        return result;
}

string Print(int[] f)
{
    string[] pows = {"⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹"};
    string output = String.Empty;
    for (int i = 0; i < f.Length; i++)
    {
        int t = f[i];
        if (f[i] == 0) continue;
        if (f[i] < 0) {output += " - "; }
        else if (i != 0) { output += " + "; }

        if (t < 0) t= -t;
        if (i == 1) { output += $"{t}x"; }
        if (i == 0) { output += $"{t}"; }
        if (i != 1 && i != 0 && f[i] != 0) { output += $"{t}x{pows[i]}"; }
        // if (f[i] != 0 && i < f.Length - 1) output += "+";
    }

    return output;
}

int[] s = Sum(f, g);
// for (int i = 0; i < s.Length; i++) Console.Write($"{s[i]} ");

Console.WriteLine(Print(f));
Console.WriteLine(Print(g));
Console.WriteLine(Print(s));