// Показать последнюю цифру трёхзначного числа

// start

Console.WriteLine("Введите 3-хзначное число:");

int value = Convert.ToInt32(Console.ReadLine());


int c = value % 10;         

Console.WriteLine(c);


// end
