// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 1. Вводим число
// 2. Делим число на 7 и 23
// 3. Если делится без остатка - выводим "кратно"
// 4. Если не делится без остатка - выводим "не кратно"

Console.WriteLine("Enter value: ");
int value = Convert.ToInt32(Console.ReadLine());

int a = value % 7;
int b = value % 23;

if (a == 0 & b == 0)
{
    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine("Не кратно");
}

