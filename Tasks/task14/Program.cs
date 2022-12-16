// Найти третью цифру числа или сообщить, что её нет

// start

Console.Clear();

Console.WriteLine("ввести целое число от 0 до 999: ");

int value = Convert.ToInt32(Console.ReadLine()); 

int a = value / 100;
int c = value % 10;

if (a >= 1) 
{
    Console.WriteLine(c);
}

else Console.WriteLine("нет");


// end
