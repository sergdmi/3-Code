//  Выяснить, кратно ли число заданному, если нет, вывести остаток.


// start

Console.Clear();
Console.WriteLine("Ввести исходное целое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввести множитель: ");

int b = Convert.ToInt32(Console.ReadLine());

int c = a % b;

if ( c == 0)
{
    Console.WriteLine ("кратно");
}

else 
Console.Write($"Остаток: {c}");


// end