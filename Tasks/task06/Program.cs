//  Выяснить является ли число чётным

// start

Console.WriteLine("ввести целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0) 
{
    Console.Write("четное");
}
else Console.Write("нечетное");