// Вывести квадрат числа (пишем для целых чисел)

// 1. Ввести число
// 2. Вычислить квадрат
// 3. Вывести результат

// start

/* Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

int result = value*value;

Console.WriteLine(result);

// end

// 1. По двум заданным числам проверять является ли первое квадратом второго

/*  1. Ввести 1-е число
    2. Ввести 2-е число
    3. Проверить является ли 2-е число квадратом 1-го
    4. Проверить является ли 1-е число квадратом 2-го
    5. Вывести результат
*/

// start

Console.WriteLine("Введите число 1: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if(value1*value1 == value2)
{
    Console.WriteLine("число 2 является квадратом числа 1");
}
else

if(value2*value2 == value1)
{
    Console.WriteLine("число 1 является квадратом числа 2");
}
else

Console.WriteLine("Ни одно число не является квадратом другого");

// end
