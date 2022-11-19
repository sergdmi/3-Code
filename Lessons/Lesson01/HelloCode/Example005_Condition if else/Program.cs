Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Great - this is Maria!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}