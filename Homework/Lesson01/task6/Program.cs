//  Напиcать программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter integral number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 2;

if (result == 0) 
{
    Console.Write("even number");
}

else 
{
    Console.Write("odd number");
}

// end