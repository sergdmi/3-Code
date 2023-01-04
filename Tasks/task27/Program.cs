// Определить количество цифр в числе

// start

Console.Clear();
Console.WriteLine("Ввести натуральное число");

int Number = Convert.ToInt32(Console.ReadLine());

int i = 0;
int n = Number;

while (n >= 1)
{
    n = n / 10;
    i = i + 1;
}

Console.WriteLine($"Количество цифр: {i}");

// end
