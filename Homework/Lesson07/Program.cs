// Доделать ввод многочлена

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

double[] GetKoeff(double[,] tr, int pow)
{
  double[] row = new double[pow + 1];
  for (int i = 0; i <= pow; i++)
  {
    row[i] = tr[pow, i];
  }
  return row;
}

void PrintKoeff(double[] koeff)
{   
   Console.Write("Значения строки треугольника Паскаля: ");
   Console.WriteLine();
   Console.WriteLine(String.Join(' ', koeff));
   Console.WriteLine();
   Console.Write("№ строки треугольника: ");
   Console.WriteLine(koeff.Length);
   Console.WriteLine();
   Console.Write("Вывод многочлена: ");
   Console.WriteLine();
    
    string br1 = "(";
    string br2 = ")";
    
    for (int i = 0; i < koeff.Length; i++)
    {
        
        if (i == 0) {Console.Write($"a^{koeff.Length - 1 - i}*b^{i} + ");}
        else
        if (i == koeff.Length - 1) {Console.Write($"a^{koeff.Length - 1 - i}*b^{i}");}
        else

        if (koeff[i] < 1000)
        {
            Console.Write($"{koeff[i]}*a^{koeff.Length - 1 - i}*b^{i} + ");
        }
        else
            Console.Write($"{br1}{koeff[i].ToString("0.#E+0")}{br2}*a^{koeff.Length - 1 - i}*b^{i} + ");
    }
}

double[,] tr = CreateTriangle(50);
double[] koeff = GetKoeff(tr, 40);
PrintKoeff(koeff);

