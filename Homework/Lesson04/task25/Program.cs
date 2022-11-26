// Написать метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 1. ввести число А и число В;
// 2. определить метод возведения А в степень В;
// 3. Вывести результат;

// start

Console.WriteLine("Введите основание степени А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите показатель степени В: ");
int b = Convert.ToInt32(Console.ReadLine());

double NaturalDegree(int a, int b)
{  
       double degree = a;
       for (int i = 1; i < b; i++)
       {
            degree = degree * a;
       }

        return degree;
  
}

Console.WriteLine();
Console.Write($"А в степени В = {NaturalDegree(a, b)}");


// end
