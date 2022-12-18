// Программа проверяет пятизначное число на палиндром.

// start

Console.Clear();

Console.WriteLine("ввести пятизначное целое число: ");

int num = Convert.ToInt32(Console.ReadLine());

int a = num / 10000;
int b = (num / 1000) % 10;
int c = (num / 10) % 10;
int d = num % 10;

if (a == d && b == c)
{
    Console.Write("палиндром");
}

else Console.Write("не палиндром");


// end

// Решение через массив

// string value = Console.ReadLine();

// char[] array = new char[value.Length];

// for(int i = 0; i < value.Length; i++)
// {
//     array[i] = value[i];
// }

// if (array[0] == array [4] && array[1] == array[3])
// {
//     Console.Write("палиндром");
// }

// else Console.Write("не палиндром");