// По заданному номеру дня недели вывести его название

// 1. Определить массив дней недели
// 2. Ввести номер дня недели
// 3. Вывести название дня недели c индексом номера

// start

string[] weekarray = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

Console.WriteLine("Enter day of the week number");
int daynumber = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine(weekarray[daynumber]);

// end