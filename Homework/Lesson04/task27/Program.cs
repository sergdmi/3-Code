// Напиcать метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 1. Ввести c консоли натуральное число
// 2. Определить метод нахождения суммы путем остатка от деления
// 3. Вывести результат

// start

Console.WriteLine("Введите натуральное число: ");
int value = Convert.ToInt32(Console.ReadLine());

int SumValueNumbers(int value)
{
  
    int sum = 0;
        
    while (value > 0)
    {
        int number = value % 10;
        sum = sum + number;
        value = value / 10;
    }

    return sum;
}

Console.WriteLine($"Сумма цифр числа = {SumValueNumbers(value)}");

// end