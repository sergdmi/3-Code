//  По двум заданным числам проверять является ли одно квадратом другого

// start


Console.Clear();

Console.WriteLine("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == y * y)
{
    Console.WriteLine("Число x является квадратом числа y");
}
else

    Console.WriteLine("Число x не является квадратом числа y");


// end