// Программа проверяет пятизначное число на палиндром.

// start

Console.Clear();

Console.WriteLine("ввести пятизначное целое число: ");

string value = Console.ReadLine();

char[] array = new char[value.Length];

for(int i = 0; i < value.Length; i++)
{
    array[i] = value[i];
}

if (array[0] == array [4] && array[1] == array[3])
{
    Console.Write("палиндром");
}

else Console.Write("не палиндром");

// end
